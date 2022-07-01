using GraphQL.Types;
using GraphQLProject.Models;

namespace GraphQLProject.Type;

public sealed class ProductType : ObjectGraphType<Product>
{
    public ProductType()
    {
        Field(p => p.Id);
        Field(p => p.Name);
        Field(p => p.Price);
    }
}