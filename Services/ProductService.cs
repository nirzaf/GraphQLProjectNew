using GraphQLProject.Interfaces;
using GraphQLProject.Models;

namespace GraphQLProject.Services;

public class ProductService : IProduct
{
    private static List<Product?> _productList = new()
    {
        new Product { Id = 1, Name = "Coffee", Price = 10 },
        new Product { Id = 2, Name = "Banana", Price = 20 },
        new Product { Id = 3, Name = "Fruit", Price = 30 },
        new Product { Id = 4, Name = "Vegetables", Price = 40 }
    };
    
    
    public IEnumerable<Product> GetAllProducts()
    {
        return _productList;
    }

    public Product? GetProductById(int id)
    {
        return _productList.FirstOrDefault(p => p!.Id == id);
    }

    public Product AddProduct(Product product)
    {
        _productList.Add(product);
        return product;
    }

    public Product UpdateProduct(int id, Product product)
    {
        var prod = _productList.FirstOrDefault(p => p.Id == id);
        if (prod == null) return product;
        prod.Name = product.Name;
        prod.Price = product.Price;
        return product;
    }

    public void DeleteProduct(int id)
    {
        var prod = _productList.FirstOrDefault(p => p.Id == id);
        if(prod != null)
            _productList.Remove(prod);
    }
}