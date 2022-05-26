using AutoMapper;
using Discount.Domain.Coupons;
using System;


namespace Discount.Infrastructure.Coupons
{
    public class CouponMappingProfile : Profile
    {

        public CouponMappingProfile()
        {
            CreateMap<Coupon, CouponDto>().ReverseMap();
        }
    }
}
