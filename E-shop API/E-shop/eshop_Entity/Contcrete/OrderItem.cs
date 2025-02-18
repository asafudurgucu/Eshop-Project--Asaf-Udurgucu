using eshop_Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop_Entity.Contcrete
{
    public class OrderItem  :BaseEntity
    {

        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public  Product Product { get; set; }
        public  Order Order { get; set; }
    }
}
