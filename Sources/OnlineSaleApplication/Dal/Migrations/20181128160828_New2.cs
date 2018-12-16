using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Dal.Migrations
{
    public partial class New2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "ProductCategories",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ApplicationParams",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2018, 11, 28, 23, 8, 28, 397, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ApplicationParams",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2018, 11, 28, 23, 8, 28, 398, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ApplicationParams",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2018, 11, 28, 23, 8, 28, 398, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ApplicationParams",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2018, 11, 28, 23, 8, 28, 398, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ApplicationParams",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2018, 11, 28, 23, 8, 28, 398, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ApplicationParams",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2018, 11, 28, 23, 8, 28, 398, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ApplicationParams",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2018, 11, 28, 23, 8, 28, 398, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ApplicationParams",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2018, 11, 28, 23, 8, 28, 398, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ApplicationParams",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2018, 11, 28, 23, 8, 28, 398, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ApplicationParams",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2018, 11, 28, 23, 8, 28, 398, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ApplicationParams",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2018, 11, 28, 23, 8, 28, 398, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ApplicationParams",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2018, 11, 28, 23, 8, 28, 398, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ApplicationParams",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2018, 11, 28, 23, 8, 28, 398, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ApplicationParams",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2018, 11, 28, 23, 8, 28, 398, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ApplicationParams",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2018, 11, 28, 23, 8, 28, 398, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ApplicationParams",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2018, 11, 28, 23, 8, 28, 398, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ApplicationParams",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2018, 11, 28, 23, 8, 28, 398, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ApplicationParams",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2018, 11, 28, 23, 8, 28, 398, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ApplicationParams",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2018, 11, 28, 23, 8, 28, 398, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ApplicationParams",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2018, 11, 28, 23, 8, 28, 398, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CategoryName", "DateCreate", "DateCreated", "Description", "ImgUrl", "ParentId" },
                values: new object[,]
                {
                    { 1, "Top", null, new DateTime(2018, 11, 28, 23, 8, 28, 399, DateTimeKind.Local), "", "./assets/img/shop01.png", null },
                    { 2, "Hot", null, new DateTime(2018, 11, 28, 23, 8, 28, 399, DateTimeKind.Local), "", "./assets/img/shop02.png", null },
                    { 3, "New", null, new DateTime(2018, 11, 28, 23, 8, 28, 399, DateTimeKind.Local), "", "./assets/img/shop03.png", null }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CategoryName", "DateCreate", "DateCreated", "Description", "ImgUrl", "ParentId" },
                values: new object[,]
                {
                    { 4, "Category top 1", null, new DateTime(2018, 11, 28, 23, 8, 28, 399, DateTimeKind.Local), "", "./assets/img/shop01.png", 1 },
                    { 5, "Category top 2", null, new DateTime(2018, 11, 28, 23, 8, 28, 399, DateTimeKind.Local), "", "./assets/img/shop02.png", 1 },
                    { 6, "Category top 3", null, new DateTime(2018, 11, 28, 23, 8, 28, 399, DateTimeKind.Local), "", "./assets/img/shop03.png", 1 },
                    { 7, "Category hot 1", null, new DateTime(2018, 11, 28, 23, 8, 28, 399, DateTimeKind.Local), "", "./assets/img/shop04.png", 2 },
                    { 8, "Category hot 2", null, new DateTime(2018, 11, 28, 23, 8, 28, 399, DateTimeKind.Local), "", "./assets/img/shop05.png", 2 },
                    { 9, "Category hot 3", null, new DateTime(2018, 11, 28, 23, 8, 28, 399, DateTimeKind.Local), "", "./assets/img/shop06.png", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "ProductCategories");

            migrationBuilder.UpdateData(
                table: "ApplicationParams",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2018, 11, 28, 22, 58, 57, 363, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ApplicationParams",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2018, 11, 28, 22, 58, 57, 365, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ApplicationParams",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2018, 11, 28, 22, 58, 57, 365, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ApplicationParams",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2018, 11, 28, 22, 58, 57, 365, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ApplicationParams",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2018, 11, 28, 22, 58, 57, 365, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ApplicationParams",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2018, 11, 28, 22, 58, 57, 365, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ApplicationParams",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2018, 11, 28, 22, 58, 57, 365, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ApplicationParams",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2018, 11, 28, 22, 58, 57, 365, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ApplicationParams",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2018, 11, 28, 22, 58, 57, 365, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ApplicationParams",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2018, 11, 28, 22, 58, 57, 365, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ApplicationParams",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2018, 11, 28, 22, 58, 57, 365, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ApplicationParams",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2018, 11, 28, 22, 58, 57, 365, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ApplicationParams",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2018, 11, 28, 22, 58, 57, 365, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ApplicationParams",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2018, 11, 28, 22, 58, 57, 365, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ApplicationParams",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2018, 11, 28, 22, 58, 57, 365, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ApplicationParams",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2018, 11, 28, 22, 58, 57, 365, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ApplicationParams",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2018, 11, 28, 22, 58, 57, 365, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ApplicationParams",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2018, 11, 28, 22, 58, 57, 365, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ApplicationParams",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2018, 11, 28, 22, 58, 57, 365, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ApplicationParams",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2018, 11, 28, 22, 58, 57, 365, DateTimeKind.Local));
        }
    }
}
