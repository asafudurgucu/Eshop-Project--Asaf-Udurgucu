using eshop_MVC.Abstract;
using eshop_MVC.Models;
using System.Net.Http.Headers;

using System.Text.Json;

namespace eshop_MVC.Services
{
    public class AuthService : BaseService, IAuthService
    {
        public AuthService(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor) : base(httpClientFactory, httpContextAccessor)
        {
        }

       public async Task<bool> DeleteUser(string id)
        {
            try
            {
                var client = GetHttpClient();
                var response = await client.DeleteAsync($"Auth?applicationUserId={id}");
                var responseBody = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<ResponseModel<bool>>(responseBody);
                return result.Data;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
          
        }


        public async Task<IEnumerable<ApplicationUserModel>> GetAllUser()
        {
            try
            {
                var client = GetHttpClient();
                var response = await client.GetAsync("auth/GetAllUser");
                var jsonString = await response.Content.ReadAsStringAsync();
                ResponseModel<IEnumerable<ApplicationUserModel>> result;
                try
                {
                    result = JsonSerializer.Deserialize<ResponseModel<IEnumerable<ApplicationUserModel>>>(jsonString);
                }
                catch (Exception)
                {
                    Console.WriteLine("Bir hata var");
                    return Enumerable.Empty<ApplicationUserModel>();
                }
                if (result != null && (result.Errors == null || result.Errors.Count == 0))
                {
                    return result.Data ?? Enumerable.Empty<ApplicationUserModel>();
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
                return Enumerable.Empty<ApplicationUserModel>();
            }
            return Enumerable.Empty<ApplicationUserModel>();
        }


        public async Task<UserProfileModel> GetOrderUser(string applicationUserId)
        {
            try
            {
                var client = GetHttpClient();
                var response = await client.GetAsync($"Auth/{applicationUserId}");
                var jsonString = await response.Content.ReadAsStringAsync();
                ResponseModel<UserProfileModel> result;
                try
                {
                    result = JsonSerializer.Deserialize<ResponseModel<UserProfileModel>>(jsonString,_jsonSerializerOptions);
                }
                catch (Exception)
                {
                    Console.WriteLine("Bir hata var");
                    return new UserProfileModel();
                }
                if (result != null && result.Errors == null || result.Errors.Count == 0)
                {
                    return result.Data;
                }
                else
                {
                    Console.WriteLine("Bir hata var");
                    return new UserProfileModel();
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
                return new UserProfileModel();
            }
        }

         public async Task<ApplicationUserModel> GetUserButId(string applicationUserId)
        {
            try
            {
                var client = GetHttpClient();
                var response = await client.GetAsync($"Auth/{applicationUserId}");
                var jsonString = await response.Content.ReadAsStringAsync();
                ResponseModel<ApplicationUserModel> result;
                try
                {
                    result = JsonSerializer.Deserialize<ResponseModel<ApplicationUserModel>>(jsonString,_jsonSerializerOptions);
                }
                catch (Exception)
                {
                    Console.WriteLine("Bir hata var");
                    return new ApplicationUserModel();
                }
                if (result != null && result.Errors == null || result.Errors.Count == 0)
                {
                    return result.Data;
                }
                else
                {
                    Console.WriteLine("Bir hata var");
                    return new ApplicationUserModel();
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
                return new ApplicationUserModel();
            }
        }

        public async Task<UserProfileModel> GetUserAsync()
        {
            try
            {
                var client = GetHttpClient();
                var response = await client.GetAsync($"Auth/myProfile");
                var jsonString = await response.Content.ReadAsStringAsync();
                ResponseModel<UserProfileModel> result;
                try
                {
                    result = JsonSerializer.Deserialize<ResponseModel<UserProfileModel>>(jsonString, _jsonSerializerOptions);
                }
                catch (Exception)
                {
                    Console.WriteLine("Bir hata var");
                    return new UserProfileModel();
                }
                if (result != null && result.Errors == null || result.Errors.Count == 0)
                {
                    return result.Data;
                }
                else
                {
                    Console.WriteLine("Bir hata var");
                    return new UserProfileModel();
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
                return new UserProfileModel();
            }
        }

        

         public async Task<int> GetUserCount()
        {
            try
            {
                var client = GetHttpClient();
                var response = await client.GetAsync("auth/user_count");
                var responseBody = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<ResponseModel<int>>(responseBody);
                return result.Data;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }


        public async Task<ResponseModel<TokenModel>> LoginAsync(LoginModel loginModel)
        {
            var client = GetHttpClient();
            var response = await client.PostAsJsonAsync("auth/login", loginModel);
            var responseBody = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ResponseModel<TokenModel>>(responseBody, _jsonSerializerOptions);
            return result;
        }





        public async Task<ResponseModel<string>> RegisterAsync(RegisterModel registerModel)
        {
            var client = GetHttpClient();
            var response = await client.PostAsJsonAsync("auth/register", registerModel);
            var responseBody = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ResponseModel<string>>(responseBody, _jsonSerializerOptions);
            return result;
        }

        public async Task<string> UpdateUser(ApplicationUserUpdateModel model)
        {
            try
            {
                var client = GetHttpClient();
                var content = new StringContent(JsonSerializer.Serialize(model), System.Text.Encoding.UTF8, "application/json");
                var response = await client.PutAsync("Auth/update-user", content);
                var responseBody = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<ResponseModel<string>>(responseBody);

                if (result == null || (result.Errors != null && result.Errors.Count > 0))
                {
                    return "Bir hata oluştu";
                }

                return result.Data ?? "Bir hata oluştu";
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
                return "Bir hata oluştu";
            }
        }

        public async Task<string> UpdateUserPicture(ApplicationUserProfilePhotoUpdate model)
        {
            try
            {
                var client = GetHttpClient();
                using var content = new MultipartFormDataContent();
                using var stream = new MemoryStream();
                if (model.ProfilePictureUrl != null)
                {
                    var logoStream = model.ProfilePictureUrl.OpenReadStream();
                    var logoContent = new StreamContent(logoStream)
                    {
                        Headers = { ContentType = new MediaTypeHeaderValue(model.ProfilePictureUrl.ContentType) }
                    };
                    content.Add(logoContent, "ProfilePictureUrl", model.ProfilePictureUrl.FileName);
                }

                var response = await client.PutAsync("Auth/update-profile-picture", content);
                var responseBody = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<ResponseModel<string>>(responseBody);

                if (result == null || (result.Errors != null && result.Errors.Count > 0))
                {
                    return "Bir hata oluştu";
                }

                return result.Data ?? "Bir hata oluştu";
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
                return "Bir hata oluştu";
            }
        }
    }
}
