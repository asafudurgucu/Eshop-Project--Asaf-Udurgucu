using AutoMapper;
using eshop_Data.Abstract;
using eshop_Entity.Contcrete;
using eshop_Service.Abstract;
using eshop_Shared.DTOs;
using eshop_Shared.DTOs.SettingsDTOs;
using eshop_Shared.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eshop_Service.Concrete
{
    public class SettingsService : ISettingsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IImageService _imageService;
        private readonly IGenericRepository<Settings> _settingsRepository;

        public SettingsService(IUnitOfWork unitOfWork, IMapper mapper, IImageService imageService, IGenericRepository<Settings> settingsRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _imageService = imageService;
            _settingsRepository = settingsRepository;
        }

        // Tüm ayarları almak
        public async Task<ResponseDTO<IEnumerable<GetSettingsDTO>>> GetAllAsync()
        {
            try
            {
                // Veritabanından tüm ayarları alıyoruz
                var settings = await _settingsRepository.GetAllAsync(); // Burada SettingsRepository'i kullanalım

                if (settings == null)
                {
                    return ResponseDTO<IEnumerable<GetSettingsDTO>>.Fail("Settings not found", 404);
                }

                // Verileri DTO'ya dönüştürüyoruz
                var settingsDTO = _mapper.Map<IEnumerable<GetSettingsDTO>>(settings);

                return  ResponseDTO<IEnumerable<GetSettingsDTO>>.Success(settingsDTO, 200);

            }
            catch (Exception ex)
            {
                return ResponseDTO<IEnumerable<GetSettingsDTO>>.Fail($"Error: {ex.Message}", 500);

            }
        }

        // Ayarları güncelleme
        public async Task<ResponseDTO<NoContent>> UpdateAsync(UpdateSettingsDTO updateSettingsDTO)
        {
            try
            {
                // Mevcut ayarı veritabanından alıyoruz
                var existingSettings = await _settingsRepository.GetAsync(s => s.Id == 3); 

                if (existingSettings == null)
                {
                    return ResponseDTO<NoContent>.Fail("Settings not found", 404);

                }

                // Dosya yollarını güncellemek için ImageService'i kullanıyoruz
               

                // Diğer metin verilerini güncelliyoruz
                existingSettings.FooterText = updateSettingsDTO.FooterText;
                existingSettings.SliderText = updateSettingsDTO.SliderText;
                existingSettings.AboutTextTitle = updateSettingsDTO.AboutTextTitle;
                existingSettings.AboutText = updateSettingsDTO.AboutText;
                existingSettings.SocialMediaUrl = updateSettingsDTO.SocialMediaUrl;
                existingSettings.SocialMediaUrl2 = updateSettingsDTO.SocialMediaUrl2;
                existingSettings.SocialMediaUrl3 = updateSettingsDTO.SocialMediaUrl3;
                existingSettings.MapLocation = updateSettingsDTO.MapLocation;

                // Güncellenmiş veriyi kaydediyoruz
                _settingsRepository.Update(existingSettings);
                await _unitOfWork.SaveAsync();

                return  ResponseDTO<NoContent>.Success(204);

            }
            catch (Exception ex)
            {
                return  ResponseDTO<NoContent>.Fail("Error: {ex.Message}", 500);

            }
        }
        public async Task<ResponseDTO<NoContent>> UpdateLogoAsync(LogoPathDTO logoPathDTO)
        {
            try
            {
                var existingSettings = await _settingsRepository.GetAsync(s => s.Id == 3);

                if (existingSettings == null)
                {
                    return ResponseDTO<NoContent>.Fail("Settings not found", 404);
                }

                if (logoPathDTO.LogoPath != null)
                {
                    existingSettings.LogoPath = await _imageService.UploadImageAsync(logoPathDTO.LogoPath);
                }

                _settingsRepository.Update(existingSettings);
                await _unitOfWork.SaveAsync();

                return ResponseDTO<NoContent>.Success(204);
            }
            catch (Exception ex)
            {
                return ResponseDTO<NoContent>.Fail($"Error: {ex.Message}", 500);
            }
        }

        public async Task<ResponseDTO<NoContent>> UpdateFooterLogoAsync(FooterLogoPathDTO footerLogoPathDTO)
        {
            try
            {
                var existingSettings = await _settingsRepository.GetAsync(s => s.Id == 3);

                if (existingSettings == null)
                {
                    return ResponseDTO<NoContent>.Fail("Settings not found", 404);
                }

                if (footerLogoPathDTO.FooterLogoPath != null)
                {
                    existingSettings.FooterLogoPath = await _imageService.UploadImageAsync(footerLogoPathDTO.FooterLogoPath);
                }

                _settingsRepository.Update(existingSettings);
                await _unitOfWork.SaveAsync();

                return ResponseDTO<NoContent>.Success(204);
            }
            catch (Exception ex)
            {
                return ResponseDTO<NoContent>.Fail($"Error: {ex.Message}", 500);
            }
        }

        public async Task<ResponseDTO<NoContent>> UpdateBanner1Async(Banner1PathDTO banner1PathDTO)
        {
            try
            {
                var existingSettings = await _settingsRepository.GetAsync(s => s.Id == 3);

                if (existingSettings == null)
                {
                    return ResponseDTO<NoContent>.Fail("Settings not found", 404);
                }

                if (banner1PathDTO.Banner1Path != null)
                {
                    existingSettings.Banner1Path = await _imageService.UploadImageAsync(banner1PathDTO.Banner1Path);
                }

                _settingsRepository.Update(existingSettings);
                await _unitOfWork.SaveAsync();

                return ResponseDTO<NoContent>.Success(204);
            }
            catch (Exception ex)
            {
                return ResponseDTO<NoContent>.Fail($"Error: {ex.Message}", 500);
            }
        }

        public async Task<ResponseDTO<NoContent>> UpdateBanner2Async(Banner2PathDTO banner2PathDTO)
        {
            try
            {
                var existingSettings = await _settingsRepository.GetAsync(s => s.Id == 3);

                if (existingSettings == null)
                {
                    return ResponseDTO<NoContent>.Fail("Settings not found", 404);
                }

                if (banner2PathDTO.Banner2Path != null)
                {
                    existingSettings.Banner2Path = await _imageService.UploadImageAsync(banner2PathDTO.Banner2Path);
                }

                _settingsRepository.Update(existingSettings);
                await _unitOfWork.SaveAsync();

                return ResponseDTO<NoContent>.Success(204);
            }
            catch (Exception ex)
            {
                return ResponseDTO<NoContent>.Fail($"Error: {ex.Message}", 500);
            }
        }

        public async Task<ResponseDTO<NoContent>> UpdateBanner3Async(Banner3PathDTO banner3PathDTO)
        {
            try
            {
                var existingSettings = await _settingsRepository.GetAsync(s => s.Id == 3);

                if (existingSettings == null)
                {
                    return ResponseDTO<NoContent>.Fail("Settings not found", 404);
                }

                if (banner3PathDTO.Banner3Path != null)
                {
                    existingSettings.Banner3Path = await _imageService.UploadImageAsync(banner3PathDTO.Banner3Path);
                }

                _settingsRepository.Update(existingSettings);
                await _unitOfWork.SaveAsync();

                return ResponseDTO<NoContent>.Success(204);
            }
            catch (Exception ex)
            {
                return ResponseDTO<NoContent>.Fail($"Error: {ex.Message}", 500);
            }
        }

        public async Task<ResponseDTO<NoContent>> UpdateAboutBannerAsync(AboutBannerPathDTO aboutBannerPathDTO)
        {
            try
            {
                var existingSettings = await _settingsRepository.GetAsync(s => s.Id == 3);

                if (existingSettings == null)
                {
                    return ResponseDTO<NoContent>.Fail("Settings not found", 404);
                }

                if (aboutBannerPathDTO.AboutBannerPath != null)
                {
                    existingSettings.AboutBannerPath = await _imageService.UploadImageAsync(aboutBannerPathDTO.AboutBannerPath);
                }

                _settingsRepository.Update(existingSettings);
                await _unitOfWork.SaveAsync();

                return ResponseDTO<NoContent>.Success(204);
            }
            catch (Exception ex)
            {
                return ResponseDTO<NoContent>.Fail($"Error: {ex.Message}", 500);
            }
        }

        public async Task<ResponseDTO<NoContent>> UpdateAboutPhotoAsync(AboutPhotoPathDTO aboutPhotoPathDTO)
        {
            try
            {
                var existingSettings = await _settingsRepository.GetAsync(s => s.Id == 3);

                if (existingSettings == null)
                {
                    return ResponseDTO<NoContent>.Fail("Settings not found", 404);
                }

                if (aboutPhotoPathDTO.AboutPhotoPath != null)
                {
                    existingSettings.AboutPhotoPath = await _imageService.UploadImageAsync(aboutPhotoPathDTO.AboutPhotoPath);
                }

                _settingsRepository.Update(existingSettings);
                await _unitOfWork.SaveAsync();

                return ResponseDTO<NoContent>.Success(204);
            }
            catch (Exception ex)
            {
                return ResponseDTO<NoContent>.Fail($"Error: {ex.Message}", 500);
            }
        }

        public async Task<ResponseDTO<NoContent>> UpdateContactBannerAsync(ContactBannerPathDTO contactBannerPathDTO)
        {
            try
            {
                var existingSettings = await _settingsRepository.GetAsync(s => s.Id == 3);

                if (existingSettings == null)
                {
                    return ResponseDTO<NoContent>.Fail("Settings not found", 404);
                }

                if (contactBannerPathDTO.ContactBannerPath != null)
                {
                    existingSettings.ContactBannerPath = await _imageService.UploadImageAsync(contactBannerPathDTO.ContactBannerPath);
                }

                _settingsRepository.Update(existingSettings);
                await _unitOfWork.SaveAsync();

                return ResponseDTO<NoContent>.Success(204);
            }
            catch (Exception ex)
            {
                return ResponseDTO<NoContent>.Fail($"Error: {ex.Message}", 500);
            }
        }

    }
}
