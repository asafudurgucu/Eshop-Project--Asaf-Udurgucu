using eshop_MVC.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eshop_MVC.Areas.Admin.Controllers
{
    
    [Area("Admin")]
    [Authorize(Roles = "AdminUser")]
    public class UsersController : Controller
    {
        private readonly IAuthService _authService;

        public UsersController(IAuthService authService)
        {
            _authService = authService;
        }

        
         public async Task<IActionResult> Index()
        {
            var users = await _authService.GetAllUser();
            var userCount = await _authService.GetUserCount();
            
            ViewBag.UserCount = userCount;
            return View(users);
        }

        public async Task<IActionResult> GetUserDetails(string userId)
        {
            var user = await _authService.GetUserButId(userId);
            if (user != null)
            {
                return View(user);
            }
            return NotFound();
        }




        [HttpDelete]
        public async Task<IActionResult> DeleteConfirmed(string userId)
        {
            var result = await _authService.DeleteUser(userId);
            if (result != null)
            {
                return Ok(new { Success = true, Message = "Kullanıcı başarıyla silindi." });
            }
            return BadRequest(new { Success = false, Message = "Kullanıcı silinemedi." });
        }
    }
}

