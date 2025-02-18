using eshop_Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace eshop_Entity.Contcrete
{
    public class BasketItem :BaseEntity
    {
        public int BasketId { get; set; }

        public Basket Basket { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public decimal DiscountedPrice { get; set; } 
        public int Quantity { get; set; } = 1;
    }
}
