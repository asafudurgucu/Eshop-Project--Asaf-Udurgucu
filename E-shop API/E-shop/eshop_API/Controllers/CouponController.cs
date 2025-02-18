using eshop_Service.Abstract;
using eshop_Shared.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eshop_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponController : ControllerBase
    {
        private readonly ICouponService _couponService;

        public CouponController(ICouponService couponService)
        {
            _couponService = couponService;
        }

        [Authorize]
        [HttpPost("apply")]
        public async Task<IActionResult> ApplyCoupon([FromBody] CouponApplyDTO couponApplyDto)
        {
            var response = await _couponService.ApplyCouponAsync(couponApplyDto);
            if (response.IsSucceded)
                return Ok(response);

            return BadRequest(response);
        }

        [Authorize(Roles = "AdminUser")]
        [HttpPost]
        public async Task<IActionResult> CreateCoupon([FromBody] CouponCreateDTO couponCreateDto)
        {
            var response = await _couponService.CreateCouponAsync(couponCreateDto);
            if (response.IsSucceded)
                return Ok(response);

            return BadRequest(response);
        }

        [Authorize(Roles = "AdminUser")]
        [HttpGet("coupons")]
        public async Task<IActionResult> GetCoupons()
        {
            var response = await _couponService.GetCouponsAsync();
            if (response.IsSucceded)
                return Ok(response);

            return BadRequest(response);
        }

        [Authorize(Roles = "AdminUser")]
        [HttpGet("{code}")]
        public async Task<IActionResult> GetById(string code)
        {
            var response = await _couponService.GetCouponByCodeAsync(code);
            if (response.IsSucceded)
                return Ok(response);

            return BadRequest(response);
        }

        [Authorize(Roles = "AdminUser")]
        [HttpDelete("{code}")]
        public async Task<IActionResult> Delete(int code)
        {
            var response = await _couponService.DeleteCouponAsync(code);
            if (response.IsSucceded)
                return Ok(response);

            return BadRequest(response);
        }


    }
}
