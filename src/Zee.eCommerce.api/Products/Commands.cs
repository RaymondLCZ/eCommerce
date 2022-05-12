using System.ComponentModel;

namespace Zee.eCommerce.Api.Products;

public static class Commands
{
    public static class V1
    {
        [DisplayName("CreateProduct")]
        public class Create
        {
            public string? Name { get; set; }
            public string? DisplayName { get; set; }
           
        }
    }
}