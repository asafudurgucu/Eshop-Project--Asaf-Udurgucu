$(document).ready(function () {
    // Carousel ayarları
    $('#categoryCarousel').carousel({
        interval: 3000
    });

    // Ürün silme işlevi
    $('.deleteProduct').click(function () {
        $(this).closest('tr').remove();
        updateTotal();
    });

    // Sepeti boşaltma işlevi
    $('.btn-danger').click(function () {
        $('tbody').empty();
        updateTotal();
    });

    // Adet değişikliği işlevi
    $('input[type="number"]').change(function () {
        var quantity = $(this).val();
        var price = $(this).closest('tr').find('td:nth-child(4)').text().replace('₺', '');
        var total = quantity * price;
        $(this).closest('tr').find('td:nth-child(5)').text('₺' + total.toFixed(2));
        updateTotal();
    });

    // Genel toplamı güncelleme işlevi
    function updateTotal() {
        var total = 0;
        $('tbody tr').each(function () {
            var rowTotal = $(this).find('td:nth-child(5)').text().replace('₺', '');
            total += parseFloat(rowTotal);
        });
        $('tfoot th:nth-child(2)').text('₺' + total.toFixed(2));
    }
});
