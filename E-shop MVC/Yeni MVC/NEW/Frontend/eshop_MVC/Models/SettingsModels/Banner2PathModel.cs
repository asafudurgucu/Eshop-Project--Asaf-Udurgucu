using System.Text.Json.Serialization;

namespace eshop_MVC.Models.SettingsModels
{
    public class Banner2PathModel
    {
        [JsonPropertyName("banner2Path")]
        public IFormFile Banner2Path { get; set; }
    }
}
