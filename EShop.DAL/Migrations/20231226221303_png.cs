using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShop.DAL.Migrations
{
    /// <inheritdoc />
    public partial class png : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "27c0497d-9067-41e3-a353-8da147a5e3d3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "42556b2e-8753-41b2-9d05-7291f5ea7a8e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "70c91b4f-84d0-4513-8012-66d70fee453d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee8997bf-21e7-4570-b664-f4bb6f765d30", new DateTime(2023, 12, 26, 22, 13, 2, 344, DateTimeKind.Utc).AddTicks(1672), "AQAAAAIAAYagAAAAENqpFUEUXqec9GT3fDSFyZrYf4NCcjTgQkPNAVy1eozyT8WO2Ghemip1N9OPHmK4Pw==", "dc33a20a-7f4b-4c63-9ddc-f97904871030" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50aaca71-4163-4218-9c49-749e0c9e71ff", new DateTime(2023, 12, 26, 22, 13, 2, 408, DateTimeKind.Utc).AddTicks(1855), "AQAAAAIAAYagAAAAEE3W5HSN4ctnf5kfwbOeyGC7WQs3XUtBv33PRmZ7GxUsHhISUtJRbBAF7aqVDqekmw==", "cdabc819-ba4e-4da7-8dac-223b787758c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64190741-150a-4da4-bcd0-a00bfeb09492", new DateTime(2023, 12, 26, 22, 13, 2, 475, DateTimeKind.Utc).AddTicks(6585), "AQAAAAIAAYagAAAAEF/Ng0i+WMcltmOxFp+0pvrJDwc3PWxgwpEPTFj6V3DLFu+8DqEVAZlUzFebtZwNWw==", "87c62621-87ce-4401-b93c-66e87fe0a201" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Games", new DateTime(2023, 12, 26, 22, 13, 2, 344, DateTimeKind.Utc).AddTicks(704), "Labore quasi ut alias yapacakmış et ea patlıcan yazın rem." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Outdoors", new DateTime(2023, 12, 26, 22, 13, 2, 344, DateTimeKind.Utc).AddTicks(997), "Non quaerat orta göze ışık aliquam reprehenderit neque gül consequatur." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Baby", new DateTime(2023, 12, 26, 22, 13, 2, 344, DateTimeKind.Utc).AddTicks(1058), "Modi beatae ratione orta bundan tv karşıdakine totam layıkıyla vel." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Music", new DateTime(2023, 12, 26, 22, 13, 2, 344, DateTimeKind.Utc).AddTicks(1143), "Mutlu ama alias değirmeni yazın qui domates enim çobanın rem." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Tools", new DateTime(2023, 12, 26, 22, 13, 2, 344, DateTimeKind.Utc).AddTicks(1195), "Öyle çıktılar yaptı kalemi ut masaya voluptatem dicta camisi reprehenderit." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Jewelery", new DateTime(2023, 12, 26, 22, 13, 2, 344, DateTimeKind.Utc).AddTicks(1249), "Vitae cesurca qui ducimus aut sit gülüyorum sarmal çünkü mutlu." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Computers", new DateTime(2023, 12, 26, 22, 13, 2, 344, DateTimeKind.Utc).AddTicks(1304), "Nostrum çünkü cesurca dışarı quaerat odio quaerat ışık et rem." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Health", new DateTime(2023, 12, 26, 22, 13, 2, 344, DateTimeKind.Utc).AddTicks(1376), "Doğru veritatis teldeki neque gülüyorum aliquam salladı qui quia aspernatur." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2023, 12, 26, 22, 13, 2, 344, DateTimeKind.Utc).AddTicks(1429), "Voluptate aspernatur voluptatem ut beğendim un sıla bilgisayarı bahar vel." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Sports", new DateTime(2023, 12, 26, 22, 13, 2, 344, DateTimeKind.Utc).AddTicks(1481), "Beatae consequatur dolayı çobanın lambadaki koşuyorlar masanın aspernatur ama ve." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(5863), "/images/ProductImages/Test.png", "Refined Frozen Chips", 249.35m, 34 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 10, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(6468), "/images/ProductImages/Test.png", "Practical Rubber Bike", 632.03m, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 4, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(6574), "/images/ProductImages/Test.png", "Handcrafted Steel Hat", 446.09m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(6664), "/images/ProductImages/Test.png", "Ergonomic Metal Pizza", 7.40m, 31 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 7, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(6852), "/images/ProductImages/Test.png", "Practical Fresh Hat", 921.52m, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(8496), "/images/ProductImages/Test.png", "Tasty Plastic Shirt", 198.27m, 48 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 7, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(8590), "/images/ProductImages/Test.png", "Gorgeous Wooden Chicken", 762.26m, 28 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 10, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(8647), "/images/ProductImages/Test.png", "Handmade Plastic Fish", 460.66m, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice" },
                values: new object[] { 3, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(8751), "/images/ProductImages/Test.png", "Generic Steel Bike", 903.52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(8807), "/images/ProductImages/Test.png", "Licensed Rubber Keyboard", 43.00m, 41 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(8990), "/images/ProductImages/Test.png", "Ergonomic Frozen Keyboard", 814.30m, 20 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 9, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(9052), "/images/ProductImages/Test.png", "Refined Granite Bacon", 952.94m, 22 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(9105), "/images/ProductImages/Test.png", "Handcrafted Concrete Pizza", 16.74m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(9157), "/images/ProductImages/Test.png", "Unbranded Soft Bacon", 922.39m, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice" },
                values: new object[] { 10, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(9207), "/images/ProductImages/Test.png", "Handmade Plastic Cheese", 475.05m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(9474), "/images/ProductImages/Test.png", "Fantastic Granite Salad", 466.05m, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 10, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(9541), "/images/ProductImages/Test.png", "Generic Granite Shoes", 611.60m, 32 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(9629), "/images/ProductImages/Test.png", "Small Steel Car", 254.29m, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(9686), "/images/ProductImages/Test.png", "Intelligent Steel Bacon", 8.42m, 30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 3, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(9738), "/images/ProductImages/Test.png", "Generic Plastic Chips", 298.17m, 42 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(9788), "/images/ProductImages/Test.png", "Tasty Rubber Bacon", 777.11m, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 10, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(9836), "/images/ProductImages/Test.png", "Handmade Steel Ball", 1.21m, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 1, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(9885), "/images/ProductImages/Test.png", "Sleek Soft Mouse", 662.36m, 30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 3, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(9935), "/images/ProductImages/Test.png", "Ergonomic Concrete Car", 654.66m, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2023, 12, 26, 22, 13, 2, 545, DateTimeKind.Utc).AddTicks(18), "/images/ProductImages/Test.png", "Awesome Fresh Shoes", 425.05m, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 4, new DateTime(2023, 12, 26, 22, 13, 2, 545, DateTimeKind.Utc).AddTicks(71), "/images/ProductImages/Test.png", "Small Frozen Keyboard", 717.97m, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2023, 12, 26, 22, 13, 2, 545, DateTimeKind.Utc).AddTicks(122), "/images/ProductImages/Test.png", "Fantastic Cotton Chair", 649.20m, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2023, 12, 26, 22, 13, 2, 545, DateTimeKind.Utc).AddTicks(173), "/images/ProductImages/Test.png", "Sleek Metal Salad", 737.22m, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2023, 12, 26, 22, 13, 2, 545, DateTimeKind.Utc).AddTicks(221), "/images/ProductImages/Test.png", "Rustic Fresh Bike", 691.35m, 26 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2023, 12, 26, 22, 13, 2, 545, DateTimeKind.Utc).AddTicks(274), "/images/ProductImages/Test.png", "Unbranded Concrete Shoes", 603.69m, 47 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2023, 12, 25, 0, 25, 10, 550, DateTimeKind.Utc).AddTicks(9767), "Çünkü bilgiyasayarı öyle telefonu bilgiyasayarı voluptatem gazete et quis et." });

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
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice" },
                values: new object[] { 6, new DateTime(2023, 12, 25, 0, 25, 10, 759, DateTimeKind.Utc).AddTicks(8313), "/images/ProductImages/Test.jpg", "Handmade Granite Gloves", 116.53m });

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
                columns: new[] { "CategoryID", "CreatedDate", "ImagePath", "ProductName", "UnitPrice" },
                values: new object[] { 3, new DateTime(2023, 12, 25, 0, 25, 10, 759, DateTimeKind.Utc).AddTicks(8697), "/images/ProductImages/Test.jpg", "Handmade Concrete Keyboard", 516.29m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 25, 0, 25, 10, 759, DateTimeKind.Utc).AddTicks(8762), "/images/ProductImages/Test.jpg", "Incredible Soft Salad", 288.66m, 40 });

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
                columns: new[] { "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 25, 0, 25, 10, 759, DateTimeKind.Utc).AddTicks(8873), "/images/ProductImages/Test.jpg", "Incredible Granite Mouse", 92.07m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ImagePath", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 25, 0, 25, 10, 759, DateTimeKind.Utc).AddTicks(8932), "/images/ProductImages/Test.jpg", "Small Granite Bike", 416.11m, 22 });

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
    }
}
