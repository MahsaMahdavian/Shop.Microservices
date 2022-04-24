using GraphQL;
using GraphQL.Types;
using MediatR;
using products.Api.GQL.Types;
using products.Api.GQL.Types.Products;
using products.Application.Products.Queries;

namespace products.Api.GQL.Queries
{
    public static class ProductsQueries
    {
        public static void ProductQueries(this ObjectGraphType schema, IMediator mediator)
        {
            schema.Field<ListGraphType<ProductResType>>(
                "getProducts",
                description: "Return list of products",
                resolve: context => mediator.Send(new GetProductsListQuery())
                );

            schema.FieldAsync<PaginitionResType<ListGraphType<ProductResType>>>(
                           "getProductsByFilter",
                           description: "return list of filtered prdoucts",
                           arguments: new QueryArguments(new QueryArgument<NonNullGraphType<ProductFilterType>> { Name = "filter" }),


                           resolve: async context =>
                           {
                               var filterParams = context.GetArgument<GetProductsListQuery>("filter");
                               var res = await mediator.Send(filterParams);

                               return res;
                           });
        }

    }
}
