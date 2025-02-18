using System;
using eshop_MVC.Models;

namespace eshop_MVC.Abstract;

public interface ICouponService
{
    Task<CouponModel> CreateCoupon(CouponCreateModel couponCreateModel);
    Task<List<CouponModel>> GetCouponsAsync();
    Task<CouponModel> GetCouponByCodeAsync(string code);
    Task<bool> Delete(int id);

}
