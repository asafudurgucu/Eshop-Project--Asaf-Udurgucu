using System.Text.Json.Serialization;

namespace eshop_MVC.Models.SettingsModels
{
    public class GetSettingsModel
    {
        [JsonPropertyName("logoPath")]
        public string LogoPath { get; set; }

        [JsonPropertyName("footerLogoPath")]
        public string FooterLogoPath { get; set; }

        [JsonPropertyName("footerText")]
        public string FooterText { get; set; }

        [JsonPropertyName("banner1Path")]
        public string Banner1Path { get; set; }

        [JsonPropertyName("banner2Path")]
        public string Banner2Path { get; set; }

        [JsonPropertyName("banner3Path")]
        public string Banner3Path { get; set; }

        [JsonPropertyName("sliderText")]
        public string SliderText { get; set; }

        [JsonPropertyName("aboutBannerPath")]
        public string AboutBannerPath { get; set; }

        [JsonPropertyName("aboutTextTitle")]
        public string AboutTextTitle { get; set; }

        [JsonPropertyName("aboutText")]
        public string AboutText { get; set; }

        [JsonPropertyName("aboutPhotoPath")]
        public string AboutPhotoPath { get; set; }

        [JsonPropertyName("socialMediaUrl")]
        public string SocialMediaUrl { get; set; }

        [JsonPropertyName("socialMediaUrl2")]
        public string SocialMediaUrl2 { get; set; }

        [JsonPropertyName("socialMediaUrl3")]
        public string SocialMediaUrl3 { get; set; }

        [JsonPropertyName("mapLocation")]
        public string MapLocation { get; set; }

        [JsonPropertyName("contactBannerPath")]
        public string ContactBannerPath { get; set; }
    }
}
