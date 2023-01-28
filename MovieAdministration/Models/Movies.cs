using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MovieAdministration.Models
{
    public class Movies
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("Director")]
        public virtual Employees DirectorId { get; set; }

        [ForeignKey("Genres")]
        public virtual Genres GenresId { get; set; }
        public virtual ICollection<Movie_Actors> Movie_Actors { get; set; }
    }
}
