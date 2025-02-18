using System;
using System.Linq;
using AutoMapper;
using eshop_Entity.Contcrete;
using eshop_Shared.DTOs;
using eshop_Shared.DTOs.SettingsDTOs;
using System.Threading.Tasks;
using System.Text;

namespace eshop_Service.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
           
             #region category
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Category, CategoryCreateDTO>().ReverseMap();
            CreateMap<Category, CategoryUpdateDTO>().ReverseMap();
            #endregion

            #region product
            CreateMap<Product, ProductDTO>()
                .ForMember(pDto => pDto.Categories, option => option
                    .MapFrom(p => p.ProductCategories.Select(pc => pc.Category)))
                .ReverseMap();
            CreateMap<Product, ProductCreateDTO>().ReverseMap();
            CreateMap<Product, ProductUpdateDTO>().ReverseMap();
            #endregion

           
            #region basket
                CreateMap<BasketItem, BasketItemDTO>()
                   .ForMember(dest => dest.product, opt => opt.MapFrom(src => src.Product))
                   .ReverseMap();
                CreateMap<Basket, BasketDTO>()
                    .ForMember(dest => dest.ApplicationUser, opt => opt.MapFrom(src => src.ApplicationUser))
                    .ForMember(dest => dest.BasketItems, opt => opt.MapFrom(src => src.BasketItems))
                    .ReverseMap();
                CreateMap<Basket, BasketCreateDTO>().ReverseMap();
                CreateMap<BasketItem, BasketItemDTO>()
                    .ForMember(dest => dest.product, opt => opt.MapFrom(src => src.Product))
                    .ReverseMap();
                CreateMap<BasketItem, BasketItemCreateDTO>().ReverseMap();
                CreateMap<BasketItem, BasketItemUpdate>().ReverseMap();
                CreateMap<BasketItemRemove, BasketItem>().ReverseMap();
            #endregion

            #region order
            CreateMap<OrderItem, OrderItemDTO>()
                .ForMember(dest => dest.Product, opt => opt.MapFrom(src => src.Product))
                .ReverseMap();
            CreateMap<OrderItem, OrderItemCreateDTO>().ReverseMap();
            CreateMap<Order, OrderDTO>()
                .ForMember(dest => dest.ApplicationUser, opt => opt.MapFrom(src => src.ApplicationUser))
                .ForMember(dest => dest.OrderItems, opt => opt.MapFrom(src => src.OrderItems))
                 
                .ReverseMap();
            CreateMap<Order, OrderCreateDTO>()
                .ForMember(dest => dest.OrderItems, opt => opt.MapFrom(src => src.OrderItems))
                 
                .ReverseMap();
            #endregion

            #region settings
            CreateMap<Settings, SettingsDTO>().ReverseMap();
            CreateMap<Settings, GetSettingsDTO>().ReverseMap();
            CreateMap<Settings, UpdateSettingsDTO>().ReverseMap();
            CreateMap<Settings, LogoPathDTO>().ReverseMap();
            CreateMap<Settings, FooterLogoPathDTO>().ReverseMap();
            CreateMap<Settings, Banner1PathDTO>().ReverseMap();
            CreateMap<Settings, Banner2PathDTO>().ReverseMap();
            CreateMap<Settings, Banner3PathDTO>().ReverseMap();
            CreateMap<Settings, AboutBannerPathDTO>().ReverseMap();
            CreateMap<Settings, AboutPhotoPathDTO>().ReverseMap();
            CreateMap<Settings, ContactBannerPathDTO>().ReverseMap();

            #endregion
            #region ContactMessage
            CreateMap<ContactMessage, ContactMessageDTO>().ReverseMap();
            CreateMap<ContactMessage, CreateContactMessageDto>().ReverseMap();
            #endregion
            #region ApplicationUpdateUser
            CreateMap<ApplicationUser, ApplicationUserUpdateDTO>().ReverseMap();
            #endregion
            #region Payment
            CreateMap<Payment, PaymentDTO>().ReverseMap();
            #endregion
            #region Coupons

            CreateMap<Coupon, CouponDTO>().ReverseMap();
            CreateMap<Coupon, CouponCreateDTO>().ReverseMap();
            CreateMap<Coupon, CouponApplyDTO>()
           .ForMember(dest => dest.TotalAmount, opt => opt.Ignore());
            #endregion

            #region Comment
            CreateMap<Comment, CommentDTO>().ReverseMap();
            CreateMap<Comment, CreateCommentDTO>().ReverseMap();
            #endregion
        }
    }
}