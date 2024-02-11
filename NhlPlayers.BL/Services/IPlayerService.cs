using NhlPlayers.DTO.WPFModels;
using System.Collections.Generic;

namespace NhlPlayers.BL.Services
{
    public interface IPlayerService
    {
        IEnumerable<PlayerStats> ImportPlayers(string path);
    }
}