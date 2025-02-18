using System.Text.Json.Serialization;

namespace eshop_MVC.Models.SettingsModels
{
    public class AboutPhotoPathModel
    {
        [JsonPropertyName("aboutPhotoPath")]
        public IFormFile AboutPhotoPath { get; set; }
    }
}
