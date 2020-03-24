using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    public interface IImportStrategy
    {
        IEnumerable<Album> ImportAlbums(string filePath);
    }
}
