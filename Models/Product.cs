using System.ComponentModel.DataAnnotations;

namespace ProductWebApp.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Range(0, 10000)]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }
    }
}
