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
    }
}
