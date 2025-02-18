using eshop_Service.Abstract;
using eshop_Shared.DTOs;
using eshop_Shared.DTOs.SettingsDTOs;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using eshop_Shared.Helpers;
using Microsoft.AspNetCore.Authorization;

namespace eshop_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SettingsController : CustomControllerBase
    {
        private readonly ISettingsService _settingsService;

        public SettingsController(ISettingsService settingsService)
        {
            _settingsService = settingsService;
        }

        [HttpPost("update")]
        [Authorize(Roles = "AdminUser")]
        public async Task<IActionResult> Update([FromBody] UpdateSettingsDTO updateSettingsDTO)
        {
            if (updateSettingsDTO == null) return BadRequest("Invalid settings data.");
            return CreateResponse(await _settingsService.UpdateAsync(updateSettingsDTO));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return CreateResponse(await _settingsService.GetAllAsync());
        }

        // Image Update Methods
        [HttpPost("update-logo")]
        [Consumes("multipart/form-data")]
        [Authorize(Roles = "AdminUser")]
        public async Task<IActionResult> UpdateLogo([FromForm] LogoPathDTO logoFile)
        {
            if (logoFile == null || logoFile.LogoPath == null)
                return BadRequest("Logo file is required.");

            return CreateResponse(await _settingsService.UpdateLogoAsync(logoFile));
        }

        [HttpPost("update-footer-logo")]
        [Authorize(Roles = "AdminUser")]
        public async Task<IActionResult> UpdateFooterLogo([FromForm] FooterLogoPathDTO footerLogoFile)
        {
            if (footerLogoFile == null || footerLogoFile.FooterLogoPath == null)
                return BadRequest("Footer logo file is required.");

            return CreateResponse(await _settingsService.UpdateFooterLogoAsync(footerLogoFile));
        }

        [HttpPost("update-banner1")]
        [Authorize(Roles = "AdminUser")]
        public async Task<IActionResult> UpdateBanner1([FromForm] Banner1PathDTO banner1File)
        {
            if (banner1File == null || banner1File.Banner1Path == null)
                return BadRequest("Banner 1 file is required.");

            return CreateResponse(await _settingsService.UpdateBanner1Async(banner1File));
        }

        [HttpPost("update-banner2")]
        [Authorize(Roles = "AdminUser")]
        public async Task<IActionResult> UpdateBanner2([FromForm] Banner2PathDTO banner2File)
        {
            if (banner2File == null || banner2File.Banner2Path == null)
                return BadRequest("Banner 2 file is required.");

            return CreateResponse(await _settingsService.UpdateBanner2Async(banner2File));
        }

        [HttpPost("update-banner3")]
        [Authorize(Roles = "AdminUser")]
        public async Task<IActionResult> UpdateBanner3([FromForm] Banner3PathDTO banner3File)
        {
            if (banner3File == null || banner3File.Banner3Path == null)
                return BadRequest("Banner 3 file is required.");

            return CreateResponse(await _settingsService.UpdateBanner3Async(banner3File));
        }

        [HttpPost("update-about-banner")]
        [Authorize(Roles = "AdminUser")]
        public async Task<IActionResult> UpdateAboutBanner([FromForm] AboutBannerPathDTO aboutBannerFile)
        {
            if (aboutBannerFile == null || aboutBannerFile.AboutBannerPath == null)
                return BadRequest("About Banner file is required.");

            return CreateResponse(await _settingsService.UpdateAboutBannerAsync(aboutBannerFile));
        }

        [HttpPost("update-about-photo")]
        [Authorize(Roles = "AdminUser")]
        public async Task<IActionResult> UpdateAboutPhoto([FromForm] AboutPhotoPathDTO aboutPhotoFile)
        {
            if (aboutPhotoFile == null || aboutPhotoFile.AboutPhotoPath == null)
                return BadRequest("About Photo file is required.");

            return CreateResponse(await _settingsService.UpdateAboutPhotoAsync(aboutPhotoFile));
        }

        [HttpPost("update-contact-banner")]
        [Authorize(Roles = "AdminUser")]
        public async Task<IActionResult> UpdateContactBanner([FromForm] ContactBannerPathDTO contactBannerFile)
        {
            if (contactBannerFile == null || contactBannerFile.ContactBannerPath == null)
                return BadRequest("Contact Banner file is required.");

            return CreateResponse(await _settingsService.UpdateContactBannerAsync(contactBannerFile));
        }
    }
}
