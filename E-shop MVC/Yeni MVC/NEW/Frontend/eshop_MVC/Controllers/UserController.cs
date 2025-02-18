using eshop_MVC.Abstract;
using eshop_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;

namespace eshop_MVC.Controllers
{
    public class UserController : Controller
    {
        private readonly IAuthService _authService;
        private readonly IToastNotification _toaster;

        public UserController(IAuthService authService, IToastNotification toaster)
        {
            _authService = authService;
            _toaster = toaster;
        }

        public async Task<IActionResult> Index()
        {
            var userProfile = await _authService.GetUserAsync();

            if (userProfile == null)
            {
                ViewBag.ErrorMessage = "Kullanıcı profili alınırken bir hata oluştu.";
                return View();
            }

            _toaster.AddSuccessToastMessage("Başarılı ");
            return View(userProfile);
        }

        public async Task<IActionResult> Update()
        {
            var userProfile = await _authService.GetUserAsync();

            if (userProfile == null)
            {
                ViewBag.ErrorMessage = "Kullanıcı profili alınırken bir hata oluştu.";
                return View(new ApplicationUserUpdateModel()); // Boş model gönderiyoruz ki hata olursa bile form çalışsın
            }

            // Kullanıcı profil bilgilerini update modeline map edin
            var updateModel = new ApplicationUserUpdateModel
            {
                // Burada userProfile'dan gerekli verileri updateModel'e aktarabilirsiniz.
                FirstName = userProfile.FirstName,
                LastName = userProfile.LastName,
                Address = userProfile.Address,
                City = userProfile.City,
                PhoneNumber = userProfile.PhoneNumber

                // Diğer alanlar da eklenebilir.
            };

            return View(updateModel); // Bu model View'a gönderilecek
        }


        [HttpPost]
        public async Task<IActionResult> UpdateUser(ApplicationUserUpdateModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.ErrorMessage = "Form verileri geçerli değil.";
                return View("Update", model);
            }

            var result = await _authService.UpdateUser(model);
            _toaster.AddSuccessToastMessage("Kullanıcı Bilgileri Başarıyla Güncellendi");
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProfilePicture(ApplicationUserProfilePhotoUpdate model)
        {
            if (model.ProfilePictureUrl == null || model.ProfilePictureUrl.Length == 0)
            {
                ViewBag.ErrorMessage = "Lütfen geçerli bir profil fotoğrafı yükleyin.";
                return RedirectToAction("Index");
            }

            var result = await _authService.UpdateUserPicture(model);
            if (result == null)
            {
                ViewBag.ErrorMessage = "Profil fotoğrafı güncellenirken bir hata oluştu.";
                return RedirectToAction("Index");
            }

            _toaster.AddSuccessToastMessage("Profil fotoğrafı başarıyla güncellendi");
            return RedirectToAction("Index");
        }
    }
}
