using GraphQLProject.Interfaces;
using GraphQLProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace GraphQLProject.Controllers;

[Route("api/controller")]
[ApiController]
public class ProductController : Controller
{
    private readonly IProduct _product;
    public ProductController(IProduct product)
    {
        _product = product;
    }
    // GET
    [HttpGet]
    public IEnumerable<Product> GetProducts()
    {
        return _product.GetAllProducts();
    }

    [HttpGet("{id}")]
    public Product? GetProductsById(int id)
    {
        return _product.GetProductById(id);
    }
    
    [HttpPost]
    public Product PostProduct([FromBody] Product product)
    {
        return _product.AddProduct(product);
    }

    [HttpPut("{id}")]
    public Product UpdateProduct(int id, Product product)
    {
        return _product.UpdateProduct(id, product);
    }

    [HttpDelete("{id}")]
    public void DeleteProduct(int id)
    {
        _product.DeleteProduct(id);
    }
}