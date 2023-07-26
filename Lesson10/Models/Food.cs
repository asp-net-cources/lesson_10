namespace Lesson10.Models;

public class Food : Product
{
    public new ProductType ProductType { get; } = ProductType.Food;
}
