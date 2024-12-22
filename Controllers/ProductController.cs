using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using uppfinnaren_1_0_maxie1337.Models;

namespace uppfinnaren_1_0_maxie1337.Controllers;
 public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductRepository _productRepository;

        public ProductController(ILogger <ProductController> logger, IProductRepository productRepository)
        {
            _logger = logger;
            this._productRepository = productRepository;

        }

        public IActionResult Index()
        {
            return View(_productRepository.AllProducts);
        }

        public IActionResult Links(string category)
{
            var products = _productRepository.GetProductListByCategory(category);

            return View(products);
}

    }
