
using NhlPlayers.DTO.Attributes;
using NhlPlayers.DTO.ImportModels;
using NhlPlayers.DTO.WPFModels;
using NhlPlayers.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhlPlayers.BL.Services
{

    public class ImportService : IImportService
    {
        IFileHandler _fileHandler;
        IBLSetting _blSetting;

        public ImportService(IFileHandler fileHandler, IBLSetting blSetting)
        {
            _fileHandler = fileHandler;
            _blSetting = blSetting;
        }

        public IEnumerable<ImportPlayer> LoadPlayersInfo(string path)
        {
            List<ImportPlayer> result = new List<ImportPlayer>();
            var importLines = _fileHandler.ReadLineStringFile(path);
            if (_blSetting.SkipFirstCsvLine)
            {
                importLines = importLines.Skip(1);
            }
            foreach (var line in importLines)
            {
                var player = ParseImportPlayer(line);
                result.Add(player);
            }
            return result;
        }

        private ImportPlayer ParseImportPlayer(string line)
        {
            var values = line.Split(_blSetting.CsvSeparator);
            var player = new ImportPlayer();

            foreach (var prop in typeof(ImportPlayer).GetProperties())
            {
                var attr = prop.GetCustomAttributes(typeof(CsvPositionAttribute), false).FirstOrDefault() as CsvPositionAttribute;
                if (attr != null)
                {
                    int position = attr.Position;
                    if (position < values.Length)
                    {
                        try
                        {
                            prop.SetValue(player, Convert.ChangeType(values[position], prop.PropertyType));
                        }
                        catch(Exception ex)
                        {
                            var foo = ex;
                        }
                    }
                }
            }
            return player;
        }
    }
}
