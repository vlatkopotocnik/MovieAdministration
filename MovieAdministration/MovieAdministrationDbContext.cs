using Microsoft.EntityFrameworkCore;
using MovieAdministration.Models;

namespace MovieAdministration
{
    public class MovieAdministrationDbContext : DbContext
    {
        public MovieAdministrationDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Genres> Genres { get; set; }
        public DbSet<Movie_Actors> Movie_Actors { get; set; }
        public DbSet<Movie_Genres> Movie_Genres { get; set; }
        public DbSet<Movies> Movies { get; set; }
        public DbSet<Types> Types { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
