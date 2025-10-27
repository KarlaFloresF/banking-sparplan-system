using BankingSparplanSystem.Domain.Entitaeten;
using Microsoft.EntityFrameworkCore;

namespace BankingSparplanSystem.Infrastructure.Persistence
{
    public class SparplanDbContext : DbContext
    {
        public SparplanDbContext(DbContextOptions<SparplanDbContext> options)
            : base(options)
        {

        }
        public DbSet<Kunde> Kunden {  get; set; }
        public DbSet<Sparplan> Sparplaene { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sparplan>()
                .Property(s => s.BarrenMenge)
                .HasPrecision(18, 5); 

            modelBuilder.Entity<Sparplan>()
                .Property(s => s.GewünschteSpargrenze)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Sparplan>()
                .Property(s => s.Zielbetrag)
                .HasPrecision(18, 5);
        }
    }
}
