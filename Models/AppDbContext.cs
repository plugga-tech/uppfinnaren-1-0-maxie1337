using System;
using Microsoft.EntityFrameworkCore;

namespace uppfinnaren_1_0_maxie1337.Models;

public class AppDbContext : DbContext
{
      public AppDbContext (DbContextOptions <AppDbContext> options) : base(options)
      {
        this.Database.EnsureCreated();
      }

      public DbSet<Product> Products {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //Skapar produkter

        modelBuilder.Entity<Product>().HasData(
            
                new Product { ProductId = 1, Name = "Torn", Description = "Ett torn karvat in i ett träd.", ImgUrl = "/Images/CTorn.jpg", Category = "Träprodukter" },
                new Product { ProductId = 2, Name = "Bord", Description = "Ett bord gjort utav en stubbe.", ImgUrl = "/Images/Ctables.jpg", Category = "Träprodukter" },
                new Product { ProductId = 3, Name = "Stol", Description = "En konstig stol.", ImgUrl = "/Images/Cchair.jpg", Category = "Träprodukter" },
                new Product { ProductId = 4, Name = "Tomte", Description = "En lurig tomte nu i juletider.", ImgUrl = "/Images/CTomte.jpg", Category = "Träprodukter" },

                new Product { ProductId = 5, Name = "Vas", Description = "En vacker keramikvas.", ImgUrl = "/Images/CVase.jpg", Category = "Keramik" },
                new Product { ProductId = 6, Name = "Mugg", Description = "En handgjord mugg av lera.", ImgUrl = "/Images/CMug.jpg", Category = "Keramik" },
                new Product { ProductId = 7, Name = "Skål", Description = "En unik handgjord skål.", ImgUrl = "/Images/CBowl.jpg", Category = "Keramik" },
                new Product { ProductId = 8, Name = "Tallrik", Description = "En elegant tallrik i keramik.", ImgUrl = "/Images/CPlate.jpg", Category = "Keramik" },

                new Product { ProductId = 9, Name = "Halsband", Description = "Ett elegant halsband i silver.", ImgUrl = "/Images/CNecklace.jpg", Category = "Smycken" },
                new Product { ProductId = 10, Name = "Armband", Description = "Ett armband med pärlor.", ImgUrl = "/Images/CBracelet.jpg", Category = "Smycken" },
                new Product { ProductId = 11, Name = "Ring", Description = "En vacker ring med en diamant.", ImgUrl = "/Images/CRing.jpg", Category = "Smycken" },
                new Product { ProductId = 12, Name = "Hänge", Description = "Ett stilrent hänge i guld.", ImgUrl = "/Images/CHanging.jpg", Category = "Smycken" },

                new Product { ProductId = 13, Name = "Tavla", Description = "En vacker tavla med landskap.", ImgUrl = "/Images/CPainting.jpg", Category = "Konst" },
                new Product { ProductId = 14, Name = "Skulptur", Description = "En modern skulptur i sten.", ImgUrl = "/Images/CStatue.jpg", Category = "Konst" },
                new Product { ProductId = 15, Name = "Fotografi", Description = "En vacker svartvit fotografi.", ImgUrl = "/Images/CPhoto.jpg", Category = "Konst" },
                new Product { ProductId = 16, Name = "Målning", Description = "En abstrakt målning med starka färger.", ImgUrl = "/Images/CAbstractPainting.jpg", Category = "Konst" },

                new Product { ProductId = 17, Name = "Lampa", Description = "En retro bordslampa.", ImgUrl = "/Images/CLamp.jpg", Category = "Inredning" },
                new Product { ProductId = 18, Name = "Matta", Description = "En handknuten matta.", ImgUrl = "/Images/CRug.jpg", Category = "Inredning" },
                new Product { ProductId = 19, Name = "Spegel", Description = "En elegant spegel med träram.", ImgUrl = "/Images/CMirror.jpg", Category = "Inredning" },
                new Product { ProductId = 20, Name = "Kudde", Description = "En mjuk dekorativ kudde.", ImgUrl = "/Images/CPillow.jpg", Category = "Inredning" }
                
        );
    }


}
