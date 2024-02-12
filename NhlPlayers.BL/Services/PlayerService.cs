using NhlPlayers.BL.Mappers;
using NhlPlayers.DTO.WPFModels;
using System.Collections.Generic;

namespace NhlPlayers.BL.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IImportService _importService;

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
