using eshop_MVC.Abstract;
using eshop_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System.Security.Claims;

namespace eshop_MVC.Controllers
{
    public class BasketController : Controller
    {
        private readonly IBasketService _basketService;
        private readonly IProductService _productService;
        private readonly IToastNotification _toaster;

        public BasketController(IBasketService basketService, IProductService productService, IToastNotification toaster)
        {
            _basketService = basketService;
            _productService = productService;
            _toaster = toaster;
        }

        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var claims = User.Claims.Select(x => x.Value);
            var basket = await _basketService.GetBasket(userId);
            if (basket == null) 
            {
                _toaster.AddErrorToastMessage("Sepet Bulunamadı");
                return RedirectToAction("Index", "Home");
            }
            return View(basket);
        }

        public async Task<IActionResult> AddToBasket(int productId, int quantity)
        {
            try
            {
                if (!User.Identity.IsAuthenticated)
                {

                    
                    TempData["PendingProductId"] = productId;
                    TempData["PendingQuantity"] = quantity;
                    TempData["ReturnController"] = "Basket";
                    TempData["ReturnAction"] = "AddToBasket";

                    _toaster.AddInfoToastMessage("Sepete ekleme işlemi için giriş sayfasına yönlendirildiniz!", new ToastrOptions { TimeOut = 3000 });
                    return RedirectToAction("Login", "Auth");
                }
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var product = await _productService.GetAsync(productId);
                if (product == null)
                {
                    return NotFound();
                }
                var basket = await _basketService.GetBasket(userId);
                if (basket == null)
                {
                    _toaster.AddErrorToastMessage("Profilinizde bir sorun var, sepete ekleme işlemi yapılamıyor, lütfen yönetim ile iletişime geçiniz!");
                    return RedirectToAction("Index", "Home");
                }
                BasketItemModel basketItemModel = new()
                {
                    BasketId = basket.Id,
                    ProductId = productId,
                    Quantity = quantity
                };
                await _basketService.AddToBasket(basketItemModel);
                _toaster.AddSuccessToastMessage($"{quantity} adet {product.Name} sepete eklenmiştir.");
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                _toaster.AddErrorToastMessage(ex.Message);
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public async Task<IActionResult> RemoveFromBasket(int basketItemId)
        {
            await _basketService.RemoveFromBasket(basketItemId);
            return RedirectToAction("Index");
        }

       
        public async Task<IActionResult> ClearBasket()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var response = await _basketService.ClearFromBasket(userId);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> UpdateQuantity(int basketItemId, int quantity)
        {
            await _basketService.QuantityUpdate(basketItemId, quantity);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> ApplyCoupon(string couponCode)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            await _basketService.ApplyCoupon(couponCode, userId);
            return RedirectToAction("Index");
        }
    }




}

