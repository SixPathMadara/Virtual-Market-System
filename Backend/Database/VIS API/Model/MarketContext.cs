using Microsoft.EntityFrameworkCore;

namespace VIS_API.Model
{
    public class MarketContext:DbContext
    {
        public MarketContext(DbContextOptions<MarketContext> options):base(options)
        {
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Market> Markets { get; set; } 
        public DbSet<MarketIndicator> MarketIndicators { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>()
       .HasKey(u => u.UserID);
            modelBuilder.Entity<Market>()
       .HasKey(u => u.MarketID);
            modelBuilder.Entity<MarketIndicator>()
       .HasKey(u => u.IndicatorID);
            base.OnModelCreating(modelBuilder);
        }
    }
}
