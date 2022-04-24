using GraphQL.Types;

namespace products.Api.GQL.Types
{
    public class PaginitionResType<TDto> : ObjectGraphType where TDto : IGraphType
    {
        public PaginitionResType()
        {
            Name = "PaginationResType";
            Field<TDto>("Data");
            Field<IntGraphType>("PageSize");
            Field<IntGraphType>("PageIndex");
            Field<IntGraphType>("TotalCount");
        }

    }
}
