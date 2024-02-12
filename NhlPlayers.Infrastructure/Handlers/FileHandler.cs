using System.Collections.Generic;
using System.IO;

namespace NhlPlayers.Infrastructure
{
    public class FileHandler : IFileHandler
    {
        public IEnumerable<string> ReadLineStringFile(string path)
        {
            return File.ReadLines(path);
        }
        public void SaveFile(string path, IEnumerable<string> lines)
        {
            File.WriteAllLines(path, lines);
        }

    }
}
