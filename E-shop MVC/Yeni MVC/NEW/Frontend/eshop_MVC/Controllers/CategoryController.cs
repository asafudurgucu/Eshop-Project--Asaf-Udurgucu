using eshop_MVC.Abstract;
using eshop_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using eshop_MVC.Services;

namespace eshop_MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;

        public CategoryController(ICategoryService categoryService, IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }

        public async Task<IActionResult> GetAllByCategory(int id, string category)
        {
            var products = await _productService.GetByCategoryAsync(id);
            ViewData["CategoryName"] = category;  
            return View(products);  
        }
    }
}
