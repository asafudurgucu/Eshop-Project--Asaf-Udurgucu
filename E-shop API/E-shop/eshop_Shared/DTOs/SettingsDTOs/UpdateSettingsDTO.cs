using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop_Shared.DTOs.SettingsDTOs
{
    public class UpdateSettingsDTO
    {
        // Ana Sayfa

        public string FooterText { get; set; }        // Footer Text

        public string SliderText { get; set; }        // Slider Text

        // Hakkımızda Sayfası

        public string AboutTextTitle { get; set; }    // About Text Title
        public string AboutText { get; set; }         // About Text


        // İletişim Sayfası
        public string SocialMediaUrl { get; set; }    // Social Media URL 1
        public string SocialMediaUrl2 { get; set; }   // Social Media URL 2
        public string SocialMediaUrl3 { get; set; }   // Social Media URL 3
        public string MapLocation { get; set; }       // Map (Location or iframe)
    }
}
