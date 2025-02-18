using System.Text.Json.Serialization;

namespace eshop_MVC.Models.SettingsModels
{
    public class Banner3PathModel
    {
        [JsonPropertyName("banner3Path")]
        public IFormFile Banner3Path { get; set; }
    }
}
