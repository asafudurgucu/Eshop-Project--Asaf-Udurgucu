using eshop_MVC.Abstract;
using eshop_MVC.Helpers;
using eshop_MVC.Models;
using System.Text.Json;

namespace eshop_MVC.Services
{
    public class OrderService : BaseService, IOrderService
    {
        public OrderService(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor) : base(httpClientFactory, httpContextAccessor)
        {
        }

        

            public async Task<IEnumerable<OrderModel>> GetByUserAsync(string userId)
            {
                var client = GetHttpClient();
                var response = await client.GetAsync($"orders/user/{userId}");
                var jsonString = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<ResponseModel<IEnumerable<OrderModel>>>(jsonString, _jsonSerializerOptions);

                if (result?.Errors != null)
                {
                    Console.WriteLine(string.Join(", ", result.Errors));
                    return new List<OrderModel>();
                }

                return result?.Data ?? new List<OrderModel>();
            }

            public async Task<OrderModel> GetAsync(int id)
            {
                var client = GetHttpClient();
                var response = await client.GetAsync($"orders/{id}");
                var jsonString = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<ResponseModel<OrderModel>>(jsonString, _jsonSerializerOptions);

                if (result?.Errors != null)
                {
                    Console.WriteLine(string.Join(", ", result.Errors));
                    return null;
                }

                return result?.Data;
            }

            public async Task AddAsync(OrderModel model)
            {
                var client = GetHttpClient();
                var response = await client.PostAsJsonAsync("orders", model);

                // HTTP yanıtının başarılı olup olmadığını kontrol edin
                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Hata: HTTP {response.StatusCode} - {response.ReasonPhrase}");
                    return;
                }

                var jsonString = await response.Content.ReadAsStringAsync();

                // Gelen JSON verisinin boş olup olmadığını kontrol edin
                if (string.IsNullOrWhiteSpace(jsonString))
                {
                    Console.WriteLine("Gelen JSON verisi boş.");
                    return;
                }

                var result = JsonSerializer.Deserialize<ResponseModel<OrderModel>>(jsonString, _jsonSerializerOptions);

                if (result?.Errors != null)
                {
                    Console.WriteLine(string.Join(", ", result.Errors));
                }

        }

        public async Task DeleteAsync(int id)
            {
                var client = GetHttpClient();
                var response = await client.DeleteAsync($"orders/{id}");

                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Error deleting the order.");
                }
            }

            public async Task UpdateAsync(int id, OrderStatus status)
            {
            var client = GetHttpClient();

            Console.WriteLine($"Gönderilen ID: {id}, Gönderilen Status: {(int)status} ({status})"); // Log ekle
            var response = await client.PutAsJsonAsync($"orders/{id}", status);

            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine("Error updating the order.");
            }
        }

            public async Task<IEnumerable<OrderModel>> GetByStatusAsync(OrderStatus status)
            {
                var client = GetHttpClient();
                var response = await client.GetAsync($"orders/status?orderStatus={status}&userId=" );
                var jsonString = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<ResponseModel<IEnumerable<OrderModel>>>(jsonString, _jsonSerializerOptions);

                if (result?.Errors != null)
                {
                    Console.WriteLine(string.Join(", ", result.Errors));
                    return new List<OrderModel>();
                }

                return result?.Data ?? new List<OrderModel>();
            }


            public async Task<IEnumerable<OrderModel>> GetByDateRangeAsync(DateTime startDate, DateTime endDate, string userId)
            {
                var client = GetHttpClient();
                var response = await client.GetAsync($"orders/daterange?startDate={startDate:yyyy-MM-dd}&endDate={endDate:yyyy-MM-dd}&userId={userId}");
                var jsonString = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<ResponseModel<IEnumerable<OrderModel>>>(jsonString, _jsonSerializerOptions);

                if (result?.Errors != null)
                {
                    Console.WriteLine(string.Join(", ", result.Errors));
                    return new List<OrderModel>();
                }

                return result?.Data ?? new List<OrderModel>();
            }

        public async Task<IEnumerable<OrderModel>> GetAllAsync()
        {
            var client = GetHttpClient();
            var response = await client.GetAsync($"orders/");
            var jsonString = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ResponseModel<IEnumerable<OrderModel>>>(jsonString, _jsonSerializerOptions);

            if (result?.Errors != null)
            {
                Console.WriteLine(string.Join(", ", result.Errors));
                return null;
            }

            return result.Data;
        }

        public async Task<int> GetTotalOrderCountAsync()
        {
            var client = GetHttpClient();
            var response = await client.GetAsync($"orders/count");
            var jsonString = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ResponseModel<int>>(jsonString, _jsonSerializerOptions);
            if(result?.Errors != null)
            {
                Console.WriteLine(string.Join(", ", result.Errors));
                return 0;
            }
            return result.Data;
        }

        public Task<Dictionary<string, int>> GetOrderCountByStatusAsync()
        {
           var client = GetHttpClient();
            var response = client.GetAsync("orders/countbystatus").Result;
            var jsonString = response.Content.ReadAsStringAsync().Result;
            var result = JsonSerializer.Deserialize<ResponseModel<Dictionary<string, int>>>(jsonString, _jsonSerializerOptions);
            if(result?.Errors != null)
            {
                Console.WriteLine(string.Join(", ", result.Errors));
                return null;
            }
            return Task.FromResult(result.Data);
        }

        public async Task<IEnumerable<OrderModel>> Statusbutuser(OrderStatus status)
        {
           
                var client = GetHttpClient();
                var response = await client.GetAsync($"orders/statusbutuser/{status}");
                var jsonString = await response.Content.ReadAsStringAsync();

                var result = JsonSerializer.Deserialize<ResponseModel<IEnumerable<OrderModel>>>(jsonString,_jsonSerializerOptions);

                if (result?.Errors != null)
                {
                    Console.WriteLine(string.Join(", ", result.Errors));
                    return new List<OrderModel>(); // Hata durumunda boş liste dön
                }

                return result?.Data ?? new List<OrderModel>(); // Null kontrolü
            

        }
    }
    }

