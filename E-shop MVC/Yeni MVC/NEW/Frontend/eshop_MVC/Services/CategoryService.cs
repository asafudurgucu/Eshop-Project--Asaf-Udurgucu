using eshop_MVC.Abstract;
using eshop_MVC.Models;
using System.Text.Json;

namespace eshop_MVC.Services
{
    public class CategoryService : BaseService, ICategoryService
    {
        public CategoryService(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor) : base(httpClientFactory, httpContextAccessor)
        {
        }

        public async Task<AddCategoryModel> AddCategoriyAsync(AddCategoryModel category)
        {
            try
            {
                var client = GetHttpClient();
                var response = await client.PostAsJsonAsync("Categories/", category);

                if (response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<AddCategoryModel>(responseString);
                }

                Console.WriteLine("Error adding category.");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

        public async Task DeleteCategoryModel(int id)
        {
            try
            {
                var client = GetHttpClient();
                var response = await client.DeleteAsync($"Categories/{id}");

                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Error deleting category.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public async Task<IEnumerable<CategoryModel>> GetActiveCategoriesAsync()
        {
            try
            {
                var client = GetHttpClient();
                var response = await client.GetAsync("categories/getall/true");
                var jsonString = await response.Content.ReadAsStringAsync();
                ResponseModel<IEnumerable<CategoryModel>> result;

                try
                {
                    result = JsonSerializer.Deserialize<ResponseModel<IEnumerable<CategoryModel>>>(jsonString);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Json Error: {ex.Message}");
                    return new List<CategoryModel>();
                }

                if (result != null && (result.Errors == null || result.Errors.Count == 0))
                {
                    return result.Data;
                }
                else
                {
                    Console.WriteLine($"Request Error: {string.Join(",", result.Errors)}");
                    return new List<CategoryModel>();
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Http Request Error: {ex.Message}");
                return new List<CategoryModel>();
            }
        }

        public async Task<IEnumerable<CategoryModel>> GetAllCategoriesAsync()
        {
            try
            {
                var client = GetHttpClient();
                var response = await client.GetAsync("categories/getall/");
                var jsonString = await response.Content.ReadAsStringAsync();
                ResponseModel<IEnumerable<CategoryModel>> result;

                try
                {
                    result = JsonSerializer.Deserialize<ResponseModel<IEnumerable<CategoryModel>>>(jsonString);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Json Error: {ex.Message}");
                    return new List<CategoryModel>();
                }

                if (result != null && (result.Errors == null || result.Errors.Count == 0))
                {
                    return result.Data;
                }
                else
                {
                    Console.WriteLine($"Request Error: {string.Join(",", result.Errors)}");
                    return new List<CategoryModel>();
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Http Request Error: {ex.Message}");
                return new List<CategoryModel>();
            }
        }

        public async Task<CategoryModel?> GetCategoriesAsync(int id)
        {
            try
            {
                var client = GetHttpClient();
                var response = await client.GetAsync($"categories/get/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var result = JsonSerializer.Deserialize<ResponseModel<CategoryModel>>(jsonString);
                    return result?.Data;
                }

                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

        public async Task<int> GetCategoriyCountAsync(int id)
        {
            try
            {
                var client = GetHttpClient();
                var response = await client.GetAsync($"categories/count/{id}");

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<int>(jsonString);
                }

                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return 0;
            }
        }

        public async Task<IEnumerable<CategoryModel>> GetPassiveCategoriesAsync()
        {
            try
            {
                var client = GetHttpClient();
                var response = await client.GetAsync("categories/getall/false");
                var jsonString = await response.Content.ReadAsStringAsync();
                ResponseModel<IEnumerable<CategoryModel>> result;

                try
                {
                    result = JsonSerializer.Deserialize<ResponseModel<IEnumerable<CategoryModel>>>(jsonString);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Json Error: {ex.Message}");
                    return new List<CategoryModel>();
                }

                return result?.Data ?? new List<CategoryModel>();
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Http Request Error: {ex.Message}");
                return new List<CategoryModel>();
            }
        }

        public async Task<bool> UpdateCategoryModel(UpdateCategoryModel category)
        {
            try
            {
                var client = GetHttpClient();
                var response = await client.PutAsJsonAsync("categories/", category);
                return response.IsSuccessStatusCode;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Http Request Error: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }
    }
}
