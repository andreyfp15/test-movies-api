
using Microsoft.EntityFrameworkCore;

namespace test_movies_api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<MovieRating> MovieLevels { get; set; }
    }
}
