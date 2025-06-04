using _166303_projekt_zpo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace _166303_projekt_zpo.Data
{
    public class MediaItemConverter : JsonConverter<MediaItem>
    {
        public override MediaItem Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using var jsonDoc = JsonDocument.ParseValue(ref reader);
            var root = jsonDoc.RootElement;

            if (!root.TryGetProperty("Type", out var typeProperty))
                throw new JsonException("Brak pola 'Type'");

            string type = typeProperty.GetString();
            return type switch
            {
                "Movie" => JsonSerializer.Deserialize<Movie>(root.GetRawText(), options),
                "Series" => JsonSerializer.Deserialize<Series>(root.GetRawText(), options),
                _ => throw new JsonException("Nieznany typ obiektu MediaItem")
            };
        }

        public override void Write(Utf8JsonWriter writer, MediaItem value, JsonSerializerOptions options)
        {
            using var jsonDoc = JsonDocument.Parse(JsonSerializer.Serialize(value, value.GetType(), options));
            writer.WriteStartObject();

            foreach (var property in jsonDoc.RootElement.EnumerateObject())
            {
                property.WriteTo(writer);
            }

            string type = value is Movie ? "Movie" :
                          value is Series ? "Series" : "Unknown";

            writer.WriteString("Type", type);
            writer.WriteEndObject();
        }
    }
}