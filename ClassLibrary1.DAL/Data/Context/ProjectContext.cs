using ClassLibrary1.DAL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.DAL.Data.Context
{
    public class ProjectContext: IdentityDbContext<User>
    {
        //public DbSet<User> Users { get; set; }
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Order> orders => Set<Order>();
        public DbSet<Cart> cartItems => Set<Cart>();
        public ProjectContext(DbContextOptions options) : base(options) { }

     
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<User>()
            //   .HasIndex(u => u.Username)
            //   .IsUnique();

            // Configure Product
            //modelBuilder.Entity<Product>()
            //    .Property(p => p.Price)
            //    .HasColumnType("decimal(18,2)");

            // Configure CartItem
            //modelBuilder.Entity<Cart>()
            //    .HasOne(ci => ci.User)
            //    .WithMany()
            //    .HasForeignKey(ci => ci.UserId);

            //modelBuilder.Entity<Cart>()
            //    .HasOne(ci => ci.Product)
            //    .WithMany()
            //    .HasForeignKey(ci => ci.ProductId);

            // Configure Order
            //modelBuilder.Entity<Order>()
            //    .HasOne(o => o.User)
            //    .WithMany()
            //    .HasForeignKey(o => o.UserId);

            //modelBuilder.Entity<Order>()
            //    .Property(o => o.TotalPrice)
            //    .HasColumnType("decimal(18,2)");


            var products = new List<Product>
                {

                  new Product {
                    Id= 1,
                    Name= "product1",
                    Category= "computers",
                    Price= 2000,
                    Description="Product1",
                    stock= 10,
                  },
                  new Product {
                    Id= 2,
                    Name= "product2",
                    Category= "TV",
                    Price= 4000,
                    Description="Product2",
                    stock= 20,
                  },
                  new Product {
                    Id= 3,
                    Name= "product3",
                    Category= "Watches",
                    Price= 2000,
                    Description="Product3",
                    stock= 10,
                  },
                  new Product {
                    Id= 4,
                    Name= "product4",
                    Category= "Smart Watches",
                    Price= 2890,
                    Description="Product4",
                    stock= 50,
                  },
                  new Product {
                    Id= 5,
                    Name= "product5",
                    Category= "Laptops",
                    Price= 2900,
                    Description="Product5",
                    stock= 90,
                  }
        };
            var orders = new List<Order>
                {

                  new Order {
                    Id= 1,
                    CreatedAt= DateTime.Now,
                    TotalPrice=1000
                  },
                   new Order {
                    Id= 2,
                    CreatedAt= DateTime.Now,
                    TotalPrice=2000
                  },
                    new Order {
                    Id= 3,
                    CreatedAt= DateTime.Now,
                    TotalPrice=3000
                  },
                     new Order {
                    Id= 4,
                    CreatedAt= DateTime.Now,
                    TotalPrice=4000
                  },
                      new Order {
                    Id= 5,
                    CreatedAt= DateTime.Now,
                    TotalPrice=5000
                  }

        };

            var cartitems = new List<Cart>
                {

                  new Cart {
                      Id= 1,
                    ProductId= 1,
                    Quantity=2
                  },
                  new Cart {
                        Id= 2,
                    ProductId= 2,
                    Quantity=3
                  },
                  new Cart {
                        Id= 3,
                    ProductId= 2,
                    Quantity=4
                  },
                  new Cart {
                      Id = 4,
                    ProductId= 4,
                    Quantity=1
                  },
                  new Cart {
                      Id = 5,
                    ProductId= 3,
                    Quantity=4
                  },

        };

            modelBuilder.Entity<Product>().HasData(products);
            modelBuilder.Entity<Order>().HasData(orders);
            modelBuilder.Entity<Cart>().HasData(cartitems);

        }
    }

}
    


   
