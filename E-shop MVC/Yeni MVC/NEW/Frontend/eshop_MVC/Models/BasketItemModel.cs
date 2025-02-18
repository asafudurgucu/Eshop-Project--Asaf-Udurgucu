using System.Text.Json.Serialization;

namespace eshop_MVC.Models
{
    public class BasketItemModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("basketId")]
        public int BasketId { get; set; }
        [JsonPropertyName("productId")]
        public int ProductId { get; set; }
        [JsonPropertyName("product")]
        public ProductModel Product { get; set; }
        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }
        
        public decimal DiscountedPrice { get; set; }
    }
}
