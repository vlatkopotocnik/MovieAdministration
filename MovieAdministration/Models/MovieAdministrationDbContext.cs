using System.Data.Entity.ModelConfiguration.Conventions;
using Microsoft.EntityFrameworkCore;

namespace MovieAdministration.Models
{
    public class MovieAdministrationDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public MovieAdministrationDbContext(Microsoft.EntityFrameworkCore.DbContextOptions options) : base(options) { }
        DbSet<Employees> Employees { get; set; }
        DbSet<Employees> Genres { get; set; }
        DbSet<Employees> Movie_Actors { get; set; }
        DbSet<Employees> Movies { get; set; }
        DbSet<Employees> Types { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
