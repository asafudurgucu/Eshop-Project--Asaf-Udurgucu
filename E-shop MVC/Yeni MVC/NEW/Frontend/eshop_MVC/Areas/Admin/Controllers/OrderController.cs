using eshop_MVC.Abstract;
using eshop_MVC.Helpers;
using eshop_MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eshop_MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "AdminUser")]
    public class OrderController : Controller
    {
        private readonly IAuthService _authService;
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService, IAuthService authService)
        {
            _orderService = orderService;
            _authService = authService;
        }

        public async Task<IActionResult> Index()
            {
                DateTime startDate = new DateTime(2024, 1, 1);
                DateTime endDate = new DateTime(2025, 12, 31);

                var orders = await _orderService.GetByDateRangeAsync(startDate, endDate, null);
                var orderStatuses = await _orderService.GetTotalOrderCountAsync();
                ViewBag.OrderStatuses = orderStatuses;

            ViewBag.TotalAmmount = orders.Sum(order => order.OrderItems.Sum(item => item.TotalPrice));

                return View(orders);
            }



        public async Task<IActionResult> Details(int id)
        {
            var order = await _orderService.GetAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            UserProfileModel user = null;
            if (!string.IsNullOrEmpty(order.ApplicationUserId))
            {
                // order.ApplicationUserId'yi GetOrderUser'a gönderiyoruz
                user = await _authService.GetOrderUser(order.ApplicationUserId);
            }

            // Kullanıcı bilgilerini ViewData ile gönder
            ViewData["User"] = user;
            ViewData["UserId"] = order.ApplicationUserId;  // UserId'yi ViewData'ya ekledik

            return View(order);
        }



        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var order = await _orderService.GetAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, int status)
        {
            Console.WriteLine($"Gelen ID: {id}, Gelen Status: {status}"); // Gelen veriyi logla

            if (!Enum.IsDefined(typeof(OrderStatus), status))
            {
                Console.WriteLine("Geçersiz bir status değeri.");
                var order = await _orderService.GetAsync(id); // Mevcut siparişi tekrar yükle
                return View(order);
            }

            var orderStatus = (OrderStatus)status; // Integer değeri Enum'a dönüştür
            await _orderService.UpdateAsync(id, orderStatus);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var order = await _orderService.GetAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _orderService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> FilterByStatus(OrderStatus status)
        {
            var orders = await _orderService.GetByStatusAsync(status);
            return View("Index", orders);
        }

        public async Task<IActionResult> FilterByDateRange(DateTime startDate, DateTime endDate)
        {
            var orders = await _orderService.GetByDateRangeAsync(startDate, endDate, null);
            return View("Index", orders);
        }
    }
}
