using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Azure;
using Azure.Core;
using eshop_Entity.Contcrete;
using eshop_Service.Abstract;
using eshop_Service.Configuration;
using eshop_Shared.DTOs;
using eshop_Shared.DTOs.Auth;
using eshop_Shared.ResponseDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace eshop_Service.Concrete
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _configuration;
        private readonly JwtConfig _jwtConfig;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IImageService _ımageService;

        public AuthService(UserManager<ApplicationUser> userManager, IConfiguration configuration, IOptions<JwtConfig> options, IHttpContextAccessor httpContextAccessor, IImageService ımageService)
        {
            _userManager = userManager;
            _configuration = configuration;
            _jwtConfig = options.Value;
            _httpContextAccessor = httpContextAccessor;
            _ımageService = ımageService;
        }

        public async Task<ResponseDTO<TokenDTO>> LoginAsync(LoginDTO loginDTO)
        {
            var user = await _userManager.FindByEmailAsync(loginDTO.Email);
            if (user == null)
            {
                return ResponseDTO<TokenDTO>.Fail("Böyle bir kullanıcı yok", 400);
            }
            var isValidPassword = await _userManager.CheckPasswordAsync(user, loginDTO.Password);
            if (!isValidPassword)
            {
                return ResponseDTO<TokenDTO>.Fail("Hatalı şifre", 400);
            }
            var tokenDTO = await GenerateJwtToken(user);
            return ResponseDTO<TokenDTO>.Success(tokenDTO, 200);
        }

        public async Task<ResponseDTO<NoContent>> RegisterAsync(RegisterDTO registerDTO)
        {
            var existingUser = await _userManager.FindByEmailAsync(registerDTO.Email);
            if (existingUser != null)
            {
                return ResponseDTO<NoContent>.Fail("Bu mail adresi ile kayıtlı kullanıcı mevcut!", 400);
            }

            ApplicationUser applicationUser = new()
            {
                Email = registerDTO.Email,
                FirstName = registerDTO.FirstName,
                LastName = registerDTO.LastName,
                UserName = registerDTO.Email,
                PhoneNumber = registerDTO.PhoneNumber,
                Address = registerDTO.Address,
                City = registerDTO.City,
                DateOfBirth = registerDTO.BirthDay
            };

            var result = await _userManager.CreateAsync(applicationUser, registerDTO.Password);
            if (!result.Succeeded)
            {
                return ResponseDTO<NoContent>.Fail(result.Errors.Select(x => x.Description).ToList(), 500);
            }

            // Kullanıcıyı role atama
            result = await _userManager.AddToRoleAsync(applicationUser, registerDTO.Role);
            if (!result.Succeeded)
            {
                return ResponseDTO<NoContent>.Fail(result.Errors.Select(x => x.Description).ToList(), 500);
            }

            return ResponseDTO<NoContent>.Success(201);
        }

        public async Task<ResponseDTO<ApplicationUserDTO>> GetUserAsync()
        {
            // Header'dan token'ı alıyoruz
            var token = _httpContextAccessor.HttpContext?.Request.Headers["Authorization"].ToString().Replace("Bearer ", "");

            // Token boş veya null ise hata döndür
            if (string.IsNullOrEmpty(token))
            {
                return ResponseDTO<ApplicationUserDTO>.Fail("Token bulunamadı", 400);
            }

            try
            {
                // Token'ı JWT olarak parse ediyoruz
                var handler = new JwtSecurityTokenHandler();
                var jsonToken = handler.ReadToken(token) as JwtSecurityToken;

                // Kullanıcı id'sini claim'den alıyoruz
                var userId = jsonToken?.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;

                // Kullanıcı id'si yoksa hata döndür
                if (string.IsNullOrEmpty(userId))
                {
                    return ResponseDTO<ApplicationUserDTO>.Fail("Kullanıcı kimliği bulunamadı", 400);
                }

                // UserManager ile kullanıcıyı veritabanından buluyoruz
                var user = await _userManager.FindByIdAsync(userId);

                // Kullanıcı bulunamadıysa hata döndür
                if (user == null)
                {
                    return ResponseDTO<ApplicationUserDTO>.Fail("Kullanıcı bulunamadı", 404);
                }

                // Kullanıcıyı DTO'ya dönüştürüyoruz
                var userDTO = new ApplicationUserDTO
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    PhoneNumber = user.PhoneNumber,
                    Address = user.Address,
                    Email = user.Email,
                    City = user.City,
                    DateOfBirth = user.DateOfBirth,
                    ProfilePictureUrl = user.ProfilePictureUrl,
                };

                // Kullanıcıyı başarılı bir şekilde döndürüyoruz
                return ResponseDTO<ApplicationUserDTO>.Success(userDTO, 200);
            }
            catch (Exception ex)
            {
                // Hata durumunda uygun bir mesaj dönüyoruz
                return ResponseDTO<ApplicationUserDTO>.Fail($"Hata oluştu: {ex.Message}", 500);
            }
        }

        private async Task<TokenDTO> GenerateJwtToken(ApplicationUser user)
        {
            var roles = await _userManager.GetRolesAsync(user);

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            }.Union(roles.Select(r => new Claim(ClaimTypes.Role, r))); 

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtConfig.Secret));
            var credential = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiry = DateTime.Now.AddMinutes(_jwtConfig.AccessTokenExpiration);

            var token = new JwtSecurityToken(
                issuer: _jwtConfig.Issuer,
                audience: _jwtConfig.Audience,
                claims: claims,
                expires: expiry,
                signingCredentials: credential
            );

            var tokenDTO = new TokenDTO
            {
                AccessToken = new JwtSecurityTokenHandler().WriteToken(token),
                ExpirationDate = expiry,
            };
            return tokenDTO;
        }

        public async Task<ResponseDTO<NoContent>> UpdateUser(ApplicationUserUpdateDTO userUpdateDTO)
        {
            var token = _httpContextAccessor.HttpContext?.Request.Headers["Authorization"].ToString().Replace("Bearer ", "");

            if (string.IsNullOrEmpty(token))
            {
                return ResponseDTO<NoContent>.Fail("Token bulunamadı", 400);
            }

            try
            {
                var handler = new JwtSecurityTokenHandler();
                var jsonToken = handler.ReadToken(token) as JwtSecurityToken;
                var userId = jsonToken?.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;

                if (string.IsNullOrEmpty(userId))
                {
                    return ResponseDTO<NoContent>.Fail("Kullanıcı kimliği bulunamadı", 400);
                }

                var user = await _userManager.FindByIdAsync(userId);

                if (user == null)
                {
                    return ResponseDTO<NoContent>.Fail("Kullanıcı bulunamadı", 404);
                }

                user.FirstName = userUpdateDTO.FirstName ?? user.FirstName;
                user.LastName = userUpdateDTO.LastName ?? user.LastName;
                user.PhoneNumber = userUpdateDTO.PhoneNumber ?? user.PhoneNumber;
                user.Address = userUpdateDTO.Address ?? user.Address;
                user.City = userUpdateDTO.City ?? user.City;

                var result = await _userManager.UpdateAsync(user);
                if (!result.Succeeded)
                {
                    return ResponseDTO<NoContent>.Fail(result.Errors.Select(x => x.Description).ToList(), 500);
                }

                return ResponseDTO<NoContent>.Success(200);
            }
            catch (Exception ex)
            {
                return ResponseDTO<NoContent>.Fail($"Hata oluştu: {ex.Message}", 500);
            }
        }



        public async Task<ResponseDTO<ApplicationUserDTO>> GetOrderUserAsync(string applicationUserId)
        {
           if (string.IsNullOrEmpty(applicationUserId))
    {
        return ResponseDTO<ApplicationUserDTO>.Fail("Kullanıcı kimliği sağlanmadı", 400);
    }

    try
    {
        // UserManager ile kullanıcıyı veritabanından buluyoruz
        var user = await _userManager.FindByIdAsync(applicationUserId);

        // Kullanıcı bulunamadıysa hata döndürüyoruz
        if (user == null)
        {
            return ResponseDTO<ApplicationUserDTO>.Fail("Kullanıcı bulunamadı", 404);
        }

        // Kullanıcıyı DTO'ya dönüştürüyoruz
        var userDTO = new ApplicationUserDTO
        {
            FirstName = user.FirstName,
            LastName = user.LastName,
            PhoneNumber = user.PhoneNumber,
            Email = user.Email,
            Address = user.Address,
            City = user.City,
            DateOfBirth = user.DateOfBirth,
            ProfilePictureUrl = user.ProfilePictureUrl,
        };

        // Kullanıcıyı başarılı bir şekilde döndürüyoruz
        return ResponseDTO<ApplicationUserDTO>.Success(userDTO, 200);
    }
    catch (Exception ex)
    {
        // Hata durumunda uygun bir mesaj dönüyoruz
        return ResponseDTO<ApplicationUserDTO>.Fail($"Hata oluştu: {ex.Message}", 500);
    }
        }

        public async Task<ResponseDTO<ApplicationUserDTO>> GetUserButIdAsync(string applicationUserId)
        {
            if (string.IsNullOrEmpty(applicationUserId))
            {
                return ResponseDTO<ApplicationUserDTO>.Fail("Kullanıcı kimliği sağlanmadı", 400);
            }

            try
            {
                // UserManager ile kullanıcıyı veritabanından buluyoruz
                var user = await _userManager.FindByIdAsync(applicationUserId);

                // Kullanıcı bulunamadıysa hata döndürüyoruz
                if (user == null)
                {
                    return ResponseDTO<ApplicationUserDTO>.Fail("Kullanıcı bulunamadı", 404);
                }

                // Kullanıcıyı DTO'ya dönüştürüyoruz
                var userDTO = new ApplicationUserDTO
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    PhoneNumber = user.PhoneNumber,
                    Email = user.Email,
                    Address = user.Address,
                    City = user.City,
                    DateOfBirth = user.DateOfBirth,
                    ProfilePictureUrl = user.ProfilePictureUrl,
                };

                // Kullanıcıyı başarılı bir şekilde döndürüyoruz
                return ResponseDTO<ApplicationUserDTO>.Success(userDTO, 200);
            }
            catch (Exception ex)
            {
                // Hata durumunda uygun bir mesaj dönüyoruz
                return ResponseDTO<ApplicationUserDTO>.Fail($"Hata oluştu: {ex.Message}", 500);
            }
        }


        public async Task<ResponseDTO<int>> GetUserCount()
        {
            try
            {
                var userCount = await _userManager.Users.CountAsync();
                return ResponseDTO<int>.Success(userCount, 200);
            }
            catch (Exception ex)
            {
                return ResponseDTO<int>.Fail($"Hata oluştu: {ex.Message}", 500);
            }
        }

        public async Task<ResponseDTO<IEnumerable<ApplicationUserDTO>>> GetAllUsers()
        {
            try
            {
                var users = await _userManager.Users.ToListAsync();
                var userDTOs = users.Select(user => new ApplicationUserDTO
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    PhoneNumber = user.PhoneNumber,
                    Email = user.Email,
                    Address = user.Address,
                    City = user.City,
                    DateOfBirth = user.DateOfBirth,
                    ProfilePictureUrl = user.ProfilePictureUrl
                }).ToList();

                return ResponseDTO<IEnumerable<ApplicationUserDTO>>.Success(userDTOs, 200);
            }
            catch (Exception ex)
            {
                return ResponseDTO<IEnumerable<ApplicationUserDTO>>.Fail($"Hata oluştu: {ex.Message}", 500);
            }
        }

        public async Task<ResponseDTO<NoContent>> DeleteUser(string applicationUserId)
        {
            if (string.IsNullOrEmpty(applicationUserId))
            {
                return ResponseDTO<NoContent>.Fail("Kullanıcı kimliği sağlanmadı", 400);
            }

            try
            {
                var user = await _userManager.FindByIdAsync(applicationUserId);
                if (user == null)
                {
                    return ResponseDTO<NoContent>.Fail("Kullanıcı bulunamadı", 404);
                }

                var result = await _userManager.DeleteAsync(user);
                if (!result.Succeeded)
                {
                    return ResponseDTO<NoContent>.Fail(result.Errors.Select(x => x.Description).ToList(), 500);
                }

                return ResponseDTO<NoContent>.Success(200);
            }
            catch (Exception ex)
            {
                return ResponseDTO<NoContent>.Fail($"Hata oluştu: {ex.Message}", 500);
            }
        }

        public async Task<ResponseDTO<NoContent>> UpdateUserProfilePicture(ApplicationUserProfilePictureDTO profilePictureDTO)
        {
            var token = _httpContextAccessor.HttpContext?.Request.Headers["Authorization"].ToString().Replace("Bearer ", "");

            if (string.IsNullOrEmpty(token))
            {
                return ResponseDTO<NoContent>.Fail("Token bulunamadı", 400);
            }

            try
            {
                var handler = new JwtSecurityTokenHandler();
                var jsonToken = handler.ReadToken(token) as JwtSecurityToken;
                var userId = jsonToken?.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;

                if (string.IsNullOrEmpty(userId))
                {
                    return ResponseDTO<NoContent>.Fail("Kullanıcı kimliği bulunamadı", 400);
                }

                var user = await _userManager.FindByIdAsync(userId);

                if (user == null)
                {
                    return ResponseDTO<NoContent>.Fail("Kullanıcı bulunamadı", 404);
                }

                if (profilePictureDTO.ProfilePictureUrl != null && profilePictureDTO.ProfilePictureUrl.Length > 0)
                {
                    var imageUrl = await _ımageService.UploadImageAsync(profilePictureDTO.ProfilePictureUrl);
                    if (!string.IsNullOrEmpty(imageUrl))
                    {
                        user.ProfilePictureUrl = imageUrl;
                        var result = await _userManager.UpdateAsync(user);
                        if (!result.Succeeded)
                        {
                            return ResponseDTO<NoContent>.Fail(result.Errors.Select(x => x.Description).ToList(), 500);
                        }
                        return ResponseDTO<NoContent>.Success(200);
                    }
                    else
                    {
                        return ResponseDTO<NoContent>.Fail("Resim yüklenirken hata oluştu", 500);
                    }
                }
                return ResponseDTO<NoContent>.Fail("Geçersiz resim dosyası", 400);
            }
            catch (Exception ex)
            {
                return ResponseDTO<NoContent>.Fail($"Hata oluştu: {ex.Message}", 500);
            }
        }

    }
}
