namespace BlazorWebShop.Models
{
    public class ProductCardInfo
    {
        public string Title { get; set; } = string.Empty;
        public List<String> Description { get; set; } = new List<string>();
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
    }
}
