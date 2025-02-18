
using eshop_Service.Abstract;
using eshop_Shared.DTOs;
using eshop_Shared.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace eshop_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : CustomControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        [Authorize(Roles = "AdminUser")]
        public async Task<IActionResult> Create(CategoryCreateDTO categoryCreateDTO)
        {
            var response = await _categoryService.AddAsync(categoryCreateDTO);
            return CreateResponse(response);
        }


        [HttpGet("getall/{isActive?}")]
        public async Task<IActionResult> GetAll(bool? isActive = null)
        {
            var response = isActive == null
                                ? await _categoryService.GetAllAsync()
                                : await _categoryService.GetAllAsync(isActive);
            return CreateResponse(response);
        }


        [HttpGet("get/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _categoryService.GetAsync(id);
            return CreateResponse(response);
        }

        [Authorize(Roles = "AdminUser")]
        [HttpGet("count/{isActive?}")]
        public async Task<IActionResult> Count(bool? isActive)
        {
            var response = isActive == null
                            ? await _categoryService.CountAsync()
                            : await _categoryService.CountAsync(isActive);
            return CreateResponse(response);
        }

        [HttpPut]
        [Authorize(Roles = "AdminUser")]
        public async Task<IActionResult> Update(CategoryUpdateDTO categoryUpdateDTO)
        {
            var response = await _categoryService.UpdateAsync(categoryUpdateDTO);
            return CreateResponse(response);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "AdminUser")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _categoryService.DeleteAsync(id);
            return CreateResponse(response);
        }

        [HttpGet("updateisactive/{id}")]
        [Authorize(Roles = "AdminUser")]
        public async Task<IActionResult> UpdateIsActive(int id)
        {
            var response = await _categoryService.UpdateIsActiveAsync(id);
            return CreateResponse(response);
        }
    }
}
