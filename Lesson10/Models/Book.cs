namespace Lesson10.Models;

public class Book : Product
{
    public new ProductType ProductType { get; } = ProductType.Book;
}
