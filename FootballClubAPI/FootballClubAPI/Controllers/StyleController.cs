using Microsoft.AspNetCore.Mvc;
using FootballClubAPI.Models;
using FootballClubAPI.Data;

namespace FootballClubAPI.Controllers
{
    [ApiController]
    [Route("style/[controller]")]
    public class StyleController : ControllerBase
    {
        private readonly FootballClubContext _context;

        private const string _createdActionName = "Created";

        public StyleController(FootballClubContext context) { 
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Style>>> getStyles(int id) 
        {
            var styles = await _context.Styles.FindAsync(id);
            
            if(styles == null) return NotFound();
            
            else return Ok(styles);
        }

        [HttpPost]
        public async Task<ActionResult<Style>> addStyle(Style style) 
        {
            if (style == null) return BadRequest();

            _context.Styles.Add(style);

            await _context.SaveChangesAsync();

            return CreatedAtAction(_createdActionName, new { style.id }, style);
        }
    }
}
