using System.ComponentModel.DataAnnotations;

namespace BlazorWebShopUI.Models
{
    public class UserData
    {
     
        [Required(ErrorMessage = "Imię jest wymagane")]
        public string firstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Nazwisko jest wymagane")]
        public string lastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Telefon jest wymagany")]
        public string phoneNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email jest wymagany")]
        public string email { get; set; } = string.Empty;

        [Required(ErrorMessage ="Miejscowość jest wymagana")]
        public string city { get; set; } = string.Empty;

        [Required(ErrorMessage ="Ulica jest wymagana")]
        public string street { get; set; } = string.Empty;

        [Required(ErrorMessage = "Kod pocztowy jest wymagany")]
        public string postalCode { get; set; } = string.Empty;



    }
}
