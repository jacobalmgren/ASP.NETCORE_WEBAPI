using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebbAPI.Data // Again, replace with your actual namespace
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Subscriber> Subscribers { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
