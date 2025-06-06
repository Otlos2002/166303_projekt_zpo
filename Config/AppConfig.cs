using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace _166303_projekt_zpo.Config
{
    public class AppConfig
    {
        private static AppConfig _instance;
        public static AppConfig Instance => _instance ??= Load();
        public string DataFilePath { get; set; } = "media_catalog.json";

        private static AppConfig Load()
        {
            if (File.Exists("config.json"))
            {
                string json = File.ReadAllText("config.json");
                return JsonSerializer.Deserialize<AppConfig>(json) ?? new AppConfig();
            }
            else
            {
                var defaultConfig = new AppConfig();
                Save(defaultConfig);
                return defaultConfig;
            }
        }
        public static void Save(AppConfig config)
        {
            string json = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("config.json", json);
        }
    }
}
