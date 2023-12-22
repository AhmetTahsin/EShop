using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShop.DAL.Migrations
{
    /// <inheritdoc />
    public partial class dbtype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "ProductImages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "20e85b6e-9828-46ca-9ae6-dec1d9df47a1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "15ef0ef2-ade7-4cef-a574-efdb58224cb7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "b0bffa9f-a0cc-4e8d-ba9c-018f515c2161");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "426e132c-d232-40ba-8c7e-1db0821bcc40", new DateTime(2023, 12, 22, 13, 36, 25, 211, DateTimeKind.Utc).AddTicks(406), "AQAAAAIAAYagAAAAEBCHbWhC3fpWjknhu61dLZU+aRDpxY3WZr8qoGiovrwtY3jP3KPFCQeAy9HYBVxPEQ==", "e9a18e8c-fb57-44d0-b0bf-4f420a9a58e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9fdbea1e-6fbe-4885-8dd4-65c976544e33", new DateTime(2023, 12, 22, 13, 36, 25, 277, DateTimeKind.Utc).AddTicks(7453), "AQAAAAIAAYagAAAAECMhjyhcBrizmEiv3sH/orqVDxRxzT+edwlNQdnNEHYu6GdHLGEseJUMBZ2pBy3A0w==", "eb88f68e-e5ac-4f8e-9e80-0e247c5c28ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "306b69f5-c789-4f78-ae17-903a8fbcbb91", new DateTime(2023, 12, 22, 13, 36, 25, 340, DateTimeKind.Utc).AddTicks(8027), "AQAAAAIAAYagAAAAEG/72FNaC6onZHbj68n9kC2uWojdd0kGZTqP/CfeHEPZ3/IjBw2quB6r0hGDztIAmQ==", "0d885e1d-702f-43e0-8fa9-02eb73a159c4" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Jewelery", new DateTime(2023, 12, 22, 13, 36, 25, 210, DateTimeKind.Utc).AddTicks(9309), "Quia incidunt nihil architecto incidunt neque odit beğendim lakin gazete." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Kids", new DateTime(2023, 12, 22, 13, 36, 25, 210, DateTimeKind.Utc).AddTicks(9576), "Quia sevindi eaque gazete camisi değirmeni quis uzattı adresini çıktılar." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Home", new DateTime(2023, 12, 22, 13, 36, 25, 210, DateTimeKind.Utc).AddTicks(9642), "Quam ut magnam consequatur de quam ea ve ekşili dışarı." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Grocery", new DateTime(2023, 12, 22, 13, 36, 25, 210, DateTimeKind.Utc).AddTicks(9756), "Patlıcan filmini ona eius için sarmal düşünüyor çünkü lakin tempora." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Grocery", new DateTime(2023, 12, 22, 13, 36, 25, 210, DateTimeKind.Utc).AddTicks(9817), "Sandalye dolayı ea corporis veniam bilgisayarı voluptatem quia magni ona." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Toys", new DateTime(2023, 12, 22, 13, 36, 25, 210, DateTimeKind.Utc).AddTicks(9905), "Yapacakmış et quia türemiş un neque aperiam düşünüyor masaya oldular." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Books", new DateTime(2023, 12, 22, 13, 36, 25, 210, DateTimeKind.Utc).AddTicks(9965), "Ama biber nisi aut nesciunt modi gül bilgiyasayarı voluptatem ipsum." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Outdoors", new DateTime(2023, 12, 22, 13, 36, 25, 211, DateTimeKind.Utc).AddTicks(22), "Ut patlıcan sokaklarda voluptatem consequatur çünkü hesap mutlu olduğu anlamsız." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Shoes", new DateTime(2023, 12, 22, 13, 36, 25, 211, DateTimeKind.Utc).AddTicks(99), "Çarpan sit gördüm commodi koşuyorlar koştum voluptatum koştum architecto dignissimos." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Grocery", new DateTime(2023, 12, 22, 13, 36, 25, 211, DateTimeKind.Utc).AddTicks(182), "Aliquid ducimus anlamsız reprehenderit çıktılar ullam nostrum et adresini quis." });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ProductID" },
                values: new object[] { new DateTime(2023, 12, 22, 13, 36, 25, 403, DateTimeKind.Utc).AddTicks(354), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2023, 12, 22, 13, 36, 25, 403, DateTimeKind.Utc).AddTicks(420), "Rustic Frozen Computer", 953.20m, 36 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 10, new DateTime(2023, 12, 22, 13, 36, 25, 403, DateTimeKind.Utc).AddTicks(812), "Ergonomic Fresh Soap", 997.76m, 48 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 22, 13, 36, 25, 403, DateTimeKind.Utc).AddTicks(855), "Incredible Soft Shoes", 605.08m, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2023, 12, 22, 13, 36, 25, 403, DateTimeKind.Utc).AddTicks(892), "Generic Rubber Computer", 857.00m, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 22, 13, 36, 25, 403, DateTimeKind.Utc).AddTicks(1001), "Unbranded Frozen Car", 982.66m, 40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2023, 12, 22, 13, 36, 25, 403, DateTimeKind.Utc).AddTicks(1046), "Unbranded Soft Gloves", 799.60m, 28 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 10, new DateTime(2023, 12, 22, 13, 36, 25, 403, DateTimeKind.Utc).AddTicks(1083), "Gorgeous Wooden Soap", 996.44m, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 4, new DateTime(2023, 12, 22, 13, 36, 25, 403, DateTimeKind.Utc).AddTicks(1118), "Rustic Cotton Pizza", 363.40m, 42 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 3, new DateTime(2023, 12, 22, 13, 36, 25, 403, DateTimeKind.Utc).AddTicks(1153), "Generic Wooden Tuna", 882.02m, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 3, new DateTime(2023, 12, 22, 13, 36, 25, 403, DateTimeKind.Utc).AddTicks(1188), "Rustic Concrete Fish", 69.09m, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 4, new DateTime(2023, 12, 22, 13, 36, 25, 403, DateTimeKind.Utc).AddTicks(1223), "Small Metal Chair", 616.64m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 22, 13, 36, 25, 403, DateTimeKind.Utc).AddTicks(1323), "Sleek Wooden Cheese", 990.69m, 26 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 9, new DateTime(2023, 12, 22, 13, 36, 25, 403, DateTimeKind.Utc).AddTicks(1359), "Intelligent Soft Fish", 260.89m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 1, new DateTime(2023, 12, 22, 13, 36, 25, 403, DateTimeKind.Utc).AddTicks(1392), "Ergonomic Cotton Hat", 917.95m, 40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 1, new DateTime(2023, 12, 22, 13, 36, 25, 403, DateTimeKind.Utc).AddTicks(1427), "Handcrafted Cotton Chair", 830.81m, 49 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2023, 12, 22, 13, 36, 25, 403, DateTimeKind.Utc).AddTicks(1460), "Intelligent Rubber Tuna", 497.76m, 37 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2023, 12, 22, 13, 36, 25, 403, DateTimeKind.Utc).AddTicks(1493), "Handcrafted Steel Chair", 895.16m, 41 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 7, new DateTime(2023, 12, 22, 13, 36, 25, 403, DateTimeKind.Utc).AddTicks(1563), "Refined Cotton Mouse", 957.01m, 48 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 1, new DateTime(2023, 12, 22, 13, 36, 25, 403, DateTimeKind.Utc).AddTicks(1601), "Sleek Metal Towels", 245.11m, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2023, 12, 22, 13, 36, 25, 403, DateTimeKind.Utc).AddTicks(1636), "Intelligent Steel Mouse", 343.85m, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2023, 12, 22, 13, 36, 25, 403, DateTimeKind.Utc).AddTicks(1669), "Generic Cotton Salad", 639.62m, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2023, 12, 22, 13, 36, 25, 403, DateTimeKind.Utc).AddTicks(1703), "Rustic Concrete Ball", 888.21m, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2023, 12, 22, 13, 36, 25, 403, DateTimeKind.Utc).AddTicks(1737), "Tasty Frozen Keyboard", 790.62m, 25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2023, 12, 22, 13, 36, 25, 403, DateTimeKind.Utc).AddTicks(1771), "Tasty Steel Pizza", 751.04m, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 4, new DateTime(2023, 12, 22, 13, 36, 25, 403, DateTimeKind.Utc).AddTicks(1824), "Ergonomic Soft Chips", 373.57m, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2023, 12, 22, 13, 36, 25, 403, DateTimeKind.Utc).AddTicks(1859), "Rustic Frozen Keyboard", 516.95m, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2023, 12, 22, 13, 36, 25, 403, DateTimeKind.Utc).AddTicks(1891), "Handmade Frozen Chips", 440.94m, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2023, 12, 22, 13, 36, 25, 403, DateTimeKind.Utc).AddTicks(1924), "Rustic Frozen Chicken", 164.48m, 22 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 22, 13, 36, 25, 403, DateTimeKind.Utc).AddTicks(1958), "Awesome Frozen Sausages", 511.92m, 34 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2023, 12, 22, 13, 36, 25, 403, DateTimeKind.Utc).AddTicks(1991), "Fantastic Plastic Fish", 549.77m, 11 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "ProductImages");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "feec714b-abaf-47d3-9201-be513ed159bc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "c379a1f2-bd2d-41c3-b1bf-4408608b1454");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "beb150f9-75b7-4b66-9f16-2a0b012e8693");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "522fcee2-fb72-4c97-adfc-8bc64c24fcd2", new DateTime(2023, 12, 22, 13, 33, 27, 754, DateTimeKind.Utc).AddTicks(3660), "AQAAAAIAAYagAAAAEIWw+zgbe22gWq4fPkiAqMtu0/iziHwpILjmOfdiusCjc68M8E2Q8zXR1u0qEwgHgA==", "201f0553-b47c-492c-9f71-3aa057658b2e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8c450f8-0b4e-4d93-8134-31fdd66bb710", new DateTime(2023, 12, 22, 13, 33, 27, 817, DateTimeKind.Utc).AddTicks(6024), "AQAAAAIAAYagAAAAEIFB1rn0p6YniwOzxg6LoN1ugh4cmN0+mjgSqVCwdLdF2/j2tDoPIFJ2uccZVUp4Kw==", "d5a4dfe3-6853-4c71-ab72-36bf1f8022fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00cfe7ab-c4d0-4328-95de-4ae14c351dc8", new DateTime(2023, 12, 22, 13, 33, 27, 881, DateTimeKind.Utc).AddTicks(7520), "AQAAAAIAAYagAAAAECUv1Q89drwzos+GuXrtX1FaKaiSmIrsnhI5pH1eSsc6dWukB9bfCzXqfY2Yyd7YNg==", "b493a7b8-6fe7-4dd7-b7b3-07c0889f5749" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Beauty", new DateTime(2023, 12, 22, 13, 33, 27, 754, DateTimeKind.Utc).AddTicks(2664), "Ea cezbelendi göze voluptatem koştum sed suscipit voluptatem ad lambadaki." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Electronics", new DateTime(2023, 12, 22, 13, 33, 27, 754, DateTimeKind.Utc).AddTicks(2923), "Çıktılar enim voluptatem fugit makinesi voluptatem ducimus enim ötekinden amet." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Tools", new DateTime(2023, 12, 22, 13, 33, 27, 754, DateTimeKind.Utc).AddTicks(2986), "Quasi magni camisi rem sayfası teldeki un rem quia çakıl." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Automotive", new DateTime(2023, 12, 22, 13, 33, 27, 754, DateTimeKind.Utc).AddTicks(3072), "Salladı velit ötekinden voluptatem laudantium aperiam patlıcan dolayı dolores yaptı." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Industrial", new DateTime(2023, 12, 22, 13, 33, 27, 754, DateTimeKind.Utc).AddTicks(3166), "Koyun velit cezbelendi filmini değirmeni camisi anlamsız sıradanlıktan koşuyorlar dolorem." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Health", new DateTime(2023, 12, 22, 13, 33, 27, 754, DateTimeKind.Utc).AddTicks(3229), "De aut quis esse quae beatae aspernatur dolore corporis nemo." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Toys", new DateTime(2023, 12, 22, 13, 33, 27, 754, DateTimeKind.Utc).AddTicks(3286), "İusto domates odit aliquam gülüyorum neque masanın de aliquid anlamsız." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Games", new DateTime(2023, 12, 22, 13, 33, 27, 754, DateTimeKind.Utc).AddTicks(3353), "Çünkü quis laudantium patlıcan et doloremque sunt açılmadan molestiae dergi." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Music", new DateTime(2023, 12, 22, 13, 33, 27, 754, DateTimeKind.Utc).AddTicks(3408), "Exercitationem quae consectetur exercitationem layıkıyla doğru masaya deleniti gidecekmiş olduğu." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Home", new DateTime(2023, 12, 22, 13, 33, 27, 754, DateTimeKind.Utc).AddTicks(3462), "Orta otobüs alias et rem sit sit dolores dignissimos autem." });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 22, 13, 33, 27, 944, DateTimeKind.Utc).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 3, new DateTime(2023, 12, 22, 13, 33, 27, 944, DateTimeKind.Utc).AddTicks(4225), "Handcrafted Metal Soap", 362.52m, 31 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2023, 12, 22, 13, 33, 27, 944, DateTimeKind.Utc).AddTicks(4651), "Practical Fresh Salad", 801.95m, 34 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 22, 13, 33, 27, 944, DateTimeKind.Utc).AddTicks(5436), "Incredible Wooden Hat", 761.07m, 28 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 4, new DateTime(2023, 12, 22, 13, 33, 27, 944, DateTimeKind.Utc).AddTicks(5577), "Refined Plastic Towels", 440.53m, 31 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 22, 13, 33, 27, 944, DateTimeKind.Utc).AddTicks(5642), "Intelligent Frozen Bike", 736.06m, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2023, 12, 22, 13, 33, 27, 944, DateTimeKind.Utc).AddTicks(5746), "Incredible Granite Cheese", 629.55m, 45 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 3, new DateTime(2023, 12, 22, 13, 33, 27, 944, DateTimeKind.Utc).AddTicks(5802), "Refined Plastic Fish", 629.36m, 47 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2023, 12, 22, 13, 33, 27, 944, DateTimeKind.Utc).AddTicks(5852), "Intelligent Metal Gloves", 736.27m, 46 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2023, 12, 22, 13, 33, 27, 944, DateTimeKind.Utc).AddTicks(5923), "Tasty Fresh Shoes", 513.96m, 47 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 7, new DateTime(2023, 12, 22, 13, 33, 27, 944, DateTimeKind.Utc).AddTicks(5971), "Sleek Concrete Chicken", 924.66m, 38 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 3, new DateTime(2023, 12, 22, 13, 33, 27, 944, DateTimeKind.Utc).AddTicks(6093), "Handcrafted Steel Chips", 805.11m, 22 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 22, 13, 33, 27, 944, DateTimeKind.Utc).AddTicks(6143), "Small Concrete Fish", 949.15m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2023, 12, 22, 13, 33, 27, 944, DateTimeKind.Utc).AddTicks(9839), "Tasty Cotton Towels", 310.99m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2023, 12, 22, 13, 33, 27, 944, DateTimeKind.Utc).AddTicks(9953), "Awesome Cotton Chair", 383.31m, 31 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 7, new DateTime(2023, 12, 22, 13, 33, 27, 945, DateTimeKind.Utc).AddTicks(1), "Ergonomic Concrete Chips", 426.79m, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 9, new DateTime(2023, 12, 22, 13, 33, 27, 945, DateTimeKind.Utc).AddTicks(154), "Fantastic Rubber Chair", 952.58m, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 9, new DateTime(2023, 12, 22, 13, 33, 27, 945, DateTimeKind.Utc).AddTicks(208), "Handcrafted Soft Computer", 868.29m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 9, new DateTime(2023, 12, 22, 13, 33, 27, 945, DateTimeKind.Utc).AddTicks(302), "Unbranded Metal Sausages", 858.65m, 29 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2023, 12, 22, 13, 33, 27, 945, DateTimeKind.Utc).AddTicks(348), "Refined Concrete Chips", 662.08m, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 4, new DateTime(2023, 12, 22, 13, 33, 27, 945, DateTimeKind.Utc).AddTicks(389), "Generic Plastic Soap", 650.61m, 48 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2023, 12, 22, 13, 33, 27, 945, DateTimeKind.Utc).AddTicks(465), "Handmade Granite Soap", 419.46m, 27 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 4, new DateTime(2023, 12, 22, 13, 33, 27, 945, DateTimeKind.Utc).AddTicks(509), "Licensed Soft Salad", 96.21m, 41 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2023, 12, 22, 13, 33, 27, 945, DateTimeKind.Utc).AddTicks(551), "Rustic Frozen Shirt", 434.50m, 36 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 7, new DateTime(2023, 12, 22, 13, 33, 27, 945, DateTimeKind.Utc).AddTicks(592), "Licensed Granite Car", 703.45m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2023, 12, 22, 13, 33, 27, 945, DateTimeKind.Utc).AddTicks(660), "Refined Fresh Bacon", 12.68m, 20 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 7, new DateTime(2023, 12, 22, 13, 33, 27, 945, DateTimeKind.Utc).AddTicks(702), "Awesome Frozen Soap", 899.10m, 36 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 10, new DateTime(2023, 12, 22, 13, 33, 27, 945, DateTimeKind.Utc).AddTicks(743), "Handcrafted Wooden Chicken", 293.53m, 41 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2023, 12, 22, 13, 33, 27, 945, DateTimeKind.Utc).AddTicks(786), "Handmade Wooden Chicken", 140.03m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 22, 13, 33, 27, 945, DateTimeKind.Utc).AddTicks(829), "Handcrafted Fresh Tuna", 592.41m, 26 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 9, new DateTime(2023, 12, 22, 13, 33, 27, 945, DateTimeKind.Utc).AddTicks(871), "Small Cotton Car", 55.40m, 9 });
        }
    }
}
