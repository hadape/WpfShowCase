using NhlPlayers.DTO.WPFModels;
using System.Collections.Generic;

namespace NhlPlayers.BL.Services
{
    public interface IPlayerMemoryService
    {
        IEnumerable<PlayerStats> Players { get; }

        void Clear();
        void Set(IEnumerable<PlayerStats> players);
    }
}