
namespace Zee.eCommerce.Domain.Products;

public static class Events  
{
    /// <summary>商品新增</summary>
    public class ProductCreated
    {
        public Guid Id { get; set; }
        public string? Name { get; set; } = default;
    }
}