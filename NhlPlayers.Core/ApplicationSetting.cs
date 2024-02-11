using NhlPlayers.BL;
using NhlPlayers.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhlPlayers.Core
{ 
    public class ApplicationSetting : IInfrastrucutreSetting, IBLSetting
    {
        public string ImportFolder { get; set; } = "Import";
        public string ExportFolder { get; set; } = "Export";
        public string ImportPath { get { return $".//{ImportFolder}"; } }
        public string ExportPath { get { return $".//{ExportFolder}"; } }

        public string FileTypeFilter { get; set; } = "CSV files (*.csv)|*.csv";

        public bool SkipFirstCsvLine { get; set; } = true;
        public char CsvSeparator { get; set; } = ';';
        public string ExportFileTemplate { get; set; } = $"Players-{DateTime.Now:yyyy-MM-dd_HH_mm_ss}.csv";

    }
}
