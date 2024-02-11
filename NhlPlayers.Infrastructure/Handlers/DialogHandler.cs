using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace NhlPlayers.Infrastructure.Handlers
{
    public class DialogHandler : IDialogHandler
    {
        IInfrastrucutreSetting _setting;

        public DialogHandler(IInfrastrucutreSetting setting)
        {
            _setting = setting;
        }

        public string ImportDialog()
        {
            string result = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = _setting.FileTypeFilter;
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
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = _setting.FileTypeFilter;
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string exportDirectory = Path.Combine(currentDirectory, _setting.ExportFolder);
            saveFileDialog1.InitialDirectory = exportDirectory;
            string defaultFileName = _setting.ExportFileTemplate; 
            saveFileDialog1.FileName = defaultFileName; 


            bool? succes = saveFileDialog1.ShowDialog();

            if (succes == true)
            {
                result = saveFileDialog1.FileName;
            }
            return result;
        }
    }
}
