using _166303_projekt_zpo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _166303_projekt_zpo.Data
{
    public static class CatalogSerializer
    {
        private static JsonSerializerOptions _options = new JsonSerializerOptions()
        {
           WriteIndented = true,
           Converters = { new MediaItemConverter() } 
        };
        public static void SaveToFile(List<MediaItem> items, string filePath)
        {
            string json = JsonSerializer.Serialize(items, _options);
            File.WriteAllText(filePath, json);
        }
        public static List<MediaItem> LoadFromFile(string filePath)
        {
            if (!File.Exists(filePath))
                return new List<MediaItem>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<MediaItem>>(json, _options);
        }

    }
}
