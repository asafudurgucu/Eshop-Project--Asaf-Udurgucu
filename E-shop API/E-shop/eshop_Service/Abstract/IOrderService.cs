using System;
using eshop_Shared.ComplexTypes;
using eshop_Shared.DTOs;
using eshop_Shared.ResponseDTOs;

namespace eshop_Service.Abstract;

public interface IOrderService
{

        Task<ResponseDTO<OrderDTO>> GetOrderAsync(int id);
        Task<ResponseDTO<IEnumerable<OrderDTO>>> GetOrdersAsync();
        Task<ResponseDTO<IEnumerable<OrderDTO>>> GetOrdersAsync(OrderStatus orderStatus);
        Task<ResponseDTO<IEnumerable<OrderDTO>>> GetOrdersAsync(string applicationUserId);
        Task<ResponseDTO<IEnumerable<OrderDTO>>> GetOrdersAsync(DateTime startDate,DateTime endDate);
        Task<ResponseDTO<OrderDTO>> CreateOrder(OrderCreateDTO orderCreateDTO);
        Task<ResponseDTO<NoContent>> UpdateOrder(OrderUpdateDTO orderUpdateDTO);
        Task<ResponseDTO<NoContent>> DeleteOrder(int id);
        Task<ResponseDTO<String>> GetOrderStatus (int id) ;
        Task<ResponseDTO<NoContent>> UpdateOrderStatusAsync (int id,OrderStatus orderStatus);
        Task<ResponseDTO<int>> GetOrderCountAsync();
        Task<ResponseDTO<Dictionary<string, int>>> GetOrderCountByStatusAsync();
        Task<ResponseDTO<IEnumerable<OrderDTO>>> GetOrdersByStatusButUser(OrderStatus orderStatus, string applicationUserId);

}
