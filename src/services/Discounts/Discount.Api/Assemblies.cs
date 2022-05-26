using Discount.Application.Coupons.Create;
using Discount.Domain.Coupons;
using Discount.Infrastructure;
using System.Reflection;

namespace Discount.Api
{
    public static class Assemblies
    {
        public static readonly Assembly EntityAssembly = typeof(Coupon).Assembly;
        public static readonly Assembly ApplicationAssembly = typeof(CreateCouponCommand).Assembly;
        public static readonly Assembly InfrastructureAssembly = typeof(DiscountDbContext).Assembly;
    }
}
