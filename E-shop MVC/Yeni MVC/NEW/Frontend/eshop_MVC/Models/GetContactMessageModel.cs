using System.Text.Json.Serialization;

namespace eshop_MVC.Models
{
    public class GetContactMessageModel
    {
        [JsonPropertyName("cName")]
        public string CName { get; set; }

        [JsonPropertyName("cEmail")]
        public string CEmail { get; set; }

        [JsonPropertyName("cMessage")]
        public string CMessage { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("createdDate")]
        public DateTime CreatedDate { get; set; }
    }
}
