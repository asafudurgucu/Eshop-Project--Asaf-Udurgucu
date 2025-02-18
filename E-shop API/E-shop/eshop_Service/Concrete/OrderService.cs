using System;
using System.Security.Claims;
using AutoMapper;
using eshop_Data.Abstract;
using eshop_Entity.Contcrete;
using eshop_Service.Abstract;
using eshop_Shared.ComplexTypes;
using eshop_Shared.DTOs;
using eshop_Shared.ResponseDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace eshop_Service.Concrete;

public class OrderService : IOrderService
{
    private readonly IGenericRepository<Order> _orderRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly IBasketService _basketService;
    private readonly ICouponService _couponService;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public OrderService(IGenericRepository<Order> orderRepository, IUnitOfWork unitOfWork, IMapper mapper, IBasketService basketService, ICouponService couponService, IHttpContextAccessor httpContextAccessor)
    {
        _orderRepository = orderRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _basketService = basketService;
        _couponService = couponService;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<ResponseDTO<OrderDTO>> CreateOrder(OrderCreateDTO orderCreateDTO)
    {
        foreach (var item in orderCreateDTO.OrderItems)
        {
            var product = await _unitOfWork.GetRepository<Product>().GetByIdAsync(item.ProductId);
            if (product == null)
            {
                return ResponseDTO<OrderDTO>.Fail($"{item.ProductId} id li ürün veritabanında bulunamadı :( ", 404);
            }
        }

        // Kullanıcının sepetini al
        var basket = await _unitOfWork.GetRepository<Basket>()
            .GetAsync(b => b.ApplicationUserId == orderCreateDTO.ApplicationUserId,
                      query => query.Include(x => x.BasketItems).ThenInclude(bi => bi.Product));
        if (basket == null)
        {
            return ResponseDTO<OrderDTO>.Fail("Sepet bulunamadı", 404);
        }

        // Sepetin toplam tutarını hesapla
        var totalAmount = basket.BasketItems.Sum(item =>
            (item.DiscountedPrice > 0 ? item.DiscountedPrice : item.Product.Price) * item.Quantity);

        // Sipariş oluştur
        var order = _mapper.Map<Order>(orderCreateDTO);
        order.TotalAmount = totalAmount; // Sepetin toplam tutarını siparişe ayarla

        await _orderRepository.AddAsync(order);
        await _unitOfWork.SaveAsync();

        foreach (var item in order.OrderItems)
        {
            item.OrderId = order.Id;
        }

        _orderRepository.Update(order);
        await _unitOfWork.SaveAsync();
        await _basketService.ClearBasketAsync(order.ApplicationUserId);

        var orderDto = _mapper.Map<OrderDTO>(order);

        return ResponseDTO<OrderDTO>.Success(orderDto, 204);
    }










    public async Task<ResponseDTO<NoContent>> DeleteOrder(int id)
  {
      var order = await _orderRepository.GetByIdAsync(id);
      if (order == null)
      {
          return ResponseDTO<NoContent>.Fail("İlgili Sipariş Kaydı Bulunamadı", 404);
      }
      _orderRepository.Delete(order);
      await _unitOfWork.SaveAsync();
      return ResponseDTO<NoContent>.Success(200);

  }

  public async Task<ResponseDTO<OrderDTO>> GetOrderAsync(int id)
  {
      var order = await _orderRepository.GetAsync(x=>x.Id==id,query=>query.Include(o=>o.OrderItems).ThenInclude(oi=>oi.Product));
      if (order == null)
      {
          return ResponseDTO<OrderDTO>.Fail("İlgili Sipariş Kaydı Bulunamadı", 404);
      }
      var orderDTO = _mapper.Map<OrderDTO>(order);
      return ResponseDTO<OrderDTO>.Success(orderDTO, 200);

  }

    public async Task<ResponseDTO<int>> GetOrderCountAsync()
    {
        var count = await _orderRepository.CountAsync();

        if (count == 0)
        {
            return ResponseDTO<int>.Fail("Herhangi Bir Sipariş Kaydı Bulunamadı", 404);
        }

        return ResponseDTO<int>.Success(count, 200);
    }

    public async Task<ResponseDTO<Dictionary<string, int>>> GetOrderCountByStatusAsync()
    {
        var pendingCount = await _orderRepository.CountAsync(x => x.OrderStatus == OrderStatus.Pending);
        var processingCount = await _orderRepository.CountAsync(x => x.OrderStatus == OrderStatus.Processing);
        var shippedCount = await _orderRepository.CountAsync(x => x.OrderStatus == OrderStatus.Shipped);
        var deliveredCount = await _orderRepository.CountAsync(x => x.OrderStatus == OrderStatus.Delivered);
        var cancelledCount = await _orderRepository.CountAsync(x => x.OrderStatus == OrderStatus.Cancelled);
        var returnedCount = await _orderRepository.CountAsync(x => x.OrderStatus == OrderStatus.Returned);
        var failedCount = await _orderRepository.CountAsync(x => x.OrderStatus == OrderStatus.Failed);

        var statusCounts = new Dictionary<string, int>
    {
        { "Beklemede", pendingCount },
        { "İşleniyor", processingCount },
        { "Kargoya Verildi", shippedCount },
        { "Teslim Edildi", deliveredCount },
        { "İptal Edildi", cancelledCount },
        { "İade Edildi", returnedCount },
        { "Başarısız", failedCount }
    };

        if (statusCounts.Values.All(count => count == 0))
        {
            return ResponseDTO<Dictionary<string, int>>.Fail("Herhangi Bir Sipariş Kaydı Bulunamadı", 404);
        }

        return ResponseDTO<Dictionary<string, int>>.Success(statusCounts, 200);
    }


    public async Task<ResponseDTO<IEnumerable<OrderDTO>>> GetOrdersAsync()
    {
        var orders = await _orderRepository.GetAllAsync();

        if (orders == null || !orders.Any())
        {
            return ResponseDTO<IEnumerable<OrderDTO>>.Fail("Herhangi Bir Sipariş Kaydı Bulunamadı", 404);
        }

        var orderDTOs = _mapper.Map<IEnumerable<OrderDTO>>(orders);

        

        return ResponseDTO<IEnumerable<OrderDTO>>.Success(orderDTOs, 200);
    }




    public async Task<ResponseDTO<IEnumerable<OrderDTO>>> GetOrdersAsync(OrderStatus orderStatus)
  {
        var orders = await _orderRepository.GetAllAsync(x => x.OrderStatus == orderStatus, null, null, query => query.Include(o => o.OrderItems).ThenInclude(oi => oi.Product));
        if (orders == null || !orders.Any())
      {
          return ResponseDTO<IEnumerable<OrderDTO>>.Fail("Belirtilen Duruma Ait Hiç Sipariş Bulunamadı", 404);
      }
      var orderDTOs = _mapper.Map<IEnumerable<OrderDTO>>(orders);
      return ResponseDTO<IEnumerable<OrderDTO>>.Success(orderDTOs, 200);
  }

  public async Task<ResponseDTO<IEnumerable<OrderDTO>>> GetOrdersAsync(string applicationUserId)
  {
        var orders = await _orderRepository.GetAllAsync(x => x.ApplicationUserId == applicationUserId, x => x.OrderByDescending(y => y.CreatedDate), null, query => query.Include(o => o.OrderItems).ThenInclude(oi => oi.Product));
        if (orders == null || !orders.Any())
      {
          return ResponseDTO<IEnumerable<OrderDTO>>.Fail("Herhangi Bir Sipariş Kaydı Bulunamadı", 404);
      }
      var orderDTOs = _mapper.Map<IEnumerable<OrderDTO>>(orders);
      return ResponseDTO<IEnumerable<OrderDTO>>.Success(orderDTOs, 200);
  }

  public async Task<ResponseDTO<IEnumerable<OrderDTO>>> GetOrdersAsync(DateTime startDate, DateTime endDate)
  {
        var order = await _orderRepository.GetAllAsync(x => x.CreatedDate >= startDate && x.CreatedDate <= endDate, null, null, query => query.Include(o => o.OrderItems).ThenInclude(oi => oi.Product));
        if (order == null || !order.Any())
      {
          return ResponseDTO<IEnumerable<OrderDTO>>.Fail("Herhangi Bir Sipariş Kaydı Bulunamadı", 404);
      }
      var orderDTOs = _mapper.Map<IEnumerable<OrderDTO>>(order);
      return ResponseDTO<IEnumerable<OrderDTO>>.Success(orderDTOs, 200);
  }

    public async Task<ResponseDTO<IEnumerable<OrderDTO>>> GetOrdersByStatusButUser(OrderStatus orderStatus, string applicaitonUserId)
    {
        var applicationUserId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);

        if (string.IsNullOrEmpty(applicationUserId))
        {
            return ResponseDTO<IEnumerable<OrderDTO>>.Fail("Kullanıcı kimliği bulunamadı", 401);
        }

        var orders = await _orderRepository.GetAllAsync(
            x => x.OrderStatus == orderStatus && x.ApplicationUserId == applicationUserId,
            x => x.OrderByDescending(y => y.CreatedDate),
            null,
            query => query.Include(o => o.OrderItems).ThenInclude(oi => oi.Product)
        );

        if (orders == null || !orders.Any())
        {
            return ResponseDTO<IEnumerable<OrderDTO>>.Fail("Belirtilen kullanıcıya ait bu duruma sahip sipariş bulunamadı", 404);
        }

        var orderDTOs = _mapper.Map<IEnumerable<OrderDTO>>(orders);
        return ResponseDTO<IEnumerable<OrderDTO>>.Success(orderDTOs, 200);
    }

