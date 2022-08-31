using System.ComponentModel.DataAnnotations;

namespace Heroes3WebApp.Models
{
    public class CreateUserViewModel
    {
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
    }
}
