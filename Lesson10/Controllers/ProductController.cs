using System.Collections.Generic;
using Lesson10.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson10.Controllers;

[Route("[controller]")]
public class ProductController : ControllerBase
{
    private static readonly List<Product> _products = new()
    {
        new Food() { Name = "Молоко", Description = "Простоквашино", Count = 100 },
        new Accessories() { Name = "Часы", Description = "Ролекс", Count = 1 },
        new Book() { Name = "Книга", Description = "Властелин колец", Count = 10 }
    };
    
    [HttpGet("{id}")]
    public Product GetProduct([FromRoute]int id)
    {
        return _products[id];
    }
    
    [HttpPost("{id}")]
    public Product UpdateProduct([FromRoute]int id, [FromBody] Product updatedProduct)
    {
        _products[id] = updatedProduct;
        return _products[id];
    }

    [HttpPost("create-product")]
    public Product? CreateProduct([FromBody] Product createdProduct) {
        if (createdProduct == null) {
            return null;
        }
        _products.Add(createdProduct);
        return createdProduct;
    }
}