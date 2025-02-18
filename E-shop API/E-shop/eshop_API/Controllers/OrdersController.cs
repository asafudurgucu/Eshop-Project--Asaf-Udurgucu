
using eshop_Service.Abstract;
using eshop_Shared.ComplexTypes;
using eshop_Shared.DTOs;
using eshop_Shared.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace eshop_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : CustomControllerBase
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrder(int id)
        {
            var response = await _orderService.GetOrderAsync(id);
            return CreateResponse(response);
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetOrders()
        {
            var response = await _orderService.GetOrdersAsync();
            return CreateResponse(response);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] OrderCreateDTO orderCreateDTO)
        {
            var response = await _orderService.CreateOrder(orderCreateDTO);
            return CreateResponse(response);
        }

        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            var response = await _orderService.DeleteOrder(id);
            return CreateResponse(response);
        }

        [Authorize]
        [HttpPut("{orderid}")]
        public async Task<IActionResult> UpdateStatus(int orderid, [FromBody] OrderStatus status)
        {
            var response = await _orderService.UpdateOrderStatusAsync(orderid, status);
            return CreateResponse(response);
        }

        [Authorize]
        [HttpGet("daterange")]
        public async Task<IActionResult> GetOrdersByDateRange([FromQuery] DateTime startDate, [FromQuery] DateTime endDate)
        {
            var response = await _orderService.GetOrdersAsync(startDate, endDate);
            return CreateResponse(response);
        }

        [Authorize]
        [HttpGet("status")]
        public async Task<IActionResult> GetOrdersByStatus([FromQuery] OrderStatus orderStatus)
        {
            var response = await _orderService.GetOrdersAsync(orderStatus);
            return CreateResponse(response);
        }

        [Authorize]
        [HttpGet("user/{applicationUserId}")]
        public async Task<IActionResult> GetOrdersByUsers(string applicationUserId)
        {
            var response = await _orderService.GetOrdersAsync(applicationUserId);
            return CreateResponse(response);
        }

        
        [HttpGet("count")]
        [Authorize]
        public async Task<IActionResult> GetOrdersCount()
        {
            var response = await _orderService.GetOrderCountAsync();
            return CreateResponse(response);
        }

        [HttpGet("countbystatus")]
        [Authorize]
        public async Task<IActionResult> GetOrdersCountByStatus()
        {
            var response = await _orderService.GetOrderCountByStatusAsync();
            return CreateResponse(response);
        }


        [Authorize]
        [HttpGet("statusbutuser/{orderStatus}")]
        public async Task<IActionResult> GetOrdersByStatusButUser(OrderStatus orderStatus)
        {
            var applicationUserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(applicationUserId))
            {
                return Unauthorized("Kullanıcı kimliği bulunamadı.");
            }

            var response = await _orderService.GetOrdersByStatusButUser(orderStatus,applicationUserId);
            return CreateResponse(response);
        }






    }
}
