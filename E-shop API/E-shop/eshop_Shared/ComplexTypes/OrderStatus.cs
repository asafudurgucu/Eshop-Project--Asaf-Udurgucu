using System;

namespace eshop_Shared.ComplexTypes;

public enum OrderStatus
{
    Pending = 0, // Beklemede
    Processing = 1, // İşleniyor
    Shipped = 2, // Kargoya Verildi
    Delivered = 3, // Teslim Edildi
    Cancelled = 4, // İptal Edildi
    Returned = 5, // İade Edildi
    Failed = 6 // Başarısız

}
