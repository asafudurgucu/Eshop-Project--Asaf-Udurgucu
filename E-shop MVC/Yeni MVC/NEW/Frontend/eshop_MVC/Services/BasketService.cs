using eshop_MVC.Abstract;
using eshop_MVC.Models;
using System.Net.Http.Json;
using System.Net.WebSockets;
using System.Text.Json;

namespace eshop_MVC.Services
{
    public class BasketService : BaseService,IBasketService
    {
        public BasketService(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor) : base(httpClientFactory, httpContextAccessor)
        {
        }

        
        public async Task AddToBasket(BasketItemModel item)
        {
            try
            {
                var client = GetHttpClient();
                var response = await client.PostAsJsonAsync("basket/addtobasket", item);
                if(!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException("Api Hatalı ");
                }
                var jsonString = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<ResponseModel<BasketItemModel>>(jsonString,_jsonSerializerOptions);
                if (result?.Errors != null || result?.Errors?.Count > 0)
                {
                    throw new Exception($"Hata var:{string.Join(",", result.Errors)}");
                }
                if(result.Data == null)
                {
                    throw new Exception("Veri Gelmedi 3488 Hata Kodu");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Hata : {ex.Message}");
                throw;
            }
        }

        public async Task ApplyCoupon(string couponCode, string applicationUserId)
        {
            try
            {
                var client = GetHttpClient();
                var content = new StringContent(string.Empty); 
                var response = await client.PostAsync($"basket/applycoupon?applicationUserId={applicationUserId}&couponCode={couponCode}", content);
                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException("Api Hatalı ");
                }
                var jsonString = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<ResponseModel<BasketItemModel>>(jsonString, _jsonSerializerOptions);
                if (result?.Errors != null && result.Errors.Count > 0)
                {
                    throw new Exception($"Hata var:{string.Join(",", result.Errors)}");
                }
                if (result?.Data == null)
                {
                    throw new Exception("Veri Gelmedi 3488 Hata Kodu");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Hata : {ex.Message}");
                throw;
            }
        }

        public async Task<bool> CheckBasketExists(string userId)
        {
            try
            {
                var client = GetHttpClient(); // HTTP istemcisi oluşturuluyor
                var response = await client.GetAsync($"basket/exists/{userId}"); // Sepet kontrol endpoint'ine GET isteği

                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException($"Sepet kontrol işlemi başarısız! HTTP Status: {response.StatusCode}");
                }

                var jsonString = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<ResponseModel<bool>>(jsonString, _jsonSerializerOptions);

                if (result?.Errors != null && result.Errors.Count > 0)
                {
                    throw new Exception($"Hata oluştu: {string.Join(", ", result.Errors)}");
                }

                return result?.Data ?? false; // Eğer veri null ise false döner
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                throw; // Hata yukarıya fırlatılır
            }
        }


        public async Task<String> ClearFromBasket(string applicationUserId)
        {
            try
            {
                var client = GetHttpClient();
                var response = await client.GetAsync($"basket/clearbasket/{applicationUserId}");
                var jsonString = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<ResponseModel<String>>(jsonString, _jsonSerializerOptions);
                if (result.Errors != null && result.Errors.Count > 0) 
                {
                    Console.WriteLine(string.Join(",",result.Errors));
                }
                return result.Data;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata Mesajı: {ex.Message}");
                throw;
            }
            // Basketi temizlemeye yarayan methot
            

        }

        public async Task CreateBasket(CreateBasketModel createBasketModel)
        {
            try
            {
                var client = GetHttpClient();
                var response = await client.PostAsJsonAsync("basket/createbasket", createBasketModel);

                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException("Basket oluşturma işlemi başarısız!");
                }

                var jsonString = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<ResponseModel<object>>(jsonString, _jsonSerializerOptions);

                if (result?.Errors != null && result.Errors.Count > 0)
                {
                    throw new Exception($"Hata oluştu: {string.Join(", ", result.Errors)}");
                }

                if (result?.Data != null)
                {
                    // Veri döndürmeye gerek yok, işlem başarılı.
                    Console.WriteLine("Basket oluşturuldu");
                }
                else
                {
                    throw new Exception("Basket oluşturma işlemi sırasında veri gelmedi!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                throw; // Hata yukarıya fırlatılır.
            }
        }


        public async Task<BasketModel> GetBasket(string applicationUserId)
        {
            try
            {
                var client = GetHttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get, $"basket/{applicationUserId}");
                var response = await client.SendAsync(request);
                if (!response.IsSuccessStatusCode) 
                {
                    return new BasketModel();
                }
                var jsonString = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<ResponseModel<BasketModel>>(jsonString, _jsonSerializerOptions);
                return result.Data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new BasketModel();
            }
        }

        public async Task<string> QuantityUpdate(int basketItemId, int quantity)
        {
            var client = GetHttpClient();
            var response = await client.PostAsJsonAsync($"basket/changequantity", new { basketItemId, quantity });
            var jsonString = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ResponseModel<string>>(jsonString, _jsonSerializerOptions);
            if (result.Errors != null && result.Errors.Count > 0)
            {
                Console.WriteLine(string.Join(", ", result.Errors));

            }
            return result.Data;
        }

        public async Task RemoveFromBasket(int basketItemId)
        {
            var client = GetHttpClient();
            var response = await client.DeleteAsync($"basket/removefrombasket/{basketItemId}");
            var jsonString = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ResponseModel<string>>(jsonString, _jsonSerializerOptions);
            if (result.Errors != null && result.Errors.Count > 0)
            {
                Console.WriteLine(string.Join(", ", result.Errors));
            }
        }
    }
}
