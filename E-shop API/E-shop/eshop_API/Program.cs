using System.Text;
using eshop_Data;
using eshop_Data.Abstract;
using eshop_Data.Contcrete.Context;
using eshop_Data.Repositories;
using eshop_Entity.Contcrete;
using eshop_Service.Abstract;
using eshop_Service.Concrete;
using eshop_Service.Configuration;
using eshop_Service.MappingProfile;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpContextAccessor();


builder.Services.AddDbContext<EshopDbContext>(x=>x.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IUnitOfWork,UnitOfWork>();
builder.Services.AddScoped(typeof(IGenericRepository<>),typeof(GenericRepository<>));
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IBasketService, BasketService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IContactMessageService, ContactMessageService>();
builder.Services.AddScoped<ISettingsService, SettingsService>();
builder.Services.AddScoped<IPaymentService, PaymentService>();
builder.Services.AddScoped<IImageService, ImageService>();
builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddScoped<ICouponService, CouponService>();
builder.Services.AddScoped<ICommentService, CommentService>();


builder.Services.AddAutoMapper(typeof(MappingProfile));


builder.Services.AddIdentity<ApplicationUser, ApplicationRole>(x =>
{
    x.Password.RequireDigit = true;
    x.Password.RequireLowercase = true;
    x.Password.RequireUppercase = true;
    x.Password.RequireNonAlphanumeric = true;
    x.Password.RequiredLength = 8;

    x.User.RequireUniqueEmail = true;
    x.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyz0123456789-._@+";
}).AddEntityFrameworkStores<EshopDbContext>().AddDefaultTokenProviders();

builder.Services.Configure<JwtConfig>(builder.Configuration.GetSection("JwtConfig"));

var JwtConfig = builder.Configuration.GetSection("JwtConfig").Get<JwtConfig>();

builder.Services.AddAuthentication(x => { 
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme; 
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme; }
    

    )
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = JwtConfig?.Issuer,
            ValidAudience = JwtConfig?.Audience,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtConfig?.Secret ?? ""))
        };
    });

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("adminUser", policy => policy.RequireRole("adminUser"));
    options.AddPolicy("normalUser", policy => policy.RequireRole("normalUser"));


});


builder.Services.AddScoped<IAuthService, AuthService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
