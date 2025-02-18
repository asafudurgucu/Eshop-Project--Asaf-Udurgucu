
using eshop_Service.Abstract;
using eshop_Shared.DTOs;
using eshop_Shared.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eshop_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : CustomControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost("addproduct")]
        [Authorize(Roles = "AdminUser")]
        public async Task<IActionResult> Create(ProductCreateDTO productCreateDTO)
        {
            var response = await _productService.AddAsync(productCreateDTO);
            return CreateResponse(response);
        }

        [HttpGet]
        [Authorize(Roles = "AdminUser")]
        public async Task<IActionResult> GetAll()
        {
            var response = await _productService.GetAllAsync();
            return CreateResponse(response);
        }

        [HttpGet("{isActive}")]

        public async Task<IActionResult> GetAll(bool isActive)
        {
            var response = await _productService.GetAllAsync(isActive);
            return CreateResponse(response);
        }

        [HttpGet("withcategories")]
        public async Task<IActionResult> GetAllWithCategories()
        {
            var response = await _productService.GetAllWithCategoriesAsync();
            return CreateResponse(response);
        }
        [HttpGet("withcategories/false")]
        public async Task<IActionResult> GetAllWithCategoriesFalse()
        {
            var response = await _productService.GetAllWithCategoriesFalseAsync();
            return CreateResponse(response);
        }

        [HttpGet("bycategory/{categoryId}")]
        public async Task<IActionResult> GetAllByCategory(int categoryId)
        {
            var response = await _productService.GetByCategoryAsync(categoryId);
            return CreateResponse(response);
        }

        [HttpGet("get/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _productService.GetAsync(id);
            return CreateResponse(response);
        }

        [HttpGet("getwithcategories/{id}")]
        public async Task<IActionResult> GetByIdWithCategories(int id)
        {
            var response = await _productService.GetWithCategoriesAsync(id);
            return CreateResponse(response);
        }

        [HttpGet("count")]
        [Authorize(Roles = "AdminUser")]
        public async Task<IActionResult> GetCount()
        {
            var response = await _productService.GetCountAsync();
            return CreateResponse(response);
        }

        [HttpGet("count/{isActive}")]
        [Authorize(Roles = "AdminUser")]
        public async Task<IActionResult> GetCount(bool isActive)
        {
            var response = await _productService.GetCountAsync(isActive);
            return CreateResponse(response);
        }

        [HttpGet("countbycategory/{categoryId}")]
        [Authorize(Roles = "AdminUser")]
        public async Task<IActionResult> GetCount(int categoryId)
        {
            var response = await _productService.GetCountByCategory(categoryId);
            return CreateResponse(response);
        }

        [HttpPost("Update")]
        [Authorize(Roles = "AdminUser")]
        public async Task<IActionResult> Update(ProductUpdateDTO productUpdateDTO)
        {
            var response = await _productService.UpdateAsync(productUpdateDTO);
            return CreateResponse(response);
        }

        [Authorize(Roles = "AdminUser")]
        [HttpGet("updateisactive/{id}")]
        public async Task<IActionResult> UpdateIsActive(int id)
        {
            var response = await _productService.UpdateIsActiveAsync(id);
            return CreateResponse(response);
        }

        [Authorize(Roles = "AdminUser")]
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _productService.DeleteAsync(id);
            return CreateResponse(response);
        }

    }
}
