using mvc.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace mvc.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<CryptoCurrency> CryptoCurrencies { get; set; }
        public DbSet<Price> Prices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CryptoCurrency>()
                .Property(o => o.Name)
                .IsRequired()
                .HasMaxLength(128);
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
