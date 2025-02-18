using System.Text.Json.Serialization;

namespace eshop_MVC.Models
{
    public class OrderItemModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("orderId")]
        public int OrderId { get; set; }

        [JsonPropertyName("productId")]
        public int ProductId { get; set; }

        [JsonPropertyName("product")]
        public ProductModel Product { get; set; }

        [JsonPropertyName("unitPrice")]
        public decimal UnitPrice { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [JsonPropertyName("totalPrice")]
        public decimal TotalPrice { get; set; }
    }
}
