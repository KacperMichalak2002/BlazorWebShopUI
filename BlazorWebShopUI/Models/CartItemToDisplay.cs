namespace BlazorWebShopUI.Models
{
    public class CartItemToDisplay
    {
        public string ImageUrl { get; set; } = string.Empty;
        public string cartItemName { get; set; } = string.Empty;
        public float cartItemPrice { get; set; }
        public int amount { get; set; }
        public int id { get; set; }
    }
}
