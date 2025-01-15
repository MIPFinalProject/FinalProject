using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Proiect2.Service
{
    public class CryptoService
    {
        private readonly byte[] _key;
        private readonly byte[] _iv;
        private const string KeyFilePath = "encryptionKey.bin";
        private const string IvFilePath = "encryptionIv.bin";

        public CryptoService()
        {
            if (File.Exists(KeyFilePath) && File.Exists(IvFilePath))
            {
                _key = File.ReadAllBytes(KeyFilePath);
                _iv = File.ReadAllBytes(IvFilePath);
            }
            else
            {
                using (var aes = Aes.Create())
                {
                    _key = aes.Key;
                    _iv = aes.IV;
                    File.WriteAllBytes(KeyFilePath, _key);
                    File.WriteAllBytes(IvFilePath, _iv);
                }
            }
        }

        public string Encrypt(string plainText)
        {
            using (var aes = Aes.Create())
            {
                aes.Key = _key;
                aes.IV = _iv;

                var encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (var ms = new MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        using (var sw = new StreamWriter(cs))
                        {
                            sw.Write(plainText);
                        }
                    }

                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        public string Decrypt(string cipherText)
        {
            using (var aes = Aes.Create())
            {
                aes.Key = _key;
                aes.IV = _iv;

                var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (var ms = new MemoryStream(Convert.FromBase64String(cipherText)))
                {
                    using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        using (var sr = new StreamReader(cs))
                        {
                            return sr.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}