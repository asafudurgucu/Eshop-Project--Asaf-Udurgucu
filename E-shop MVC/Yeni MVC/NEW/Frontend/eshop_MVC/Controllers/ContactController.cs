using eshop_MVC.Abstract;
using eshop_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;

namespace eshop_MVC.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactMessage _contactMessage;
        private readonly IToastNotification _toaster;
        private readonly ISettingService _settingService;

        public ContactController(IContactMessage contactMessage, IToastNotification toaster, ISettingService settingService)
        {
            _contactMessage = contactMessage;
            _toaster = toaster;
            _settingService = settingService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var settings = await _settingService.GetSettingsAsync();

            ViewBag.Banner = settings.Select(x => x.ContactBannerPath).FirstOrDefault();
            ViewBag.Map = settings.Select(x => x.MapLocation).FirstOrDefault();

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Index(ContactMessageModel model)
        {
            if (!ModelState.IsValid)
            {
                _toaster.AddErrorToastMessage("Formda hatalar var. Lütfen kontrol edin.");
                return View(model);
            }

            var response = await _contactMessage.SendAsync(model);

            if (response != null)
            {
                _toaster.AddSuccessToastMessage("Mesaj başarıyla gönderildi!");
                return RedirectToAction("Index");
            }

            _toaster.AddErrorToastMessage($"Mesaj gönderilemedi. Hata: {response}");
            return View(model);
        }
    }
}
