using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhlPlayers.BL
{
    public interface IBLSetting
    {
        bool SkipFirstCsvLine { get; set; }
        char CsvSeparator {  get; set; }    
    }
}
