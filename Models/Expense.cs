using System.ComponentModel.DataAnnotations;

namespace TransactionManager.Models
{
    public class Expense : Transactions
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public bool FixedOrVariableExpanse { get; set; }

        public Expense() { }
    }
}
