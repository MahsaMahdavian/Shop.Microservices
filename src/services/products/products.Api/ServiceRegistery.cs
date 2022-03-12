using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using products.Application.Behaviours;
using products.Domain;
using products.Infrustructure;
using System.Text.Json.Serialization;

namespace products.Api
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


        public static IServiceCollection AddInfrustructureServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddAutoMapper(Assemblies.InfrastructureAssembly);
            builder.Services.AddDbContext<ProductDBContext>(option =>
              option.UseNpgsql(builder.Configuration.GetConnectionString("ProductDbConn")));
            builder.Services.AddScoped<IReadUnitOfWork, ReadUnitOfWork>();
            builder.Services.AddScoped<IWriteUnitOfWork, WriteUnitOfWork>();
            return builder.Services;
        }

        public static IServiceCollection AddApplicationServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddValidatorsFromAssembly(Assemblies.ApplicationAssembly);
            builder.Services.AddMediatR(Assemblies.ApplicationAssembly);
            builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehaviour<,>));
            builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
            return builder.Services;
        }
    }
}
