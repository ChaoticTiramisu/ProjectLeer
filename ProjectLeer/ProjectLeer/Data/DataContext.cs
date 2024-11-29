using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectLeer.Entity;

namespace ProjectLeer.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Vak> Vakken { get; set; }
        public DbSet<Leerling> Leerlingen { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure the many-to-many relationship
            modelBuilder.Entity<Leerling>()
                .HasMany(leerling => leerling.Vakken)
                .WithMany(); 
        }
    }
}
