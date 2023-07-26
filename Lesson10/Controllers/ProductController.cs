using System.Collections.Generic;
using Lesson10.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson10.Controllers;

[Route("[controller]")]
public class ProductController : ControllerBase
{
    public static readonly List<Product> Products = new()
    {
        new() { Name = "Молоко", Description = "Простоквашино", Count = 100 },
        new() { Name = "Часы", Description = "Ролекс", Count = 1 },
        new() { Name = "Книга", Description = "Властелин колец", Count = 10 }
    };
    
    [HttpGet("{id}")]
    public Product GetProduct([FromRoute]int id)
    {
        return Products[id];
    }
    
    [HttpPost("{id}")]
    public Product UpdateProduct([FromRoute]int id, [FromBody] Product updatedProduct)
    {
        Products[id] = updatedProduct;
        return Products[id];
    }
}