using eshop_Service.Abstract;
using eshop_Shared.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eshop_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateCommentAsync(CreateCommentDTO createCommentDto)
        {
            var response = await _commentService.CreateCommentAsync(createCommentDto);
            if (response.IsSucceded)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        [HttpGet("{productId}")]
        public async Task<IActionResult> GetCommentsByProductIdAsync(int productId)
        {
            var response = await _commentService.GetCommentsByProductIdAsync(productId);
            if (response.IsSucceded)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        [HttpDelete("{commentId}")]
        [Authorize(Roles = "AdminUser")]
        public async Task<IActionResult> DeleteCommentAsync(int commentId)
        {
            var response = await _commentService.DeleteCommentAsync(commentId);
            if (response.IsSucceded)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAllCommentAsync()
        {
            var response = await _commentService.GetAllCommentAsync();
            if (response.IsSucceded)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }
    }
}
