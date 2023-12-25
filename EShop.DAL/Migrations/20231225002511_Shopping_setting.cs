using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShop.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Shopping_setting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "204e5634-438e-4681-aa49-5db2ffe04804");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "4f0757fd-a32c-4404-b51e-74ba8a80e2b1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "f785e3bb-573e-4d4a-b44f-070c0f802daa");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba1838d2-7674-467c-a7da-f6623e8c8f97", new DateTime(2023, 12, 25, 0, 25, 10, 551, DateTimeKind.Utc).AddTicks(103), "AQAAAAIAAYagAAAAELl/bskvX3WrPZKOl9fnY3jzi04kn4fz+B85tm/HEt+/Jyz2Ffw8CPcJnOnMgHzeWQ==", "5fc21e5d-dd3f-439d-9293-c52427f7d25b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09a55d8f-92cc-4c26-abb6-dad23e00dba9", new DateTime(2023, 12, 25, 0, 25, 10, 617, DateTimeKind.Utc).AddTicks(4729), "AQAAAAIAAYagAAAAEG1GPJt2ZHe5ATJBheYPsH9GxSdBHP77w5Sdy+iVAkrpwoku9XEtusn0lsPoiWwJgA==", "5d265dda-3fe7-43f0-893e-17722db17594" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b1aec08-7f41-4ae5-a1b0-16be56d4015f", new DateTime(2023, 12, 25, 0, 25, 10, 684, DateTimeKind.Utc).AddTicks(2342), "AQAAAAIAAYagAAAAECQPpHHlao6If1CXJfe/Hg8ha4KczlpPSnq+aaqQualKYGSJAOWZlcQCSkPKzIa4LA==", "1e49c427-7f94-4dd1-a584-e7175820ea0e" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Computers", new DateTime(2023, 12, 25, 0, 25, 10, 550, DateTimeKind.Utc).AddTicks(8822), "Koyun commodi sunt mıknatıslı sed sarmal rem ratione dağılımı labore." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Computers", new DateTime(2023, 12, 25, 0, 25, 10, 550, DateTimeKind.Utc).AddTicks(9194), "Sinema praesentium aut qui bahar labore quae camisi enim ipsa." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Health", new DateTime(2023, 12, 25, 0, 25, 10, 550, DateTimeKind.Utc).AddTicks(9282), "Mutlu ullam sunt filmini sokaklarda totam ratione nostrum deleniti sit." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Sports", new DateTime(2023, 12, 25, 0, 25, 10, 550, DateTimeKind.Utc).AddTicks(9361), "Ekşili gül sarmal cesurca alias ona lakin tempora beğendim nisi." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Clothing", new DateTime(2023, 12, 25, 0, 25, 10, 550, DateTimeKind.Utc).AddTicks(9467), "Camisi orta kulu commodi yaptı voluptatum salladı beatae aut vel." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Kids", new DateTime(2023, 12, 25, 0, 25, 10, 550, DateTimeKind.Utc).AddTicks(9540), "Esse doğru qui bilgiyasayarı çorba dağılımı camisi vitae quam cesurca." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Shoes", new DateTime(2023, 12, 25, 0, 25, 10, 550, DateTimeKind.Utc).AddTicks(9610), "Vitae explicabo kulu mutlu quis bahar ea kalemi rem ipsam." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Toys", new DateTime(2023, 12, 25, 0, 25, 10, 550, DateTimeKind.Utc).AddTicks(9678), "Mi ut corporis lakin cesurca ut ipsum beğendim eius nemo." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Outdoors", new DateTime(2023, 12, 25, 0, 25, 10, 550, DateTimeKind.Utc).AddTicks(9767), "Çünkü bilgiyasayarı öyle telefonu bilgiyasayarı voluptatem gazete et quis et." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Grocery", new DateTime(2023, 12, 25, 0, 25, 10, 550, DateTimeKind.Utc).AddTicks(9842), "Çarpan değerli ut enim qui minima dignissimos quam quis ad." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 7, new DateTime(2023, 12, 25, 0, 25, 10, 759, DateTimeKind.Utc).AddTicks(6902), "/images/ProductImages/Test.jpg", "Fantastic Steel Bacon", 56.95m, 49 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 7, new DateTime(2023, 12, 25, 0, 25, 10, 759, DateTimeKind.Utc).AddTicks(7646), "/images/ProductImages/Test.jpg", "Generic Cotton Sausages", 42.45m, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2023, 12, 25, 0, 25, 10, 759, DateTimeKind.Utc).AddTicks(7751), "/images/ProductImages/Test.jpg", "Unbranded Metal Gloves", 438.74m, 44 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2023, 12, 25, 0, 25, 10, 759, DateTimeKind.Utc).AddTicks(7833), "/images/ProductImages/Test.jpg", "Generic Fresh Pizza", 43.49m, 27 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2023, 12, 25, 0, 25, 10, 759, DateTimeKind.Utc).AddTicks(7921), "/images/ProductImages/Test.jpg", "Rustic Cotton Pizza", 557.03m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 9, new DateTime(2023, 12, 25, 0, 25, 10, 759, DateTimeKind.Utc).AddTicks(8109), "/images/ProductImages/Test.jpg", "Practical Granite Soap", 529.69m, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 9, new DateTime(2023, 12, 25, 0, 25, 10, 759, DateTimeKind.Utc).AddTicks(8181), "/images/ProductImages/Test.jpg", "Rustic Metal Towels", 878.74m, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 7, new DateTime(2023, 12, 25, 0, 25, 10, 759, DateTimeKind.Utc).AddTicks(8245), "/images/ProductImages/Test.jpg", "Handmade Frozen Shoes", 92.48m, 33 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2023, 12, 25, 0, 25, 10, 759, DateTimeKind.Utc).AddTicks(8313), "/images/ProductImages/Test.jpg", "Handmade Granite Gloves", 116.53m, 31 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2023, 12, 25, 0, 25, 10, 759, DateTimeKind.Utc).AddTicks(8366), "/images/ProductImages/Test.jpg", "Licensed Steel Shirt", 691.32m, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 9, new DateTime(2023, 12, 25, 0, 25, 10, 759, DateTimeKind.Utc).AddTicks(8423), "/images/ProductImages/Test.jpg", "Generic Wooden Towels", 608.75m, 45 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2023, 12, 25, 0, 25, 10, 759, DateTimeKind.Utc).AddTicks(8476), "/images/ProductImages/Test.jpg", "Fantastic Granite Chair", 990.75m, 21 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 1, new DateTime(2023, 12, 25, 0, 25, 10, 759, DateTimeKind.Utc).AddTicks(8588), "/images/ProductImages/Test.jpg", "Unbranded Wooden Chicken", 252.32m, 29 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2023, 12, 25, 0, 25, 10, 759, DateTimeKind.Utc).AddTicks(8645), "/images/ProductImages/Test.jpg", "Incredible Steel Gloves", 853.47m, 42 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 3, new DateTime(2023, 12, 25, 0, 25, 10, 759, DateTimeKind.Utc).AddTicks(8697), "/images/ProductImages/Test.jpg", "Handmade Concrete Keyboard", 516.29m, 44 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 4, new DateTime(2023, 12, 25, 0, 25, 10, 759, DateTimeKind.Utc).AddTicks(8762), "/images/ProductImages/Test.jpg", "Incredible Soft Salad", 288.66m, 40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 9, new DateTime(2023, 12, 25, 0, 25, 10, 759, DateTimeKind.Utc).AddTicks(8821), "/images/ProductImages/Test.jpg", "Unbranded Metal Salad", 441.72m, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 10, new DateTime(2023, 12, 25, 0, 25, 10, 759, DateTimeKind.Utc).AddTicks(8873), "/images/ProductImages/Test.jpg", "Incredible Granite Mouse", 92.07m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 9, new DateTime(2023, 12, 25, 0, 25, 10, 759, DateTimeKind.Utc).AddTicks(8932), "/images/ProductImages/Test.jpg", "Small Granite Bike", 416.11m, 22 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 7, new DateTime(2023, 12, 25, 0, 25, 10, 759, DateTimeKind.Utc).AddTicks(9016), "/images/ProductImages/Test.jpg", "Generic Fresh Fish", 173.47m, 29 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2023, 12, 25, 0, 25, 10, 759, DateTimeKind.Utc).AddTicks(9074), "/images/ProductImages/Test.jpg", "Sleek Steel Computer", 58.04m, 24 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2023, 12, 25, 0, 25, 10, 759, DateTimeKind.Utc).AddTicks(9127), "/images/ProductImages/Test.jpg", "Practical Granite Tuna", 6.81m, 31 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 10, new DateTime(2023, 12, 25, 0, 25, 10, 759, DateTimeKind.Utc).AddTicks(9179), "/images/ProductImages/Test.jpg", "Intelligent Wooden Table", 125.65m, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2023, 12, 25, 0, 25, 10, 759, DateTimeKind.Utc).AddTicks(9231), "/images/ProductImages/Test.jpg", "Generic Frozen Cheese", 264.50m, 49 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2023, 12, 25, 0, 25, 10, 759, DateTimeKind.Utc).AddTicks(9283), "/images/ProductImages/Test.jpg", "Unbranded Plastic Keyboard", 108.60m, 43 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 3, new DateTime(2023, 12, 25, 0, 25, 10, 759, DateTimeKind.Utc).AddTicks(9334), "/images/ProductImages/Test.jpg", "Fantastic Fresh Computer", 750.81m, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2023, 12, 25, 0, 25, 10, 759, DateTimeKind.Utc).AddTicks(9412), "/images/ProductImages/Test.jpg", "Licensed Cotton Gloves", 802.88m, 39 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2023, 12, 25, 0, 25, 10, 759, DateTimeKind.Utc).AddTicks(9463), "/images/ProductImages/Test.jpg", "Awesome Fresh Towels", 664.24m, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2023, 12, 25, 0, 25, 10, 759, DateTimeKind.Utc).AddTicks(9518), "/images/ProductImages/Test.jpg", "Fantastic Wooden Keyboard", 699.03m, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 3, new DateTime(2023, 12, 25, 0, 25, 10, 759, DateTimeKind.Utc).AddTicks(9568), "/images/ProductImages/Test.jpg", "Fantastic Rubber Tuna", 710.13m, 2 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "e3a87501-b26f-452f-b0b0-05c4f8d3e529");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "34ba69d3-dfa9-4784-b208-80b23be09725");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "914cb600-4265-4fa6-ad74-d0dac8f4c966");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24ed57cb-89f3-4a60-a83b-3f2c40b6655f", new DateTime(2023, 12, 25, 0, 20, 11, 543, DateTimeKind.Utc).AddTicks(9321), "AQAAAAIAAYagAAAAELD9Dygxz7KLw2vNKjqL5IK8drRObpaMrHVbw4p2Cgo1TvFx804Edx12Y/vtehA0JA==", "17bfbaf3-2282-45c9-9c41-a9010f65f138" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c58f17e0-7b9d-4371-a227-e39a3397c82d", new DateTime(2023, 12, 25, 0, 20, 11, 607, DateTimeKind.Utc).AddTicks(8154), "AQAAAAIAAYagAAAAEA1xx3+sxVG0gkhjUQK5ublpAdBAaoREmlA1Nvylrnyj7GysTiABLDOzwNeMdSDQIQ==", "f1204eaa-4040-4942-8d04-2722ddd1e2df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d19f458-4446-498c-a775-27cbc17d037d", new DateTime(2023, 12, 25, 0, 20, 11, 674, DateTimeKind.Utc).AddTicks(1454), "AQAAAAIAAYagAAAAEKgoyNxlr2L3BB3v6hr7wQa+qfiV7u2HFZ40wa+1fO0IAHCvbMY7CiDPAoAIO0dhow==", "6646927a-2fb0-4345-b6fc-d51944effc93" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Games", new DateTime(2023, 12, 25, 0, 20, 11, 543, DateTimeKind.Utc).AddTicks(8333), "Balıkhaneye quae iure dignissimos et quia çobanın domates aut quasi." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Sports", new DateTime(2023, 12, 25, 0, 20, 11, 543, DateTimeKind.Utc).AddTicks(8589), "Vel consequatur koşuyorlar nesciunt quis nesciunt biber quis değirmeni masanın." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Beauty", new DateTime(2023, 12, 25, 0, 20, 11, 543, DateTimeKind.Utc).AddTicks(8656), "Ea bahar vitae sıfat ışık aliquid inventore voluptate lambadaki inventore." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Toys", new DateTime(2023, 12, 25, 0, 20, 11, 543, DateTimeKind.Utc).AddTicks(8712), "Sed filmini gidecekmiş ullam biber sinema çünkü voluptate türemiş ve." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Home", new DateTime(2023, 12, 25, 0, 20, 11, 543, DateTimeKind.Utc).AddTicks(8806), "Quia karşıdakine patlıcan dignissimos ut eve koştum ratione adanaya amet." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Clothing", new DateTime(2023, 12, 25, 0, 20, 11, 543, DateTimeKind.Utc).AddTicks(8866), "Dolores velit dolorem öyle domates consequuntur quis olduğu gördüm neque." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Garden", new DateTime(2023, 12, 25, 0, 20, 11, 543, DateTimeKind.Utc).AddTicks(8921), "Makinesi un sinema minima dergi voluptatem kapının quam ea sevindi." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Baby", new DateTime(2023, 12, 25, 0, 20, 11, 543, DateTimeKind.Utc).AddTicks(8979), "Aperiam sit filmini ratione consequatur labore de yaptı teldeki sinema." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Kids", new DateTime(2023, 12, 25, 0, 20, 11, 543, DateTimeKind.Utc).AddTicks(9057), "Dolore fugit beatae cesurca aut duyulmamış autem çorba et aliquid." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Music", new DateTime(2023, 12, 25, 0, 20, 11, 543, DateTimeKind.Utc).AddTicks(9120), "Dolayı quia velit sokaklarda praesentium quia commodi bahar balıkhaneye duyulmamış." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2023, 12, 25, 0, 20, 11, 743, DateTimeKind.Utc).AddTicks(3585), "http://lorempixel.com/640/480/nightlife", "Gorgeous Steel Hat", 711.83m, 31 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 3, new DateTime(2023, 12, 25, 0, 20, 11, 743, DateTimeKind.Utc).AddTicks(4409), "http://lorempixel.com/640/480/nightlife", "Incredible Granite Pants", 884.00m, 30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 7, new DateTime(2023, 12, 25, 0, 20, 11, 743, DateTimeKind.Utc).AddTicks(4540), "http://lorempixel.com/640/480/nightlife", "Practical Cotton Chicken", 946.53m, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 9, new DateTime(2023, 12, 25, 0, 20, 11, 743, DateTimeKind.Utc).AddTicks(7849), "http://lorempixel.com/640/480/nightlife", "Practical Fresh Shoes", 853.77m, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 10, new DateTime(2023, 12, 25, 0, 20, 11, 743, DateTimeKind.Utc).AddTicks(8341), "http://lorempixel.com/640/480/nightlife", "Handmade Wooden Bike", 331.27m, 26 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 7, new DateTime(2023, 12, 25, 0, 20, 11, 743, DateTimeKind.Utc).AddTicks(8500), "http://lorempixel.com/640/480/nightlife", "Ergonomic Steel Salad", 926.30m, 30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2023, 12, 25, 0, 20, 11, 743, DateTimeKind.Utc).AddTicks(8601), "http://lorempixel.com/640/480/nightlife", "Tasty Frozen Shirt", 476.48m, 22 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2023, 12, 25, 0, 20, 11, 743, DateTimeKind.Utc).AddTicks(8684), "http://lorempixel.com/640/480/nightlife", "Unbranded Steel Table", 310.76m, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 7, new DateTime(2023, 12, 25, 0, 20, 11, 743, DateTimeKind.Utc).AddTicks(8837), "http://lorempixel.com/640/480/nightlife", "Handcrafted Wooden Gloves", 84.13m, 38 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 1, new DateTime(2023, 12, 25, 0, 20, 11, 743, DateTimeKind.Utc).AddTicks(8928), "http://lorempixel.com/640/480/nightlife", "Gorgeous Plastic Shoes", 446.93m, 34 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2023, 12, 25, 0, 20, 11, 743, DateTimeKind.Utc).AddTicks(9167), "http://lorempixel.com/640/480/nightlife", "Refined Granite Pizza", 490.54m, 39 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2023, 12, 25, 0, 20, 11, 743, DateTimeKind.Utc).AddTicks(9250), "http://lorempixel.com/640/480/nightlife", "Handmade Wooden Chicken", 651.58m, 43 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2023, 12, 25, 0, 20, 11, 743, DateTimeKind.Utc).AddTicks(9349), "http://lorempixel.com/640/480/nightlife", "Generic Soft Chicken", 644.19m, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 7, new DateTime(2023, 12, 25, 0, 20, 11, 743, DateTimeKind.Utc).AddTicks(9433), "http://lorempixel.com/640/480/nightlife", "Ergonomic Rubber Pizza", 54.30m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 4, new DateTime(2023, 12, 25, 0, 20, 11, 743, DateTimeKind.Utc).AddTicks(9510), "http://lorempixel.com/640/480/nightlife", "Practical Granite Salad", 357.73m, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 3, new DateTime(2023, 12, 25, 0, 20, 11, 743, DateTimeKind.Utc).AddTicks(9673), "http://lorempixel.com/640/480/nightlife", "Ergonomic Cotton Fish", 750.05m, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 7, new DateTime(2023, 12, 25, 0, 20, 11, 743, DateTimeKind.Utc).AddTicks(9753), "http://lorempixel.com/640/480/nightlife", "Tasty Fresh Hat", 887.85m, 23 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2023, 12, 25, 0, 20, 11, 743, DateTimeKind.Utc).AddTicks(9849), "http://lorempixel.com/640/480/nightlife", "Tasty Soft Keyboard", 379.55m, 38 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2023, 12, 25, 0, 20, 11, 743, DateTimeKind.Utc).AddTicks(9927), "http://lorempixel.com/640/480/nightlife", "Generic Soft Salad", 587.56m, 27 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 9, new DateTime(2023, 12, 25, 0, 20, 11, 744, DateTimeKind.Utc).AddTicks(2), "http://lorempixel.com/640/480/nightlife", "Small Granite Bike", 294.36m, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 4, new DateTime(2023, 12, 25, 0, 20, 11, 744, DateTimeKind.Utc).AddTicks(76), "http://lorempixel.com/640/480/nightlife", "Ergonomic Concrete Pizza", 994.14m, 43 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2023, 12, 25, 0, 20, 11, 744, DateTimeKind.Utc).AddTicks(203), "http://lorempixel.com/640/480/nightlife", "Gorgeous Cotton Fish", 403.50m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2023, 12, 25, 0, 20, 11, 744, DateTimeKind.Utc).AddTicks(284), "http://lorempixel.com/640/480/nightlife", "Fantastic Plastic Computer", 962.26m, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 3, new DateTime(2023, 12, 25, 0, 20, 11, 744, DateTimeKind.Utc).AddTicks(360), "http://lorempixel.com/640/480/nightlife", "Licensed Metal Hat", 963.42m, 23 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2023, 12, 25, 0, 20, 11, 744, DateTimeKind.Utc).AddTicks(435), "http://lorempixel.com/640/480/nightlife", "Generic Cotton Tuna", 856.29m, 22 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 10, new DateTime(2023, 12, 25, 0, 20, 11, 744, DateTimeKind.Utc).AddTicks(508), "http://lorempixel.com/640/480/nightlife", "Practical Soft Towels", 25.91m, 25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 10, new DateTime(2023, 12, 25, 0, 20, 11, 744, DateTimeKind.Utc).AddTicks(622), "http://lorempixel.com/640/480/nightlife", "Intelligent Soft Pizza", 859.19m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 3, new DateTime(2023, 12, 25, 0, 20, 11, 744, DateTimeKind.Utc).AddTicks(698), "http://lorempixel.com/640/480/nightlife", "Incredible Soft Chips", 699.40m, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 1, new DateTime(2023, 12, 25, 0, 20, 11, 744, DateTimeKind.Utc).AddTicks(776), "http://lorempixel.com/640/480/nightlife", "Generic Wooden Chicken", 994.78m, 25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2023, 12, 25, 0, 20, 11, 744, DateTimeKind.Utc).AddTicks(856), "http://lorempixel.com/640/480/nightlife", "Rustic Rubber Keyboard", 561.37m, 36 });
        }
    }
}
