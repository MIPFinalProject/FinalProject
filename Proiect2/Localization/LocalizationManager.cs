using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Proiect2.Localization
{

    public static class LocalizationManager
    {
        private static ResourceManager resourceManager = new ResourceManager("Proiect2.Resources", typeof(LocalizationManager).Assembly);
        private static CultureInfo cultureInfo;

        public static string GetString(string key)
        {
            return resourceManager.GetString(key, cultureInfo);
        }

        public static void SetLanguage(string languageCode)
        {
            cultureInfo = new CultureInfo(languageCode);
        }
    }

}
