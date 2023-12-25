using System.ComponentModel.DataAnnotations;

namespace E_CommerceMedicalTools.Models
{
    public class Payment
    {
        public int ID { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
