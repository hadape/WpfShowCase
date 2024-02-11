using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
