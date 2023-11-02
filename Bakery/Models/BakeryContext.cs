  using Microsoft.EntityFrameworkCore;

  namespace Bakery.Models
  {
    public class BakeryContext : DbContext
    {
      public DbSet<Treat> Treats { get; set; }
      public DbSet<Flavor> Flavorss { get; set; }

      public BakeryContext(DbContextOptions options) : base(options) { }
    }
  }