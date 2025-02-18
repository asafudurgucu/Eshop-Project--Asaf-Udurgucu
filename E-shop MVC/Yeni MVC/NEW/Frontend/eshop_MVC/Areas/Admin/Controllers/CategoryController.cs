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
using System.Linq;

namespace eshop_MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "AdminUser")]
    public class CategoryController : Controller
    {
        private readonly IToastNotification _toaster;
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService, IToastNotification toaster)
        {
            _categoryService = categoryService;
            _toaster = toaster;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _categoryService.GetAllCategoriesAsync();
            
            
            return View(categories);
        }

        public async Task<IActionResult> GetFalseCategories()
        {
            var activeCategories = await _categoryService.GetPassiveCategoriesAsync();
            return View(activeCategories);
        }

        public async Task<IActionResult> Details(int id)
        {
            var category = await _categoryService.GetCategoriesAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        public  IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AddCategoryModel addCategoryModel)
        {
            if (ModelState.IsValid)
            {
                await _categoryService.AddCategoriyAsync(addCategoryModel);
               
                return RedirectToAction(nameof(Index));
            }
            return View(addCategoryModel);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var category = await _categoryService.GetCategoriesAsync(id);
           if(category == null)
            {
                return NotFound();
            }
            var UpdateCategoryModel = new UpdateCategoryModel
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
                IsActive = category.IsActive
            };

            return View(UpdateCategoryModel);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, UpdateCategoryModel category)
        {
            if (id != category.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                var updateResult = await _categoryService.UpdateCategoryModel(category);
                if (updateResult)
                {
                   
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Kategori güncellenirken bir hata oluştu.");
                }
            }
            return View(category);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var category = await _categoryService.GetCategoriesAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _categoryService.DeleteCategoryModel(id);
           
            return RedirectToAction(nameof(Index));
        }
    }
}
