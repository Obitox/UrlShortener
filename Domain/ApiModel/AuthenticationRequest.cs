using System.ComponentModel.DataAnnotations;

namespace Domain.ApiModel
{
    public class AuthenticationRequest
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}