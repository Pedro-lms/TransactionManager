using System.ComponentModel.DataAnnotations;

namespace TransactionManager.Models
{
    public class Category
    {
        [Key] 
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public List<Category> Categories { get; set;}
    }
}
