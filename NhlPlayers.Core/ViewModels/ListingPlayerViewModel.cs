using MvvmCross.Commands;
using MvvmCross.ViewModels;
using NhlPlayers.BL.Services;
using NhlPlayers.DTO.WPFModels;
using NhlPlayers.Infrastructure.Handlers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace NhlPlayers.Core.ViewModels
{
    public partial class ListingPlayerViewModel : MvxViewModel
    {
        IDialogHandler _dialogHandler;
        IPlayerService _playerService;
        IPlayerMemoryService _playersMemory;

        public ListingPlayerViewModel(IDialogHandler dialogHandler, IPlayerService playerService, IPlayerMemoryService playersMemory)
        {
            ImportPlayerCommand = new MvxCommand(ImportPlayers);
            _dialogHandler = dialogHandler;
            _playerService = playerService;
            _playersMemory = playersMemory;
            PlayersProperty = new ObservableCollection<string>(
            typeof(PlayerStats).GetProperties(BindingFlags.Public | BindingFlags.Instance)
                               .Select(prop => prop.Name))
                                {
                                    EMPTY
                                };
        }

        private ObservableCollection<PlayerStats> _players = new ObservableCollection<PlayerStats>();

        public ObservableCollection<PlayerStats> Players
		{
			get { return _players; }
			set { SetProperty(ref _players, value); }
		}


        private ObservableCollection<string> _playersProperty = new ObservableCollection<string>();

        public ObservableCollection<string> PlayersProperty
        {
            get { return _playersProperty; }
            set { SetProperty(ref _playersProperty, value); }
        }

      


        public IMvxCommand ImportPlayerCommand { get; set; }


		public void ImportPlayers()
		{
            Players.Clear();
            _playersMemory.Clear();
			var path = _dialogHandler.ImportDialog();
            var importedPlayer = _playerService.ImportPlayers(path);
            _playersMemory.Set(importedPlayer);
            Players = new ObservableCollection<PlayerStats>(importedPlayer);
		}

    }
}
