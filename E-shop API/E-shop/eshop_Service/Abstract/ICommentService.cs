using System;
using eshop_Shared.DTOs;
using eshop_Shared.ResponseDTOs;

namespace eshop_Service.Abstract;

public interface ICommentService
{
    Task<ResponseDTO<CommentDTO>> CreateCommentAsync(CreateCommentDTO createCommentDto);
    Task<ResponseDTO<IEnumerable<CommentDTO>>> GetCommentsByProductIdAsync(int productId);
    Task<ResponseDTO<NoContent>> DeleteCommentAsync(int commentId);
    Task<ResponseDTO<IEnumerable<CommentDTO>>> GetAllCommentAsync();

}
