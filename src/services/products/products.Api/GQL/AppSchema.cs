using GraphQL.Types;
using products.Api.GQL.Mutation;
using products.Api.GQL.Queries;

namespace products.Api.GQL
{
    public class AppSchema:Schema
    {
        public AppSchema(AppQueries appQueries, AppMutation appMutation)
        {
            this.Query=appQueries;  
            this.Mutation=appMutation;  

        }
    }
}
