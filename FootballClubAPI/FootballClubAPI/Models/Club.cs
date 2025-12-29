using System.Collections;

namespace FootballClubAPI.Models
{
    public class Club
    {
        public int id { get; set; }

        public string name { get; set; } = null!;

        public string league { get; set; } = null!;

        public string tournament { get; set; } = null!;
    }
}
