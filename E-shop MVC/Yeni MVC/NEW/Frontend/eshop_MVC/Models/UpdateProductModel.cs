using System.Text.Json.Serialization;

namespace eshop_MVC.Models
{
    public class UpdateProductModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("properties")]
        public string Properties { get; set; }

        [JsonPropertyName("price")]
        public decimal Price { get; set; }

        [JsonPropertyName("categoryIds")]
        public List<int> CategoryIds { get; set; }

        [JsonPropertyName("image")]
        public IFormFile Image { get; set; }

        
    }
}
