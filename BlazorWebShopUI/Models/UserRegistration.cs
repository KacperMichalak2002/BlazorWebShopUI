using System.ComponentModel.DataAnnotations;

namespace BlazorWebShopUI.Models
{
    public class UserRegistration
    {
        [Required(ErrorMessage = "Email jest wymagany")]
        public string email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Hasło jest wymagane")]
        public string password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Potwierdzenie hasła jest wymagane")]
        public string ConfirmPassword { get; set; } = string.Empty;

        [Required(ErrorMessage = "Imię jest wymagane")]
        public string firstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Nazwisko jest wymagane")]
        public string lastName { get; set; } = string.Empty;
    }
}
