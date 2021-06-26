using System;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace MemoryStepsCore.Models
{
    public class AppConfig
    {
        private static readonly string configLocation = "appSettings.json";
        private static Config _config;
        public static Config Config 
        {
            get 
            {
                if (_config == null)
                    InitAppConfig();
                return _config;
            }
        }
 
        private static void InitAppConfig()
        {
            try
            {
                _config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(configLocation));
            }
            catch (FileNotFoundException)
            {
                CreateConfig();
            }
        }

        private static void CreateConfig() 
        {
            _config = new Config();
            string _configString = JsonConvert.SerializeObject(_config, Formatting.Indented);
            using var fs = File.Create(configLocation);
            byte[] jsonBytes = new UTF8Encoding(true).GetBytes(_configString);
            fs.Write(jsonBytes, 0, jsonBytes.Length);
        }
    }
}
