using eshop_MVC.Abstract;
using eshop_MVC.Models;
using System.Net.Http;
using System.Text.Json;

namespace eshop_MVC.Services
{
    public class ContactMessageService : BaseService, IContactMessage
    {
        public ContactMessageService(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor) : base(httpClientFactory, httpContextAccessor)
        {
        }

        public async Task<int> CountAsync()
        {
            try
            {
                var client = GetHttpClient();
                var response = await client.GetAsync("ContactMessage/count");

                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException($"API hatalı. Durum kodu: {response.StatusCode}");
                }

                var jsonString = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<ResponseModel<int>>(jsonString);

                if (result == null)
                {
                    throw new JsonException("API yanıtı beklenen formatta değil.");
                }

                return result.Data;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Beklenmeyen Hata: {ex.Message}");
                return 0;
            }
        }

        public async Task<bool> Delete(int Id)
        {
            try
            {
                var client = GetHttpClient();
                var response = await client.DeleteAsync($"ContactMessage/delete/{Id}");

                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException($"Silme işlemi başarısız. Status Code: {response.StatusCode}");
                }

                var jsonString = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<ResponseModel<bool>>(jsonString);

                if (result.Data == false)
                {
                    throw new JsonException("API yanıtı beklenen formatta değil.");
                }

                return result.Data;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                return false;
            }
        }

        public async Task<GetContactMessageModel> Get(int Id)
        {
            try
            {
                var client = GetHttpClient();
                var response = await client.GetAsync($"ContactMessage/get/{Id}");

                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException($"API isteği başarısız. Status Code: {response.StatusCode}");
                }

                var jsonString = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<ResponseModel<GetContactMessageModel>>(jsonString);

                if (result == null)
                {
                    throw new JsonException("API yanıtı beklenen formatta değil.");
                }

                return result.Data;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                return null;
            }
        }

        public async Task<IEnumerable<GetContactMessageModel>> GetAll()
        {
            try
            {
                var client = GetHttpClient();
                var response = await client.GetAsync("ContactMessage/getall");

                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException($"API isteği başarısız. Status Code: {response.StatusCode}");
                }

                var jsonString = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<ResponseModel<IEnumerable<GetContactMessageModel>>>(jsonString);

                if (result == null)
                {
                    throw new Exception("API'den geçerli bir veri alınamadı.");
                }

                return result.Data;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Beklenmeyen Hata: {ex.Message}");
                return null;
            }
        }

        public async Task<ContactMessageModel> SendAsync(ContactMessageModel contactMessageModel)
        {
            try
            {
                var client = GetHttpClient();
                var response = await client.PostAsJsonAsync("ContactMessage/", contactMessageModel);

                if (!response.IsSuccessStatusCode)
                {
                    var errorMessage = await response.Content.ReadAsStringAsync();
                    throw new HttpRequestException($"Mesaj Gönderme İşlemi Başarısız. API Hatası: {errorMessage}");
                }

                var jsonString = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<ResponseModel<ContactMessageModel>>(jsonString);

                if (result == null)
                {
                    throw new JsonException("API yanıtı beklenen formatta değil.");
                }

                return result.Data;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Beklenmeyen Hata: {ex.Message}");
                return null;
            }
        }
    }
}
