using eshop_MVC.Abstract;
using eshop_MVC.Models;
using eshop_MVC.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eshop_MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "AdminUser")]
    public class MessageController : Controller
    {
        private readonly IContactMessage _contactMessage;

        public MessageController(IContactMessage contactMessage)
        {
            _contactMessage = contactMessage;
        }

        public async Task<IActionResult> Index()
        {

            var contactmessage = await _contactMessage.GetAll();
            //var contactmessagecount = _contactMessage.Count();
            //ViewBag.MessageCount = contactmessagecount;
            return View(contactmessage);
        }
        [HttpGet]
        public async Task<ActionResult> Delete(int id)
        {
            var contact = await  _contactMessage.Delete(id);
            return Redirect(Request.Headers["Referer"].ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var contact = await _contactMessage.Get(id);
            return View(contact);
        }




    }
}
