using NhlPlayers.DTO.WPFModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhlPlayers.Core.ViewModels
{
    public partial class ListingPlayerViewModel
    {

        private const string EMPTY = "Body (default)";
        private List<Func<PlayerStats, bool>> _filters = new List<Func<PlayerStats, bool>>();
        private string _selectedProperty;
        public string SelectedProperty
        {
            get { return _selectedProperty; }
            set
            {
                if (SetProperty(ref _selectedProperty, value))
                {
                    ApplyFilters();
                }
            }
        }

        private string _filterFirstName;
        public string FilterFirstName
        {
            get { return _filterFirstName; }
            set
            {
                if (SetProperty(ref _filterFirstName, value))
                {
                    ApplyFilters();
                }
            }
        }

        private string _filterLastName;
        public string FilterLastName
        {
            get { return _filterLastName; }
            set
            {
                if (SetProperty(ref _filterLastName, value))
                {
                    ApplyFilters();
                }
            }
        }

        private string _filterClub;
        public string FilterClub
        {
            get { return _filterClub; }
            set
            {
                if (SetProperty(ref _filterClub, value))
                {
                    ApplyFilters();
                }
            }
        }

        private void ApplyFilters()
        {

            _filters.Clear();

            if (!string.IsNullOrWhiteSpace(FilterFirstName))
            {
                _filters.Add(p => p.FirstName.IndexOf(FilterFirstName, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            if (!string.IsNullOrWhiteSpace(FilterLastName))
            {
                _filters.Add(p => p.LastName.IndexOf(FilterLastName, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            if (!string.IsNullOrWhiteSpace(FilterClub))
            {
                _filters.Add(p => p.Club.IndexOf(FilterClub, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            var filtered = _playersMemory.Players.Where(player => _filters.All(filter => filter(player)));

            if (!string.IsNullOrEmpty(SelectedProperty) && SelectedProperty != EMPTY)
            {
                var propertyInfo = typeof(PlayerStats).GetProperty(SelectedProperty);
                filtered = filtered.OrderBy(p => propertyInfo?.GetValue(p, null));
            }

            Players = new ObservableCollection<PlayerStats>(filtered);
        }
    }
}
