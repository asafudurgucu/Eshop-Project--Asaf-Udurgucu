using eshop_Service.Abstract;
using eshop_Shared.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace eshop_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : Controller
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        // POST api/payment
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddPayment([FromBody] PaymentDTO paymentDTO)
        {
            if (paymentDTO == null)
            {
                return BadRequest("Geçersiz veri.");
            }

            var response = await _paymentService.AddAsync(paymentDTO);
            if (response.IsSucceded)
            {
                return StatusCode(201, response); // 201 Created
            }
            return StatusCode(response.StatusCode, response); // Fail response
        }

        // GET api/payment
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAllPayments()
        {
            var response = await _paymentService.GetAll();
            if (response.IsSucceded)
            {
                return Ok(response); // 200 OK
            }
            return StatusCode(response.StatusCode, response); // Fail response
        }

        // GET api/payment/{id}
        [HttpGet("{id}")]
        [Authorize]
        public async Task<IActionResult> GetPaymentById(int id)
        {
            var response = await _paymentService.GetPayment(id);
            if (response.IsSucceded)
            {
                return Ok(response); // 200 OK
            }
            return StatusCode(response.StatusCode, response); // Fail response
        }

    }
}

