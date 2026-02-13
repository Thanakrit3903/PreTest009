using backEnd.Data;
using backEnd.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backEnd.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FeedController : Controller
    {
        private readonly AppDbContext _context;

        public FeedController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPost(int id)
        {
            var post = await _context.Posts
                .Include(p => p.comments)
                .FirstOrDefaultAsync(p => p.id == id);

            if (post == null) return NotFound();
            return Ok(post);
        }

        [HttpPost("comment")]
        public async Task<IActionResult> AddComment([FromBody] Comment comment)
        {
            comment.createdAt = DateTime.UtcNow;
            _context.Comments.Add(comment);
            await _context.SaveChangesAsync();
            return Ok(comment);
        }
    }
}
