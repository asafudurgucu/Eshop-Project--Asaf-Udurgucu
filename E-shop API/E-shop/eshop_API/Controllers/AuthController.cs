
using Azure;
using eshop_Entity.Contcrete;
using eshop_Service.Abstract;
using eshop_Shared.DTOs;
using eshop_Shared.DTOs.Auth;
using eshop_Shared.Helpers;
using eshop_Shared.ResponseDTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Text.Json;

namespace eshop_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : CustomControllerBase
    {
        private readonly IAuthService _authService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IEmailService _emailService;

        public AuthController(IAuthService authService, UserManager<ApplicationUser> userManager, IEmailService emailService)
        {
            _authService = authService;
            _userManager = userManager;
            _emailService = emailService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register( RegisterDTO registerDTO)
        {
            var response = await _authService.RegisterAsync(registerDTO);
            return CreateResponse(response);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login( LoginDTO loginDTO)
        {
            var response = await _authService.LoginAsync(loginDTO);
            return CreateResponse(response);
        }


        [HttpGet("myProfile")]
        [Authorize]
        public async Task<IActionResult> GetUser()
        {
            try
            {
                // Kullan�c�y� servisten al
                var response = await _authService.GetUserAsync();

                if (response == null)
                {
                    return NotFound("Kullan�c� bulunamad�.");
                }

                // Kullan�c� bilgilerini d�nd�r
                return Ok(response);
            }
            catch (JsonException ex)
            {
                return BadRequest($"Yan�t format� hatal�: {ex.Message}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Sunucu hatas�: {ex.Message}");
            }
        }

        [HttpGet("{applicationUserId}")]
        [Authorize]
        public async Task<IActionResult> GetOrderUser(string applicationUserId)
        {
            try
            {
                // Kullan�c�y� servisten al
                var response = await _authService.GetOrderUserAsync(applicationUserId);

                if (response == null)
                {
                    return NotFound("Kullan�c� bulunamad�.");
                }

                // Kullan�c� bilgilerini d�nd�r
                return Ok(response);
            }
            catch (JsonException ex)
            {
                return BadRequest($"Yan�t format� hatal�: {ex.Message}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Sunucu hatas�: {ex.Message}");
            }
        }

        

        [HttpGet("user_count")]
        [Authorize(Roles = "AdminUser")]
        public async Task<ResponseDTO<int>> GetUserCount()
        {
            try
            {
                var userCount = await _userManager.Users.CountAsync();
                return ResponseDTO<int>.Success(userCount, 200);
            }
            catch (Exception ex)
            {
                return ResponseDTO<int>.Fail($"Hata oluştu: {ex.Message}", 500);
            }
        }

        [HttpGet("GetAllUser")]
        [Authorize(Roles = "AdminUser")]
        public async Task<ResponseDTO<IEnumerable<ApplicationUserDTO>>> GetAllUsers()
        {
            try
            {
                var users = await _userManager.Users.ToListAsync();
                var userDTOs = users.Select(user => new ApplicationUserDTO
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    PhoneNumber = user.PhoneNumber,
                    Email = user.Email,
                    Address = user.Address,
                    City = user.City,
                    DateOfBirth = user.DateOfBirth,
                    ProfilePictureUrl = user.ProfilePictureUrl
                }).ToList();
            
                return ResponseDTO<IEnumerable<ApplicationUserDTO>>.Success(userDTOs, 200);
            }
            catch (Exception ex)
            {
                return ResponseDTO<IEnumerable<ApplicationUserDTO>>.Fail($"Hata oluştu: {ex.Message}", 500);
            }
        }


        [HttpDelete]
        [Authorize(Roles = "AdminUser")]
        public async Task<ResponseDTO<NoContent>> DeleteUser(string applicationUserId)
        {
            if (string.IsNullOrEmpty(applicationUserId))
            {
                return ResponseDTO<NoContent>.Fail("Kullanıcı kimliği sağlanmadı", 400);
            }

            try
            {
                var user = await _userManager.FindByIdAsync(applicationUserId);
                if (user == null)
                {
                    return ResponseDTO<NoContent>.Fail("Kullanıcı bulunamadı", 404);
                }

                var result = await _userManager.DeleteAsync(user);
                if (!result.Succeeded)
                {
                    return ResponseDTO<NoContent>.Fail(result.Errors.Select(x => x.Description).ToList(), 500);
                }

                return ResponseDTO<NoContent>.Success(200);
            }
            catch (Exception ex)
            {
                return ResponseDTO<NoContent>.Fail($"Hata oluştu: {ex.Message}", 500);
            }
        }

        [HttpPut("update-user")]
        [Authorize]
        public async Task<IActionResult> UpdateUser(ApplicationUserUpdateDTO userUpdateDTO)
        {
            try
            {
                var response = await _authService.UpdateUser(userUpdateDTO);
                return CreateResponse(response);
            }
            catch (JsonException ex)
            {
                return BadRequest($"Yanıt formatı hatalı: {ex.Message}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Sunucu hatası: {ex.Message}");
            }
        }

        [HttpPut("update-profile-picture")]
        [Authorize]
        public async Task<IActionResult> UpdateUserProfilePicture([FromForm] ApplicationUserProfilePictureDTO profilePictureDTO)
        {
            try
            {
                var response = await _authService.UpdateUserProfilePicture(profilePictureDTO);
                return CreateResponse(response);
            }
            catch (JsonException ex)
            {
                return BadRequest($"Yanıt formatı hatalı: {ex.Message}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Sunucu hatası: {ex.Message}");
            }
        }




    }
}
