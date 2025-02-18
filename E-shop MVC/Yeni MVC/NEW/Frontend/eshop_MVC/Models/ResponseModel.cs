using System.Text.Json.Serialization;

namespace eshop_MVC.Models
{
    public class ResponseModel<T>
    {
        [JsonPropertyName("data")]
        public T? Data { get; set; }


        [JsonPropertyName("errors")]
        public List<string>? Errors { get; set; }
    }
}
