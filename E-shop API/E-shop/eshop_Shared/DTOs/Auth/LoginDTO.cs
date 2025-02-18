using System;
using System.ComponentModel.DataAnnotations;

namespace eshop_Shared.DTOs.Auth;

public class LoginDTO
{
    [Required(ErrorMessage = "Bu Kýsým Boþ Býrakýlamaz")]
    public string Email { get; set; }
    [Required(ErrorMessage = "Bu Kýsým Boþ Býrakýlamaz")]
    public string Password { get; set; }

}
