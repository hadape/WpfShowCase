using NhlPlayers.DTO.ImportModels;
using NhlPlayers.DTO.WPFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhlPlayers.BL.Mappers
{
    public static class ImportPlayerExtensions
    {
        public static PlayerStats ToWPFModel(this ImportPlayer importPlayer)
        {
            var fullnameSplit = importPlayer.FullName.Split(' ');
            return new PlayerStats
            {
                FirstName = fullnameSplit[0],
                LastName = fullnameSplit[1],
                Club = importPlayer.Club,
                GamesPlayed = importPlayer.GamesPlayed,
                Goals = importPlayer.Goals,
                Assistence = importPlayer.Assistence,
                GoalsPerGame = importPlayer.GoalsPerGame
            };
        }
    }
}
