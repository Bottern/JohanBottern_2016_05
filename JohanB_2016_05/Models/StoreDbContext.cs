using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JohanB_2016_05.Models
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext() : base("StoreDb")
        {
            Database.SetInitializer<StoreDbContext>(new StoreInitializer());
        }

        public DbSet<Store> Stores { get; set; }
        public DbSet<Products> Productses { get; set; }

        public class StoreInitializer : DropCreateDatabaseAlways<StoreDbContext>
        {
            protected override void Seed(StoreDbContext ctx)
            {
                //List<Products> products = new List<Products>();
                //products.Add(new Products()
                //{
                //    ProductId = 1,
                //    Name = "First Product",
                //    ProductNumber = 1,
                //    ProductText = "This is the first product of the first store, BUY IT!!!",
                //    ProductsInStock = 50
                //});
                //products.Add(new Products()
                //{
                //    ProductId = 2,
                //    Name = "First Product",
                //    ProductNumber = 2,
                //    ProductText = "This is the first second product of the first store, BUY IT!!!",
                //    ProductsInStock = 50
                //});


                List<Store> storeList = new List<Store>();
                storeList.Add(new Store()
                {
                    StoreId = 1,
                    Name = "First Store",
                    Address = "Sodergatan 78 275 45 Helsingborg",
                    Products = new Products()
                    {
                        ProductId = 1,
                        Name = "First Product",
                        ProductNumber = 1,
                        ProductText = "This is the first product of the first store, BUY IT!!!",
                        ProductsInStock = 50,
                    },
                    //Products = new Products()  
                    //{
                    //    ProductId = 4,
                    //    Name = "Second Product",
                    //    ProductNumber = 2,
                    //    ProductText = "This is the second product of the first store, BUY IT!!!",
                    //    ProductsInStock = 25
                    //},
                });
                storeList.Add( new Store()
                {
                    StoreId = 2,
                    Name = "Second Store",
                    Address = "Södergatan 79, 275 45 Helsingborg",
                    Products = new Products()
                    {
                        ProductId = 2,
                        Name = "First Product",
                        ProductNumber = 1,
                        ProductText = "This is the first product of the first store, BUY IT!!!",
                        ProductsInStock = 50
                    },
                   //Products = new Products()
                   // {
                   //     ProductId = 4,
                   //     Name = "Second Product",
                   //     ProductNumber = 2,
                   //     ProductText = "This is the second product of the first store, BUY IT!!!",
                   //     ProductsInStock = 25
                   // },
                });
                ctx.Stores.AddRange(storeList);
                ctx.SaveChanges();
            }
        }
    }
}