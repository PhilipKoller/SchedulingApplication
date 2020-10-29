using Microsoft.EntityFrameworkCore;

namespace SchedulingApplication.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }

        public DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuiler)
        {
            modelBuiler.Seed();
        }

    }
}
