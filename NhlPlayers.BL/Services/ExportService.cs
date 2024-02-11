using NhlPlayers.DTO.WPFModels;
using NhlPlayers.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhlPlayers.BL.Services
{
    public class ExportService : IExportService
    {
        private readonly IFileHandler _fileHandler;
        private readonly IBLSetting _blSettings;

        public ExportService(IFileHandler fileHandler, IBLSetting blSettings)
        {
            _fileHandler = fileHandler;
            _blSettings = blSettings;
        }

        public void ExportPlayers(string path, IEnumerable<PlayerStats> input)
        {
            var separator = _blSettings.CsvSeparator;
            var exportLines = new List<string>();
            foreach (var player in input)
            {
                exportLines.Add($"{player.FirstName}{separator}{player.LastName}{separator}{player.Club}{separator}{player.GamesPlayed}{separator}{player.Goals}{separator}{player.Assistence}{separator}{player.Points}{separator}{player.GoalsPerGame}{separator}");
            }
            _fileHandler.SaveFile(path, exportLines);
        }
    }
}
