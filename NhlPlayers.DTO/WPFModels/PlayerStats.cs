namespace NhlPlayers.DTO.WPFModels
{
    public class PlayerStats
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Club { get; set; }
        public int GamesPlayed { get; set; }
        public int Goals { get; set; }
        public int Assistence { get; set; }
        public int Points { get; set; }
        public double GoalsPerGame { get; set; }
        public string GAndA => $"{Goals}+{Assistence}";
    }
}
