using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Dal.Migrations
{
    public partial class New : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationParams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    Key = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationParams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    IpAddress = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    VisistedDate = table.Column<DateTime>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    ProductViewedIds = table.Column<string>(nullable: true),
                    LastVisistedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    RegistrationDate = table.Column<DateTime>(nullable: true),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    Descriotions = table.Column<string>(nullable: true),
                    DateCreate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    CategoryName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ParentId = table.Column<int>(nullable: true),
                    DateCreate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductCategories_ProductCategories_ParentId",
                        column: x => x.ParentId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductView",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    ProductViewName = table.Column<string>(nullable: true),
                    DateCreate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductView", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Visistors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    IpAddress = table.Column<string>(nullable: true),
                    DateEntered = table.Column<DateTime>(nullable: true),
                    LastEnteredDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visistors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    ProductCount = table.Column<int>(nullable: false),
                    ShipAddress = table.Column<string>(nullable: true),
                    ShipContactPhone = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    OrderUpdatedDate = table.Column<DateTime>(nullable: true),
                    OrderStatusId = table.Column<int>(nullable: false),
                    ShipperId = table.Column<int>(nullable: true),
                    OrderDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_OrderStatus_OrderStatusId",
                        column: x => x.OrderStatusId,
                        principalTable: "OrderStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Employee_ShipperId",
                        column: x => x.ShipperId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    ModelName = table.Column<string>(nullable: true),
                    ParentId = table.Column<int>(nullable: true),
                    DateCreate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductModels_ProductCategories_ParentId",
                        column: x => x.ParentId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductPrice = table.Column<double>(nullable: true),
                    ProductDiscount = table.Column<double>(nullable: true),
                    ProductCostReference = table.Column<double>(nullable: true),
                    ProductReference = table.Column<string>(nullable: true),
                    ProductWeight = table.Column<double>(nullable: true),
                    ProductTags = table.Column<string>(nullable: true),
                    ProductShortDesc = table.Column<string>(nullable: true),
                    ProductLongDesc = table.Column<string>(nullable: true),
                    ProductThumb = table.Column<string>(nullable: true),
                    ProductAvatar = table.Column<string>(nullable: true),
                    ProductCategoryId = table.Column<int>(nullable: true),
                    ProductUpdateDate = table.Column<DateTime>(nullable: true),
                    ProductCount = table.Column<int>(nullable: true),
                    ProductModelId = table.Column<int>(nullable: true),
                    ProductLocation = table.Column<string>(nullable: true),
                    ProductIssurance = table.Column<int>(nullable: true),
                    ProductIssuranceDesc = table.Column<string>(nullable: true),
                    ProductIsAvailable = table.Column<bool>(nullable: true),
                    ProductIsDeleted = table.Column<bool>(nullable: true),
                    ProductDateCreated = table.Column<bool>(nullable: true),
                    ProductViewTypeId = table.Column<int>(nullable: true),
                    Rating = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_ProductModels_ProductModelId",
                        column: x => x.ProductModelId,
                        principalTable: "ProductModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_ProductView_ProductViewTypeId",
                        column: x => x.ProductViewTypeId,
                        principalTable: "ProductView",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    DetailDescription = table.Column<string>(nullable: true),
                    DetailPrice = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ApplicationParams",
                columns: new[] { "Id", "DateCreated", "Key", "Value" },
                values: new object[,]
                {
                    { 1, new DateTime(2018, 11, 28, 22, 58, 57, 363, DateTimeKind.Local), "provider-name", "HieuPham" },
                    { 18, new DateTime(2018, 11, 28, 22, 58, 57, 365, DateTimeKind.Local), "app-section-hotdeal-text", "hot deal this week" },
                    { 17, new DateTime(2018, 11, 28, 22, 58, 57, 365, DateTimeKind.Local), "app-section-hotdeal-is-show", "1" },
                    { 16, new DateTime(2018, 11, 28, 22, 58, 57, 365, DateTimeKind.Local), "app-cart-text", "Your Cart" },
                    { 15, new DateTime(2018, 11, 28, 22, 58, 57, 365, DateTimeKind.Local), "app-cart-is-show", "1" },
                    { 14, new DateTime(2018, 11, 28, 22, 58, 57, 365, DateTimeKind.Local), "app-wishlist-text", "Your Wishlist" },
                    { 13, new DateTime(2018, 11, 28, 22, 58, 57, 365, DateTimeKind.Local), "app-wishlist-is-show", "1" },
                    { 12, new DateTime(2018, 11, 28, 22, 58, 57, 365, DateTimeKind.Local), "app-searchbtn-text", "Search" },
                    { 11, new DateTime(2018, 11, 28, 22, 58, 57, 365, DateTimeKind.Local), "app-searchbox-placeholder-text", "Laptop name, brand, cost" },
                    { 10, new DateTime(2018, 11, 28, 22, 58, 57, 365, DateTimeKind.Local), "app-searchbox-is-show", "1" },
                    { 9, new DateTime(2018, 11, 28, 22, 58, 57, 365, DateTimeKind.Local), "app-logo-alt", "Logo alt" },
                    { 8, new DateTime(2018, 11, 28, 22, 58, 57, 365, DateTimeKind.Local), "app-logo-url", "./assets/img/logo.png" },
                    { 7, new DateTime(2018, 11, 28, 22, 58, 57, 365, DateTimeKind.Local), "app-language", "VI" },
                    { 6, new DateTime(2018, 11, 28, 22, 58, 57, 365, DateTimeKind.Local), "app-adress", "1st Le Duan Vinh City Viet Nam" },
                    { 5, new DateTime(2018, 11, 28, 22, 58, 57, 365, DateTimeKind.Local), "app-phone", "+849 6735 6524" },
                    { 4, new DateTime(2018, 11, 28, 22, 58, 57, 365, DateTimeKind.Local), "shop-address", "Số 64 đường Bạch Liêu Tp.Vinh Nghệ An" },
                    { 3, new DateTime(2018, 11, 28, 22, 58, 57, 365, DateTimeKind.Local), "app-email", "laptoptuanhoang@rmail.com" },
                    { 2, new DateTime(2018, 11, 28, 22, 58, 57, 365, DateTimeKind.Local), "app-slogen", "Welcome to TuanHoangLaptop" },
                    { 19, new DateTime(2018, 11, 28, 22, 58, 57, 365, DateTimeKind.Local), "app-section-hotdeal-description", "New Collection Up to 50% OFF" },
                    { 20, new DateTime(2018, 11, 28, 22, 58, 57, 365, DateTimeKind.Local), "appapp-section-hotdeal-button-text", "Shop now" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderStatusId",
                table: "Orders",
                column: "OrderStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ShipperId",
                table: "Orders",
                column: "ShipperId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_ParentId",
                table: "ProductCategories",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductModels_ParentId",
                table: "ProductModels",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductModelId",
                table: "Products",
                column: "ProductModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductViewTypeId",
                table: "Products",
                column: "ProductViewTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationParams");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Visistors");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "OrderStatus");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "ProductModels");

            migrationBuilder.DropTable(
                name: "ProductView");

            migrationBuilder.DropTable(
                name: "ProductCategories");
        }
    }
}
