using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhlPlayers.Infrastructure
{
    public class FolderHandler
    {
        private readonly IInfrastrucutreSetting _setting;

        public FolderHandler(IInfrastrucutreSetting setting)
        {
            _setting = setting;
        }
        public void InitFolders()
        {
            if(Directory.Exists(_setting.ImportPath) == false)
            {
                Directory.CreateDirectory(_setting.ImportPath);
            }

            if (Directory.Exists(_setting.ExportPath) == false)
            {
                Directory.CreateDirectory(_setting.ExportPath);
            }
        }
    }
}
