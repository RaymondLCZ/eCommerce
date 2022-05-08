using System;
using Zee.eCommerce.Framework;

namespace Zee.eCommerce.Domain.Products;

public class ProductName : Value<ProductName>
{
    public string Value { get; private set; }

    public ProductName(string value) => Value = value;
}