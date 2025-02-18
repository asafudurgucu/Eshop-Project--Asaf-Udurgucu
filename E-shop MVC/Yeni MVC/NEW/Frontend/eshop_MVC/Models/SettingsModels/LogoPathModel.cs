using System.Text.Json.Serialization;

namespace eshop_MVC.Models.SettingsModels
{
    public class LogoPathModel
    {
        [JsonPropertyName("logoPath")]
        public IFormFile LogoPath { get; set; }
    }
}