    public async Task<ResponseDTO<string>> GetOrderStatus(int id)
  {
      var order = await _orderRepository.GetByIdAsync(id);
      if (order == null)
      {
          return ResponseDTO<string>.Fail("İlgili Sipariş Kaydı Bulunamadı", 404);
      }
      var status = order.OrderStatus.ToString();
      return ResponseDTO<string>.Success(status, 200);

  }

  public async Task<ResponseDTO<NoContent>> UpdateOrder(OrderUpdateDTO orderUpdateDTO)
  {
      var order = await _orderRepository.GetAsync(x=>x.Id==orderUpdateDTO.Id,query=>query.Include(x=>x.OrderItems).ThenInclude(o=>o.Product));
      if (order == null)
      {
          return ResponseDTO<NoContent>.Fail("İlgili Sipariş Kaydı Bulunamadı", 404);
      }
      order.OrderItems.Clear();
      _orderRepository.Update(order);
      await _unitOfWork.SaveAsync(); 

      order.OrderItems = orderUpdateDTO.OrderItems.Select(oi=>new OrderItem
      {
          Id = oi.Id,
          ModifiedDate = DateTime.Now,
          Quantity = oi.Quantity,
          UnitPrice = oi.UnitPrice
      }).ToList();
      _orderRepository.Update(order);
      await _unitOfWork.SaveAsync();
      return ResponseDTO<NoContent>.Success(200);
  }

  public async Task<ResponseDTO<NoContent>> UpdateOrderStatusAsync(int id, OrderStatus orderStatus)
  {
      var order = await _orderRepository.GetByIdAsync(id);
      if (order == null) 
      {
          return ResponseDTO<NoContent>.Fail("İlgili Sipariş Kaydı Bulunamadı", 404);
      }
      order.OrderStatus = orderStatus;
      _orderRepository.Update(order);
      await _unitOfWork.SaveAsync();
      return ResponseDTO<NoContent>.Success(200);
  }
}
