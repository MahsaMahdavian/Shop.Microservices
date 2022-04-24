﻿using GraphQL.Types;

namespace products.Api.GQL.Types.Products
{
    public class ProductReqType:InputObjectGraphType
    {
        public ProductReqType()
        {
            Name =nameof(ProductReqType);
            Field<IdGraphType>("id");
            Field<BooleanGraphType>("Active");
            Field<StringGraphType>("Title");
            Field<StringGraphType>("Description");
            Field<StringGraphType>("CoverImageUrl");
            Field<DecimalGraphType>("Price");
            Field<StringGraphType>("Code");
            Field<StringGraphType>("Permalink");
            Field<IntGraphType>("CategoryId");
        }
    }
}
