﻿
using Discount.Domain.Coupons;
using Discount.Infrastructure;
using Discount.Infrastructure.Coupons;
using MediatR;
using Microsoft.EntityFrameworkCore;
using products.Api;
using System.Text.Json.Serialization;

namespace Discount.Api
{
    public static class ServiceRegistery
    {
        public static IServiceCollection AddServiceRegistery(this WebApplicationBuilder builder)
        {

            builder.Services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
                options.JsonSerializerOptions.WriteIndented = true;
            });
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();




            return builder.Services;
        }

        public static IServiceCollection AddInfrastructureServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddAutoMapper(Assemblies.InfrastructureAssembly);
            builder.Services.AddDbContext<DiscountDbContext>(option =>
                option.UseNpgsql(builder.Configuration.GetConnectionString("DiscountDbConn")));
            builder.Services.AddScoped<ICouponRepository, CouponRepository>();
            return builder.Services;
        }
        public static IServiceCollection AddApplicationServices(this WebApplicationBuilder builder)
        {

            builder.Services.AddMediatR(Assemblies.ApplicationAssembly);

            return builder.Services;
        }
    }
}
