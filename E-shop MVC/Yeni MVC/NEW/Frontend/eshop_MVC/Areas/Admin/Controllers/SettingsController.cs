using eshop_MVC.Abstract;
using eshop_MVC.Models;
using eshop_MVC.Models.SettingsModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eshop_MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "AdminUser")]
    public class SettingsController : Controller
    {
        private readonly ISettingService _settingService;

        public SettingsController(ISettingService settingService)
        {
            _settingService = settingService;
        }

        // Index GET (Mevcut ayarları getirir)
        public async Task<IActionResult> Index()
        {
            var settings = await _settingService.GetSettingsAsync();
            return View(settings);
        }

       
        public async Task<IActionResult> Update()
        {
            // Veritabanından veya servisten ayarları alın
            var settings = await _settingService.GetSettingsAsync();

            // İlk öğeyi alıyoruz
            var firstSetting = settings.FirstOrDefault();

            // Eğer ayar bulunduysa, ViewBag üzerinden verilere aktarın
            if (firstSetting != null)
            {
                ViewBag.FooterText = firstSetting.FooterText;
                ViewBag.SliderText = firstSetting.SliderText;
                ViewBag.AboutTextTitle = firstSetting.AboutTextTitle;
                ViewBag.AboutText = firstSetting.AboutText;
                ViewBag.SocialMediaUrl = firstSetting.SocialMediaUrl;
                ViewBag.SocialMediaUrl2 = firstSetting.SocialMediaUrl2;
                ViewBag.SocialMediaUrl3 = firstSetting.SocialMediaUrl3;
                ViewBag.MapLocation = firstSetting.MapLocation;
            }

            return View();
        }



        // Update POST (Ayarları günceller)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(SettingsModel settings)
        {
            var updateResult = await _settingService.UpdateSettingsAsync(settings);

            if (updateResult)
            {
                TempData["SuccessMessage"] = "Ayarlar başarıyla güncellendi!";
                return RedirectToAction(nameof(Update));
            }
            else
            {
                TempData["ErrorMessage"] = "Ayarlar güncellenirken bir hata oluştu.";
                return View(settings);
            }
        }

        // Logo güncelleme
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateLogo(LogoPathModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _settingService.UpdateLogo(model);

                if (result)
                {
                    TempData["SuccessMessage"] = "Logo başarıyla güncellendi!";
                    return RedirectToAction(nameof(Update));
                }
                else
                {
                    TempData["ErrorMessage"] = "Logo güncellenirken bir hata oluştu.";
                }
            }
            return View("Update");
        }

        // Footer Logo güncelleme
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateFooterLogo(FooterLogoPathModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _settingService.UpdateFooterLogo(model);

                if (result)
                {
                    TempData["SuccessMessage"] = "Footer logo başarıyla güncellendi!";
                    return RedirectToAction(nameof(Update));
                }
                else
                {
                    TempData["ErrorMessage"] = "Footer logo güncellenirken bir hata oluştu.";
                }
            }
            return View("Update");
        }

        // Banner 1 güncelleme
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateBanner1(Banner1PathModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _settingService.UpdateBanner1(model);

                if (result)
                {
                    TempData["SuccessMessage"] = "Banner 1 başarıyla güncellendi!";
                    return RedirectToAction(nameof(Update));
                }
                else
                {
                    TempData["ErrorMessage"] = "Banner 1 güncellenirken bir hata oluştu.";
                }
            }
            return View("Update");
        }

        // Banner 2 güncelleme
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateBanner2(Banner2PathModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _settingService.UpdateBanner2(model);

                if (result)
                {
                    TempData["SuccessMessage"] = "Banner 2 başarıyla güncellendi!";
                    return RedirectToAction(nameof(Update));
                }
                else
                {
                    TempData["ErrorMessage"] = "Banner 2 güncellenirken bir hata oluştu.";
                }
            }
            return View("Update");
        }

        // Banner 3 güncelleme
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateBanner3(Banner3PathModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _settingService.UpdateBanner3(model);

                if (result)
                {
                    TempData["SuccessMessage"] = "Banner 3 başarıyla güncellendi!";
                    return RedirectToAction(nameof(Update));
                }
                else
                {
                    TempData["ErrorMessage"] = "Banner 3 güncellenirken bir hata oluştu.";
                }
            }
            return View("Update");
        }

        // About Banner güncelleme
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateAboutBanner(AboutBannerPathModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _settingService.UpdateAboutBanner(model);

                if (result)
                {
                    TempData["SuccessMessage"] = "About Banner başarıyla güncellendi!";
                    return RedirectToAction(nameof(Update));
                }
                else
                {
                    TempData["ErrorMessage"] = "About Banner güncellenirken bir hata oluştu.";
                }
            }
            return View("Update");
        }

        // About Photo güncelleme
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateAboutPhoto(AboutPhotoPathModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _settingService.UpdateAboutPhoto(model);

                if (result)
                {
                    TempData["SuccessMessage"] = "About Photo başarıyla güncellendi!";
                    return RedirectToAction(nameof(Update));
                }
                else
                {
                    TempData["ErrorMessage"] = "About Photo güncellenirken bir hata oluştu.";
                }
            }
            return View("Update");
        }

        // Contact Banner güncelleme
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateContactBanner(ContactBannerPathModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _settingService.UpdateContactBanner(model);

                if (result)
                {
                    TempData["SuccessMessage"] = "Contact Banner başarıyla güncellendi!";
                    return RedirectToAction(nameof(Update));
                }
                else
                {
                    TempData["ErrorMessage"] = "Contact Banner güncellenirken bir hata oluştu.";
                }
            }
            return View("Update");
        }
    }
}
