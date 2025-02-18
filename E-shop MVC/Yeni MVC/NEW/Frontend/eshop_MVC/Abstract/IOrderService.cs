using eshop_MVC.Helpers;
using eshop_MVC.Models;

namespace eshop_MVC.Abstract
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderModel>> GetByUserAsync(string userId);
        Task<OrderModel> GetAsync(int id);
        Task<IEnumerable<OrderModel>> GetAllAsync();
        Task AddAsync(OrderModel model);
        Task DeleteAsync(int id);
        Task UpdateAsync(int id, OrderStatus status);
        Task<IEnumerable<OrderModel>> GetByStatusAsync(OrderStatus status);
        Task<IEnumerable<OrderModel>> GetByDateRangeAsync(DateTime startDate, DateTime endDate, string userId);
        Task<int> GetTotalOrderCountAsync();
        Task<Dictionary<string, int>> GetOrderCountByStatusAsync();
        Task<IEnumerable<OrderModel>> Statusbutuser(OrderStatus status);
    }
}
