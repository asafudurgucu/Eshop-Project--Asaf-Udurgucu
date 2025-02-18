using System;
using System.ComponentModel.DataAnnotations;

namespace eshop_Shared.DTOs.Auth;

public class RegisterDTO
{
    
    public string FirstName { get; set; }

    
    public string LastName { get; set; }

   
    public string Address { get; set; }

   
    public string City { get; set; }

    
    public string PhoneNumber { get; set; }

 
    public DateTime BirthDay { get; set; }

    
    public string Email { get; set; }

    
    public string Password { get; set; }

    
    public string ConfirmPassword { get; set; }

    public string Role { get; set; } = "NormalUser";


}
