namespace FootballClubAPI.Models
{
    public class Match
    {
        public int id { get; set; }
        public int firstClubId {  get; set; }

        public int sencondClubId { get; set; }

        public int firstScore {  get; set; }

        public int sencondScore { get; set; }
    }
}
