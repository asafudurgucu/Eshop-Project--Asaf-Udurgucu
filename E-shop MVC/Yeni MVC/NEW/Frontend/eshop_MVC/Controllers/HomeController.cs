using eshop_MVC.Abstract;
using eshop_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

public class HomeController : Controller
{
    private readonly ICategoryService _categoryService;
    private readonly IProductService _productService;
    private readonly ISettingService _settingService;

    public HomeController(ICategoryService categoryService, IProductService productService, ISettingService settingService)
    {
        _categoryService = categoryService;
        _productService = productService;
        _settingService = settingService;
    }

    public async Task<IActionResult> Index()
    {
        
        var categories = await _categoryService.GetActiveCategoriesAsync();
        var products = await _productService.GetAllWithCategoriesAsync();
        var settings = await _settingService.GetSettingsAsync();


        // Kategori ID'si 12 olanlarý filtreleme
        var filteredProducts = products.Where(p => p.Categories.Any(c => c.Id == 12)).Take(12).ToList();

        var model = new HomeProductModel
        {
            Settings = settings,
            Categories = categories,
            Products = filteredProducts
        };

        return View(model);
    }
}
