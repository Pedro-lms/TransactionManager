using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;

namespace TransactionManager.Models
{
    public class Income : Transactions
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public bool IncomeOrigin { get; set; }
        
        public Income() { }
    }
}
