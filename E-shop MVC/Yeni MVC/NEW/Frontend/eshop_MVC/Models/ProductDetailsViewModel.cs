using System;

namespace eshop_MVC.Models;

public class ProductDetailsViewModel
{
        public ProductModel Product { get; set; }
        public IEnumerable<CommentModel> Comments { get; set; }
}
