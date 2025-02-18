using eshop_MVC.Abstract;
using eshop_MVC.Helpers;
using eshop_MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System.Security.Claims;

namespace eshop_MVC.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IBasketService _basketService;
        private readonly IToastNotification _toaster;
        private readonly IAuthService _authService;

        public OrderController(IOrderService orderService, IBasketService basketService, IToastNotification toaster, IAuthService authService)
        {
            _orderService = orderService;
            _basketService = basketService;
            _toaster = toaster;
            _authService = authService;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var response = await _orderService.GetByUserAsync(userId);
            
            return View(response);
        }
        [Authorize]
        public async Task<IActionResult> GetOrdersByStatus(OrderStatus status)
        {
           
            var response = await _orderService.GetByStatusAsync(status);
            return View(response);
        }

        [Authorize]
        public async Task<IActionResult> GetOrdersByDateRange(DateTime startDate, DateTime endDate)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var response = await _orderService.GetByDateRangeAsync(startDate, endDate, userId);
            return View(response);
        }

        
         [Authorize]
        public async Task<IActionResult> GetShippedOrders()
        {
           
            var response = await _orderService.Statusbutuser(OrderStatus.Shipped );
            return View(response);
        }

        [Authorize]
        public async Task<IActionResult> GetDeliveredOrders()
        {
            
            var response = await _orderService.Statusbutuser(OrderStatus.Delivered);
            return View(response);
        }

        [Authorize]
        public async Task<IActionResult> Details(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            
            var order = await _orderService.GetAsync(id);
            if (order == null || order.ApplicationUserId != userId)
            {
                _toaster.AddErrorToastMessage("Sipariş bulunamadı veya yetkiniz yok.");
                return RedirectToAction("Index");
            }
            var UserBlock = await _authService.GetUserAsync();
            ViewBag.UserName = (UserBlock.FirstName  + UserBlock.LastName);
            return View(order);
        }

    }
}
