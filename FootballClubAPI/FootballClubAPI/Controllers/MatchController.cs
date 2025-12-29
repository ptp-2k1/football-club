using Microsoft.AspNetCore.Mvc;
using FootballClubAPI.Models;
using FootballClubAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace FootballClubAPI.Controllers
{
    [ApiController]
    [Route("match/[controller]")]
    public class MatchController : ControllerBase
    {
        private readonly FootballClubContext _context;

        private const string _createdActionName = "Created";

        public MatchController(FootballClubContext context) { 
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Match>>> getMatches() 
        {
            return Ok(await _context.Matches.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult<Match>> addStyle(Match match) 
        {
            if (match == null) return BadRequest();

            _context.Matches.Add(match);

            await _context.SaveChangesAsync();

            return CreatedAtAction(_createdActionName, new { match.id }, match);
        }
    }
}
