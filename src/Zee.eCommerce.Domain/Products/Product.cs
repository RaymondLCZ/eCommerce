using Zee.eCommerce.Domain.Shared;
using Zee.eCommerce.Framework;

namespace Zee.eCommerce.Domain.Products;
public class Product : AggregateRoot<ProductId>
{
    #region constructor
    protected Product()
    { }

    public Product(ProductId id, ProductName name)
    {
        Apply(new Events.ProductCreated
        {
            Id = id,
            Name = name
        });

    }
    #endregion

    #region properties
    public ProductName Name { get; private set; }
    public EntityState Status { get; private set; }
    #endregion

    protected override void EnsureValidState()
    {
        switch (Status)
        {
            case EntityState.Draft:
                break;

            case EntityState.PendingReview:
                break;
        }
    }

    protected override void When(object @event)
    {
        switch (@event)
        {
            case Events.ProductCreated e:
                Id = new ProductId(e.Id);
                Name = new ProductName(e.Name);
                Status = EntityState.Draft;

                break;
        }
    }

}
