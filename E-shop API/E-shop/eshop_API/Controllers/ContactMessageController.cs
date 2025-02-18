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
    public class ContactMessageController : CustomControllerBase
    {
        private readonly IContactMessageService _contactService;

        public ContactMessageController(IContactMessageService contactService)
        {
            _contactService = contactService;
        }

        [HttpPost]
        public async Task<IActionResult> SendAsync(CreateContactMessageDto contactMessageDTO)
        {
            var response = await _contactService.SendAsync(contactMessageDTO);
            return CreateResponse(response);
        }

        [HttpGet("getall")]
        [Authorize(Roles ="AdminUser")]
        public async Task<IActionResult> GetAll()
        {
            var response = await _contactService.GetAll();
            return CreateResponse(response);
        }

        [HttpGet("get/{Id}")]
        [Authorize(Roles = "AdminUser")]
        public async Task<IActionResult> Get(int Id)
        {
            var response = await _contactService.Get(Id);
            return CreateResponse(response);
        }

        [HttpGet("count")]
        [Authorize(Roles = "AdminUser")]
        public async Task<IActionResult> Count()
        {
            var response = await _contactService.Count();
            return CreateResponse(response);
        }

        [HttpDelete("delete/{Id}")]
        [Authorize(Roles = "AdminUser")]
        public async Task<IActionResult> Delete(int Id)
        {
            var response = await _contactService.Delete(Id);
            return CreateResponse(response);
        }

    }
}
