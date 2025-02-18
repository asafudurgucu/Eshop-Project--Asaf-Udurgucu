using eshop_MVC.Abstract;
using eshop_MVC.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.DataProtection;
using NToastNotify;

var builder = WebApplication.CreateBuilder(args);


builder.Services
    .AddControllersWithViews()
    .AddNToastNotifyToastr(new ToastrOptions
    {
        ProgressBar = true,
        PositionClass = ToastPositions.TopRight,
        CloseButton = true,
        TimeOut = 5000,
        ShowDuration = 1000,
        HideDuration = 1000,
        ShowEasing = "swing",
        HideEasing = "linear",
        ShowMethod = "fadeIn",
        HideMethod = "fadeOut"
    });

builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IBasketService, BasketService>();
builder.Services.AddScoped<IContactMessage, ContactMessageService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IPaymentService,PaymentService>();
builder.Services.AddScoped<ISettingService,SettingService>();
builder.Services.AddScoped<ICouponService,CouponService>();
builder.Services.AddScoped<ICommentService,CommentService>();



// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddHttpClient("EshopAPI", client =>
{
    client.BaseAddress = new Uri("http://localhost:5051/api/");
});


builder
    .Services
    .AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.Cookie.Name = "Eshop.Auth";
        options.LoginPath= "/Auth/Login";
        options.AccessDeniedPath="/Auth/AccessDenied";
        options.ExpireTimeSpan = TimeSpan.FromHours(1);
        options.Cookie.HttpOnly = true;
    });

builder.Services.AddAuthorization();

#region DataProtection
builder.Services.AddDataProtection()
    .PersistKeysToFileSystem(new DirectoryInfo(Path.Combine(builder.Environment.ContentRootPath, "keys")))
    .SetApplicationName("eshop_MVC")
    .SetDefaultKeyLifetime(TimeSpan.FromDays(14));

builder.Services.AddDistributedMemoryCache();
#endregion


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseStaticFiles();


app.UseAuthentication();

app.UseRouting();

app.UseAuthorization();

app.UseNToastNotify();

app.MapAreaControllerRoute(
    name: "admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Index}/{id?}",
    defaults: new { area = "Admin" });


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
