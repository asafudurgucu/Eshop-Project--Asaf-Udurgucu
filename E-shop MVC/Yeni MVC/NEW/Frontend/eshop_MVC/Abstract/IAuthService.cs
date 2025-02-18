
using eshop_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace eshop_MVC.Abstract
{
    public interface IAuthService
    {
        Task<ResponseModel<string>> RegisterAsync(RegisterModel registerModel);
        Task<ResponseModel<TokenModel>> LoginAsync(LoginModel loginModel);
        Task<UserProfileModel> GetOrderUser(string applicationUserId);
        Task<ApplicationUserModel> GetUserButId(string applicationUserId);
        Task<UserProfileModel> GetUserAsync();
        Task<string> UpdateUser(ApplicationUserUpdateModel model);
        Task<string> UpdateUserPicture(ApplicationUserProfilePhotoUpdate model);
        Task<int> GetUserCount();
        Task<bool> DeleteUser(string id);
        Task<IEnumerable<ApplicationUserModel>> GetAllUser();

    }
}
