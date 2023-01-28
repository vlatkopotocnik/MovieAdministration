using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieAdministration.Models
{
    public class Employees
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("Type")]
        public virtual Types TypeId { get; set; }

        public virtual ICollection<Movie_Actors> Movie_Actors { get; set; }
    }
}
