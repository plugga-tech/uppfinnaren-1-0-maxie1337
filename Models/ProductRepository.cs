using System;
using Microsoft.EntityFrameworkCore;

namespace uppfinnaren_1_0_maxie1337.Models;

public class ProductRepository : IProductRepository
{
    private readonly AppDbContext _appDbContext;

    public ProductRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public IEnumerable<Product> AllProducts
    {
        get
        {
            return _appDbContext.Products;
        }
    }

    public IEnumerable<Product> GetProductListByCategory(string category)
    {
        // Filtrerar produkterna i databasen baserat på angiven kategori och returnerar som en lista.
        return _appDbContext.Products.Where(p => p.Category == category).ToList();
    }
}
