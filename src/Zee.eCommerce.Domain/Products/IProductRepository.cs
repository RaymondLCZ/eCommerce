namespace Zee.eCommerce.Domain.Products;

public interface IProductRepository
{
    Task<Product> Load(Guid Id);

    Task Add(Product entity);

    Task Update(Product entity);
}
