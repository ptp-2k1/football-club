using Microsoft.AspNetCore.Mvc;
using FootballClubAPI.Models;
using FootballClubAPI.Data;

namespace FootballClubAPI.Controllers
{
    [ApiController]
    [Route("user/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly FootballClubContext _context;

        private const string _createdActionName = "Created";

        public UserController(FootballClubContext context) { 
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> getUser(int id) 
        {
            var user = await _context.Users.FindAsync(id);
            
            if(user == null) return NotFound();
            
            else return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<User>> addUser(User user) 
        {
            if (user == null) return BadRequest();

            _context.Users.Add(user);

            await _context.SaveChangesAsync();

            return CreatedAtAction(_createdActionName, new { user.id }, user);
        }
    }
}
