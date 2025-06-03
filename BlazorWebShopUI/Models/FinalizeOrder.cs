using System.ComponentModel.DataAnnotations;

namespace BlazorWebShopUI.Models
{
    public class FinalizeOrder
    {
        [Required(ErrorMessage = "Wybierz dostawcę")]
        public DeliveryCompany deliveryCompany { get; set; } = new DeliveryCompany();

        [Required]
        public UserData userData { get; set; } = new UserData();

        [Required(ErrorMessage = "Wybierz metodę płatności")]
        public PaymentMethod paymentMethod { get; set; } = new PaymentMethod();

    }
}
