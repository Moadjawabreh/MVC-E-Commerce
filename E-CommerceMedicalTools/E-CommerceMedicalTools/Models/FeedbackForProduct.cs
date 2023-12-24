using System.ComponentModel.DataAnnotations.Schema;

namespace E_CommerceMedicalTools.Models
{
    public class FeedbackForProduct
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public bool status { get; set; } = false;

        public int Rating { get; set; }

        [ForeignKey("userId")]
        public int userId { get; set; }

        [ForeignKey("productId")]
        public int productId { get; set; }

        public virtual Product Product{ get; set; }
        public virtual User User { get; set; }

    }
}
