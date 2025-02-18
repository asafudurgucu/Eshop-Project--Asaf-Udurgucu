using System;
using System.Text.Json.Serialization;

namespace eshop_MVC.Models;

public class CouponCreateModel
{

    [JsonPropertyName("code")]
    public string Code { get; set; }

    [JsonPropertyName("discountPercentage")]
    public int DiscountPercentage { get; set; }
}
