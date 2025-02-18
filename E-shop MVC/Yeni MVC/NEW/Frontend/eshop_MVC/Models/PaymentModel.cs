using System.Text.Json.Serialization;

namespace eshop_MVC.Models
{
    public class PaymentModel
    {
        [JsonPropertyName("cardUserName")]
        public string CardUserName { get; set; }

        [JsonPropertyName("cardNumber")]
        public string CardNumber { get; set; }

        [JsonPropertyName("cvv")]
        public int Cvv { get; set; }

        [JsonPropertyName("cardDate")]
        public string CardDate { get; set; }
    }
}
