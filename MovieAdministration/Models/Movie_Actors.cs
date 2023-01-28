using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MovieAdministration.Models
{
    public class Movie_Actors
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int MovieID { get; set; }
        public int ActorID { get; set; }
        public virtual Movies Movie { get; set; }
        public virtual Employees Actor { get; set; }
    }
}
