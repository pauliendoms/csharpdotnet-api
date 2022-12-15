using Microsoft.EntityFrameworkCore;

namespace parkeer_api.Contexts
{
    public class ParkingContext : DbContext
    {

        public ParkingContext(DbContextOptions<ParkingContext> opt) : base(opt)
        {

        }
        public DbSet<Parking> parkings { get; set; }

        public DbSet<Stad> steden { get; set; }

    }
}
