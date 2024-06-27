using FK_Stiftung.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FK_Stiftung.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasData(
                new Project { Id = 1, Name = "KI-Projekt", Description = "Das KI-Projekt ist super!" },
                new Project { Id = 2, Name = "Europawoche", Description = "Mehr über unser Projekt: Europawoche." },
                new Project { Id = 3, Name = "Liam nerven", Description = "Unser bisher wichtigstes Projekt." }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
