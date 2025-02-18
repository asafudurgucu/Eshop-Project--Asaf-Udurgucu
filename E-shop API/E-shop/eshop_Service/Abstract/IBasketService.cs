using System;
using eshop_Entity.Contcrete;
using eshop_Shared.DTOs;
using eshop_Shared.ResponseDTOs;

namespace eshop_Service.Abstract;

public interface IBasketService
{
    Task<ResponseDTO<BasketDTO>> ApplyCouponToBasketAsync(BasketDTO basket, string couponCode);
    Task<ResponseDTO<BasketDTO>> GetBasketAsync(string applicationUserId);
    Task<ResponseDTO<IEnumerable<BasketDTO>>> GetAllBasketAsync();
    Task<ResponseDTO<BasketDTO>> CreateBasketAsync(BasketCreateDTO basketCreateDTO);
    Task<ResponseDTO<NoContent>> ClearBasketAsync(string applicationUserId);
    Task<ResponseDTO<BasketItemDTO>> AddProductAsync(BasketItemCreateDTO basketItemCreateDTO);
    Task<ResponseDTO<NoContent>> RemoveProductAsync(int basketItemId);
    Task<ResponseDTO<NoContent>> ChangeQuantityBasketAsync(BasketItemChangeQuantityDTO basketItemChangeQuantityDTO);
    Task<bool> CheckBasketExistsAsync(string userId);


}
