using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TransactionManager.Models
{
    public class Category
    {
        [Key] 
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Icon { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(10)")]
        public string Type { get; set; }

        public List<Transactions> Transactions { get; set;}
    }
}
