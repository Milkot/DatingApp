using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.DTOs
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        
        [Required]
        [StringLength(8, MinimumLength=4,
         ErrorMessage = "Vous devez indiquez un mot de passe entre 4 et 8 caractères")]
        public string Password { get; set; }

    }
}