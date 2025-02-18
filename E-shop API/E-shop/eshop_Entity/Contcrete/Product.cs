using eshop_Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop_Entity.Contcrete
{
    public class Product :BaseEntity
    {
        public string Name { get; set; }
        public string Properties { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<ProductCategories> ProductCategories { get; set; } = new HashSet<ProductCategories>();
        public ICollection<Comment> Comments { get; set; } = new HashSet<Comment>(); 
    }
}
