using System.Text.Json.Serialization;

namespace eshop_MVC.Models
{
    public class CategoryModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("isActive")]
        public bool IsActive { get; set; }
    }
}
