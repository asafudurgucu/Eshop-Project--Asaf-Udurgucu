using System.Text.Json.Serialization;

namespace eshop_MVC.Models
{
    public class ContactMessageModel
    {
        [JsonPropertyName("cName")]
        public string CName { get; set; }

        [JsonPropertyName("cEmail")]
        public string CEmail { get; set; }

        [JsonPropertyName("cMessage")]
        public string CMessage { get; set; }
    }
}
