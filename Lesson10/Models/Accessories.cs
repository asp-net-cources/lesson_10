using System.Text.Json.Serialization;

namespace Lesson10.Models;

public class Accessories : Product
{
    public new ProductType ProductType { get; } = ProductType.Accessories;
}
