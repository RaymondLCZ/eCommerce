using Microsoft.EntityFrameworkCore;
using Zee.eCommerce.Domain.Products;

namespace Zee.eCommerce.Api.Infrastructure;

public class EDbContext : DbContext
{
    private readonly ILoggerFactory _loggerFactory;

    public EDbContext(DbContextOptions<EDbContext> options, ILoggerFactory loggerFactory) : base(options)
    {

        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseLazyLoadingProxies();
    }
}