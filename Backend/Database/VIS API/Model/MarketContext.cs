using Microsoft.EntityFrameworkCore;

namespace VIS_API.Model
{
    public class MarketContext:DbContext
    {
        public MarketContext(DbContextOptions<MarketContext> options):base(options)
        {
        }
        public DbSet<Users> Users { get; set; } = null!;
        public DbSet<Market> Markets { get; set; } = null!;
        public DbSet<MarketIndicator> MarketIndicators { get; set; } = null!;

    }
}
