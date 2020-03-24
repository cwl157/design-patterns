using System;
using System.IO;

namespace DesignPatterns.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            MusicManager manager = new MusicManager();
            while (input != "2")
            {
                Console.WriteLine("");
                Console.WriteLine("Music Importer");
                Console.WriteLine("1. Import file");
                Console.WriteLine("2. Exit");
                Console.Write("> ");
                input = Console.ReadLine();
                Console.WriteLine("");
                if (input == "1")
                {
                    Console.Write("File path (csv or json): ");
                    string filepath = Console.ReadLine();
                    string extension = Path.GetExtension(filepath);
                    manager.Importer = ImportStrategyPicker.Select(extension.ToLower());
                    var albums = manager.Importer.ImportAlbums(filepath);

                    foreach (Album a in albums)
                    {
                        manager.Albums.Add(a);
                    }

                    Display(manager);
                }
                else if (input == "2")
                {
                    Console.WriteLine("Bye");
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }

        private static void Display(MusicManager m)
        {
            foreach (Album a in m.Albums)
            {
                Console.WriteLine(a.Artist + " " + a.Title + " " + a.NumberOfTracks + " " + a.ReleaseYear);
            }
        }
    }
}
