using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop_Shared.DTOs
{
    public class ContactMessageDTO
    {
        public string CName { get; set; }
        public string CEmail { get; set; }
        public string CMessage { get; set; }
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;


    }
}
