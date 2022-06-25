using GraphQLProject.Query;

namespace GraphQLProject.Schema;

public class ProductSchema : GraphQL.Types.Schema
{
    public ProductSchema(ProductQuery productQuery) 
    {
        Query = productQuery;
    }
}