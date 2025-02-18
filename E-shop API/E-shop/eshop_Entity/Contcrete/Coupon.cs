using eshop_Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop_Entity.Contcrete
{
    public class Coupon:BaseEntity
    {
        public string Code { get; set; }  
        public int DiscountPercentage { get; set; }

    }
}
