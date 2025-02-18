using System;
using AutoMapper;
using Azure;
using eshop_Data.Abstract;
using eshop_Entity.Contcrete;
using eshop_Service.Abstract;
using eshop_Shared.DTOs;
using eshop_Shared.ResponseDTOs;
using Microsoft.EntityFrameworkCore;

namespace eshop_Service.Concrete;

public class BasketService : IBasketService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IGenericRepository<Basket> _basketRepository;
    private readonly IMapper _mapper;
    private readonly ICouponService _couponService;

    public BasketService(IUnitOfWork unitOfWork, IGenericRepository<Basket> basketRepository, IMapper mapper, ICouponService couponService)
    {
        _unitOfWork = unitOfWork;
        _basketRepository = basketRepository;
        _mapper = mapper;
        _couponService = couponService;
    }

    public async Task<ResponseDTO<BasketDTO>> ApplyCouponToBasketAsync(BasketDTO basket, string couponCode)
    {
        // Kupon kodunun geçerli olup olmadığını kontrol et
        var coupon = await _couponService.GetCouponByCodeAsync(couponCode);
        if (coupon == null)
        {
            return ResponseDTO<BasketDTO>.Fail(couponCode + " kodlu kupon bulunamadı", 404);
        }

        // İndirim yüzdesi
        var discountPercentage = coupon.Data?.DiscountPercentage ?? 0;

        // Sepeti güncellemek için mevcut sepeti veritabanından al
        var existingBasket = await _basketRepository.GetAsync(b => b.Id == basket.Id, query => query.Include(x => x.BasketItems).ThenInclude(bi => bi.Product));
        if (existingBasket == null)
        {
            return ResponseDTO<BasketDTO>.Fail("Sepet bulunamadı", 404);
        }

        // Sepetteki her ürüne indirim uygula ve toplam fiyatı hesapla
        foreach (var item in existingBasket.BasketItems)
        {
            // Toplam fiyat üzerinden indirim hesapla
            var totalItemPrice = item.Product.Price * item.Quantity;
            var discountAmount = (totalItemPrice * discountPercentage) / 100;

            // İndirimli toplam fiyatı hesapla
            var discountedTotalPrice = totalItemPrice - discountAmount;

            // İndirimli fiyatı birim fiyat olarak güncelle
            item.DiscountedPrice = discountedTotalPrice / item.Quantity;
        }

        // Sepeti güncelle ve değişiklikleri kaydet
        _basketRepository.Update(existingBasket);
        await _unitOfWork.SaveAsync();

        // Güncellenmiş sepeti döndür
        var updatedBasketDTO = _mapper.Map<BasketDTO>(existingBasket);
        return ResponseDTO<BasketDTO>.Success(updatedBasketDTO, 200);
    }






    public async Task<ResponseDTO<BasketItemDTO>> AddProductAsync(BasketItemCreateDTO basketItemCreateDTO)
    {
        var basket = await _basketRepository.GetAsync(b=>b.Id==basketItemCreateDTO.BasketId, query=>query.Include(x=>x.BasketItems).ThenInclude(bi=>bi.Product));
        if (basket == null)
        {
            return ResponseDTO<BasketItemDTO>.Fail("Sepet Bulunamadı", 404);
        }
        var product = await _unitOfWork.GetRepository<Product>().GetByIdAsync(basketItemCreateDTO.ProductId);
        if(product == null)
        {
            return ResponseDTO<BasketItemDTO>.Fail("Ürün Bulunamadı", 404);
        }
        var existingBasketItem = basket.BasketItems.FirstOrDefault(x => x.ProductId == basketItemCreateDTO.ProductId);
        if (existingBasketItem != null)
        {
            existingBasketItem.Quantity = basketItemCreateDTO.Quantity;
            _basketRepository.Update(basket);
            await _unitOfWork.SaveAsync();
            var updatedBasketItem = _mapper.Map<BasketItemDTO>(existingBasketItem);
            return ResponseDTO<BasketItemDTO>.Success(_mapper.Map<BasketItemDTO>(existingBasketItem), 200);
        }
        var basketItem = _mapper.Map<BasketItem>(basketItemCreateDTO);
        basket.BasketItems.Add(basketItem);
        _basketRepository.Update(basket);
        await _unitOfWork.SaveAsync();
        var createdBasketItem = _mapper.Map<BasketItemDTO>(basketItem);
        return ResponseDTO<BasketItemDTO>.Success(createdBasketItem, 201);

    }

    public async Task<ResponseDTO<NoContent>> ChangeQuantityBasketAsync(BasketItemChangeQuantityDTO basketItemChangeQuantityDTO)
    {
       var basketItem = await _unitOfWork.GetRepository<BasketItem>().GetByIdAsync(basketItemChangeQuantityDTO.BasketItemID);
       if (basketItem == null)
       {
           return ResponseDTO<NoContent>.Fail("Ürün Bulunamadı", 404);
       }
         basketItem.Quantity = basketItemChangeQuantityDTO.Quantity;
         _unitOfWork.GetRepository<BasketItem>().Update(basketItem);
        await _unitOfWork.SaveAsync();
         return  ResponseDTO<NoContent>.Success(200);
    }

    public async Task<bool> CheckBasketExistsAsync(string userId)
    {
        // Kullanıcının sepetinin olup olmadığını kontrol ediyoruz
        var basket = await _unitOfWork.GetRepository<Basket>()
                                      .GetAllAsync(b => b.ApplicationUserId == userId); // Sepetleri filtrele

        return basket.Any(); // Eğer herhangi bir sepet varsa true döners
    }




    public async Task<ResponseDTO<NoContent>> ClearBasketAsync(string applicationUserId)
    {
        var basket = await _basketRepository.GetAsync(b => b.ApplicationUserId == applicationUserId, query => query.Include(x => x.BasketItems).ThenInclude(bi => bi.Product));
        if (basket == null)
        {
            return ResponseDTO<NoContent>.Fail("Sepet Bulunamadı", 404);
        }
        basket.BasketItems.Clear();
        _basketRepository.Update(basket);
        await _unitOfWork.SaveAsync();
        return ResponseDTO<NoContent>.Success(200);

    }

    public async Task<ResponseDTO<BasketDTO>> CreateBasketAsync(BasketCreateDTO basketCreateDTO)
    {
        var basket = _mapper.Map<Basket>(basketCreateDTO);
        await _basketRepository.AddAsync(basket);
        await _unitOfWork.SaveAsync();
        return ResponseDTO<BasketDTO>.Success(_mapper.Map<BasketDTO>(basket), 201);
    }

    public async Task<ResponseDTO<IEnumerable<BasketDTO>>> GetAllBasketAsync()
    {
        var basket = await _basketRepository.GetAllAsync();
        if (basket == null)
        {
            return ResponseDTO<IEnumerable<BasketDTO>>.Fail("Sepet Bulunamadı", 404);
        }
        return ResponseDTO<IEnumerable<BasketDTO>>.Success(_mapper.Map<IEnumerable<BasketDTO>>(basket), 200);
        
    }

    public async Task<ResponseDTO<BasketDTO>> GetBasketAsync(string applicationUserId)
    {
        var basket = await _basketRepository.GetAsync(b => b.ApplicationUserId == applicationUserId, query => query.Include(b => b.BasketItems).ThenInclude(bi => bi.Product));
        if (basket == null)
        {
            return ResponseDTO<BasketDTO>.Fail("Sepet Bulunamadı :( ", 404);
        }
        var basketDTO = _mapper.Map<BasketDTO>(basket);
        return ResponseDTO<BasketDTO>.Success(basketDTO, 200);
    }

    public async Task<ResponseDTO<NoContent>> RemoveProductAsync(int basketItemId)
    {
       var basketItem = await _unitOfWork.GetRepository<BasketItem>().GetByIdAsync(basketItemId);
       if (basketItem == null)
       {
           return ResponseDTO<NoContent>.Fail("Ürün Sepette Bulunamadı", 404);
       }
         _unitOfWork.GetRepository<BasketItem>().Delete(basketItem);
        await _unitOfWork.SaveAsync();
        return  ResponseDTO<NoContent>.Success(200);

    }
}
