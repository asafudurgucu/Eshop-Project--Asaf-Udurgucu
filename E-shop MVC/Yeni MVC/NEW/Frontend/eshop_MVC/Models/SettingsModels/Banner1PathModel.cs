using System.Text.Json.Serialization;

namespace eshop_MVC.Models.SettingsModels
{
    public class Banner1PathModel
    {
        [JsonPropertyName("banner1Path")]
        public IFormFile Banner1Path { get; set; }
    }
}
