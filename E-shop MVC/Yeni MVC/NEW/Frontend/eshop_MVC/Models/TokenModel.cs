using System.Text.Json.Serialization;

namespace eshop_MVC.Models
{
    public class TokenModel
    {
        [JsonPropertyName("accessToken")]
        public string AccessToken { get; set; }

        [JsonPropertyName("expirationDate")]
        public DateTime ExpirationDate { get; set; }
    }
}
