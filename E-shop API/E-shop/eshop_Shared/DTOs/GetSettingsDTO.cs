using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop_Shared.DTOs
{
    public class GetSettingsDTO
    {
        public string LogoPath { get; set; }          // Logo
        public string FooterLogoPath { get; set; }    // Footer Logo
        public string FooterText { get; set; }        // Footer Text
        public string Banner1Path { get; set; }       // Banner 1
        public string Banner2Path { get; set; }       // Banner 2
        public string Banner3Path { get; set; }       // Banner 3
        public string SliderText { get; set; }        // Slider Text

        // Hakkımızda Sayfası
        public string AboutBannerPath { get; set; }   // About Banner
        public string AboutTextTitle { get; set; }    // About Text Title
        public string AboutText { get; set; }         // About Text
        public string AboutPhotoPath { get; set; }    // About Photo

        // İletişim Sayfası
        public string SocialMediaUrl { get; set; }    // Social Media URL 1
        public string SocialMediaUrl2 { get; set; }   // Social Media URL 2
        public string SocialMediaUrl3 { get; set; }   // Social Media URL 3
        public string MapLocation { get; set; }       // Map (Location or iframe)
        public string ContactBannerPath { get; set; } // Contact Banner
    }
}
