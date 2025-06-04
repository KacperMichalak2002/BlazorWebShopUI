namespace BlazorWebShopUI.Models
{
    public class ProductCardInfo
    {

        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public List<String> Category { get; set; } = new List<string>();
        public List<String> Description { get; set; } = new List<string>();
        public Dictionary<string, string> Specification { get; set; } = new Dictionary<string, string>();
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } = string.Empty;

        public List<String> images { get; set; } = new List<string>();
    }
}
