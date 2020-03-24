using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    public class MusicManager
    {
        public List<Album> Albums { get; private set; }
        public IImportStrategy Importer { get; set; }

        public MusicManager()
        {
            Albums = new List<Album>();
        }
    }
}
