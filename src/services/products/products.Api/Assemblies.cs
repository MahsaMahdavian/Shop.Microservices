using products.Application.Products.Command.Create;
using products.Domain.Products;
using products.Infrustructure;
using System.Reflection;

namespace products.Api
{
    public class Assemblies
    {
        public static readonly Assembly EntityAssembly = typeof(Product).Assembly;
        public static readonly Assembly InfrastructureAssembly = typeof(ProductDBContext).Assembly;
        public static readonly Assembly ApplicationAssembly = typeof(AddProductCommand).Assembly;
    }
}
