using System.Text.Json.Serialization;

namespace eshop_MVC.Models.SettingsModels
{
    public class AboutBannerPathModel
    {
        [JsonPropertyName("aboutBannerPath")]
        public IFormFile AboutBannerPath { get; set; }
    }
}
