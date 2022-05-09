using System;
using Zee.eCommerce.Framework;

namespace Zee.eCommerce.Domain.Products;

public class ProductName : Value<ProductName>
{
    public string Value { get; private set; }

    public ProductName(string value) => Value = value;

    public static implicit operator ProductName(string value) => new ProductName(value);
    public static implicit operator string(ProductName name) => name.Value;
}