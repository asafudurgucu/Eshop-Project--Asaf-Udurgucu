using eshop_MVC.Models;
using eshop_MVC.Models.SettingsModels;

namespace eshop_MVC.Abstract
{
    public interface ISettingService
    {
        Task<IEnumerable<GetSettingsModel>> GetSettingsAsync();

        // Ayarları güncellemek için
        Task<bool> UpdateSettingsAsync(SettingsModel settingsModel);

        // Logo güncelleme
        Task<bool> UpdateLogo(LogoPathModel model);

        // Footer Logo güncelleme
        Task<bool> UpdateFooterLogo(FooterLogoPathModel model);

        // Banner 1 güncelleme
        Task<bool> UpdateBanner1(Banner1PathModel model);

        // Banner 2 güncelleme
        Task<bool> UpdateBanner2(Banner2PathModel model);

        // Banner 3 güncelleme
        Task<bool> UpdateBanner3(Banner3PathModel model);

        // About Banner güncelleme
        Task<bool> UpdateAboutBanner(AboutBannerPathModel model);

        // About Photo güncelleme
        Task<bool> UpdateAboutPhoto(AboutPhotoPathModel model);

        // Contact Banner güncelleme
        Task<bool> UpdateContactBanner(ContactBannerPathModel model);
    }
}
