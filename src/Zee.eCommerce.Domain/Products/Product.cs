using Zee.eCommerce.Framework;

namespace Zee.eCommerce.Domain.Products;
public class Product : AggregateRoot<ProductId>
{
    public Product()
    {
    }

    #region properties
    public ProductName Name { get; private set; }


    public override string ToString()
    {
        return base.ToString();
    }

    protected override void EnsureValidState()
    {
        throw new System.NotImplementedException();
    }

    protected override void When(object @event)
    {
        throw new System.NotImplementedException();
    }
    #endregion
}
