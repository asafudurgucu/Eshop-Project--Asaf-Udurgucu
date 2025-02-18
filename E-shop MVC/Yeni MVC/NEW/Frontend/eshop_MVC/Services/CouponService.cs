using System;
using System.Text.Json;
using eshop_MVC.Abstract;
using eshop_MVC.Models;

namespace eshop_MVC.Services;

public class CouponService : BaseService,ICouponService
{
    public CouponService(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor) : base(httpClientFactory, httpContextAccessor)
    {
    }

    public async Task<CouponModel> CreateCoupon(CouponCreateModel couponCreateModel)
    {
        try
        {
            var client = GetHttpClient();
            var response = await client.PostAsJsonAsync("Coupon/",couponCreateModel);
            if(!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"API hatalı. Durum kodu: {response.StatusCode}");
            }
            var jsonString = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ResponseModel<CouponModel>>(jsonString);
            if(result == null)
            {
                throw new JsonException("API yanıtı beklenen formatta değil.");
            }
            return result.Data;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Beklenmeyen bir hata oluştu : {ex.Message}");
            return null;
        }
    }

    public async Task<bool> Delete(int id)
    {
        try
        {
            var client = GetHttpClient();
            var response = await client.DeleteAsync($"Coupon/{id}");
            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"API hatalı. Durum kodu: {response.StatusCode}");
            }
            return true;


        }
        catch (Exception ex)
        {
            Console.WriteLine($"Beklenmeyen bir hata oluştu : {ex.Message}");
            return false;
        }
    }

    public async Task<CouponModel> GetCouponByCodeAsync(string code)
    {
       try
       {
            var client = GetHttpClient();
            var response = await client.GetAsync($"Coupon/{code}");
            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"API hatalı. Durum kodu: {response.StatusCode}");
            }
            var jsonString = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ResponseModel<CouponModel>>(jsonString);
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

    public async Task<List<CouponModel>> GetCouponsAsync()
    {
        try
        {
            var client = GetHttpClient();
            var response = await client.GetAsync("Coupon/coupons");
            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"API hatalı. Durum kodu: {response.StatusCode}");
            }
            var jsonString = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ResponseModel<List<CouponModel>>>(jsonString);
            if (result == null || result.Data == null)
            {
                throw new JsonException("API yanıtı beklenen formatta değil.");
            }
            return result.Data;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Beklenmeyen bir hata oluştu : {ex.Message}");
            return null;
        }
    }
}
