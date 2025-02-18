// filepath: /C:/Users/Casper/Documents/GitHub/E-Shop-Project/Projet-MVC-APİ/E-shop MVC/Yeni MVC/NEW/Frontend/eshop_MVC/ViewComponents/LogoViewComponent.cs
using eshop_MVC.Abstract;
using eshop_MVC.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

public class LogoViewComponent : ViewComponent
{
    private readonly ISettingService _settingService;

    public LogoViewComponent(ISettingService settingService)
    {
        _settingService = settingService;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var settings = await _settingService.GetSettingsAsync();
        var logoPath = settings?.FirstOrDefault()?.LogoPath ?? "default-logo.png";
        return View("Default", logoPath);
    }
}