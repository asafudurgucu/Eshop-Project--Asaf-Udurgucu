using System;
using System.Text.Json;
using eshop_MVC.Abstract;
using eshop_MVC.Models;

namespace eshop_MVC.Services;

public class CommentService : BaseService,ICommentService
{
    public CommentService(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor) : base(httpClientFactory, httpContextAccessor)
    {
    }

    public async Task<CommentModel> CreateCommentAsync(CreateCommentModel createCommentModel)
    {
       try
       {
              var client = GetHttpClient();
              var response = await client.PostAsJsonAsync("Comment/", createCommentModel);
              if (!response.IsSuccessStatusCode)
              {
                var errorMessage = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException($"API Hatası: {errorMessage}");
              }
              var jsonString = await response.Content.ReadAsStringAsync();
              var result = JsonSerializer.Deserialize<ResponseModel<CommentModel>>(jsonString);
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

    public Task<string> DeleteComment(int commentId)
    {

        try
        {
            var client = GetHttpClient();
            var response = client.DeleteAsync($"Comment/{commentId}");
            if (!response.Result.IsSuccessStatusCode)
            {
                var errorMessage = response.Result.Content.ReadAsStringAsync();
                throw new HttpRequestException($"API Hatası: {errorMessage}");
            }
            var jsonString = response.Result.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ResponseModel<string>>(jsonString.Result);
            if (result == null)
            {
                throw new JsonException("API yanıtı beklenen formatta değil.");
            }
            return Task.FromResult(result.Data);

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Hata : {ex.Message}");
            return null;
        }
    }

    public Task<IEnumerable<CommentModel>> GetAllComments()
    {
        try
        {
            var client = GetHttpClient();
            var response = client.GetAsync("Comment");
            if (!response.Result.IsSuccessStatusCode)
            {
                var errorMessage = response.Result.Content.ReadAsStringAsync();
                throw new HttpRequestException($"API Hatası: {errorMessage}");
            }
            var jsonString = response.Result.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ResponseModel<IEnumerable<CommentModel>>>(jsonString.Result);
            if (result == null)
            {
                throw new JsonException("API yanıtı beklenen formatta değil.");
            }
            return Task.FromResult(result.Data);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Hata : {ex.Message}");
            return null;
            
        }
    }

    public async Task<IEnumerable<CommentModel>> GetCommentsByProductIdAsync(int productId)
    {
        try
        {
            var client = GetHttpClient();
            var response = await client.GetAsync($"Comment/{productId}");
            if (!response.IsSuccessStatusCode)
            {
                var errorMessage = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException($"API Hatası: {errorMessage}");
            }
            var jsonString = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ResponseModel<IEnumerable<CommentModel>>>(jsonString);
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
