using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace eshop_MVC.Models
{
    public class LoginModel
    {
        [JsonPropertyName("email")]
        [Display(Name = "Email")]
        [Required(ErrorMessage ="Email boş bırakılamaz")]
        [EmailAddress(ErrorMessage ="Geçersiz email adresi")]
        public string Email { get; set; }

        [JsonPropertyName("password")]
        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifre boş bırakılamaz")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
