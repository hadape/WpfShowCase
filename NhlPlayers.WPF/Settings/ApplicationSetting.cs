using NhlPlayers.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhlPlayers.WPF.Settings
{
    internal class ApplicationSetting : IInfrastrucutreSetting
    {
        public string ImportFolder { get; set; } = "Import";
        public string ExportFolder { get; set; } = "Export";
        public string ImportPath { get { return $".//{ImportFolder}"; } }
        public string ExportPath { get { return $".//{ExportFolder}"; } }

        public string FileTypeFilter { get; set; } = "CSV files (*.csv)|*.csv";

    }
}
