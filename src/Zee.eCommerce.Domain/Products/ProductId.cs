using System;
using Zee.eCommerce.Framework;

namespace Zee.eCommerce.Domain.Products;

public class ProductId
{
    public Guid Value { get; private set; }

    protected ProductId() { }

    public ProductId(Guid value) => Value = value;

    public static implicit operator Guid(ProductId self) => self.Value;
    public static implicit operator ProductId(string value) => new ProductId(Guid.Parse(value));
}