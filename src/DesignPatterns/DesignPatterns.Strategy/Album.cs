using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    public class Album
    {
        public string Artist { get; set; }
        public string Title { get; set; }
        public int NumberOfTracks { get; set; }
        public int ReleaseYear { get; set; }
    }
}
