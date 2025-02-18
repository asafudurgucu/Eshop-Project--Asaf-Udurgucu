using System;
using System.Text.Json.Serialization;

namespace eshop_MVC.Models;

public class CreateCommentModel
{
        [JsonPropertyName("productId")]
        public int ProductId { get; set; }

        [JsonPropertyName("applicationUserId")]
        public string? ApplicationUserId { get; set; }

        [JsonPropertyName("content")]
        public string Content { get; set; }

        [JsonPropertyName("rating")]
        public int Rating { get; set; }
}
