using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_CommerceMedicalTools.Models
{
    public class Image
    {
        public int Id { get; set; }

        [Required]
        public string UrlImage { get; set; }

        [ForeignKey("productId")]
        public int productId { get; set; }
        public virtual Product Product { get; set; }
    }
}
