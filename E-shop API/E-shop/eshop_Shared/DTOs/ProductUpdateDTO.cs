using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop_Shared.DTOs
{
    public class ProductUpdateDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Properties { get; set; }
        public decimal Price { get; set; }
        public int[] CategoryIds { get; set; } = [];
        public IFormFile Image { get; set; }
       
    }
}
