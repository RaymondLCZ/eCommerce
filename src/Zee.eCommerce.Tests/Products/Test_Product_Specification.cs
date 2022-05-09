using System;
using NUnit.Framework;
using Zee.eCommerce.Domain.Products;
using Zee.eCommerce.Framework;

namespace Tests
{
    [Category("Product")]
    public class Test_Product_Specification
    {
        private string name = string.Empty;

        [SetUp]
        public void Setup()
        {
            name = "ABCXXSS";
        }

        [Test]
        public void Product_Should_Pass_When_Create_Valid()
        {
            TestDelegate code = () => new Product(new ProductId(Guid.NewGuid()), new ProductName(name));

            Assert.DoesNotThrow(code);
        }

        [Test]
        public void Product_Shoule_Pass_When_Submit_Valid()
        {
            var product = new Product(new ProductId(Guid.NewGuid()), new ProductName(name));

            
        }
    }
}