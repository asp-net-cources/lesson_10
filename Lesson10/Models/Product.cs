using System.Text.Json.Serialization;

namespace Lesson10.Models;

public abstract class Product
{
    [JsonPropertyName("id")]
    [JsonPropertyOrder(-1)]
    public int Id { get; private set; }
    [JsonPropertyOrder(2)]
    public string Name { get; set; }
    [JsonPropertyOrder(3)]
    public string Description { get; set; }
    [JsonPropertyOrder(4)]
    public int Count { get; set; }
    [JsonPropertyOrder(1)]
    public ProductType ProductType { get; set; }
    [JsonIgnore]
    public DateTime CreatedOn { get; } = DateTime.UtcNow;
}