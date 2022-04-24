using GraphQL;
using GraphQL.Types;
using MediatR;
using products.Api.GQL.Types.Products;
using products.Application.Products.Command.Create;
using products.Application.Products.Command.Update;
using products.Domain.Products;

namespace products.Api.GQL.Mutation
{
    public static class ProductsMutations
    {
        public static void ProductMutations(this ObjectGraphType schema,IMediator mediator)
        {
            schema.FieldAsync<ProductResType>(

                "addProduct",
                "Is used to add a new product to the database",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<ProductReqType>> { Name= "ProductInput", Description="product input parameter"}),
                resolve: async context =>

                {
                    var addProduct = context.GetArgument<AddProductCommand>("ProductInput");
                    ProductResDto addProductRes=new ProductResDto();
                    try
                    {
                        addProductRes = await mediator.Send(addProduct);
                    }
                    catch (Exception ex)
                    {

                        context.Errors.Add(new ExecutionError(ex.Message));
                        return null;
                    }
                    return addProductRes;
                }

                );
            schema.FieldAsync<BooleanGraphType>(

                "updateProduct",
                "Is used to update a  product to the database",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<ProductReqType>> { Name = "ProductInput", Description = "product input parameter" }),
                resolve: async context =>

                {
                    UpdateProductCommand updateProduct = context.GetArgument<UpdateProductCommand>("ProductInput");

                    bool updateProductRes;
                    try
                    {
                        updateProductRes = await mediator.Send(updateProduct);
                    }
                    catch (Exception ex)
                    {

                        context.Errors.Add(new ExecutionError(ex.Message));
                        return null;
                    }
                    return updateProductRes;
                }

                );

        }
    }
}
