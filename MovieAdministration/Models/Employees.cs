using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieAdministration.Models
{
    public class Employees
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }

        [ForeignKey("Type")]
        public virtual Types TypeId { get; set; }

        public virtual ICollection<Movie_Actors> Movie_Actors { get; set; }
    }
}
