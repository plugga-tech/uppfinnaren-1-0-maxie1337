using System;

namespace uppfinnaren_1_0_maxie1337.Models;

public interface IProductRepository
{
    //Returnerar alla produkter i Product
    IEnumerable<Product> AllProducts { get; }
    //Returnerar en lista baserat på kategori
    IEnumerable<Product> GetProductListByCategory(string category);

}
