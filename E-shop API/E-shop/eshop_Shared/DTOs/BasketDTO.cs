using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop_Shared.DTOs
{
    public class BasketDTO

    {
        public int Id { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUserDTO ApplicationUser { get; set; }
        public decimal TotalAmount => BasketItems.Sum(item => (item.DiscountedPrice > 0 ? item.DiscountedPrice : item.product.Price) * item.Quantity);
        public List<BasketItemDTO> BasketItems { get; set; } = new List<BasketItemDTO>();
    }
}
