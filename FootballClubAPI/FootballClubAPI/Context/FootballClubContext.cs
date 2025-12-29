using FootballClubAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FootballClubAPI.Data
{
    public class FootballClubContext: DbContext
    {
        public FootballClubContext(DbContextOptions<FootballClubContext> options):base(options)
        {
                
        }

        public DbSet<Club> Clubs { get; set; }
        public DbSet<Style> Styles {  get; set; }
        public DbSet<User>  Users { get; set; }
        public DbSet<Match> Matches { get; set; }

    }
}
