using eshop_MVC.Abstract;
using eshop_MVC.Models;
using System.Net.Http.Headers;
using System.Text.Json;

namespace eshop_MVC.Services
{
    public class ProductService : BaseService, IProductService
    {

        public ProductService(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor)
            : base(httpClientFactory, httpContextAccessor)
        {
        }

        public async Task<ProductModel> AddAsync(AddProductModel productModel)
        {
            try
            {
                var client = GetHttpClient();
                var content = new MultipartFormDataContent();

                content.Add(new StringContent(productModel.Name), "Name");
                content.Add(new StringContent(productModel.Properties), "Properties");
                content.Add(new StringContent(productModel.Price.ToString()), "Price");

                if (productModel.Image != null)
                {
                    // Resim dosyasını API'ye gönderme
                    var imageContent = new StreamContent(productModel.Image.OpenReadStream());
                    imageContent.Headers.ContentType = new MediaTypeHeaderValue(productModel.Image.ContentType);
                    content.Add(imageContent, "Image", productModel.Image.FileName);
                }

                foreach (var categoryId in productModel.CategoryIds)
                {
                    content.Add(new StringContent(categoryId.ToString()), "CategoryIds");
                }

                var response = await client.PostAsync("products/addproduct", content);

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var response2 = JsonSerializer.Deserialize<ResponseModel<ProductModel>>(jsonResponse);
                    return response2.Data;
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error in AddAsync: {response.StatusCode}, {response.ReasonPhrase}, {errorContent}");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AddAsync: {ex.Message}");
                return null;
            }
        }

 

    public async Task<IEnumerable<ProductModel>> GetAllAsync()
        {
            try
            {
                var client = GetHttpClient();
                var response = await client.GetAsync("products");

                // API yanıtını kontrol et
                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"API Error: {response.StatusCode}");
                    return new List<ProductModel>();
                }

