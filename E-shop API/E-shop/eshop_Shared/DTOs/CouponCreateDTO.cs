using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop_Shared.DTOs
{
    public class CouponCreateDTO
    {
        public string Code { get; set; }
        public int DiscountPercentage { get; set; }
    }
}
