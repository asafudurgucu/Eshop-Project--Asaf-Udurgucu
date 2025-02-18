using eshop_MVC.Models;

namespace eshop_MVC.Abstract
{
    public interface IBasketService
    {
        Task ApplyCoupon(string couponCode, string applicationUserId);
        Task<BasketModel> GetBasket(string applicationUserId);
        Task AddToBasket(BasketItemModel item);
        Task RemoveFromBasket(int basketItemId);
        Task<String> ClearFromBasket(string applicationUserId);
        Task<String> QuantityUpdate(int quantity,int basketItemId);
        Task CreateBasket(CreateBasketModel createBasketModel);
        Task<bool> CheckBasketExists(string userId);

    }
}
