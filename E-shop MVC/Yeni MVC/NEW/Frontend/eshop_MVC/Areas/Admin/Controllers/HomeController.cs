using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using eshop_MVC.Services;
using eshop_MVC.Abstract;

namespace eshop_MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "AdminUser")]
    public class HomeController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IContactMessage _contactMessage;
        private readonly IProductService _productService;
        private readonly IAuthService _authService;

        public HomeController(IOrderService orderService, IContactMessage contactMessage, IAuthService authService, IProductService productService)
        {
            _orderService = orderService;
            _contactMessage = contactMessage;
            _authService = authService;
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var totalOrderCount = await _orderService.GetTotalOrderCountAsync();
            var orderCountByStatus = await _orderService.GetOrderCountByStatusAsync();
            var getmessagecount = await _contactMessage.CountAsync();
            var getproductcount = await _productService.GetCountAsync();
            var userCount = await _authService.GetUserCount();

            ViewBag.UserCount = userCount;
            ViewBag.ProductCount = getproductcount;
            ViewBag.MessageCount = getmessagecount;
            ViewBag.TotalOrderCount = totalOrderCount;
            ViewBag.OrderCountByStatus = orderCountByStatus;

            return View();
        }
    }
}
