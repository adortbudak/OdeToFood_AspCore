using Microsoft.EntityFrameworkCore;

namespace OdeToFood_AspCore.Entities
{
    public class OdeToFoodDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }

        public OdeToFoodDbContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
