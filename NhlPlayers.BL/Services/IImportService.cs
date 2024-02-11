using NhlPlayers.DTO.ImportModels;
using System.Collections.Generic;

namespace NhlPlayers.BL.Services
{
    public interface IImportService
    {
        IEnumerable<ImportPlayer> LoadPlayersInfo(string path);
    }
}