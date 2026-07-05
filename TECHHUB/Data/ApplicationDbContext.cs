using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TECHHUB.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace TECHHUB.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<HardwareInventory> HardwareInventories { get; set; }
        public DbSet<SoftwareLicense> SoftwareLicenses { get; set; }
        public DbSet<SupportTicket> SupportTickets { get; set; }

        // I accidentally named my tables inconsistently (plural suffix-wise)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<HardwareInventory>().ToTable("HardwareInventory");
            modelBuilder.Entity<SoftwareLicense>().ToTable("SoftwareLicense");
        }
    }
}
