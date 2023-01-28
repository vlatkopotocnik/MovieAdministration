using System.Data.Entity.ModelConfiguration.Conventions;
using Microsoft.EntityFrameworkCore;
using MovieAdministration.Models;

namespace MovieAdministration.Models
{
    public class MovieAdministrationDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public MovieAdministrationDbContext(Microsoft.EntityFrameworkCore.DbContextOptions options) : base(options) { }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Employees> Genres { get; set; }
        public DbSet<Employees> Movie_Actors { get; set; }
        public DbSet<Employees> Movies { get; set; }
        public DbSet<Employees> Types { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<MovieAdministration.Models.Genres> Genres_1 { get; set; }

        public DbSet<MovieAdministration.Models.Movie_Actors> Movie_Actors_1 { get; set; }

        public DbSet<MovieAdministration.Models.Movies> Movies_1 { get; set; }

        public DbSet<MovieAdministration.Models.Types> Types_1 { get; set; }
    }
}
