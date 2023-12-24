using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_CommerceMedicalTools.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public double Price { get; set; }

        public string Description { get; set; }

        public double percentageOfDiscount { get; set; } = 1;

        [ForeignKey("categoryId")]
        public int? categoryId { get; set; }

        public virtual Category category { get; set; }

        public ICollection<User> users { get; set; }

        public ICollection<Image> images { get; set; }

    }
}
