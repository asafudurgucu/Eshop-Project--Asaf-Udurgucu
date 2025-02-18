using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop_Shared.DTOs
{
    public class SettingsDTO
    {
        // Ana Sayfa
        public IFormFile LogoPath { get; set; }          // Logo
        public IFormFile FooterLogoPath { get; set; }    // Footer Logo
        public string FooterText { get; set; }        // Footer Text
        public IFormFile Banner1Path { get; set; }       // Banner 1
        public IFormFile Banner2Path { get; set; }       // Banner 2
        public IFormFile Banner3Path { get; set; }       // Banner 3
        public string SliderText { get; set; }        // Slider Text

        // Hakkımızda Sayfası
        public IFormFile AboutBannerPath { get; set; }   // About Banner
        public string AboutTextTitle { get; set; }    // About Text Title
        public string AboutText { get; set; }         // About Text
        public IFormFile AboutPhotoPath { get; set; }    // About Photo

        // İletişim Sayfası
        public string SocialMediaUrl { get; set; }    // Social Media URL 1
        public string SocialMediaUrl2 { get; set; }   // Social Media URL 2
        public string SocialMediaUrl3 { get; set; }   // Social Media URL 3
        public string MapLocation { get; set; }       // Map (Location or iframe)
        public IFormFile ContactBannerPath { get; set; } // Contact Banner
    }
}
