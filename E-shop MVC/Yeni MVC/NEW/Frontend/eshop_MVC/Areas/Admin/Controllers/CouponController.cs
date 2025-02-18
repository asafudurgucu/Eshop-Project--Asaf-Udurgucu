using eshop_MVC.Abstract;
using eshop_MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eshop_MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "AdminUser")]
    public class CouponController : Controller
    {
        private readonly ICouponService _couponService;

        public CouponController(ICouponService couponService)
        {
            _couponService = couponService;
        }

        public async Task<ActionResult> Index()
        {
            var coupons = await _couponService.GetCouponsAsync();
            TempData["SuccessMessage"] = "Kupon baþarýyla oluþturuldu.";
            return View(coupons);
        }

        
        [HttpGet]
        public IActionResult CreateCoupon()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCoupon(CouponCreateModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _couponService.CreateCoupon(model);
                if (result != null)
                {
                    TempData["SuccessMessage"] = "Kupon baþarýyla oluþturuldu.";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    TempData["ErrorMessage"] = "Kupon oluþturulurken bir hata oluþtu.";
                }
            }
            return View(model);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _couponService.Delete(id);
            if (result)
            {
                TempData["SuccessMessage"] = "Kupon baþarýyla silindi.";
            }
            else
            {
                TempData["ErrorMessage"] = "Kupon silinirken bir hata oluþtu.";
            }
            return RedirectToAction(nameof(Index));
        }

    }
}
