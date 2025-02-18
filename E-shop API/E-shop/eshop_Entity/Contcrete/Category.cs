using eshop_Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop_Entity.Contcrete
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public string   Description { get; set; }

        public ICollection<ProductCategories> ProductCategories { get; set; } = new HashSet<ProductCategories>();
    }
}
