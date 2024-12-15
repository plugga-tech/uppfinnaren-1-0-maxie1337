using System;
using Microsoft.AspNetCore.Mvc;
using uppfinnaren_1_0_maxie1337.Models;
 public class ProductController : Controller
    {
        public IActionResult Index()
        {
            //hårdkodad lista med produkter
            var products = new List<Product>
            {
                new Product { Name = "Torn", Description = "Ett torn karvat in i ett träd.", ImgUrl = "/Images/CTorn.jpg" },
                new Product { Name = "Bord", Description = "Ett bord gjort utav en stubbe.", ImgUrl = "/Images/Ctables.jpg" },
                new Product { Name = "Stol", Description = "En konstig stol.", ImgUrl = "/Images/Cchair.jpg" },
                new Product { Name = "Tomte", Description = "En lurig tomte nu i juletider.", ImgUrl = "/Images/CTomte.jpg" }
            };

            return View(products);
        }
    }
