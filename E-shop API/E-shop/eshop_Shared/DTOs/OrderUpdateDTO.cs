using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop_Shared.DTOs
{
    public class OrderUpdateDTO
    {

        public int Id { get; set; }
        public string ApplicationUserId { get; set; }
        public List<OrderItemDTO> OrderItems { get; set; }
        public decimal TotalAmount => OrderItems.Sum(item => item.UnitPrice * item.Quantity);
    }
}
