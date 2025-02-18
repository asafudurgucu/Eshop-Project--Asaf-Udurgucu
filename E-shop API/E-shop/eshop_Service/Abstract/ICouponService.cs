using eshop_Shared.DTOs;
using eshop_Shared.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop_Service.Abstract
{
     public interface ICouponService
     {
        Task<ResponseDTO<CouponDTO>> GetCouponByCodeAsync(string code);
        Task<ResponseDTO<List<CouponDTO>>> GetCouponsAsync();
        Task<ResponseDTO<CouponDTO>> CreateCouponAsync(CouponCreateDTO couponCreateDto);
        Task<ResponseDTO<decimal>> ApplyCouponAsync(CouponApplyDTO couponApplyDto);
        Task<ResponseDTO<NoContent>> DeleteCouponAsync(int code);
    }
}
