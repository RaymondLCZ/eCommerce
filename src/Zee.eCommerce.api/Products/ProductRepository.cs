using Zee.eCommerce.Domain.Products;
using Zee.eCommerce.Api.Infrastructure;

namespace Zee.eCommerce.Api.Products;

public class ProductRepository : IProductRepository, IDisposable
{
    public Task<Product> Load(Guid Id)
    {
        throw new NotImplementedException();
    }

    public Task Add(Product entity)
    {
        throw new NotImplementedException();
    }

    public Task Update(Product entity)
    {
        throw new NotImplementedException();
    }
    
    private bool disposedValue;

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                // TODO: dispose managed state (managed objects)
            }

            // TODO: free unmanaged resources (unmanaged objects) and override finalizer
            // TODO: set large fields to null
            disposedValue = true;
        }
    }

    // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
    // ~ProductRepository()
    // {
    //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
    //     Dispose(disposing: false);
    // }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }

    
}