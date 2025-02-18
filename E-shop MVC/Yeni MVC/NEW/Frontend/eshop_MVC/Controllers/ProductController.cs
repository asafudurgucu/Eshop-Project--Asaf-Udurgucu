using eshop_MVC.Abstract;
using eshop_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;

namespace eshop_MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICommentService _commentService;
        private readonly ICategoryService _categoryService;

        public ProductController(IProductService productService, ICommentService commentService, ICategoryService categoryService)
        {
            this._productService = productService;
            _commentService = commentService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _productService.GetAllActiveAsync();
            var category = await _categoryService.GetActiveCategoriesAsync();

            var half = new HomeProductModel{
                Products = products ,
                Categories = category


            };
            return View(half);
        }

        public async Task<IActionResult> GettAllByCategory(int id , string category)
        {
            var products = await _productService.GetByCategoryAsync(id);
            ViewBag["CategoryName"] = category;
            return View(products);
        }

         public async Task<IActionResult> Details(int id)
        {
            var product = await _productService.GetWithCategoriesAsync(id);
            var comments = await _commentService.GetCommentsByProductIdAsync(id);

            var model = new ProductDetailsViewModel
            {
                Product = product,
                Comments = comments
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateComment(CreateCommentModel model)
        {
            
                var result = await _commentService.CreateCommentAsync(model);
                if (result != null)
                {
                    TempData["SuccessMessage"] = "Yorumunuz başarıyla oluşturuldu.";
                    return RedirectToAction(nameof(Details), new { id = model.ProductId });
                }
                else
                {
                    TempData["ErrorMessage"] = "Yorum oluşturulurken bir hata oluştu.";
               }
            
            return RedirectToAction(nameof(Details), new { id = model.ProductId });
        }

        

    }
}
