using carDealer.Models;
using Microsoft.EntityFrameworkCore;

namespace carDealer.Persistence
{
    public class CarDealerDbContext : DbContext
    {
        public CarDealerDbContext(DbContextOptions<CarDealerDbContext> options) : base (options){}

        public DbSet<Make> Makes { get; set; }
        public DbSet<Feature> Features { get; set; }
    }
}