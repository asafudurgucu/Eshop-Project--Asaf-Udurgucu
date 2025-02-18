using System;
using eshop_MVC.Models;

namespace eshop_MVC.Abstract;

public interface ICommentService
{
    Task<CommentModel> CreateCommentAsync(CreateCommentModel createCommentModel);
    Task<IEnumerable<CommentModel>> GetCommentsByProductIdAsync(int productId);
    Task<IEnumerable<CommentModel>> GetAllComments();
    Task<string> DeleteComment(int commentId);


}
