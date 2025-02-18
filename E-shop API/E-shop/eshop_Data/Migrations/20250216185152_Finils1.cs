using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eshop_Data.Migrations
{
    /// <inheritdoc />
    public partial class Finils1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 50 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14a0183f-1e96-4930-a83d-6ef5f22d8c09",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8652bf77-14ca-4220-906b-871d4b91c17d", new DateTime(2025, 2, 16, 21, 51, 51, 317, DateTimeKind.Local).AddTicks(2695), "AQAAAAIAAYagAAAAEGFwKd7ytIor0323k0F3f3GOT3ylX2P6/93yeJLh8qoIySnkuvTnynwFANKZDAAJIA==", "ce455470-6b55-4e22-b31a-b62b95dc1635" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c0b7fef7-df2b-4857-9b3d-bc8967ad19ac",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10ab6855-7563-409c-bca2-e685071734cd", new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7760), "AQAAAAIAAYagAAAAEGwHs0fGFaegSPAyiHvitSPZooXHjxEuct/odpfGBkdeA6aBmn3/FN42FuGnmUURgQ==", "a2467d7e-2b72-43ec-bd02-cbafc24f7a63" });

            migrationBuilder.UpdateData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 411, DateTimeKind.Local).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 411, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(6869));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "ModifiedDate", "Name", "isActive" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(6823), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elektronik", true },
                    { 2, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(6843), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mobil Cihazlar", true },
                    { 3, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(6846), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Televizyonlar", true },
                    { 4, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(6848), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bilgisayarlar", true },
                    { 5, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(6850), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aksesuarlar", true },
                    { 6, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(6852), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple", true },
                    { 7, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(6854), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung", true },
                    { 8, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(6855), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LG", true },
                    { 9, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(6857), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Huawei", true },
                    { 10, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(6859), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sony", true },
                    { 11, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(6861), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lenovo", true },
                    { 13, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(6864), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xiaomi", true },
                    { 14, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(6866), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akıllı Saatler", true },
                    { 15, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(6868), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tabletler", true },
                    { 16, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(6862), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dell", true }
                });

            migrationBuilder.UpdateData(
                table: "Coupon",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 411, DateTimeKind.Local).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "Coupon",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 411, DateTimeKind.Local).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "Coupon",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 411, DateTimeKind.Local).AddTicks(7176));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ImageUrl", "Name", "Price", "Properties" },
                values: new object[] { new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7293), "/images/product-50.jpg", "Samsung Galaxy Z Fold 4", 1799.99m, "Samsung Galaxy Z Fold 4, katlanabilir ekran, 12GB RAM, 512GB depolama alanı ile güçlü bir cihaz." });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "ImageUrl", "ModifiedDate", "Name", "Price", "Properties", "isActive" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7035), "/images/product-1.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iPhone 14", 999.99m, "Apple iPhone 14, 128GB, Siyah, 6.1 inch ekran, A15 Bionic chip ile yüksek performans.", true },
                    { 2, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7047), "/images/product-2.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy S23", 899.99m, "Samsung Galaxy S23, 128GB, Beyaz, 6.2 inch ekran, 50MP ana kamera ile mükemmel fotoğraflar.", true },
                    { 3, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7050), "/images/product-3.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LG OLED TV", 1299.99m, "LG 55in OLED TV, 4K, Ultra HD, OLED ekran teknolojisi ile mükemmel renk ve kontrast.", true },
                    { 4, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7053), "/images/product-4.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sony Bravia 65", 1799.99m, "Sony Bravia 65in 4K TV, Akıllı TV özellikleri, Android işletim sistemi ve Google Assistant desteği.", true },
                    { 5, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7055), "/images/product-5.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple MacBook Pro", 2399.99m, "Apple MacBook Pro, 16GB RAM, 512GB SSD, M1 Pro chip ile yüksek performanslı ve taşınabilir dizüstü.", true },
                    { 6, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7059), "/images/product-6.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy Tab S8", 649.99m, "Samsung Galaxy Tab S8, 128GB, 11 inç ekran, S Pen desteği ile verimli kullanım için ideal tablet.", true },
                    { 7, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7062), "/images/product-7.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dell XPS 13", 1199.99m, "Dell XPS 13, 16GB RAM, 512GB SSD, İnce tasarımı ve 13 inç 4K ekranıyla taşınabilirlik ve güç bir arada.", true },
                    { 8, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7065), "/images/product-8.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Huawei MateBook X", 1599.99m, "Huawei MateBook X, 16GB RAM, 512GB SSD, 13 inç ekran, ince ve hafif yapısıyla mükemmel mobilite.", true },
                    { 9, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7067), "/images/product-9.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xiaomi Mi 11", 599.99m, "Xiaomi Mi 11, 128GB, Siyah, Snapdragon 888 işlemci, 108MP ana kamera ile ultra yüksek çözünürlük.", true },
                    { 10, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7071), "/images/product-10.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lenovo ThinkPad X1", 1499.99m, "Lenovo ThinkPad X1, 16GB RAM, 512GB SSD, 14 inç ekran, dayanıklı tasarım ve güçlü performans.", true },
                    { 11, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7074), "/images/product-11.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple AirPods Pro", 249.99m, "Apple AirPods Pro, aktif gürültü engelleme özelliği, üstün ses kalitesi ve Apple ekosistemiyle uyumlu.", true },
                    { 12, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7077), "/images/product-12.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy Watch 5", 299.99m, "Samsung Galaxy Watch 5, Akıllı saat, 40mm ekran, spor ve sağlık takibi, 2 gün batarya süresi.", true },
                    { 13, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7079), "/images/product-13.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LG 27GL850-B Monitor", 349.99m, "LG 27in QHD IPS Monitör, 144Hz yenileme hızı, NVIDIA G-Sync uyumluluğu ile oyun için ideal.", true },
                    { 14, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7082), "/images/product-14.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sony WH-1000XM5", 349.99m, "Sony WH-1000XM5, Kablosuz kulaklık, mükemmel ses yalıtımı, 30 saat pil ömrü ve rahat kullanım.", true },
                    { 15, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7085), "/images/product-15.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Huawei P50 Pro", 899.99m, "Huawei P50 Pro, 256GB, 50MP dörtlü kamera, 6.6 inç OLED ekran, mükemmel fotoğraf ve video çekimi.", true },
                    { 16, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7150), "/images/product-16.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iPad Pro 12.9", 1099.99m, "iPad Pro 12.9, 128GB, M1 chip, 12.9 inç Liquid Retina ekran, çizim ve medya düzenleme için ideal.", true },
                    { 17, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7153), "/images/product-17.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple Watch Series 7", 399.99m, "Apple Watch Series 7, 41mm ekran, giyilebilir sağlık ve fitness takibi, su geçirmez özellik.", true },
                    { 18, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7158), "/images/product-18.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung QLED 65in TV", 1499.99m, "Samsung 65in QLED TV, 4K, Quantum Dot teknolojisi ile renkleri daha parlak ve canlı.", true },
                    { 19, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7160), "/images/product-19.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xiaomi Mi 10", 699.99m, "Xiaomi Mi 10, 128GB, Snapdragon 865 işlemci, 108MP ana kamera, 6.67 inç AMOLED ekran.", true },
                    { 20, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7163), "/images/product-20.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sony Xperia 1 II", 949.99m, "Sony Xperia 1 II, 128GB, 6.5 inç 4K OLED ekran, sinematik video çekimleri için mükemmel.", true },
                    { 21, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7165), "/images/product-21.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple MacBook Air", 1099.99m, "Apple MacBook Air, M1 chip, 8GB RAM, 256GB SSD, hafif ve ince dizüstü bilgisayar.", true },
                    { 22, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7168), "/images/product-22.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy Buds Pro", 199.99m, "Samsung Galaxy Buds Pro, kablosuz kulaklık, aktif gürültü engelleme, üstün ses kalitesi.", true },
                    { 23, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7171), "/images/product-23.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LG Gram 17", 1699.99m, "LG Gram 17, 16GB RAM, 512GB SSD, 17 inç ekran, ultra hafif taşınabilir dizüstü bilgisayar.", true },
                    { 24, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7173), "/images/product-24.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sony Alpha 7 III", 2199.99m, "Sony Alpha 7 III, 24.2MP, 4K video çekimi, profesyonel fotoğraf makineleri.", true },
                    { 25, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7176), "/images/product-25.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple iPad Mini", 499.99m, "Apple iPad Mini, 8.3 inç ekran, A15 Bionic chip, taşınabilir ve güçlü tablet.", true },
                    { 26, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7179), "/images/product-26.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Huawei FreeBuds Pro", 179.99m, "Huawei FreeBuds Pro, kablosuz kulaklık, aktif gürültü engelleme ve yüksek ses kalitesi.", true },
                    { 27, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7181), "/images/product-27.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xiaomi Mi Band 6", 44.99m, "Xiaomi Mi Band 6, Akıllı bileklik, 1.56 inç AMOLED ekran, spor takibi ve fitness özellikleri.", true },
                    { 28, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7184), "/images/product-28.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung 970 EVO Plus SSD", 149.99m, "Samsung 970 EVO Plus, 1TB SSD, NVMe M.2, ultra hızlı veri transferi.", true },
                    { 29, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7186), "/images/product-29.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lenovo Legion 5", 1399.99m, "Lenovo Legion 5, 16GB RAM, 512GB SSD, 15.6 inç 144Hz ekran, güçlü oyun laptopu.", true },
                    { 30, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7189), "/images/product-30.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dell Alienware X17", 2499.99m, "Dell Alienware X17, 32GB RAM, 1TB SSD, 17.3 inç 4K ekran, yüksek performanslı oyun bilgisayarı.", true },
                    { 31, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7191), "/images/product-31.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sony PlayStation 5", 499.99m, "Sony PlayStation 5, 825GB SSD, 4K oyun desteği, ultra hızlı performans.", true },
                    { 32, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7194), "/images/product-32.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple TV 4K", 179.99m, "Apple TV 4K, 64GB, 4K HDR, Dolby Vision ve Dolby Atmos ile mükemmel görüntü ve ses.", true },
                    { 33, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7196), "/images/product-33.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Odyssey G7 Monitor", 799.99m, "Samsung Odyssey G7, 27in QHD, 240Hz, 1ms tepki süresi ile oyun için en iyi ekran.", true },
                    { 34, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7200), "/images/product-34.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xiaomi Mi Robot Vacuum", 399.99m, "Xiaomi Mi Robot Vakum, 2.5 saat pil ömrü, akıllı navigasyon, güçlü emiş gücü.", true },
                    { 35, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7202), "/images/product-35.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lenovo Smart Clock", 79.99m, "Lenovo Smart Clock, Google Assistant ile akıllı saat, uyandırma alarmı ve diğer özellikler.", true },
                    { 36, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7205), "/images/product-36.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Huawei Watch GT 3", 249.99m, "Huawei Watch GT 3, 46mm ekran, 14 güne kadar pil ömrü, fitness ve sağlık takibi.", true },
                    { 37, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7207), "/images/product-37.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sony Xperia 5 III", 1049.99m, "Sony Xperia 5 III, 128GB, 6.1 inç OLED ekran, 120Hz yenileme hızı ve mükemmel video çekim özellikleri.", true },
                    { 38, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7210), "/images/product-38.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple iMac 24\" M1", 1299.99m, "Apple iMac 24\" M1, 8GB RAM, 256GB SSD, parlak ve canlı renklerle tasarlanmış masaüstü bilgisayar.", true },
                    { 39, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7212), "/images/product-39.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy Note 20 Ultra", 1299.99m, "Samsung Galaxy Note 20 Ultra, 256GB, 108MP ana kamera, 5G desteği ile hızlı bağlantı.", true },
                    { 40, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7215), "/images/product-40.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xiaomi Redmi Note 11 Pro", 249.99m, "Xiaomi Redmi Note 11 Pro, 128GB, 6.67 inç AMOLED ekran, 108MP kamera.", true },
                    { 41, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7217), "/images/product-41.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lenovo Yoga 9i", 1899.99m, "Lenovo Yoga 9i, 16GB RAM, 512GB SSD, 14 inç 4K ekran, dönüştürülebilir dizüstü bilgisayar.", true },
                    { 42, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7220), "/images/product-42.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple Magic Mouse", 79.99m, "Apple Magic Mouse, kablosuz, çoklu dokunmatik yüzey, zarif ve kompakt tasarım.", true },
                    { 43, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7222), "/images/product-43.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sony WH-XB900N", 249.99m, "Sony WH-XB900N, Kablosuz kulaklık, ekstra bass özelliği ve gürültü engelleme.", true },
                    { 44, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7224), "/images/product-44.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple HomePod Mini", 99.99m, "Apple HomePod Mini, Akıllı hoparlör, yüksek kaliteli ses ve Apple ekosistemine uyum.", true },
                    { 45, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7227), "/images/product-45.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung T7 Touch SSD", 149.99m, "Samsung T7 Touch, 1TB SSD, parmak izi güvenliği, ultra hızlı veri transferi.", true },
                    { 46, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7229), "/images/product-46.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xiaomi Mi 11 Lite", 369.99m, "Xiaomi Mi 11 Lite, 128GB, Snapdragon 732G, 6.55 inç AMOLED ekran, ince ve şık tasarım.", true },
                    { 47, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7232), "/images/product-47.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lenovo IdeaPad Flex 5", 849.99m, "Lenovo IdeaPad Flex 5, 8GB RAM, 512GB SSD, 14 inç ekran, dönüştürülebilir laptop.", true },
                    { 48, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7287), "/images/product-48.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sony Bravia A80J", 2199.99m, "Sony Bravia A80J, 65 inç OLED, 4K, Google TV ile akıllı özellikler ve mükemmel görüntü kalitesi.", true },
                    { 49, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7290), "/images/product-49.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple Pencil 2. Nesil", 129.99m, "Apple Pencil 2. Nesil, iPad Pro ve iPad Air için hassas çizim ve not alma aracı.", true }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "CategoryId", "ProductId", "CreatedDate", "Id", "ModifiedDate", "isActive" },
                values: new object[,]
                {
                    { 12, 1, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7393), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 12, 2, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7396), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 2, 3, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7407), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 2, 4, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7408), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 3, 5, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7410), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 12, 5, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7398), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 12, 6, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7399), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 3, 7, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7411), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 3, 8, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7412), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 12, 9, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7400), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 3, 10, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7413), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 5, 11, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7414), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 5, 12, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7416), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 6, 13, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7417), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 12, 13, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7401), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 5, 14, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7418), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 12, 15, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7403), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 12, 16, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7404), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 5, 17, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7419), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 2, 18, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7420), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 12, 19, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7405), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 12, 20, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7406), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 3, 21, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7421), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 5, 22, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7422), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 3, 23, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7424), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 7, 24, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7425), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 4, 25, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7426), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 5, 26, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7427), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 8, 27, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7428), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 9, 28, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7429), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 3, 29, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7430), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 3, 30, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7432), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 10, 31, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7433), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 11, 32, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7434), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 6, 33, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7435), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 12, 34, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7436), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 5, 35, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7437), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 5, 36, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7439), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 1, 37, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7440), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 3, 38, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7441), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 1, 39, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7442), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 1, 40, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7443), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 3, 41, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7444), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 5, 42, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7445), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 5, 43, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7448), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 11, 44, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7449), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 9, 45, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7450), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 1, 46, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7451), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 3, 47, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7452), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 2, 48, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7454), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 5, 49, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7455), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 1, 50, new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7456), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 5 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 6 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 9 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 11 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 12 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 13 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 13 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 14 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 15 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 16 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 17 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 18 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 19 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 20 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 21 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 22 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 23 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 24 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 25 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 26 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 27 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 28 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 29 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 30 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 31 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 32 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 33 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 34 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 35 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 36 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 37 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 38 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 39 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 40 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 41 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 42 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 43 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 44 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 45 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 46 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 47 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 48 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 49 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 50 });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14a0183f-1e96-4930-a83d-6ef5f22d8c09",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e7e3f38-4a4b-43d4-9492-d879741ba7d2", new DateTime(2025, 2, 16, 21, 38, 47, 338, DateTimeKind.Local).AddTicks(1641), "AQAAAAIAAYagAAAAELAehoN9GU+uFDLFrwrN1iS3gWe8F3P2ep8xo0MV+E6wVW2648TR+BYrIQNZydZTXw==", "6fc735c2-373c-4bba-9d5a-12b9de4ac376" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c0b7fef7-df2b-4857-9b3d-bc8967ad19ac",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6165a1d1-7469-4849-82a7-8b60b6779e80", new DateTime(2025, 2, 16, 21, 38, 47, 245, DateTimeKind.Local).AddTicks(8402), "AQAAAAIAAYagAAAAEHRNHhT6QzaZchQoOJ3Osxx2BLOsthS4mWH3bR1vfoFsNnnZi676BiWnhcunP4z/jA==", "0615b807-e61e-4b8d-b1c7-b6207d0f6df5" });

            migrationBuilder.UpdateData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 38, 47, 441, DateTimeKind.Local).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 38, 47, 441, DateTimeKind.Local).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 38, 47, 245, DateTimeKind.Local).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "Coupon",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 38, 47, 441, DateTimeKind.Local).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "Coupon",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 38, 47, 441, DateTimeKind.Local).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "Coupon",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 38, 47, 441, DateTimeKind.Local).AddTicks(2507));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 38, 47, 245, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "CategoryId", "ProductId", "CreatedDate", "Id", "ModifiedDate", "isActive" },
                values: new object[] { 12, 50, new DateTime(2025, 2, 16, 21, 38, 47, 245, DateTimeKind.Local).AddTicks(8143), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ImageUrl", "Name", "Price", "Properties" },
                values: new object[] { new DateTime(2025, 2, 16, 21, 38, 47, 245, DateTimeKind.Local).AddTicks(8071), "/images/product-5.jpg", "Yemek Kitabı", 49.99m, "Yemek tarifleri kitabı" });
        }
    }
}
