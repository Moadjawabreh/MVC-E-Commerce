using System.ComponentModel.DataAnnotations;

namespace E_CommerceMedicalTools.Models
{
    public class Category
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Image { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
