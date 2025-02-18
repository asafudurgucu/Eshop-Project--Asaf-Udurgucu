using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop_Shared.DTOs
{
    public class PaymentDTO
    {
        public string cardUserName { get; set; }
        public string cardNumber { get; set; }
        public decimal CVV { get; set; }
        public string CardDate { get; set; }
    }
}
