using NhlPlayers.DTO.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhlPlayers.DTO.ImportModels
{
    public class ImportPlayer
    {
        [CsvPosition(0)]
        public string FullName { get; set; }
        [CsvPosition(2)]
        public string Club { get; set; }
        [CsvPosition(5)]
        public int GamesPlayed { get; set; }
        [CsvPosition(6)]
        public int Goals { get; set; }
        [CsvPosition(7)]
        public int Assistence { get; set; }
        [CsvPosition(8)]
        public int Points { get; set; }
        [CsvPosition(11)]
        public double GoalsPerGame { get; set; }
    }
}
