using System;
using Azure;
using eshop_Shared.DTOs;
using eshop_Shared.DTOs.Auth;
using eshop_Shared.ResponseDTOs;
using Microsoft.AspNetCore.Http;

namespace eshop_Service.Abstract;

public interface IAuthService
{
    Task<ResponseDTO<TokenDTO>> LoginAsync(LoginDTO loginDTO);
    Task<ResponseDTO<NoContent>> RegisterAsync(RegisterDTO registerDTO);
   
    Task<ResponseDTO<ApplicationUserDTO>> GetUserAsync();
    Task<ResponseDTO<ApplicationUserDTO>> GetOrderUserAsync(string applicationUserId);
    Task<ResponseDTO<IEnumerable<ApplicationUserDTO>>> GetAllUsers();
    Task<ResponseDTO<NoContent>> UpdateUser(ApplicationUserUpdateDTO userUpdateDTO);
    Task<ResponseDTO<NoContent>> UpdateUserProfilePicture(ApplicationUserProfilePictureDTO profilePictureDTO);
    Task<ResponseDTO<int>> GetUserCount();
    Task<ResponseDTO<NoContent>> DeleteUser(string applicationUserId);

    Task<ResponseDTO<ApplicationUserDTO>> GetUserButIdAsync(string applicationUserId);





}
