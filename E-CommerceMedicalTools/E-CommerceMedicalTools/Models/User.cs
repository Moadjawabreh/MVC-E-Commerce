using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace E_CommerceMedicalTools.Models
{
    public enum Role
    {
        Admin,
        User
    }
    public class User
    {
        public User()
        {
            this.products = new HashSet<Product>();
        }
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string locationUrl { get; set; }

        [Required]
        public Role Role { get; set; }

        public ICollection<Product> products { get; set; }
    }
}
