﻿// <auto-generated />
using System;
using Dal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Dal.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20181128160828_New2")]
    partial class New2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domains.ApplicationParam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Key");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.ToTable("ApplicationParams");

                    b.HasData(
                        new { Id = 1, DateCreated = new DateTime(2018, 11, 28, 23, 8, 28, 397, DateTimeKind.Local), Key = "provider-name", Value = "HieuPham" },
                        new { Id = 2, DateCreated = new DateTime(2018, 11, 28, 23, 8, 28, 398, DateTimeKind.Local), Key = "app-slogen", Value = "Welcome to TuanHoangLaptop" },
                        new { Id = 3, DateCreated = new DateTime(2018, 11, 28, 23, 8, 28, 398, DateTimeKind.Local), Key = "app-email", Value = "laptoptuanhoang@rmail.com" },
                        new { Id = 4, DateCreated = new DateTime(2018, 11, 28, 23, 8, 28, 398, DateTimeKind.Local), Key = "shop-address", Value = "Số 64 đường Bạch Liêu Tp.Vinh Nghệ An" },
                        new { Id = 5, DateCreated = new DateTime(2018, 11, 28, 23, 8, 28, 398, DateTimeKind.Local), Key = "app-phone", Value = "+849 6735 6524" },
                        new { Id = 6, DateCreated = new DateTime(2018, 11, 28, 23, 8, 28, 398, DateTimeKind.Local), Key = "app-adress", Value = "1st Le Duan Vinh City Viet Nam" },
                        new { Id = 7, DateCreated = new DateTime(2018, 11, 28, 23, 8, 28, 398, DateTimeKind.Local), Key = "app-language", Value = "VI" },
                        new { Id = 8, DateCreated = new DateTime(2018, 11, 28, 23, 8, 28, 398, DateTimeKind.Local), Key = "app-logo-url", Value = "./assets/img/logo.png" },
                        new { Id = 9, DateCreated = new DateTime(2018, 11, 28, 23, 8, 28, 398, DateTimeKind.Local), Key = "app-logo-alt", Value = "Logo alt" },
                        new { Id = 10, DateCreated = new DateTime(2018, 11, 28, 23, 8, 28, 398, DateTimeKind.Local), Key = "app-searchbox-is-show", Value = "1" },
                        new { Id = 11, DateCreated = new DateTime(2018, 11, 28, 23, 8, 28, 398, DateTimeKind.Local), Key = "app-searchbox-placeholder-text", Value = "Laptop name, brand, cost" },
                        new { Id = 12, DateCreated = new DateTime(2018, 11, 28, 23, 8, 28, 398, DateTimeKind.Local), Key = "app-searchbtn-text", Value = "Search" },
                        new { Id = 13, DateCreated = new DateTime(2018, 11, 28, 23, 8, 28, 398, DateTimeKind.Local), Key = "app-wishlist-is-show", Value = "1" },
                        new { Id = 14, DateCreated = new DateTime(2018, 11, 28, 23, 8, 28, 398, DateTimeKind.Local), Key = "app-wishlist-text", Value = "Your Wishlist" },
                        new { Id = 15, DateCreated = new DateTime(2018, 11, 28, 23, 8, 28, 398, DateTimeKind.Local), Key = "app-cart-is-show", Value = "1" },
                        new { Id = 16, DateCreated = new DateTime(2018, 11, 28, 23, 8, 28, 398, DateTimeKind.Local), Key = "app-cart-text", Value = "Your Cart" },
                        new { Id = 17, DateCreated = new DateTime(2018, 11, 28, 23, 8, 28, 398, DateTimeKind.Local), Key = "app-section-hotdeal-is-show", Value = "1" },
                        new { Id = 18, DateCreated = new DateTime(2018, 11, 28, 23, 8, 28, 398, DateTimeKind.Local), Key = "app-section-hotdeal-text", Value = "hot deal this week" },
                        new { Id = 19, DateCreated = new DateTime(2018, 11, 28, 23, 8, 28, 398, DateTimeKind.Local), Key = "app-section-hotdeal-description", Value = "New Collection Up to 50% OFF" },
                        new { Id = 20, DateCreated = new DateTime(2018, 11, 28, 23, 8, 28, 398, DateTimeKind.Local), Key = "appapp-section-hotdeal-button-text", Value = "Shop now" }
                    );
                });

            modelBuilder.Entity("Domains.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("FullName");

                    b.Property<string>("IpAddress");

                    b.Property<DateTime?>("LastVisistedDate");

                    b.Property<string>("Phone");

                    b.Property<string>("ProductViewedIds");

                    b.Property<string>("Url");

                    b.Property<DateTime?>("VisistedDate");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Domains.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Email");

                    b.Property<string>("FullName");

                    b.Property<string>("Password");

                    b.Property<string>("Phone");

                    b.Property<DateTime?>("RegistrationDate");

                    b.HasKey("Id");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("Domains.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<int>("CustomerId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<bool?>("OrderDeleted");

                    b.Property<int>("OrderStatusId");

                    b.Property<DateTime?>("OrderUpdatedDate");

                    b.Property<int>("ProductCount");

                    b.Property<string>("ShipAddress");

                    b.Property<string>("ShipContactPhone");

                    b.Property<int?>("ShipperId");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("OrderStatusId");

                    b.HasIndex("ShipperId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Domains.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("DetailDescription");

                    b.Property<double?>("DetailPrice");

                    b.Property<int>("OrderId");

                    b.Property<int>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Domains.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateCreate");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Descriotions");

                    b.HasKey("Id");

                    b.ToTable("OrderStatus");
                });

            modelBuilder.Entity("Domains.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("ProductAvatar");

                    b.Property<int?>("ProductCategoryId");

                    b.Property<double?>("ProductCostReference");

                    b.Property<int?>("ProductCount");

                    b.Property<bool?>("ProductDateCreated");

                    b.Property<double?>("ProductDiscount");

                    b.Property<bool?>("ProductIsAvailable");

                    b.Property<bool?>("ProductIsDeleted");

                    b.Property<int?>("ProductIssurance");

                    b.Property<string>("ProductIssuranceDesc");

                    b.Property<string>("ProductLocation");

                    b.Property<string>("ProductLongDesc");

                    b.Property<int?>("ProductModelId");

                    b.Property<string>("ProductName");

                    b.Property<double?>("ProductPrice");

                    b.Property<string>("ProductReference");

                    b.Property<string>("ProductShortDesc");

                    b.Property<string>("ProductTags");

                    b.Property<string>("ProductThumb");

                    b.Property<DateTime?>("ProductUpdateDate");

                    b.Property<int?>("ProductViewTypeId");

                    b.Property<double?>("ProductWeight");

                    b.Property<double?>("Rating");

                    b.HasKey("Id");

                    b.HasIndex("ProductCategoryId");

                    b.HasIndex("ProductModelId");

                    b.HasIndex("ProductViewTypeId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Domains.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName");

                    b.Property<DateTime?>("DateCreate");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Description");

                    b.Property<string>("ImgUrl");

                    b.Property<int?>("ParentId");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new { Id = 1, CategoryName = "Top", DateCreated = new DateTime(2018, 11, 28, 23, 8, 28, 399, DateTimeKind.Local), Description = "", ImgUrl = "./assets/img/shop01.png" },
                        new { Id = 2, CategoryName = "Hot", DateCreated = new DateTime(2018, 11, 28, 23, 8, 28, 399, DateTimeKind.Local), Description = "", ImgUrl = "./assets/img/shop02.png" },
                        new { Id = 3, CategoryName = "New", DateCreated = new DateTime(2018, 11, 28, 23, 8, 28, 399, DateTimeKind.Local), Description = "", ImgUrl = "./assets/img/shop03.png" },
                        new { Id = 4, CategoryName = "Category top 1", DateCreated = new DateTime(2018, 11, 28, 23, 8, 28, 399, DateTimeKind.Local), Description = "", ImgUrl = "./assets/img/shop01.png", ParentId = 1 },
                        new { Id = 5, CategoryName = "Category top 2", DateCreated = new DateTime(2018, 11, 28, 23, 8, 28, 399, DateTimeKind.Local), Description = "", ImgUrl = "./assets/img/shop02.png", ParentId = 1 },
                        new { Id = 6, CategoryName = "Category top 3", DateCreated = new DateTime(2018, 11, 28, 23, 8, 28, 399, DateTimeKind.Local), Description = "", ImgUrl = "./assets/img/shop03.png", ParentId = 1 },
                        new { Id = 7, CategoryName = "Category hot 1", DateCreated = new DateTime(2018, 11, 28, 23, 8, 28, 399, DateTimeKind.Local), Description = "", ImgUrl = "./assets/img/shop04.png", ParentId = 2 },
                        new { Id = 8, CategoryName = "Category hot 2", DateCreated = new DateTime(2018, 11, 28, 23, 8, 28, 399, DateTimeKind.Local), Description = "", ImgUrl = "./assets/img/shop05.png", ParentId = 2 },
                        new { Id = 9, CategoryName = "Category hot 3", DateCreated = new DateTime(2018, 11, 28, 23, 8, 28, 399, DateTimeKind.Local), Description = "", ImgUrl = "./assets/img/shop06.png", ParentId = 2 }
                    );
                });

            modelBuilder.Entity("Domains.ProductModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateCreate");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("ModelName");

                    b.Property<int?>("ParentId");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("ProductModels");
                });

            modelBuilder.Entity("Domains.ProductView", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateCreate");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("ProductViewName");

                    b.HasKey("Id");

                    b.ToTable("ProductView");
                });

            modelBuilder.Entity("Domains.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domains.Visitor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime?>("DateEntered");

                    b.Property<string>("IpAddress");

                    b.Property<DateTime?>("LastEnteredDate");

                    b.HasKey("Id");

                    b.ToTable("Visistors");
                });

            modelBuilder.Entity("Domains.Order", b =>
                {
                    b.HasOne("Domains.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domains.OrderStatus", "OrderStatus")
                        .WithMany("Orders")
                        .HasForeignKey("OrderStatusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domains.Employee", "Shipper")
                        .WithMany("Orders")
                        .HasForeignKey("ShipperId");
                });

            modelBuilder.Entity("Domains.OrderDetail", b =>
                {
                    b.HasOne("Domains.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domains.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domains.Product", b =>
                {
                    b.HasOne("Domains.ProductCategory", "ProductCategory")
                        .WithMany("Products")
                        .HasForeignKey("ProductCategoryId");

                    b.HasOne("Domains.ProductModel", "ProductModel")
                        .WithMany("Products")
                        .HasForeignKey("ProductModelId");

                    b.HasOne("Domains.ProductView", "ProductViewType")
                        .WithMany("Products")
                        .HasForeignKey("ProductViewTypeId");
                });

            modelBuilder.Entity("Domains.ProductCategory", b =>
                {
                    b.HasOne("Domains.ProductCategory", "Parent")
                        .WithMany("InverseParent")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("Domains.ProductModel", b =>
                {
                    b.HasOne("Domains.ProductCategory", "Parent")
                        .WithMany("ProductModels")
                        .HasForeignKey("ParentId");
                });
#pragma warning restore 612, 618
        }
    }
}
