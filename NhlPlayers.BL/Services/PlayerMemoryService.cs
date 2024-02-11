using NhlPlayers.DTO.WPFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhlPlayers.BL.Services
{
    public class PlayerMemoryService : IPlayerMemoryService
    {
        public IEnumerable<PlayerStats> Players { get; private set; } = new List<PlayerStats>();

        public void Clear()
        {
            Players = new List<PlayerStats>();
        }
        public void Set(IEnumerable<PlayerStats> players)
        {
            Players = new List<PlayerStats>(players);
        }

    }
}
