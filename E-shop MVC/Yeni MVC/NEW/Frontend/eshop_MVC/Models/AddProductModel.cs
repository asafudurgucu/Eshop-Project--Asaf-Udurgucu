using System.Text.Json.Serialization;

namespace eshop_MVC.Models
{
    public class AddProductModel
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("properties")]
        public string Properties { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("image")]
        public IFormFile Image { get; set; }

        [JsonPropertyName("categoryIds")]
        public List<int> CategoryIds { get; set; }

        
    }
}
