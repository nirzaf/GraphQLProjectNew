using GraphQLProject.Models;

namespace GraphQLProject.Interfaces;

public interface IProduct
{
    List<Product?> GetAllProducts();
    Product? GetProductById(int id);
    Product AddProduct(Product product);
    Product UpdateProduct(int Id, Product product);
    void DeleteProduct(int Id);
}