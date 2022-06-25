using GraphQLProject.Models;

namespace GraphQLProject.Interfaces;

public interface IProduct
{
    IEnumerable<Product> GetAllProducts();
    Product? GetProductById(int id);
    Product AddProduct(Product product);
    Product UpdateProduct(int id, Product product);
    void DeleteProduct(int id);
}