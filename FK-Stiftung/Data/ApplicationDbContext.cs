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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Project>().HasData(
                new Project { Id = 1, Name = "KI-Projekt", Description = "Das KI-Projekt ist super!", PicturePath= "C:\\Users\\leono\\source\\repos\\FK-Stiftung\\FK-Stiftung\\wwwroot\\images\\buch_offen_mit_schuber.jpg" },
                new Project { Id = 2, Name = "Europawoche", Description = "Mehr über unser Projekt: Europawoche.", PicturePath= "C:\\Users\\leono\\source\\repos\\FK-Stiftung\\FK-Stiftung\\wwwroot\\images\\buch_offen_mit_schuber.jpg" },
                new Project { Id = 3, Name = "Liam nerven", Description = "Unser bisher wichtigstes Projekt.", PicturePath= "C:\\Users\\leono\\source\\repos\\FK-Stiftung\\FK-Stiftung\\wwwroot\\images\\buch_offen_mit_schuber.jpg" }
                );
            modelBuilder.Entity<ProjektFoerderer>().HasData(
                new ProjektFoerderer { Id = 1, Name = "Liam" },
                new ProjektFoerderer { Id = 2, Name = "Leon" }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
