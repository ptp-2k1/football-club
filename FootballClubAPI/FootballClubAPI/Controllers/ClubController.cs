using Microsoft.AspNetCore.Mvc;
using FootballClubAPI.Models;
using FootballClubAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace FootballClubAPI.Controllers
{
    [ApiController]
    [Route("club/[controller]")]
    public class ClubController : ControllerBase
    {
        private readonly FootballClubContext _context;

        private const string _createdActionName = "Created";

        public ClubController(FootballClubContext context) {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Club>>> getClubs()
        {
            return Ok(await _context.Clubs.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Club>> getClub(int id)
        {
            var club = await _context.Clubs.FindAsync(id);

            if (club == null) return NotFound();

            else return Ok(club);
        }

        [HttpPost]
        public async Task<ActionResult<Club>> addClub(Club club)
        {
            if (club == null) return BadRequest();

            _context.Clubs.Add(club);

            await _context.SaveChangesAsync();

            return CreatedAtAction(_createdActionName, new { club.id }, club);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> updateClub(int id, Club updatedclub)
        {

            if(updatedclub == null) return BadRequest();

            var club = await _context.Clubs.FindAsync(id);

            if (club == null) return NotFound();

            club.name = updatedclub.name;
            club.league = updatedclub.league;
            club.tournament = updatedclub.tournament;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> deleteClub(int id)
        {
            var club = await _context.Clubs.FindAsync(id);

            if (club == null) return NotFound();

            _context.Clubs.Remove(club);

            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
