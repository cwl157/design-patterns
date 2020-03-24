using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesignPatterns.Strategy.Strategies
{
    public class CsvStrategy : IImportStrategy
    {
        public IEnumerable<Album> ImportAlbums(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            List<Album> result = new List<Album>();
            for (int i = 1; i < lines.Length; i++)
            {
                string l = lines[i];
                string[] parsedLine = l.Split(',');
                result.Add(new Album
                {
                    Artist = parsedLine[0],
                    Title = parsedLine[1],
                    ReleaseYear = int.Parse(parsedLine[2]),
                    NumberOfTracks = int.Parse(parsedLine[3])
                });
            }

            return result;
        }
    }
}
