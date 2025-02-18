using System;
using System.ComponentModel.DataAnnotations;

namespace eshop_Shared.DTOs.Auth;

public class LoginDTO
{
    [Required(ErrorMessage = "Bu K�s�m Bo� B�rak�lamaz")]
    public string Email { get; set; }
    [Required(ErrorMessage = "Bu K�s�m Bo� B�rak�lamaz")]
    public string Password { get; set; }

}
