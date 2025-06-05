namespace BlazorWebShopUI.Models
{
    public class HistoryOrderBody
    {
        public List<String> imagesUrl { get; set; } = new List<String>();
        public float totalPrice { get; set; }

        public String date { get; set; } = DateTime.Now.ToShortDateString();
    }
}
