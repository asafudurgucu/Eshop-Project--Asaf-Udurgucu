using eshop_MVC.Abstract;
using eshop_MVC.Models.SettingsModels;
using Microsoft.AspNetCore.Mvc;

namespace eshop_MVC.Controllers
{
    public class AboutController : Controller
    {
        private readonly ISettingService _settingService;

        public AboutController(ISettingService settingService)
        {
            _settingService = settingService;
        }

        public  async Task<ActionResult> Index()
        {
            var settings = await _settingService.GetSettingsAsync();
            return View(settings);
        }
    }
}
