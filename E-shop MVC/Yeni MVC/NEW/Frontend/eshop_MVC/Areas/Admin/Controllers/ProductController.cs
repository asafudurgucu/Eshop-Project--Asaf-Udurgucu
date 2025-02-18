using eshop_MVC.Abstract;
using eshop_MVC.Models;
using eshop_MVC.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using NToastNotify;

using Microsoft.AspNetCore.Mvc.Rendering;

namespace eshop_MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "AdminUser")]
    public class ProductController : Controller
    {
        private readonly IToastNotification _toaster;
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        

        public ProductController(IProductService productService, ICategoryService categoryService, IToastNotification toaster)
        {
            _productService = productService;
            _categoryService = categoryService;
            _toaster = toaster;
           
        }

        public async Task<IActionResult> Index()
        {
            var ActiveCount = await _productService.GetCountAsync(true);
            var ProductCount = await _productService.GetCountAsync();
            var products = await _productService.GetAllWithCategoriesAsync();
            ViewBag.ProductCount = ProductCount;
            ViewBag.ActiveCount = ActiveCount;
            return View(products);
        }

        public async Task<IActionResult> GetAllFalse()
        {
            var product = await _productService.GetAllWithCategoriesFalseAsync();
            var ProductCount = await _productService.GetCountAsync(false);
            ViewBag.ProductCount = ProductCount; 
            return View(product);
        }

        public async Task<IActionResult> Details(int id)
        {
            var product = await _productService.GetWithCategoriesAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }



        public async Task<IActionResult> Create()
        {
            ViewBag.Categories = new SelectList(await _categoryService.GetAllCategoriesAsync(), "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AddProductModel addProductModel)
        {

            if (ModelState.IsValid)
            {
                // AddProductModel'i doğrudan kullanarak ürün ekleme
                await _productService.AddAsync(addProductModel);
               
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Categories = new SelectList(await _categoryService.GetAllCategoriesAsync(), "Id", "Name");
            return View(addProductModel);
        }

        public async Task<IActionResult> Edit(int id)
        {
            
            var product = await _productService.GetAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            
            ViewBag.ProductName = product.Name;
            ViewBag.ProductProperties = product.Properties;
            ViewBag.ProductPrice = product.Price;
            ViewBag.ProductImage = product.ImageUrl; 
            ViewBag.SelectedCategories = product.Categories.Select(c => c.Id).ToList();

           
            ViewBag.Categories = new SelectList(await _categoryService.GetAllCategoriesAsync(), "Id", "Name");
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, UpdateProductModel product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                var updateResult = await _productService.UpdateAsync(product);
                if (updateResult)
                {
                   
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "An error occurred while updating the product.");
                }
            }
            ViewBag.Categories = new SelectList(await _categoryService.GetAllCategoriesAsync(), "Id", "Name");
            return View(product);
        }



        public async Task<IActionResult> Delete(int id)
        {
            var product = await _productService.GetAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _productService.DeleteAsync(id);
          
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<ActionResult> UpdateIsActive(int id)
        {
            
            var result = await _productService.UpdateIsActiveAsync(id);
            return Redirect(Request.Headers["Referer"].ToString());

        }


    }

    }
