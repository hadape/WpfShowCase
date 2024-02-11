using System.Collections.Generic;

namespace NhlPlayers.Infrastructure
{
    public interface IFileHandler
    {
        IEnumerable<string> ReadLineStringFile(string path);
        void SaveFile(string path, IEnumerable<string> lines);
    }
}