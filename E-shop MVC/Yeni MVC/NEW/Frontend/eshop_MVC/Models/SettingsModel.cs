using System.Text.Json.Serialization;

namespace eshop_MVC.Models
{
    public class SettingsModel
    {
       

       

        [JsonPropertyName("footerText")]
        public string FooterText { get; set; }

        [JsonPropertyName("sliderText")]
        public string SliderText { get; set; }


        [JsonPropertyName("aboutTextTitle")]
        public string AboutTextTitle { get; set; }

        [JsonPropertyName("aboutText")]
        public string AboutText { get; set; }

        

        [JsonPropertyName("socialMediaUrl")]
        public string SocialMediaUrl { get; set; }

        [JsonPropertyName("socialMediaUrl2")]
        public string SocialMediaUrl2 { get; set; }

        [JsonPropertyName("socialMediaUrl3")]
        public string SocialMediaUrl3 { get; set; }

        [JsonPropertyName("mapLocation")]
        public string MapLocation { get; set; }

        
    }
}
