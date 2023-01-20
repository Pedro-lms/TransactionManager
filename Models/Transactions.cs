using System.ComponentModel.DataAnnotations;

namespace TransactionManager.Models
{
    public class Transactions
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [Required]
        public double Value { get; set; }

        [Required,StringLength(1000)]
        public string Description { get; set; }
        
        [Required]
        public DateTime RegistreDate { get; set; }

        [Required]
        public Category Category{ get; set; }
    }
}
