using eshop_MVC.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using eshop_MVC.Abstract;
using NToastNotify;

namespace eshop_MVC.Controllers
{
    public class AuthController : Controller
    {
        private readonly IBasketService _basketService;
        private readonly IAuthService _authService;
        private readonly IToastNotification _toaster;

        public AuthController(IAuthService authService, IToastNotification toaster, IBasketService basketService)
        {
            _authService = authService;
            _toaster = toaster;
            _basketService = basketService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            if (!ModelState.IsValid)
            {
                return View(loginModel);
            }

            try
            {
                var response = await _authService.LoginAsync(loginModel);
                Console.WriteLine($"Response: {response}");

                if (response.Errors == null && response.Data != null)
                {
                    Console.WriteLine($"Access Token: {response.Data.AccessToken}");

                    var handler = new JwtSecurityTokenHandler();
                    var token = handler.ReadJwtToken(response.Data.AccessToken);

                    var userName = token.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value ??
                                   token.Claims.FirstOrDefault(c => c.Type == "email")?.Value;
                    var userId = token.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
                    var role = token.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Role)?.Value;

                    if (userName != null && userId != null)
                    {
                        var basketExists = await _basketService.CheckBasketExists(userId);
                        if (!basketExists)
                        {
                            await _basketService.CreateBasket(new CreateBasketModel { ApplicationUserId = userId });
                            Console.WriteLine("Kullanıcı için yeni bir sepet oluşturuldu.");
                        }

                        var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, userName),
                    new Claim(ClaimTypes.Name, userName),
                    new Claim(ClaimTypes.NameIdentifier, userId),
                    new Claim(ClaimTypes.Role, role ?? string.Empty),
                    new Claim("AccessToken", response.Data.AccessToken)
                };

                        var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        var principal = new ClaimsPrincipal(identity);
                        await HttpContext.SignInAsync(
                            CookieAuthenticationDefaults.AuthenticationScheme,
                            principal,
                            new AuthenticationProperties
                            {
                                ExpiresUtc = response.Data.ExpirationDate,
                                IsPersistent = true
                            });

                        _toaster.AddSuccessToastMessage("Giriş işlemi başarıyla tamamlandı");
                        return RedirectToAction("Index", "Home");
                    }
                }

                ModelState.AddModelError(string.Empty, "Giriş hatası");
                return View(loginModel);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Giriş hatası: {ex.Message}");
                ModelState.AddModelError(string.Empty, "Bir hata oluştu, daha sonra yeniden deneyiniz.");
                return View(loginModel);
            }
        }




        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel registerModel)
        {
            if (!ModelState.IsValid)
            {
                return View(registerModel);
            }

            try
            {
                var response = await _authService.RegisterAsync(registerModel);
                _toaster.AddSuccessToastMessage("Kayıt işlemi başarıyla tamamlandı");
                return RedirectToAction("Login");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Kayıt hatası: {ex.Message}");
                ModelState.AddModelError(string.Empty, "Bir hata oluştu, daha sonra yeniden deneyiniz.");
                return View(registerModel);
            }
        }



        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            _toaster.AddSuccessToastMessage("Çıkış işlemi başarıyla tamamlandı");
            return RedirectToAction("Index", "Home");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
