using System;

namespace uppfinnaren_1_0_maxie1337.Models;

public interface IProductRepository
{
    IEnumerable<Product> AllProducts { get; }
    IEnumerable<Product> GetProductListByCategory(string category);

}
