using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop_Shared.DTOs
{
    public class BasketItemDTO
    {
        public int BasketId { get; set; }
        public int Id { get; set; }
        public int ProductId { get; set; }
        public decimal DiscountedPrice { get; set; } 
        public ProductDTO product { get; set; }
        public int Quantity { get; set; }

    }
}
