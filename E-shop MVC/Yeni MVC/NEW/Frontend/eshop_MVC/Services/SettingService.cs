using eshop_MVC.Abstract;
using eshop_MVC.Models;
using eshop_MVC.Models.SettingsModels;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace eshop_MVC.Services
{
    public class SettingService : BaseService, ISettingService
    {
        public SettingService(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor) : base(httpClientFactory, httpContextAccessor)
        {
        }

        public async Task<IEnumerable<GetSettingsModel>> GetSettingsAsync()
        {
            var client = GetHttpClient();
            var response = await client.GetAsync("settings/");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<ResponseModel<IEnumerable<GetSettingsModel>>>(content);
                return result.Data;
            }

            return null;  // Ya da uygun bir hata yönetimi yapılabilir
        }

        public async Task<bool> UpdateSettingsAsync(SettingsModel settingsModel)
        {
            try
            {
                var client = GetHttpClient();

                // SettingsModel'i JSON formatına dönüştürme
                var cc = new SettingsModel
                {
                    FooterText = settingsModel.FooterText,
                    SliderText = settingsModel.SliderText,
                    AboutTextTitle = settingsModel.AboutTextTitle,
                    AboutText = settingsModel.AboutText,
                    SocialMediaUrl = settingsModel.SocialMediaUrl,
                    SocialMediaUrl2 = settingsModel.SocialMediaUrl2,
                    SocialMediaUrl3 = settingsModel.SocialMediaUrl3,
                    MapLocation = settingsModel.MapLocation
                };

                // JSON'a dönüştürme işlemi
                var jsonContent = JsonSerializer.Serialize(cc);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                // API'ye gönderim
                var response = await client.PostAsync("settings/update", content);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    return true;
                    
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error in UpdateSettingsAsync: {response.StatusCode}, {response.ReasonPhrase}, {errorContent}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UpdateSettingsAsync: {ex.Message}");
                return false;
            }
        }


        // Logo güncelleme metodu
        public async Task<bool> UpdateLogo(LogoPathModel model)
        {
            try
            {
                if (model?.LogoPath == null) return false;

                var client = GetHttpClient();
                using var content = new MultipartFormDataContent();

                var logoStream = model.LogoPath.OpenReadStream();
                var logoContent = new StreamContent(logoStream)
                {
                    Headers = { ContentType = new MediaTypeHeaderValue(model.LogoPath.ContentType) }
                };
                content.Add(logoContent, "LogoPath", model.LogoPath.FileName);

                var response = await client.PostAsync("settings/update-logo", content);

                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UpdateLogo: {ex.Message}");
                return false;
            }
        }

        // Footer Logo güncelleme metodu
        public async Task<bool> UpdateFooterLogo(FooterLogoPathModel model)
        {
            try
            {
                if (model?.FooterLogoPath == null) return false;

                var client = GetHttpClient();
                using var content = new MultipartFormDataContent();

                var footerLogoStream = model.FooterLogoPath.OpenReadStream();
                var footerLogoContent = new StreamContent(footerLogoStream)
                {
                    Headers = { ContentType = new MediaTypeHeaderValue(model.FooterLogoPath.ContentType) }
                };
                content.Add(footerLogoContent, "FooterLogoPath", model.FooterLogoPath.FileName);

                var response = await client.PostAsync("settings/update-footer-logo", content);

                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UpdateFooterLogo: {ex.Message}");
                return false;
            }
        }

        // Banner 1 güncelleme metodu
        public async Task<bool> UpdateBanner1(Banner1PathModel model)
        {
            try
            {
                if (model?.Banner1Path == null) return false;

                var client = GetHttpClient();
                using var content = new MultipartFormDataContent();

                var banner1Stream = model.Banner1Path.OpenReadStream();
                var banner1Content = new StreamContent(banner1Stream)
                {
                    Headers = { ContentType = new MediaTypeHeaderValue(model.Banner1Path.ContentType) }
                };
                content.Add(banner1Content, "Banner1Path", model.Banner1Path.FileName);

                var response = await client.PostAsync("settings/update-banner1", content);

                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UpdateBanner1: {ex.Message}");
                return false;
            }
        }

        // Banner 2 güncelleme metodu
        public async Task<bool> UpdateBanner2(Banner2PathModel model)
        {
            try
            {
                if (model?.Banner2Path == null) return false;

                var client = GetHttpClient();
                using var content = new MultipartFormDataContent();

                var banner2Stream = model.Banner2Path.OpenReadStream();
                var banner2Content = new StreamContent(banner2Stream)
                {
                    Headers = { ContentType = new MediaTypeHeaderValue(model.Banner2Path.ContentType) }
                };
                content.Add(banner2Content, "Banner2Path", model.Banner2Path.FileName);

                var response = await client.PostAsync("settings/update-banner2", content);

                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UpdateBanner2: {ex.Message}");
                return false;
            }
        }

        // Banner 3 güncelleme metodu
        public async Task<bool> UpdateBanner3(Banner3PathModel model)
        {
            try
            {
                if (model?.Banner3Path == null) return false;

                var client = GetHttpClient();
                using var content = new MultipartFormDataContent();

                var banner3Stream = model.Banner3Path.OpenReadStream();
                var banner3Content = new StreamContent(banner3Stream)
                {
                    Headers = { ContentType = new MediaTypeHeaderValue(model.Banner3Path.ContentType) }
                };
                content.Add(banner3Content, "Banner3Path", model.Banner3Path.FileName);

                var response = await client.PostAsync("settings/update-banner3", content);

                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UpdateBanner3: {ex.Message}");
                return false;
            }
        }

        // About Banner güncelleme metodu
        public async Task<bool> UpdateAboutBanner(AboutBannerPathModel model)
        {
            try
            {
                if (model?.AboutBannerPath == null) return false;

                var client = GetHttpClient();
                using var content = new MultipartFormDataContent();

                var aboutBannerStream = model.AboutBannerPath.OpenReadStream();
                var aboutBannerContent = new StreamContent(aboutBannerStream)
                {
                    Headers = { ContentType = new MediaTypeHeaderValue(model.AboutBannerPath.ContentType) }
                };
                content.Add(aboutBannerContent, "AboutBannerPath", model.AboutBannerPath.FileName);

                var response = await client.PostAsync("settings/update-about-banner", content);

                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UpdateAboutBanner: {ex.Message}");
                return false;
            }
        }

        // About Photo güncelleme metodu
        public async Task<bool> UpdateAboutPhoto(AboutPhotoPathModel model)
        {
            try
            {
                if (model?.AboutPhotoPath == null) return false;

                var client = GetHttpClient();
                using var content = new MultipartFormDataContent();

                var aboutPhotoStream = model.AboutPhotoPath.OpenReadStream();
                var aboutPhotoContent = new StreamContent(aboutPhotoStream)
                {
                    Headers = { ContentType = new MediaTypeHeaderValue(model.AboutPhotoPath.ContentType) }
                };
                content.Add(aboutPhotoContent, "AboutPhotoPath", model.AboutPhotoPath.FileName);

                var response = await client.PostAsync("settings/update-about-photo", content);

                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UpdateAboutPhoto: {ex.Message}");
                return false;
            }
        }

        // Contact Banner güncelleme metodu
        public async Task<bool> UpdateContactBanner(ContactBannerPathModel model)
        {
            try
            {
                if (model?.ContactBannerPath == null) return false;

                var client = GetHttpClient();
                using var content = new MultipartFormDataContent();

                var contactBannerStream = model.ContactBannerPath.OpenReadStream();
                var contactBannerContent = new StreamContent(contactBannerStream)
                {
                    Headers = { ContentType = new MediaTypeHeaderValue(model.ContactBannerPath.ContentType) }
                };
                content.Add(contactBannerContent, "ContactBannerPath", model.ContactBannerPath.FileName);

                var response = await client.PostAsync("settings/update-contact-banner", content);

                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UpdateContactBanner: {ex.Message}");
                return false;
            }
        }
    }
}
