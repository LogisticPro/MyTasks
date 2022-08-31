using System.ComponentModel.DataAnnotations;

namespace Heroes3WebApp.Models
{
    public class LoginViewModel
    {
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
