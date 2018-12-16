
using Domains;
using Microsoft.EntityFrameworkCore;
using System;

namespace Dal
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ApplicationParam> ApplicationParams { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderStatus> OrderStatus { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<ProductModel> ProductModels { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductView> ProductView { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Visitor> Visistors { get; set; }
        public virtual DbSet<Navigation> Navigation { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ApplicationParam>()
                .HasData(
                new ApplicationParam { Id = 1, Key = "provider-name", Value = "HieuPham", DateCreated = DateTime.Now },
                new ApplicationParam { Id = 2, Key = "app-slogen", Value = "Welcome to TuanHoangLaptop", DateCreated = DateTime.Now },
                new ApplicationParam { Id = 3, Key = "app-email", Value = "laptoptuanhoang@rmail.com", DateCreated = DateTime.Now },
                new ApplicationParam { Id = 4, Key = "shop-address", Value = "Số 64 đường Bạch Liêu Tp.Vinh Nghệ An", DateCreated = DateTime.Now },
                new ApplicationParam { Id = 5, Key = "app-phone", Value = "+849 6735 6524", DateCreated = DateTime.Now },
                new ApplicationParam { Id = 6, Key = "app-adress", Value = "1st Le Duan Vinh City Viet Nam", DateCreated = DateTime.Now },
                new ApplicationParam { Id = 7, Key = "app-language", Value = "VI", DateCreated = DateTime.Now },
                new ApplicationParam { Id = 8, Key = "app-logo-url", Value = "./assets/img/logo.png", DateCreated = DateTime.Now },
                new ApplicationParam { Id = 9, Key = "app-logo-alt", Value = "Logo alt", DateCreated = DateTime.Now },
                new ApplicationParam { Id = 10, Key = "app-searchbox-is-show", Value = "1", DateCreated = DateTime.Now },
                new ApplicationParam { Id = 11, Key = "app-searchbox-placeholder-text", Value = "Laptop name, brand, cost", DateCreated = DateTime.Now },
                new ApplicationParam { Id = 12, Key = "app-searchbtn-text", Value = "Search", DateCreated = DateTime.Now },
                new ApplicationParam { Id = 13, Key = "app-wishlist-is-show", Value = "1", DateCreated = DateTime.Now },
                new ApplicationParam { Id = 14, Key = "app-wishlist-text", Value = "Your Wishlist", DateCreated = DateTime.Now },
                new ApplicationParam { Id = 15, Key = "app-cart-is-show", Value = "1", DateCreated = DateTime.Now },
                new ApplicationParam { Id = 16, Key = "app-cart-text", Value = "Your Cart", DateCreated = DateTime.Now },
                new ApplicationParam { Id = 17, Key = "app-section-hotdeal-is-show", Value = "1", DateCreated = DateTime.Now },
                new ApplicationParam { Id = 18, Key = "app-section-hotdeal-text", Value = "hot deal this week", DateCreated = DateTime.Now },
                new ApplicationParam { Id = 19, Key = "app-section-hotdeal-description", Value = "New Collection Up to 50% OFF", DateCreated = DateTime.Now },
                new ApplicationParam { Id = 20, Key = "app-section-hotdeal-button-text", Value = "Shop now", DateCreated = DateTime.Now }
            );

            builder.Entity<ProductCategory>()
               .HasData(
               new ProductCategory { Id = 1, CategoryName = "Top", ImgUrl = "./assets/img/shop01.png", Description = "", ParentId = null, DateCreated = DateTime.Now },
               new ProductCategory { Id = 2, CategoryName = "Hot", ImgUrl = "./assets/img/shop02.png", Description = "", ParentId = null, DateCreated = DateTime.Now },
               new ProductCategory { Id = 3, CategoryName = "New", ImgUrl = "./assets/img/shop03.png", Description = "", ParentId = null, DateCreated = DateTime.Now },
               new ProductCategory { Id = 4, CategoryName = "Category top 1", ImgUrl = "./assets/img/shop01.png", Description = "", ParentId = 1, DateCreated = DateTime.Now },
               new ProductCategory { Id = 5, CategoryName = "Category top 2", ImgUrl = "./assets/img/shop02.png", Description = "", ParentId = 1, DateCreated = DateTime.Now },
               new ProductCategory { Id = 6, CategoryName = "Category top 3", ImgUrl = "./assets/img/shop03.png", Description = "", ParentId = 1, DateCreated = DateTime.Now },
               new ProductCategory { Id = 7, CategoryName = "Category hot 1", ImgUrl = "./assets/img/shop04.png", Description = "", ParentId = 2, DateCreated = DateTime.Now },
               new ProductCategory { Id = 8, CategoryName = "Category hot 2", ImgUrl = "./assets/img/shop05.png", Description = "", ParentId = 2, DateCreated = DateTime.Now },
               new ProductCategory { Id = 9, CategoryName = "Category hot 3", ImgUrl = "./assets/img/shop06.png", Description = "", ParentId = 2, DateCreated = DateTime.Now }
               );

            builder.Entity<Navigation>()
              .HasData(
              new Navigation { Id = 1, Index = 1, Title = "Menu 1", Description = "Home description", DateCreated = DateTime.Now },
              new Navigation { Id = 2, Index = 2, Title = "Menu 2", Description = "Menu 2 description", DateCreated = DateTime.Now },
              new Navigation { Id = 3, Index = 3, Title = "Menu 3", Description = "Menu 3 description", DateCreated = DateTime.Now },
              new Navigation { Id = 4, Index = 4, Title = "Menu 4", Description = "Menu 4 description", DateCreated = DateTime.Now },
              new Navigation { Id = 5, Index = 5, Title = "Menu 5", Description = "Menu 5 description", DateCreated = DateTime.Now, ParentId = 1 },
              new Navigation { Id = 6, Index = 6, Title = "Menu 6", Description = "Menu 6 description", DateCreated = DateTime.Now, ParentId = 2 },
              new Navigation { Id = 7, Index = 7, Title = "Menu 7", Description = "Menu 7 description", DateCreated = DateTime.Now, ParentId = 1 });

            base.OnModelCreating(builder);
        }
    }
}