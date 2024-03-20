using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;
using WebbAPI.Data;

namespace YourProjectName.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SubscribeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SubscribeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Subscribe([FromBody] Subscriber subscriber)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingSubscriber = await _context.Subscribers
                                        .FirstOrDefaultAsync(s => s.Email == subscriber.Email);
            if (existingSubscriber == null)
            {
                _context.Subscribers.Add(subscriber);
                await _context.SaveChangesAsync();
                return Ok($"Subscribed {subscriber.Email} successfully.");
            }
            return BadRequest("Email is already subscribed.");
        }

        [HttpDelete("{email}")]
        public async Task<IActionResult> Unsubscribe(string email)
        {
            var subscriber = await _context.Subscribers
                                .FirstOrDefaultAsync(s => s.Email == email);
            if (subscriber != null)
            {
                _context.Subscribers.Remove(subscriber);
                await _context.SaveChangesAsync();
                return Ok($"Unsubscribed {email} successfully.");
            }
            return NotFound("Email not found.");
        }
    }
}
