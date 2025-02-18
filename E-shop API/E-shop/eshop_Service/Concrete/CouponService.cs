using AutoMapper;
using eshop_Data.Abstract;
using eshop_Entity.Contcrete;
using eshop_Service.Abstract;
using eshop_Shared.DTOs;
using eshop_Shared.ResponseDTOs;

public class CouponService : ICouponService
{
    private readonly IGenericRepository<Coupon> _couponRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CouponService(IGenericRepository<Coupon> couponRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _couponRepository = couponRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<ResponseDTO<decimal>> ApplyCouponAsync(CouponApplyDTO couponApplyDto)
    {
        var coupon = await _couponRepository.GetAsync(c => c.Code == couponApplyDto.Code);

        if (coupon == null)
            return ResponseDTO<decimal>.Fail("Invalid coupon code", 404);

        var discountAmount = (couponApplyDto.TotalAmount * coupon.DiscountPercentage) / 100;
        var discountedAmount = couponApplyDto.TotalAmount - discountAmount;

        return ResponseDTO<decimal>.Success(discountedAmount, 200);
    }

    public async Task<ResponseDTO<CouponDTO>> CreateCouponAsync(CouponCreateDTO couponCreateDto)
    {
        var coupon = new Coupon
        {
            Code = couponCreateDto.Code,
            DiscountPercentage = couponCreateDto.DiscountPercentage
        };

        await _couponRepository.AddAsync(coupon);
        await _unitOfWork.SaveAsync();

        var couponDto = _mapper.Map<CouponDTO>(coupon);
        return ResponseDTO<CouponDTO>.Success(couponDto, 200);
    }

    public async Task<ResponseDTO<NoContent>> DeleteCouponAsync(int code)
    {
        var coupon = await _couponRepository.GetAsync(c => c.Id == code);

        if (coupon == null)
            return ResponseDTO<NoContent>.Fail("Coupon not found", 404);

         _couponRepository.Delete(coupon); 
        await _unitOfWork.SaveAsync();

        return ResponseDTO<NoContent>.Success(204);
    }

    public async Task<ResponseDTO<CouponDTO>> GetCouponByCodeAsync(string code)
    {
        var coupon = await _couponRepository.GetAsync(c => c.Code == code);

        if (coupon == null)
            return ResponseDTO<CouponDTO>.Fail("Coupon not found", 404);

        var couponDto = _mapper.Map<CouponDTO>(coupon);
        return ResponseDTO<CouponDTO>.Success(couponDto, 200);
    }

    public async Task<ResponseDTO<List<CouponDTO>>> GetCouponsAsync()
    {
        var coupons = await _couponRepository.GetAllAsync();
        var couponDtos = _mapper.Map<List<CouponDTO>>(coupons);

        return ResponseDTO<List<CouponDTO>>.Success(couponDtos, 200);
    }
}
