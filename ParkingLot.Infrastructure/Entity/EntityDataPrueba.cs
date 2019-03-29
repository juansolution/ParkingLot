
using Microsoft.EntityFrameworkCore;

namespace ParkingLot.Infrastructure.Entity
{
    public class EntityDataPrueba : DbContext
    {
        public DbSet<personas> personasContext { get; set; }


        public EntityDataPrueba(DbContextOptions<EntityDataPrueba> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
