using System;

namespace eshop_Shared.DTOs.Auth;

public class TokenDTO
{
    public string AccessToken { get; set; }
    public DateTime ExpirationDate { get; set; }
}
