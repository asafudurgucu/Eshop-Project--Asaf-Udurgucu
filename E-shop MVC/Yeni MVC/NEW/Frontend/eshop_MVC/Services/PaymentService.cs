using eshop_MVC.Abstract;
using eshop_MVC.Models;
using System.Text.Json;

namespace eshop_MVC.Services
{
    public class PaymentService : BaseService, IPaymentService
    {
        public PaymentService(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor) : base(httpClientFactory, httpContextAccessor)
        {
        }

        public async Task<PaymentModel> CreatePaymentAsync(PaymentModel payment)
        {
            try
            {
                var client = GetHttpClient();
                var response = await client.PostAsJsonAsync("Payment/", payment);
                if (!response.IsSuccessStatusCode)
                {
                    var errorMessage = await response.Content.ReadAsStringAsync();
                    throw new HttpRequestException($"API Hatası: {errorMessage}");
                }
                var jsonString = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<ResponseModel<PaymentModel>>(jsonString);
                if (result == null)
                {
                    throw new JsonException("API yanıtı beklenen formatta değil.");
                }

                return result.Data;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata : {ex.Message}");
                return null;
            }
        }

        public async Task<IEnumerable<PaymentModel>> GetAllPaymentsAsync()
        {
            try
            {
                var client = GetHttpClient();
                var response = await client.GetAsync($"Payment/");
                if (!response.IsSuccessStatusCode)
                {
                    var errorMessage = await response.Content.ReadAsStringAsync();
                    throw new HttpRequestException($"API Hatası: {errorMessage}");
                }
                var jsonString = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<ResponseModel<IEnumerable<PaymentModel>>>(jsonString);
                if (result == null)
                {
                    throw new JsonException("API yanıtı beklenen formatta değil.");
                }

                return result.Data;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata : {ex.Message}");
                return null;
            }
        }

        public async Task<PaymentModel> GetPaymentByIdAsync(int id)
        {
            try
            {
                var client = GetHttpClient();
                var response = await client.GetAsync($"Payment/{id}");
                if (!response.IsSuccessStatusCode)
                {
                    var errorMessage = await response.Content.ReadAsStringAsync();
                    throw new HttpRequestException($"API Hatası: {errorMessage}");
                }
                var jsonString = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<ResponseModel<PaymentModel>>(jsonString);
                if (result == null)
                {
                    throw new JsonException("API yanıtı beklenen formatta değil.");
                }

                return result.Data;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata : {ex.Message}");
                return null;
            }
        }
    }
}
