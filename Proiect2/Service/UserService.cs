using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Proiect2.Entity;
using Proiect2.Repository;

namespace Proiect2.Service
{
    public class UserService
    {
        private readonly IRepository<User> _repository;
        private readonly CryptoService _cryptoService;

        public UserService(IRepository<User> repository)
        {
            _repository = repository;
            _cryptoService = new CryptoService();
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _repository.GetAll();
        }

        public async Task<User> GetUserById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task AddUser(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            user.Password = _cryptoService.Encrypt(user.Password);

            await _repository.Add(user);
        }

        public async Task UpdateUser(User user)
        {
            await _repository.Update(user);
        }

        public async Task DeleteUser(int id)
        {
            await _repository.Delete(id);
        }

        public async Task<User> AuthenticateUser(string username, string password)
        {
            var users = await _repository.GetAll();
            foreach (var user in users)
            {
                if (user.Username == username)
                {
                    var decryptedPassword = _cryptoService.Decrypt(user.Password);
                    if (decryptedPassword == password)
                    {
                        return user;
                    }
                }
            }

            throw new Exception("Invalid username or password");
        }

        public async Task ChangeUsernameAndPassword(string username, string oldPassword, string newUsername, string newPassword)
        {
            var users = await _repository.GetAll();
            foreach (var user in users)
            {
                if (user.Username == username)
                {
                    var decryptedPassword = _cryptoService.Decrypt(user.Password);
                    if (decryptedPassword == oldPassword)
                    {
                        if (!string.IsNullOrEmpty(newUsername))
                        {
                            user.Username = newUsername;
                        }
                        if (!string.IsNullOrEmpty(newPassword))
                        {
                            user.Password = _cryptoService.Encrypt(newPassword);
                        }
                        await _repository.Update(user);
                        return;
                    }
                }
            }
            throw new Exception("Invalid username or old password");
        }
    }
}