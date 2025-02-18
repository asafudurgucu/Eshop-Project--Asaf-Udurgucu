
using eshop_Service.Abstract;
using eshop_Shared.DTOs;
using eshop_Shared.Helpers;
using eshop_Shared.ResponseDTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eshop_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : CustomControllerBase
    {
        private readonly IBasketService _basketService;

        public BasketController(IBasketService basketService)
        {
            _basketService = basketService;
        }

        [HttpPost("applycoupon")]
        [Authorize]
        public async Task<IActionResult> ApplyCouponToBasket(string applicationUserId, string couponCode)
        {
            var basketResponse = await _basketService.GetBasketAsync(applicationUserId);
            

            var applyCouponResponse = await _basketService.ApplyCouponToBasketAsync(basketResponse.Data, couponCode);
            return CreateResponse(applyCouponResponse);
        }

        [Authorize]
        [HttpPost("addtobasket")]

        public async Task<IActionResult> AddProductToBasket(BasketItemCreateDTO basketItemCreateDTO)
        {
            var response = await _basketService.AddProductAsync(basketItemCreateDTO);
            return CreateResponse(response);
        }


       
        [HttpPost("createbasket")]
        public async Task<IActionResult> CreateBasket(BasketCreateDTO basketCreateDTO)
        {
            var response = await _basketService.CreateBasketAsync(basketCreateDTO);
            return CreateResponse(response);
        }

        [Authorize]
        [HttpDelete("removefrombasket/{basketItemId}")]
        public async Task<IActionResult> RemoveProductFromBasket(int basketItemId)
        {
            var response = await _basketService.RemoveProductAsync(basketItemId);
            return CreateResponse(response);
        }

        [Authorize]
        [HttpGet("clearbasket/{applicationUserId}")]
        public async Task<IActionResult> ClearBasket(string applicationUserId)
        {
            var response = await _basketService.ClearBasketAsync(applicationUserId);
            return CreateResponse(response);
        }

        [Authorize]
        [HttpGet("{applicationUserId}")]
        public async Task<IActionResult> GetBasket(string applicationUserId)
        {
            var response = await _basketService.GetBasketAsync(applicationUserId);
            return CreateResponse(response);
        }

        [Authorize]
        [HttpPost("changequantity")]
        public async Task<IActionResult> ChangeQuantity(BasketItemChangeQuantityDTO basketItemChangeQuantityDTO)
        {
            var response = await _basketService.ChangeQuantityBasketAsync(basketItemChangeQuantityDTO);
            return CreateResponse(response);
        }

        [HttpGet("exists/{userId}")]
        public async Task<IActionResult> BasketExists(string userId)
        {
            var basketExists = await _basketService.CheckBasketExistsAsync(userId);
            return Ok(new ResponseDTO<bool>
            {
                Data = basketExists,
                Errors = null
            });
        }



    }
}
