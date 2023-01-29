using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MovieAdministration.Models
{
    public class Movie_Actors
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public decimal ExpectedBudget { get; set; }
        public bool isCalled { get; set; }
        public bool isActing { get; set; }
        public bool isBudgetChangeRequested { get; set; }
        public decimal RequestedBudgetChange { get; set; }
        public int MovieId { get; set; }
        public int ActorId { get; set; }
        public virtual Movies Movie { get; set; }
        public virtual Employees Actor { get; set; }
    }
}
