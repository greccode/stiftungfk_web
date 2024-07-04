using FK_Stiftung.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FK_Stiftung.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjektFoerderer> ProjektFoerderer { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Project>().HasData(
                new Project { Id = 1, Name = "KI-Projekt", Description = "Das KI-Projekt ist super!", PicturePath = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=205119&type=card" },
                new Project { Id = 2, Name = "Europawoche", Description = "Mehr über unser Projekt: Europawoche.", PicturePath = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=205119&type=card" },
                new Project { Id = 3, Name = "Liam nerven", Description = "Unser bisher wichtigstes Projekt.", PicturePath = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=205119&type=card" }
                );
            modelBuilder.Entity<ProjektFoerderer>().HasData(
                new ProjektFoerderer { Id = 1, Name = "Liam" },
                new ProjektFoerderer { Id = 2, Name = "Leon" }
                );            
        }
    }
}
