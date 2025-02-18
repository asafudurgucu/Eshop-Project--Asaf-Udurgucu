using System.Text.Json.Serialization;

namespace eshop_MVC.Models;

public class BasketModel
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("applicationUserId")]
    public string ApplicationUserId { get; set; }

    [JsonPropertyName("basketItems")]
    public List<BasketItemModel> BasketItems { get; set; }
    public decimal TotalAmount { get; set; }
}
