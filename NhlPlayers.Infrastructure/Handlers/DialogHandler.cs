using Microsoft.Win32;
using System;
using System.IO;

namespace NhlPlayers.Infrastructure.Handlers
{
    public class DialogHandler : IDialogHandler
    {
        private readonly IInfrastrucutreSetting _setting;

        public DialogHandler(IInfrastrucutreSetting setting)
        {
            _setting = setting;
        }

        public string ImportDialog()
        {
            string result = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = _setting.FileTypeFilter
            };
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string importDirectory = Path.Combine(currentDirectory, _setting.ImportFolder);
            openFileDialog.InitialDirectory = importDirectory;

            bool? succes = openFileDialog.ShowDialog();

            if (succes == true)
            {
                result = openFileDialog.FileName;
            }
            return result;
        }

        public string ExportDialog()
        {
            string result = string.Empty;
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = _setting.FileTypeFilter
            };
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string exportDirectory = Path.Combine(currentDirectory, _setting.ExportFolder);
            saveFileDialog.InitialDirectory = exportDirectory;
            string defaultFileName = _setting.ExportFileTemplate;
            saveFileDialog.FileName = defaultFileName;


            bool? succes = saveFileDialog.ShowDialog();

            if (succes == true)
            {
                result = saveFileDialog.FileName;
            }
            return result;
        }
    }
}
