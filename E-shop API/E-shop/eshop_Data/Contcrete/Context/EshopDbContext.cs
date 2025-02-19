using eshop_Entity.Contcrete;
using eshop_Shared.ComplexTypes;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop_Data.Contcrete.Context
{
    public class EshopDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public EshopDbContext(DbContextOptions<EshopDbContext> options) : base(options)
        {

        }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Coupon>? Coupon { get; set; }
        public DbSet<Payment>? Payment { get; set; }
        public DbSet<ContactMessage>? ContactMessages { get; set; }
        public DbSet<Settings>? Settings { get; set; }
        public DbSet<Basket>? Baskets { get; set; }
        public DbSet<BasketItem>? BasketItems { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Order>? Orders { get; set; }
        public DbSet<OrderItem>? OrderItems { get; set; }
        public DbSet<Product>? Products { get; set; }
        public DbSet<ProductCategories>? ProductCategories { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Payment>(entity =>
            {
                entity.HasKey(p => p.Id);
            });

            // Category entity yapılandırması
            builder.Entity<Category>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity.Property(c => c.Name).IsRequired().HasMaxLength(100);
                entity.Property(c => c.Description).HasMaxLength(500);
            });

            // Product entity yapılandırması
            builder.Entity<Product>(entity =>
            {
                entity.HasKey(p => p.Id);
                entity.Property(p => p.Name).IsRequired().HasMaxLength(200);
                entity.Property(p => p.Price).IsRequired().HasColumnType("decimal(18,2)");
                entity.Property(p => p.Properties).HasMaxLength(1000);
            });

            // ProductCategories entity yapılandırması
            builder.Entity<ProductCategories>(entity =>
            {
                entity.HasKey(pc => new { pc.ProductId, pc.CategoryId });
                entity.HasOne(pc => pc.Product)
                      .WithMany(p => p.ProductCategories)
                      .HasForeignKey(pc => pc.ProductId);
                entity.HasOne(pc => pc.Category)
                      .WithMany(c => c.ProductCategories)
                      .HasForeignKey(pc => pc.CategoryId);
            });

            builder.Entity<OrderItem>().Property(p => p.UnitPrice).HasColumnType("decimal(10,2)");

            // Kategori verileri
            builder.Entity<Category>().HasData(
                  new Category { Id = 1, Name = "Elektronik", Description = "" },
                  new Category { Id = 2, Name = "Mobil Cihazlar", Description = "" },
                  new Category { Id = 3, Name = "Televizyonlar", Description = "" },
                  new Category { Id = 4, Name = "Bilgisayarlar", Description = "" },
                  new Category { Id = 5, Name = "Aksesuarlar", Description = "" },
                  new Category { Id = 6, Name = "Apple", Description = "" },
                  new Category { Id = 7, Name = "Samsung", Description = "" },
                  new Category { Id = 8, Name = "LG", Description = "" },
                  new Category { Id = 9, Name = "Huawei", Description = "" },
                  new Category { Id = 10, Name = "Sony", Description = "" },
                  new Category { Id = 11, Name = "Lenovo", Description = "" },
                  new Category { Id = 16, Name = "Dell", Description = "" },
                  new Category { Id = 13, Name = "Xiaomi", Description = "" },
                  new Category { Id = 14, Name = "Akıllı Saatler", Description = "" },
                  new Category { Id = 15, Name = "Tabletler", Description = "" },
                new Category { Id = 12, Name = "Ana Sayfa", Description = "" }
            );

            List<Product> products = new List<Product>
            {
                 new Product { Id = 1, Name = "iPhone 14", Price = 999.99m, Properties = "Apple iPhone 14, 128GB, Siyah, 6.1 inch ekran, A15 Bionic chip ile yüksek performans.", ImageUrl = "images/38e038fb-146d-41b7-bd17-fa8285d9980d.webp" },
    new Product { Id = 2, Name = "Samsung Galaxy S23", Price = 899.99m, Properties = "Samsung Galaxy S23, 128GB, Beyaz, 6.2 inch ekran, 50MP ana kamera ile mükemmel fotoğraflar.", ImageUrl = "images/7facead8-3650-418a-b685-680ce2ca8837.png" },
    new Product { Id = 3, Name = "LG OLED TV", Price = 1299.99m, Properties = "LG 55in OLED TV, 4K, Ultra HD, OLED ekran teknolojisi ile mükemmel renk ve kontrast.", ImageUrl = "images/a1d95372-6e37-4972-bd5d-ee761a49c2f4.jpg" },
    new Product { Id = 4, Name = "Sony Bravia 65", Price = 1799.99m, Properties = "Sony Bravia 65in 4K TV, Akıllı TV özellikleri, Android işletim sistemi ve Google Assistant desteği.", ImageUrl = "images/3c39749c-cb04-4d94-b43b-ba15ac0faa06.png" },
    new Product { Id = 5, Name = "Apple MacBook Pro", Price = 2399.99m, Properties = "Apple MacBook Pro, 16GB RAM, 512GB SSD, M1 Pro chip ile yüksek performanslı ve taşınabilir dizüstü.", ImageUrl = "images/58dc13d3-b448-47b5-a466-e526fe648d60.jpg" },
    new Product { Id = 6, Name = "Samsung Galaxy Tab S8", Price = 649.99m, Properties = "Samsung Galaxy Tab S8, 128GB, 11 inç ekran, S Pen desteği ile verimli kullanım için ideal tablet.", ImageUrl = "images/a84c00c6-1ca5-4b84-9b6f-66e9866df1fb.png" },
    new Product { Id = 7, Name = "Dell XPS 13", Price = 1199.99m, Properties = "Dell XPS 13, 16GB RAM, 512GB SSD, İnce tasarımı ve 13 inç 4K ekranıyla taşınabilirlik ve güç bir arada.", ImageUrl = "images/f72c266f-04db-413c-9b9b-12f8206954be.png" },
    new Product { Id = 8, Name = "Huawei MateBook X", Price = 1599.99m, Properties = "Huawei MateBook X, 16GB RAM, 512GB SSD, 13 inç ekran, ince ve hafif yapısıyla mükemmel mobilite.", ImageUrl = "images/64ebd99e-00a8-428e-82ae-ffcf6d242f7d.png" },
    new Product { Id = 9, Name = "Xiaomi Mi 11", Price = 599.99m, Properties = "Xiaomi Mi 11, 128GB, Siyah, Snapdragon 888 işlemci, 108MP ana kamera ile ultra yüksek çözünürlük.", ImageUrl = "/images/product-9.jpg" },
    new Product { Id = 10, Name = "Lenovo ThinkPad X1", Price = 1499.99m, Properties = "Lenovo ThinkPad X1, 16GB RAM, 512GB SSD, 14 inç ekran, dayanıklı tasarım ve güçlü performans.", ImageUrl = "/images/product-10.jpg" },
    new Product { Id = 11, Name = "Apple AirPods Pro", Price = 249.99m, Properties = "Apple AirPods Pro, aktif gürültü engelleme özelliği, üstün ses kalitesi ve Apple ekosistemiyle uyumlu.", ImageUrl = "/images/product-11.jpg" },
    new Product { Id = 12, Name = "Samsung Galaxy Watch 5", Price = 299.99m, Properties = "Samsung Galaxy Watch 5, Akıllı saat, 40mm ekran, spor ve sağlık takibi, 2 gün batarya süresi.", ImageUrl = "/images/product-12.jpg" },
    new Product { Id = 13, Name = "LG 27GL850-B Monitor", Price = 349.99m, Properties = "LG 27in QHD IPS Monitör, 144Hz yenileme hızı, NVIDIA G-Sync uyumluluğu ile oyun için ideal.", ImageUrl = "/images/product-13.jpg" },
    new Product { Id = 14, Name = "Sony WH-1000XM5", Price = 349.99m, Properties = "Sony WH-1000XM5, Kablosuz kulaklık, mükemmel ses yalıtımı, 30 saat pil ömrü ve rahat kullanım.", ImageUrl = "/images/product-14.jpg" },
    new Product { Id = 15, Name = "Huawei P50 Pro", Price = 899.99m, Properties = "Huawei P50 Pro, 256GB, 50MP dörtlü kamera, 6.6 inç OLED ekran, mükemmel fotoğraf ve video çekimi.", ImageUrl = "/images/product-15.jpg" },
    new Product { Id = 16, Name = "iPad Pro 12.9", Price = 1099.99m, Properties = "iPad Pro 12.9, 128GB, M1 chip, 12.9 inç Liquid Retina ekran, çizim ve medya düzenleme için ideal.", ImageUrl = "/images/product-16.jpg" },
    new Product { Id = 17, Name = "Apple Watch Series 7", Price = 399.99m, Properties = "Apple Watch Series 7, 41mm ekran, giyilebilir sağlık ve fitness takibi, su geçirmez özellik.", ImageUrl = "/images/product-17.jpg" },
    new Product { Id = 18, Name = "Samsung QLED 65in TV", Price = 1499.99m, Properties = "Samsung 65in QLED TV, 4K, Quantum Dot teknolojisi ile renkleri daha parlak ve canlı.", ImageUrl = "/images/product-18.jpg" },
    new Product { Id = 19, Name = "Xiaomi Mi 10", Price = 699.99m, Properties = "Xiaomi Mi 10, 128GB, Snapdragon 865 işlemci, 108MP ana kamera, 6.67 inç AMOLED ekran.", ImageUrl = "/images/product-19.jpg" },
    new Product { Id = 20, Name = "Sony Xperia 1 II", Price = 949.99m, Properties = "Sony Xperia 1 II, 128GB, 6.5 inç 4K OLED ekran, sinematik video çekimleri için mükemmel.", ImageUrl = "/images/product-20.jpg" },
    new Product { Id = 21, Name = "Apple MacBook Air", Price = 1099.99m, Properties = "Apple MacBook Air, M1 chip, 8GB RAM, 256GB SSD, hafif ve ince dizüstü bilgisayar.", ImageUrl = "/images/product-21.jpg" },
    new Product { Id = 22, Name = "Samsung Galaxy Buds Pro", Price = 199.99m, Properties = "Samsung Galaxy Buds Pro, kablosuz kulaklık, aktif gürültü engelleme, üstün ses kalitesi.", ImageUrl = "/images/product-22.jpg" },
    new Product { Id = 23, Name = "LG Gram 17", Price = 1699.99m, Properties = "LG Gram 17, 16GB RAM, 512GB SSD, 17 inç ekran, ultra hafif taşınabilir dizüstü bilgisayar.", ImageUrl = "/images/product-23.jpg" },
    new Product { Id = 24, Name = "Sony Alpha 7 III", Price = 2199.99m, Properties = "Sony Alpha 7 III, 24.2MP, 4K video çekimi, profesyonel fotoğraf makineleri.", ImageUrl = "/images/product-24.jpg" },
    new Product { Id = 25, Name = "Apple iPad Mini", Price = 499.99m, Properties = "Apple iPad Mini, 8.3 inç ekran, A15 Bionic chip, taşınabilir ve güçlü tablet.", ImageUrl = "/images/product-25.jpg" },
    new Product { Id = 26, Name = "Huawei FreeBuds Pro", Price = 179.99m, Properties = "Huawei FreeBuds Pro, kablosuz kulaklık, aktif gürültü engelleme ve yüksek ses kalitesi.", ImageUrl = "/images/product-26.jpg" },
    new Product { Id = 27, Name = "Xiaomi Mi Band 6", Price = 44.99m, Properties = "Xiaomi Mi Band 6, Akıllı bileklik, 1.56 inç AMOLED ekran, spor takibi ve fitness özellikleri.", ImageUrl = "/images/product-27.jpg" },
    new Product { Id = 28, Name = "Samsung 970 EVO Plus SSD", Price = 149.99m, Properties = "Samsung 970 EVO Plus, 1TB SSD, NVMe M.2, ultra hızlı veri transferi.", ImageUrl = "/images/product-28.jpg" },
    new Product { Id = 29, Name = "Lenovo Legion 5", Price = 1399.99m, Properties = "Lenovo Legion 5, 16GB RAM, 512GB SSD, 15.6 inç 144Hz ekran, güçlü oyun laptopu.", ImageUrl = "/images/product-29.jpg" },
    new Product { Id = 30, Name = "Dell Alienware X17", Price = 2499.99m, Properties = "Dell Alienware X17, 32GB RAM, 1TB SSD, 17.3 inç 4K ekran, yüksek performanslı oyun bilgisayarı.", ImageUrl = "/images/product-30.jpg" },
    new Product { Id = 31, Name = "Sony PlayStation 5", Price = 499.99m, Properties = "Sony PlayStation 5, 825GB SSD, 4K oyun desteği, ultra hızlı performans.", ImageUrl = "/images/product-31.jpg" },
    new Product { Id = 32, Name = "Apple TV 4K", Price = 179.99m, Properties = "Apple TV 4K, 64GB, 4K HDR, Dolby Vision ve Dolby Atmos ile mükemmel görüntü ve ses.", ImageUrl = "/images/product-32.jpg" },
    new Product { Id = 33, Name = "Samsung Odyssey G7 Monitor", Price = 799.99m, Properties = "Samsung Odyssey G7, 27in QHD, 240Hz, 1ms tepki süresi ile oyun için en iyi ekran.", ImageUrl = "/images/product-33.jpg" },
    new Product { Id = 34, Name = "Xiaomi Mi Robot Vacuum", Price = 399.99m, Properties = "Xiaomi Mi Robot Vakum, 2.5 saat pil ömrü, akıllı navigasyon, güçlü emiş gücü.", ImageUrl = "/images/product-34.jpg" },
    new Product { Id = 35, Name = "Lenovo Smart Clock", Price = 79.99m, Properties = "Lenovo Smart Clock, Google Assistant ile akıllı saat, uyandırma alarmı ve diğer özellikler.", ImageUrl = "/images/product-35.jpg" }


            };

            
            builder.Entity<Product>().HasData(products);


            builder.Entity<ProductCategories>().HasData(
      // Ana Sayfa Kategorisi (Id = 12)
      new ProductCategories { ProductId = 1, CategoryId = 12 },  // iPhone 14
      new ProductCategories { ProductId = 2, CategoryId = 12 },  // Samsung Galaxy S23
      new ProductCategories { ProductId = 3, CategoryId = 12 },  // Apple MacBook Pro
      new ProductCategories { ProductId = 4, CategoryId = 12 },  // Samsung Galaxy Tab S8
      new ProductCategories { ProductId = 5, CategoryId = 12 },  // Xiaomi Mi 11
      new ProductCategories { ProductId = 6, CategoryId = 12 }, // LG 27GL850-B Monitor
      new ProductCategories { ProductId = 7, CategoryId = 12 }, // Huawei P50 Pro
      new ProductCategories { ProductId = 8, CategoryId = 12 }, // iPad Pro 12.9


      // Diğer kategorilerle ilişkili ürünler
      new ProductCategories { ProductId = 3, CategoryId = 2 },  // LG OLED TV, Elektronik
      new ProductCategories { ProductId = 4, CategoryId = 2 },  // Sony Bravia 65, Elektronik
      new ProductCategories { ProductId = 5, CategoryId = 3 },  // Apple MacBook Pro, Bilgisayarlar
      new ProductCategories { ProductId = 7, CategoryId = 3 },  // Dell XPS 13, Bilgisayarlar
      new ProductCategories { ProductId = 8, CategoryId = 3 },  // Huawei MateBook X, Bilgisayarlar
      new ProductCategories { ProductId = 10, CategoryId = 3 }, // Lenovo ThinkPad X1, Bilgisayarlar
      new ProductCategories { ProductId = 11, CategoryId = 5 }, // Apple AirPods Pro, Aksesuarlar
      new ProductCategories { ProductId = 12, CategoryId = 5 }, // Samsung Galaxy Watch 5, Aksesuarlar
      new ProductCategories { ProductId = 13, CategoryId = 6 }, // LG 27GL850-B Monitor, Monitörler
      new ProductCategories { ProductId = 14, CategoryId = 5 }, // Sony WH-1000XM5, Aksesuarlar
      new ProductCategories { ProductId = 17, CategoryId = 5 }, // Apple Watch Series 7, Aksesuarlar
      new ProductCategories { ProductId = 18, CategoryId = 2 }, // Samsung QLED 65in TV, Elektronik
      new ProductCategories { ProductId = 21, CategoryId = 3 }, // Apple MacBook Air, Bilgisayarlar
      new ProductCategories { ProductId = 22, CategoryId = 5 }, // Samsung Galaxy Buds Pro, Aksesuarlar
      new ProductCategories { ProductId = 23, CategoryId = 3 }, // LG Gram 17, Bilgisayarlar
      new ProductCategories { ProductId = 24, CategoryId = 7 }, // Sony Alpha 7 III, Kameralar
      new ProductCategories { ProductId = 25, CategoryId = 4 }, // Apple iPad Mini, Tabletler
      new ProductCategories { ProductId = 26, CategoryId = 5 }, // Huawei FreeBuds Pro, Aksesuarlar
      new ProductCategories { ProductId = 27, CategoryId = 8 }, // Xiaomi Mi Band 6, Fitness Ürünleri
      new ProductCategories { ProductId = 28, CategoryId = 9 }, // Samsung 970 EVO Plus SSD, Depolama
      new ProductCategories { ProductId = 29, CategoryId = 3 }, // Lenovo Legion 5, Bilgisayarlar
      new ProductCategories { ProductId = 30, CategoryId = 3 }, // Dell Alienware X17, Bilgisayarlar
      new ProductCategories { ProductId = 31, CategoryId = 10 }, // Sony PlayStation 5, Oyun Konsolları
      new ProductCategories { ProductId = 32, CategoryId = 11 }, // Apple TV 4K, Akıllı Ev Ürünleri
      new ProductCategories { ProductId = 33, CategoryId = 6 }, // Samsung Odyssey G7 Monitor, Monitörler
      new ProductCategories { ProductId = 34, CategoryId = 12 }, // Xiaomi Mi Robot Vacuum, Ev Elektroniği
      new ProductCategories { ProductId = 35, CategoryId = 5 }, // Lenovo Smart Clock, Akıllı Ev Ürünleri
      new ProductCategories { ProductId = 36, CategoryId = 5 }, // Huawei Watch GT 3, Aksesuarlar
      new ProductCategories { ProductId = 37, CategoryId = 1 }, // Sony Xperia 5 III, Mobil Cihazlar
      new ProductCategories { ProductId = 38, CategoryId = 3 }, // Apple iMac 24\" M1, Bilgisayarlar
      new ProductCategories { ProductId = 39, CategoryId = 1 }, // Samsung Galaxy Note 20 Ultra, Mobil Cihazlar
      new ProductCategories { ProductId = 40, CategoryId = 1 }, // Xiaomi Redmi Note 11 Pro, Mobil Cihazlar
      new ProductCategories { ProductId = 41, CategoryId = 3 }, // Lenovo Yoga 9i, Bilgisayarlar
      new ProductCategories { ProductId = 42, CategoryId = 5 }, // Apple Magic Mouse, Aksesuarlar
      new ProductCategories { ProductId = 43, CategoryId = 5 }, // Sony WH-XB900N, Aksesuarlar
      new ProductCategories { ProductId = 44, CategoryId = 11 }, // Apple HomePod Mini, Akıllı Ev Ürünleri
      new ProductCategories { ProductId = 45, CategoryId = 9 }, // Samsung T7 Touch SSD, Depolama
      new ProductCategories { ProductId = 46, CategoryId = 1 }, // Xiaomi Mi 11 Lite, Mobil Cihazlar
      new ProductCategories { ProductId = 47, CategoryId = 3 }, // Lenovo IdeaPad Flex 5, Bilgisayarlar
      new ProductCategories { ProductId = 48, CategoryId = 2 }, // Sony Bravia A80J, Elektronik
      new ProductCategories { ProductId = 49, CategoryId = 5 }, // Apple Pencil 2. Nesil, Aksesuarlar
      new ProductCategories { ProductId = 50, CategoryId = 1 }  // Samsung Galaxy Z Fold 4, Mobil Cihazlar
  );



            builder.Entity<Order>().HasData(
           
                new Order { Id = 130, ApplicationUserId = "14a0183f-1e96-4930-a83d-6ef5f22d8c09", OrderStatus = OrderStatus.Pending, CreatedDate = new DateTime(2024, 12, 29) }
            );

            
            builder.Entity<OrderItem>().HasData(
               
                new OrderItem { Id = 230, OrderId = 130, ProductId = 50, UnitPrice = 89.99m, Quantity = 1 }
            );

            
            builder.Entity<ApplicationRole>().HasData(
                new ApplicationRole { Id = "115c7796-cfac-44de-91b5-916eaae125b5", Name = "AdminUser", NormalizedName = "ADMINUSER", Description = "Administrator role" },
                new ApplicationRole { Id = "811f466c-9d06-43f8-a054-24aedbb4161b", Name = "NormalUser", NormalizedName = "NORMALUSER", Description = "Regular user role" }
            );

            
            var hasher = new PasswordHasher<ApplicationUser>();
            var adminUser = new ApplicationUser
            {
                Id = "c0b7fef7-df2b-4857-9b3d-bc8967ad19ac",
                UserName = "adminuser@gmail.com",
                NormalizedUserName = "ADMINUSER@GMAIL.COM",
                Email = "adminuser@gmail.com",
                NormalizedEmail = "ADMINUSER@GMAIL.COM",
                EmailConfirmed = true,
                FirstName = "Admin",
                LastName = "User",
                Address = "",
                PhoneNumber = "",
                City = "",
                DateOfBirth = DateTime.Now,

                PasswordHash = hasher.HashPassword(null, "Qwe123.,")
            };
            var normalUser = new ApplicationUser
            {
                Id = "14a0183f-1e96-4930-a83d-6ef5f22d8c09",
                UserName = "normaluser@gmail.com",
                NormalizedUserName = "NORMALUSER@GMAIL.COM",
                Email = "normaluser@gmail.com",
                NormalizedEmail = "NORMALUSER@GMAIL.COM",
                EmailConfirmed = true,
                FirstName = "Normal",
                LastName = "User",
                Address = "",
                PhoneNumber = "",
                City = "",
                DateOfBirth = DateTime.Now,

                PasswordHash = hasher.HashPassword(null, "Qwe123.,")
            };
            builder.Entity<ApplicationUser>().HasData(adminUser, normalUser);

            // Assign roles to users
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { UserId = adminUser.Id, RoleId = "115c7796-cfac-44de-91b5-916eaae125b5" },
                new IdentityUserRole<string> { UserId = normalUser.Id, RoleId = "811f466c-9d06-43f8-a054-24aedbb4161b" }
            );

            builder.Entity<Basket>().HasData(
                new Basket { Id = 1, ApplicationUserId = adminUser.Id },
                new Basket { Id = 2, ApplicationUserId = normalUser.Id }
            );

            builder.Entity<Coupon>().HasData(
            new Coupon
            {
                 Id = 1,  
                 Code = "MERHABA20",
                 DiscountPercentage = 20
            },
            new Coupon
            {
                 Id = 2,
                 Code = "INDIRIM10",
                 DiscountPercentage = 10
            },
            new Coupon
            {
                 Id = 3,
                 Code = "HOŞGELDIN15",
                 DiscountPercentage = 15
            }
             );

           builder.Entity<Settings>().HasData(
                new Settings{
                    Id = 3,
                    LogoPath = "images/18e44284-f31f-497b-81a1-62da2a31fea9.png",
                    FooterLogoPath = "images/9a0ca075-205b-439e-ac0e-6a607b52a09b.png",
                    FooterText = "All Rights Reserved.",
                    Banner1Path = "images/e809f6cf-8fd0-4217-bbd9-60b52dd0620c.png",
                    Banner2Path = "images/deb0b266-1e12-49d2-97ff-fd19c2ebb8b8.png",
                    Banner3Path = "images/232d72b1-c24c-41f0-bc0f-c396e0a16347.png",
                    SliderText = "E-ticaret sitemize hoş geldiniz! Sizin için en iyi ürünleri burada bulabilirsiniz.",
                    AboutBannerPath = "images/0f28bbb8-1897-43b0-aef1-0598efcfccc4.png",
                    AboutTextTitle = "Hakkımızda",
                    AboutText = "Biz, geniş ürün yelpazesi sunan lider bir e-ticaret şirketiyiz.",
                    AboutPhotoPath = "images/f3651d17-2c1e-4fe8-8bc6-9a4922a29043.png",
                    ContactBannerPath = "images/eefaa8e9-e2b7-4cb8-85e1-345994ef9420.png",
                    MapLocation = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3022.073292073073!2d-73.9854286845949!3d40.74881797932569!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x89c2598f3f3b3b3f%3A0x1c3bb99243deb742!2sEmpire%20State%20Building!5e0!3m2!1str!2str!4v1640730000000!5m2!1str!2str",
                    SocialMediaUrl="https://www.facebook.com/",
                    SocialMediaUrl2="https://www.instagram.com/",
                    SocialMediaUrl3="https://www.twitter.com/",
                }
            );

        }
    }
}