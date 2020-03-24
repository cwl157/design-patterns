using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace DesignPatterns.Strategy.Strategies
{
    public class JsonStrategy : IImportStrategy
    {
        public IEnumerable<Album> ImportAlbums(string filePath)
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            };
            string content = File.ReadAllText(filePath);
            List<Album> result = JsonSerializer.Deserialize<List<Album>>(content, options);
            return result;
        }
    }
}
