using eshop_Entity.Contcrete;
using eshop_Shared.DTOs;
using eshop_Shared.DTOs.SettingsDTOs;
using eshop_Shared.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop_Service.Abstract
{
    public interface ISettingsService
    {

        Task<ResponseDTO<IEnumerable<GetSettingsDTO>>> GetAllAsync();

        // Method to update general settings
        Task<ResponseDTO<NoContent>> UpdateAsync(UpdateSettingsDTO updateSettingsDTO);

        // Method to update Logo
        Task<ResponseDTO<NoContent>> UpdateLogoAsync(LogoPathDTO logoPathDTO);

        // Method to update Footer Logo
        Task<ResponseDTO<NoContent>> UpdateFooterLogoAsync(FooterLogoPathDTO footerLogoPathDTO);

        // Method to update Banner 1
        Task<ResponseDTO<NoContent>> UpdateBanner1Async(Banner1PathDTO banner1PathDTO);

        // Method to update Banner 2
        Task<ResponseDTO<NoContent>> UpdateBanner2Async(Banner2PathDTO banner2PathDTO);

        // Method to update Banner 3
        Task<ResponseDTO<NoContent>> UpdateBanner3Async(Banner3PathDTO banner3PathDTO);

        // Method to update About Banner
        Task<ResponseDTO<NoContent>> UpdateAboutBannerAsync(AboutBannerPathDTO aboutBannerPathDTO);

        // Method to update About Photo
        Task<ResponseDTO<NoContent>> UpdateAboutPhotoAsync(AboutPhotoPathDTO aboutPhotoPathDTO);

        // Method to update Contact Banner
        Task<ResponseDTO<NoContent>> UpdateContactBannerAsync(ContactBannerPathDTO contactBannerPathDTO);
    


}
}
