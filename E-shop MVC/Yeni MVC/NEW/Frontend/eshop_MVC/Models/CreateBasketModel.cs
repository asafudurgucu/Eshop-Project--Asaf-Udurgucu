using System.Text.Json.Serialization;

namespace eshop_MVC.Models
{
    public class CreateBasketModel
    {
        [JsonPropertyName("applicationUserId")]
        public string ApplicationUserId { get; set; }
    }
}
