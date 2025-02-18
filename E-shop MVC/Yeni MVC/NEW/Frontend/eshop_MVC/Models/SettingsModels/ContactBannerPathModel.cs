using System.Text.Json.Serialization;

namespace eshop_MVC.Models.SettingsModels
{
    public class ContactBannerPathModel
    {
        [JsonPropertyName("contactBannerPath")]
        public IFormFile ContactBannerPath { get; set; }
    }
}
