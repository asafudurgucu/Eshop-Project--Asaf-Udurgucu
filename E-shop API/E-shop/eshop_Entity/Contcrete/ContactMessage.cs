using eshop_Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop_Entity.Contcrete
{
    public class ContactMessage:BaseEntity
    {
        public string CName { get; set; }
        public string CEmail { get; set; }
        public string CMessage { get; set; }

    }
}
