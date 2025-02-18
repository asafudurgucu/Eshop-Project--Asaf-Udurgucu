using System.Text.Json.Serialization;

namespace eshop_MVC.Models.SettingsModels
{
    public class FooterLogoPathModel
    {
        [JsonPropertyName("footerLogoPath")]
        public IFormFile FooterLogoPath { get; set; }
    }
}
