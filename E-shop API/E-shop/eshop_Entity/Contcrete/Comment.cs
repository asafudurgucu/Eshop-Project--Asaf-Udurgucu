using System;
using eshop_Entity.Abstract;

namespace eshop_Entity.Contcrete;

public class Comment :BaseEntity
{
        public int ProductId { get; set; }
        public string ApplicationUserId { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
        public virtual Product Product { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

}
