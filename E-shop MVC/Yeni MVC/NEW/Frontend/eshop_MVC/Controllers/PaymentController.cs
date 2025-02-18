using eshop_MVC.Abstract;
using eshop_MVC.Models;
using eshop_MVC.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System.Security.Claims;
using System.Threading.Tasks;

namespace eshop_MVC.Controllers
{
    public class PaymentController : Controller
    {
        private readonly IPaymentService _paymentService;
        private readonly IBasketService _basketService;
        private readonly IOrderService _orderService;
        private readonly IToastNotification _toaster;
        public PaymentController(IPaymentService paymentService, IBasketService basketService, IOrderService orderService, IToastNotification toaster)
        {
            _paymentService = paymentService;
            _basketService = basketService;
            _orderService = orderService;
            _toaster = toaster;
        }


        [Authorize]
        public async Task<IActionResult> Checkout()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var basket = await _basketService.GetBasket(userId);
            var totalPrice = basket.TotalAmount;

            ViewData["TotalPrice"] = totalPrice;
            return View(new PaymentModel());
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Checkout(OrderModel orderModel,PaymentModel paymentModel)
        {
            try
            {
                var createdPayment = await _paymentService.CreatePaymentAsync(paymentModel);
               

                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var basket = await _basketService.GetBasket(userId);
                orderModel.ApplicationUserId = userId;
                orderModel.OrderItems = basket.BasketItems.Select(x => new OrderItemModel
                {
                    ProductId = x.ProductId,
                    Quantity = x.Quantity,
                    UnitPrice = x.Product.Price
                }).ToList();
                orderModel.CreatedDate = DateTime.Now;
                await _orderService.AddAsync(orderModel);
                await _basketService.ClearFromBasket(userId);
                _toaster.AddSuccessToastMessage("Ödeme Alınmıştır Siparişiniz başarıyla verilmiştir");
                return RedirectToAction("Index", "Order");
            }
            catch (Exception)
            {

                Console.WriteLine("hata");
                return null;
            }
           
        }
    }
}