                var jsonResponse = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"API Response: {jsonResponse}");  // API cevabını kontrol et

                ResponseModel<IEnumerable<ProductModel>> result;

                try
                {
                    // JSON'ı deserialize et
                    result = JsonSerializer.Deserialize<ResponseModel<IEnumerable<ProductModel>>>(jsonResponse, _jsonSerializerOptions);
                }
                catch (JsonException jsonEx)
                {
                    Console.WriteLine($"JSON Parsing Error: {jsonEx.Message}");
                    return new List<ProductModel>();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unexpected Error: {ex.Message}");
                    return new List<ProductModel>();
                }

                // Result kontrolü yap
                if (result != null && (result.Errors == null || result.Errors.Count == 0))
                {
                    // Veriyi döndür
                    Console.WriteLine($"Successfully retrieved {result.Data?.Count() ?? 0} products.");
                    return result.Data;
                }
                else
                {
                    // Eğer hata varsa, hata mesajlarını yazdır
                    Console.WriteLine("API Error: " + string.Join(", ", result?.Errors ?? new List<string>()));
                    return new List<ProductModel>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetAllAsync: {ex.Message}");
                return new List<ProductModel>();
            }
        }


        public async Task<IEnumerable<ProductModel>> GetAllActiveAsync()
        {
            try
            {
                var client = GetHttpClient();
                var response = await client.GetAsync("products/true");
                var jsonResponse = await response.Content.ReadAsStringAsync();
                ResponseModel<IEnumerable<ProductModel>> result;
                try
                {
                    result = JsonSerializer.Deserialize<ResponseModel<IEnumerable<ProductModel>>>(jsonResponse, _jsonSerializerOptions);
                }
                catch (Exception)
                {
                    Console.WriteLine("Bir hata var");
                    return new List<ProductModel>();
                }
                if (result != null && result.Errors == null || result.Errors.Count == 0)
                {
                    return result.Data;
                }
                else
                {
                    Console.WriteLine("Bir hata var");
                    return new List<ProductModel>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetAllActiveAsync: {ex.Message}");
                return new List<ProductModel>();
            }
        }

        public async Task<IEnumerable<ProductModel>> GetAllPassiveAsync()
        {
            try
            {
                var client = GetHttpClient();
                var response = await client.GetAsync("products/false");
                var jsonResponse = await response.Content.ReadAsStringAsync();
                ResponseModel<IEnumerable<ProductModel>> result;
                try
                {
                    result = JsonSerializer.Deserialize<ResponseModel<IEnumerable<ProductModel>>>(jsonResponse, _jsonSerializerOptions);
                }
                catch (Exception)
                {
                    Console.WriteLine("Bir hata var");
                    return new List<ProductModel>();
                }
                if (result != null && result.Errors == null || result.Errors.Count == 0)
                {
                    return result.Data;
                }
                else
                {
                    Console.WriteLine("Bir hata var");
                    return new List<ProductModel>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetAllPassiveAsync: {ex.Message}");
                return new List<ProductModel>();
            }
        }

        public async Task<IEnumerable<ProductModel>> GetAllWithCategoriesAsync()
        {
            try
            {
                var client = GetHttpClient();
                var response = await client.GetAsync("products/withcategories");
                var jsonResponse = await response.Content.ReadAsStringAsync();
                ResponseModel<IEnumerable<ProductModel>> result;
                try
                {
                    result = JsonSerializer.Deserialize<ResponseModel<IEnumerable<ProductModel>>>(jsonResponse, _jsonSerializerOptions);
                }
                catch (Exception)
                {
                    Console.WriteLine("Bir hata var");
                    return new List<ProductModel>();
                }
                if (result != null && result.Errors == null || result.Errors.Count == 0)
                {
                    return result.Data;
                }
                else
                {
                    Console.WriteLine("Bir hata var");
                    return new List<ProductModel>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetAllWithCategoriesAsync: {ex.Message}");
                return new List<ProductModel>();
            }
        }

        public async Task<IEnumerable<ProductModel>> GetByCategoryAsync(int categoryId)
        {
            try
            {
                var client = GetHttpClient();
                var response = await client.GetAsync($"Products/bycategory/{categoryId}");
                var jsonResponse = await response.Content.ReadAsStringAsync();
                ResponseModel<IEnumerable<ProductModel>> result;
                try
                {
                    result = JsonSerializer.Deserialize<ResponseModel<IEnumerable<ProductModel>>>(jsonResponse, _jsonSerializerOptions);
                }
                catch (Exception)
                {
                    Console.WriteLine("Bir hata var");
                    return new List<ProductModel>();
                }
                if (result != null && result.Errors == null || result.Errors.Count == 0)
                {
                    return result.Data;
                }
                else
                {
                    Console.WriteLine("Bir hata var");
                    return new List<ProductModel>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetByCategoryAsync: {ex.Message}");
                return new List<ProductModel>();
            }
        }

        public async Task<ProductModel> GetAsync(int id)
        {
            try
            {
                var client = GetHttpClient();
                var response = await client.GetAsync($"products/get/{id}");
                var jsonResponse = await response.Content.ReadAsStringAsync();
                ResponseModel<ProductModel> result;
                try
                {
                    result = JsonSerializer.Deserialize<ResponseModel<ProductModel>>(jsonResponse, _jsonSerializerOptions);
                }
                catch (Exception)
                {
                    Console.WriteLine("Bir hata var");
                    return null;
                }
                if (result != null && result.Errors == null || result.Errors.Count == 0)
                {
                    return result.Data;
                }
                else
                {
                    Console.WriteLine("Bir hata var");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetAsync: {ex.Message}");
                return null;
            }
        }

        public async Task<ProductModel> GetWithCategoriesAsync(int id)
        {
            try
            {
                var client = GetHttpClient();
                var response = await client.GetAsync($"Products/getwithcategories/{id}");
                var jsonResponse = await response.Content.ReadAsStringAsync();
                ResponseModel<ProductModel> result;
                try
                {
                    result = JsonSerializer.Deserialize<ResponseModel<ProductModel>>(jsonResponse, _jsonSerializerOptions);
                }
                catch (Exception)
                {
                    Console.WriteLine("Bir hata var");
                    return null;
                }
                if (result != null && result.Errors == null || result.Errors.Count == 0)
                {
                    return result.Data;
                }
                else
                {
                    Console.WriteLine("Bir hata var");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetWithCategoriesAsync: {ex.Message}");
                return null;
            }
        }

        public async Task<bool> UpdateAsync(UpdateProductModel productModel)
        {
            try
            {
                var client = GetHttpClient();
                var content = new MultipartFormDataContent();
                content.Add(new StringContent(productModel.Id.ToString()), "Id");
                content.Add(new StringContent(productModel.Name), "Name");
                content.Add(new StringContent(productModel.Properties), "Properties");
                content.Add(new StringContent(productModel.Price.ToString()), "Price");

                if (productModel.Image != null)
                {
                    // Resim dosyasını API'ye gönderme
                    var imageContent = new StreamContent(productModel.Image.OpenReadStream());
                    imageContent.Headers.ContentType = new MediaTypeHeaderValue(productModel.Image.ContentType);
                    content.Add(imageContent, "Image", productModel.Image.FileName);
                }

                foreach (var categoryId in productModel.CategoryIds)
                {
                    content.Add(new StringContent(categoryId.ToString()), "CategoryIds");
                }

                var response = await client.PostAsync("products/update", content);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error in UpdateAsync: {response.StatusCode}, {response.ReasonPhrase}, {errorContent}");
                }

                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UpdateAsync: {ex.Message}");
                return false;
            }
        }




        public async Task<bool> UpdateIsActiveAsync(int id)
        {
            try
            {
                var client = GetHttpClient();
                var response = await client.GetAsync($"products/updateisactive/{id}");
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UpdateIsActiveAsync: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                var client = GetHttpClient();
                var response = await client.DeleteAsync($"products/delete/{id}");
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in DeleteAsync: {ex.Message}");
                return false;
            }
        }

        public async Task<int> GetCountAsync()
        {
            try
            {
                var client = GetHttpClient();
                var response = await client.GetAsync("products/count");
                var jsonResponse = await response.Content.ReadAsStringAsync();
                ResponseModel<int> result;
                try
                {
                    result = JsonSerializer.Deserialize<ResponseModel<int>>(jsonResponse, _jsonSerializerOptions);
                }
                catch (Exception)
                {
                    Console.WriteLine("Bir hata var");
                    return 0;
                }
                if (result != null && result.Errors == null || result.Errors.Count == 0)
                {
                    return result.Data;
                }
                else
                {
                    Console.WriteLine("Bir hata var");
                    return 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetCountAsync: {ex.Message}");
                return 0;
            }
        }

        public async Task<int> GetCountAsync(bool isActive)
        {
            try
            {
                var client = GetHttpClient();
                var response = await client.GetAsync($"products/count/{isActive}");
                var jsonResponse = await response.Content.ReadAsStringAsync();
                ResponseModel<int> result;
                try
                {
                    result = JsonSerializer.Deserialize<ResponseModel<int>>(jsonResponse, _jsonSerializerOptions);
                }
                catch (Exception)
                {
                    Console.WriteLine("Bir hata var");
                    return 0;
                }
                if (result != null && result.Errors == null || result.Errors.Count == 0)
                {
                    return result.Data;
                }
                else
                {
                    Console.WriteLine("Bir hata var");
                    return 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetCountAsync (with filter): {ex.Message}");
                return 0;
            }
        }

        public async Task<int> GetCountByCategory(int categoryId)
        {
            try
            {
                var client = GetHttpClient();
                var response = await client.GetAsync($"Products/countbycategory/{categoryId}");
                var jsonResponse = await response.Content.ReadAsStringAsync();
                ResponseModel<int> result;
                try
                {
                    result = JsonSerializer.Deserialize<ResponseModel<int>>(jsonResponse, _jsonSerializerOptions);
                }
                catch (Exception)
                {
                    Console.WriteLine("Bir hata var");
                    return 0;
                }
                if (result != null && result.Errors == null || result.Errors.Count == 0)
                {
                    return result.Data;
                }
                else
                {
                    Console.WriteLine("Bir hata var");
                    return 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetCountByCategory: {ex.Message}");
                return 0;
            }
        }

        public async Task<IEnumerable<ProductModel>> GetAllWithCategoriesFalseAsync()
        {
            try
            {
                var client = GetHttpClient();
                var response = await client.GetAsync("products/withcategories/false");
                var jsonResponse = await response.Content.ReadAsStringAsync();
                ResponseModel<IEnumerable<ProductModel>> result;
                try
                {
                    result = JsonSerializer.Deserialize<ResponseModel<IEnumerable<ProductModel>>>(jsonResponse, _jsonSerializerOptions);
                }
                catch (Exception)
                {
                    Console.WriteLine("Bir hata var");
                    return new List<ProductModel>();
                }
                if (result != null && result.Errors == null || result.Errors.Count == 0)
                {
                    return result.Data;
                }
                else
                {
                    Console.WriteLine("Bir hata var");
                    return new List<ProductModel>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetAllWithCategoriesAsync: {ex.Message}");
                return new List<ProductModel>();
            }
        }

        public async Task<GetUpdateProductModel> UpdateGetWithCategoriesAsync(int id)
        {
            try
            {
                var client = GetHttpClient();
                var response = await client.GetAsync($"Products/getwithcategories/{id}");
                var jsonResponse = await response.Content.ReadAsStringAsync();
                ResponseModel<GetUpdateProductModel> result;
                try
                {
                    result = JsonSerializer.Deserialize<ResponseModel<GetUpdateProductModel>>(jsonResponse, _jsonSerializerOptions);
                }
                catch (Exception)
                {
                    Console.WriteLine("Bir hata var");
                    return null;
                }
                if (result != null && result.Errors == null || result.Errors.Count == 0)
                {
                    return result.Data;
                }
                else
                {
                    Console.WriteLine("Bir hata var");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetWithCategoriesAsync: {ex.Message}");
                return null;
            }
        }
    }
}
