using eshop_MVC.Abstract;
using eshop_MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eshop_MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "AdminUser")]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly IProductService _productService;

        public CommentController(ICommentService commentService, IProductService productService)
        {
            _commentService = commentService;
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var comments = await _commentService.GetAllComments();
            var products = await _productService.GetAllAsync();

            var commentList = comments.Select(comment => new CommentWithProductViewModel
            {
                Id = comment.Id,
                ProductId = comment.ProductId,
                ProductName = products.FirstOrDefault(p => p.Id == comment.ProductId)?.Name ?? "Bilinmeyen Ürün",
                ApplicationUserId = comment.ApplicationUserId,
                Name = comment.Name,
                LastName = comment.LastName,
                Content = comment.Content,
                Rating = comment.Rating,
                CreatedDate = comment.CreatedDate,
                ProfileImageUrl = comment.ProfileImageUrl
            }).ToList();

            return View(commentList);
        }


        public async Task<IActionResult> Delete(int id)
        {
            var result = await _commentService.DeleteComment(id);
          
            return RedirectToAction("Index");
        }
    }
}
