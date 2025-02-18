using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using eshop_Data.Abstract;
using eshop_Entity.Contcrete;
using eshop_Service.Abstract;
using eshop_Shared.DTOs;
using eshop_Shared.ResponseDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace eshop_Service.Concrete
{
    public class CommentService : ICommentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Comment> _genericRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CommentService(IUnitOfWork unitOfWork, IMapper mapper, IGenericRepository<Comment> genericRepository, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _genericRepository = genericRepository;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<ResponseDTO<CommentDTO>> CreateCommentAsync(CreateCommentDTO createCommentDto)
        {
            try
            {
                var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (string.IsNullOrEmpty(userId))
                {
                    return ResponseDTO<CommentDTO>.Fail("User is not authenticated", 401);
                }

                var comment = _mapper.Map<Comment>(createCommentDto);
                comment.ApplicationUserId = userId;
                comment.CreatedDate = DateTime.Now;

                await _genericRepository.AddAsync(comment);
                await _unitOfWork.SaveAsync();

                var commentDto = _mapper.Map<CommentDTO>(comment);

                return ResponseDTO<CommentDTO>.Success(commentDto, 200);
            }
            catch (Exception ex)
            {
                return ResponseDTO<CommentDTO>.Fail("An error occurred while creating the comment: " + ex.Message, 500);
            }
        }

        public async Task<ResponseDTO<NoContent>> DeleteCommentAsync(int commentId)
        {
            try
            {
                
                var comment = await _genericRepository.GetByIdAsync(commentId);
                if (comment == null)
                {
                    return ResponseDTO<NoContent>.Fail("Comment not found", 404);
                }

                
                 _genericRepository.Delete(comment);
                await _unitOfWork.SaveAsync();

                return ResponseDTO<NoContent>.Success(204); 
            }
            catch (Exception ex)
            {
                return ResponseDTO<NoContent>.Fail("An error occurred while deleting the comment: " + ex.Message, 500);
            }
        }

        public async Task<ResponseDTO<IEnumerable<CommentDTO>>> GetAllCommentAsync()
        {
            try
            {
                
                var comments = await _genericRepository.GetAllAsync(
                    includes: query => query.Include(c => c.ApplicationUser) 
                );

                
                var commentDtos = comments.Select(comment => new CommentDTO
                {
                    Id = comment.Id,
                    ProductId = comment.ProductId,
                    ApplicationUserId = comment.ApplicationUserId,
                    Content = comment.Content,
                    Rating = comment.Rating,
                    CreatedDate = comment.CreatedDate,
                    Name = comment.ApplicationUser?.FirstName, 
                    LastName = comment.ApplicationUser?.LastName,
                    ProfileImageUrl = comment.ApplicationUser?.ProfilePictureUrl
                }).ToList();

                return ResponseDTO<IEnumerable<CommentDTO>>.Success(commentDtos, 200);
            }
            catch (Exception ex)
            {
                return ResponseDTO<IEnumerable<CommentDTO>>.Fail("An error occurred while retrieving the comments: " + ex.Message, 500);
            }
        }

        public async Task<ResponseDTO<IEnumerable<CommentDTO>>> GetCommentsByProductIdAsync(int productId)
{
    try
    {
        var comments = await _genericRepository.GetAllAsync(
            c => c.ProductId == productId,
            includes: query => query.Include(c => c.ApplicationUser) // Kullanıcı bilgilerini çek
        );

        var commentDtos = comments.Select(comment => new CommentDTO
        {
            Id = comment.Id,
            ProductId = comment.ProductId,
            ApplicationUserId = comment.ApplicationUserId,
            Content = comment.Content,
            Rating = comment.Rating,
            CreatedDate = comment.CreatedDate,
            Name = comment.ApplicationUser?.FirstName, // Kullanıcı bilgilerini DTO'ya aktar
            LastName = comment.ApplicationUser?.LastName,
            ProfileImageUrl = comment.ApplicationUser?.ProfilePictureUrl
        }).ToList();

        return ResponseDTO<IEnumerable<CommentDTO>>.Success(commentDtos, 200);
    }
    catch (Exception ex)
    {
        return ResponseDTO<IEnumerable<CommentDTO>>.Fail("An error occurred while retrieving the comments: " + ex.Message, 500);
    }
}





    }
}