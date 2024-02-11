using NhlPlayers.BL.Mappers;
using NhlPlayers.DTO.WPFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhlPlayers.BL.Services
{
    public class PlayerService : IPlayerService
    {
        IImportService _importService;

        public PlayerService(IImportService importService)
        {
            _importService = importService;
        }

        public IEnumerable<PlayerStats> ImportPlayers(string path)
        {
            List<PlayerStats> result = new List<PlayerStats>();

            var importedPlayersCollection = _importService.LoadPlayersInfo(path);

            foreach (var player in importedPlayersCollection)
            {

                result.Add(player.ToWPFModel());
            }

            return result;

        }
    }
}
