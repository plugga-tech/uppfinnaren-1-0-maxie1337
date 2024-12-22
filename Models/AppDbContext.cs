using System;
using Microsoft.EntityFrameworkCore;

namespace uppfinnaren_1_0_maxie1337.Models;

public class AppDbContext : DbContext
{
      public AppDbContext (DbContextOptions <AppDbContext> options) : base(options)
      {

      }

      public DbSet<Product> Products {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //mockdata producter

        modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, Name = "Torn", Description = "Ett torn karvat in i ett träd.", ImgUrl = "/Images/CTorn.jpg", Category = "Träprodukter"},
                new Product { ProductId = 2, Name = "Bord", Description = "Ett bord gjort utav en stubbe.", ImgUrl = "/Images/Ctables.jpg", Category = "Träprodukter"},
                new Product { ProductId = 3, Name = "Stol", Description = "En konstig stol.", ImgUrl = "/Images/Cchair.jpg", Category = "Träprodukter" },
                new Product { ProductId = 4, Name = "Tomte", Description = "En lurig tomte nu i juletider.", ImgUrl = "/Images/CTomte.jpg", Category = "Träprodukter"},
                new Product { ProductId = 5, Name = "Vas", Description = "En vacker keramikvas.", ImgUrl = "/Images/CVase.jpg", Category = "Keramik" },
                new Product { ProductId = 6, Name = "Mugg", Description = "En handgjord mugg av lera.", ImgUrl = "/Images/CMug.jpg", Category = "Keramik" },
                new Product { ProductId = 7, Name = "Halsband", Description = "Ett elegant halsband i silver.", ImgUrl = "/Images/CNecklace.jpg", Category = "Smycken" },
                new Product { ProductId = 8, Name = "Armband", Description = "Ett armband med pärlor.", ImgUrl = "/Images/CBracelet.jpg", Category = "Smycken" },
                new Product { ProductId = 9, Name = "Tavla", Description = "En vacker tavla med landskap.", ImgUrl = "/Images/CPainting.jpg", Category = "Konst" },
                new Product { ProductId = 10, Name = "Skulptur", Description = "En modern skulptur i sten.", ImgUrl = "/Images/CStatue.jpg", Category = "Konst" },
                new Product { ProductId = 11, Name = "Lampa", Description = "En retro bordslampa.", ImgUrl = "/Images/CLamp.jpg", Category = "Inredning" },
                new Product { ProductId = 12, Name = "Matta", Description = "En handknuten matta.", ImgUrl = "/Images/CRug.jpg", Category = "Inredning" }
                
        );
    }


}
