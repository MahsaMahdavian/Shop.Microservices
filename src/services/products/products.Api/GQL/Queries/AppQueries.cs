using GraphQL.Types;
using MediatR;

namespace products.Api.GQL.Queries
{
    public class AppQueries: ObjectGraphType
    {
        public AppQueries(IMediator mediator)
        {
            this.ProductQueries(mediator);
        }
    }
}
