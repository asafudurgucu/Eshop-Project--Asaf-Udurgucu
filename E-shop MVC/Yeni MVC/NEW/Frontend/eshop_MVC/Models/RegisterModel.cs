using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
namespace eshop_MVC.Models
{
    public class RegisterModel
    {
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonPropertyName("birthDay")]
        public DateTime BirthDay { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonPropertyName("confirmPassword")]
        public string ConfirmPassword { get; set; }

        
    }
}
