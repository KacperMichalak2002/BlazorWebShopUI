namespace BlazorWebShopUI.Models
{
    public class Filters
    {
        public List<String> Categories { get; set; } = new List<string>();
        public Dictionary<String, List<String>> FiltersToCreate { get; set; } = new Dictionary<string, List<string>>();
    }
}
