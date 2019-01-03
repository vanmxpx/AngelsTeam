using Microsoft.EntityFrameworkCore;

namespace AngelsTeam.Model
{
    public class AngelsDbContext : DbContext
    {

        public DbSet<User> Users { get; set; }

        public AngelsDbContext(DbContextOptions<AngelsDbContext> options) : base(options) { }
    }
}