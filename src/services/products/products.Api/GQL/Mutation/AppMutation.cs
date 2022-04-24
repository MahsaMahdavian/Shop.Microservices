using GraphQL.Types;
using MediatR;

namespace products.Api.GQL.Mutation
{
    public class AppMutation: ObjectGraphType
    {
        public AppMutation(IMediator mediator)
        {
            this.ProductMutations(mediator);
        }
    }
}
