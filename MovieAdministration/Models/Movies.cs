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
        public string Description { get; set; }
        public TimeSpan Duration { get; set; }
        public decimal Budget { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        [ForeignKey("Director")]
        public virtual Employees DirectorId { get; set; }


        public virtual ICollection<Movie_Genres> Movie_Genres { get; set; }
        public virtual ICollection<Movie_Actors> Movie_Actors { get; set; }
    }
}
