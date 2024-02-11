using NhlPlayers.DTO.WPFModels;
using System.Collections.Generic;

namespace NhlPlayers.BL.Services
{
    public interface IExportService
    {
        void ExportPlayers(string path, IEnumerable<PlayerStats> input);
    }
}