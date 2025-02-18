using System.Text.Json.Serialization;

namespace eshop_MVC.Models
{
    public class ProductModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("properties")]
        public string Properties { get; set; }

        [JsonPropertyName("price")]
        public decimal Price { get; set; }

        [JsonPropertyName("imageUrl")]
        public string ImageUrl { get; set; }

        
        [JsonPropertyName("categories")]
        public IEnumerable<CategoryModel> Categories { get; set; }

       
    }
}
