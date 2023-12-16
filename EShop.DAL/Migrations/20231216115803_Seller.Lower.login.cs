using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShop.DAL.Migrations
{
    /// <inheritdoc />
    public partial class SellerLowerlogin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "456c04e3-364c-4e30-92a2-84b1d4e356ad");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "0ebe1783-cfde-41ef-90c7-b68d50bda64e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 3, "226ebf1e-b891-4347-9557-5dba6884e05d", "Seller", "SELLER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3a6f8982-8a85-4758-9090-9678b6827424", new DateTime(2023, 12, 16, 11, 58, 2, 120, DateTimeKind.Utc).AddTicks(1530), "admin@gmail.com", "AQAAAAIAAYagAAAAEF0NR66516PPf4YKKjqwD7ILWPk2APaidH5dYB07UlmT6jcG06OPrtvKTTIeWnXy+Q==", "931cc686-a246-4f95-bb09-cc6857ceb365", "admin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c4c1619-0da2-43bc-a5fb-87167bb57cf9", new DateTime(2023, 12, 16, 11, 58, 2, 178, DateTimeKind.Utc).AddTicks(6790), "AQAAAAIAAYagAAAAEPp9KWfybkmJENdleD0yXTiA93gt6QwmMuGd04Us4oXkrufwe8SXDHcEiADQWsDMWg==", "3462b240-4264-4cc0-a959-ee3b6bcf30b5" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "ModifiedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[] { 3, 0, "034336b4-ac66-49ec-9b0f-d89c076ea004", new DateTime(2023, 12, 16, 11, 58, 2, 251, DateTimeKind.Utc).AddTicks(6834), null, "seller@gmail.com", true, false, null, null, "SELLER@GMAIL.COM", "SELLER", "AQAAAAIAAYagAAAAECp4Tri1MwWbVER2B4Oh8UIz4zoc772wC+8ATBJZ4iX5g42Hp4jsRYN4BJxI2mjcYA==", null, false, "bb39d50b-d971-45c2-a92a-c3a4fba8fa1f", 1, false, "seller123" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2023, 12, 16, 11, 58, 2, 120, DateTimeKind.Utc).AddTicks(572), "Mi yapacakmış dağılımı perferendis nihil sit ipsa consectetur açılmadan ipsa." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Grocery", new DateTime(2023, 12, 16, 11, 58, 2, 120, DateTimeKind.Utc).AddTicks(827), "Işık nisi architecto consequatur gülüyorum hesap koyun quaerat değirmeni çobanın." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Health", new DateTime(2023, 12, 16, 11, 58, 2, 120, DateTimeKind.Utc).AddTicks(930), "Ama quis bahar dolayı tv fugit ipsam kalemi kutusu gül." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Health", new DateTime(2023, 12, 16, 11, 58, 2, 120, DateTimeKind.Utc).AddTicks(1018), "Consectetur masanın aperiam nihil dağılımı domates molestiae totam makinesi totam." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Beauty", new DateTime(2023, 12, 16, 11, 58, 2, 120, DateTimeKind.Utc).AddTicks(1072), "Voluptate voluptatem çorba alias camisi göze bundan değerli tempora veritatis." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Industrial", new DateTime(2023, 12, 16, 11, 58, 2, 120, DateTimeKind.Utc).AddTicks(1129), "Sit gül architecto değerli şafak quis ut lakin quia corporis." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Sports", new DateTime(2023, 12, 16, 11, 58, 2, 120, DateTimeKind.Utc).AddTicks(1180), "Sarmal türemiş voluptatem doloremque camisi çarpan sandalye gidecekmiş koyun sunt." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Shoes", new DateTime(2023, 12, 16, 11, 58, 2, 120, DateTimeKind.Utc).AddTicks(1233), "Düşünüyor ama illo blanditiis çorba explicabo quae ut aut dicta." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Books", new DateTime(2023, 12, 16, 11, 58, 2, 120, DateTimeKind.Utc).AddTicks(1306), "Çorba gitti koştum mıknatıslı labore amet dolorem uzattı ullam kalemi." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Music", new DateTime(2023, 12, 16, 11, 58, 2, 120, DateTimeKind.Utc).AddTicks(1359), "İpsum dignissimos balıkhaneye qui sequi orta nemo doloremque modi doloremque." });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 16, 11, 58, 2, 319, DateTimeKind.Utc).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2023, 12, 16, 11, 58, 2, 319, DateTimeKind.Utc).AddTicks(4738), "Incredible Cotton Chips", 104.52m, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 1, new DateTime(2023, 12, 16, 11, 58, 2, 319, DateTimeKind.Utc).AddTicks(6229), "Intelligent Frozen Mouse", 98.45m, 44 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2023, 12, 16, 11, 58, 2, 319, DateTimeKind.Utc).AddTicks(6337), "Fantastic Rubber Chair", 770.88m, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2023, 12, 16, 11, 58, 2, 319, DateTimeKind.Utc).AddTicks(6426), "Gorgeous Steel Computer", 290.56m, 35 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 4, new DateTime(2023, 12, 16, 11, 58, 2, 319, DateTimeKind.Utc).AddTicks(6556), "Ergonomic Fresh Keyboard", 302.72m, 29 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 10, new DateTime(2023, 12, 16, 11, 58, 2, 319, DateTimeKind.Utc).AddTicks(6682), "Incredible Granite Fish", 427.87m, 43 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 16, 11, 58, 2, 319, DateTimeKind.Utc).AddTicks(7062), "Licensed Granite Ball", 701.26m, 23 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2023, 12, 16, 11, 58, 2, 319, DateTimeKind.Utc).AddTicks(7114), "Refined Fresh Bacon", 318.90m, 31 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 7, new DateTime(2023, 12, 16, 11, 58, 2, 319, DateTimeKind.Utc).AddTicks(7212), "Awesome Rubber Tuna", 265.83m, 49 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 7, new DateTime(2023, 12, 16, 11, 58, 2, 319, DateTimeKind.Utc).AddTicks(7273), "Fantastic Soft Computer", 822.92m, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2023, 12, 16, 11, 58, 2, 319, DateTimeKind.Utc).AddTicks(7399), "Rustic Metal Table", 754.37m, 23 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 16, 11, 58, 2, 319, DateTimeKind.Utc).AddTicks(8002), "Small Rubber Pants", 707.32m, 25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2023, 12, 16, 11, 58, 2, 319, DateTimeKind.Utc).AddTicks(8051), "Refined Granite Tuna", 175.22m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 9, new DateTime(2023, 12, 16, 11, 58, 2, 319, DateTimeKind.Utc).AddTicks(8098), "Awesome Frozen Shirt", 475.61m, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 4, new DateTime(2023, 12, 16, 11, 58, 2, 319, DateTimeKind.Utc).AddTicks(8149), "Awesome Wooden Pants", 47.00m, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 1, new DateTime(2023, 12, 16, 11, 58, 2, 319, DateTimeKind.Utc).AddTicks(8377), "Practical Granite Soap", 764.78m, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2023, 12, 16, 11, 58, 2, 319, DateTimeKind.Utc).AddTicks(8434), "Rustic Cotton Chicken", 844.70m, 28 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2023, 12, 16, 11, 58, 2, 319, DateTimeKind.Utc).AddTicks(8486), "Intelligent Wooden Bike", 440.09m, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2023, 12, 16, 11, 58, 2, 319, DateTimeKind.Utc).AddTicks(8564), "Incredible Steel Ball", 223.32m, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 16, 11, 58, 2, 319, DateTimeKind.Utc).AddTicks(8906), "Incredible Steel Ball", 236.99m, 41 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 16, 11, 58, 2, 319, DateTimeKind.Utc).AddTicks(8955), "Handmade Wooden Gloves", 926.54m, 21 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 1, new DateTime(2023, 12, 16, 11, 58, 2, 319, DateTimeKind.Utc).AddTicks(9172), "Practical Concrete Car", 325.47m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { 5, new DateTime(2023, 12, 16, 11, 58, 2, 319, DateTimeKind.Utc).AddTicks(9222), "Sleek Soft Cheese", 10.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 9, new DateTime(2023, 12, 16, 11, 58, 2, 319, DateTimeKind.Utc).AddTicks(9271), "Handcrafted Granite Fish", 365.64m, 43 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 16, 11, 58, 2, 319, DateTimeKind.Utc).AddTicks(9537), "Handmade Concrete Chair", 266.56m, 37 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 4, new DateTime(2023, 12, 16, 11, 58, 2, 319, DateTimeKind.Utc).AddTicks(9644), "Sleek Soft Ball", 638.30m, 24 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2023, 12, 16, 11, 58, 2, 319, DateTimeKind.Utc).AddTicks(9693), "Ergonomic Cotton Hat", 631.35m, 48 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 3, new DateTime(2023, 12, 16, 11, 58, 2, 319, DateTimeKind.Utc).AddTicks(9750), "Refined Cotton Gloves", 950.81m, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2023, 12, 16, 11, 58, 2, 319, DateTimeKind.Utc).AddTicks(9802), "Tasty Fresh Table", 406.23m, 31 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 10, new DateTime(2023, 12, 16, 11, 58, 2, 319, DateTimeKind.Utc).AddTicks(9850), "Rustic Plastic Pants", 390.52m, 5 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 3, 3 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "47a39032-f462-4aa2-8157-7613c6a90374");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "44958d28-c726-4410-a36c-14a8cb65e5a0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "568a6063-114a-4454-ac02-edb3d1e6a1f0", new DateTime(2023, 12, 15, 12, 26, 28, 649, DateTimeKind.Utc).AddTicks(7836), "Admin@gmail.com", "AQAAAAIAAYagAAAAELWwukbkjf5h9CSRyj9cPXoChJsLgmMA6GZ93NhZJs398jNl/lxOoYQXp2ttAetW0Q==", "5099cba3-2776-4dc4-94b4-6598f6ec8302", "Admin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c60824cd-697b-4812-ac8f-2ae93781429a", new DateTime(2023, 12, 15, 12, 26, 28, 712, DateTimeKind.Utc).AddTicks(3560), "AQAAAAIAAYagAAAAELs9ay2ar9Gw0/AmcS7kIEwUofABh+rfpusZMM8+T2Z5kXYQYcK9tkKpRZ86+vquBA==", "9314bf99-c135-429b-be7f-04d79d533ca0" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2023, 12, 15, 12, 26, 28, 649, DateTimeKind.Utc).AddTicks(6875), "Eve yazın mıknatıslı dergi vel dolor mutlu masaya molestiae mıknatıslı." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Movies", new DateTime(2023, 12, 15, 12, 26, 28, 649, DateTimeKind.Utc).AddTicks(7145), "İn iure çorba adanaya explicabo rem et beğendim ad ipsum." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Grocery", new DateTime(2023, 12, 15, 12, 26, 28, 649, DateTimeKind.Utc).AddTicks(7209), "Alias consequatur masaya quam labore mutlu aliquam suscipit yapacakmış alias." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Toys", new DateTime(2023, 12, 15, 12, 26, 28, 649, DateTimeKind.Utc).AddTicks(7260), "Sayfası tv in değerli olduğu minima dolor eum aspernatur sıradanlıktan." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Sports", new DateTime(2023, 12, 15, 12, 26, 28, 649, DateTimeKind.Utc).AddTicks(7318), "Patlıcan hesap ullam aliquam telefonu umut quis duyulmamış quia magnam." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Garden", new DateTime(2023, 12, 15, 12, 26, 28, 649, DateTimeKind.Utc).AddTicks(7394), "Ea yaptı voluptatem sokaklarda ducimus qui doloremque sit adresini fugit." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Home", new DateTime(2023, 12, 15, 12, 26, 28, 649, DateTimeKind.Utc).AddTicks(7452), "Eve türemiş et şafak blanditiis labore filmini non oldular exercitationem." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Electronics", new DateTime(2023, 12, 15, 12, 26, 28, 649, DateTimeKind.Utc).AddTicks(7503), "Çorba beatae batarya aperiam sed kutusu quia yapacakmış corporis ut." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Automotive", new DateTime(2023, 12, 15, 12, 26, 28, 649, DateTimeKind.Utc).AddTicks(7558), "Nemo gidecekmiş totam perferendis salladı lambadaki sit ipsa ratione öyle." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Clothing", new DateTime(2023, 12, 15, 12, 26, 28, 649, DateTimeKind.Utc).AddTicks(7653), "Teldeki gül laboriosam et quia orta quia mi voluptatem oldular." });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(8160), "Generic Fresh Chips", 556.49m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 10, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(8599), "Gorgeous Plastic Keyboard", 861.53m, 47 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(8656), "Gorgeous Steel Ball", 909.42m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 3, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(8696), "Tasty Plastic Bike", 672.53m, 46 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(8738), "Small Frozen Shirt", 158.84m, 30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 4, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(8785), "Generic Frozen Car", 959.94m, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(8825), "Handcrafted Concrete Salad", 333.40m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(8868), "Gorgeous Granite Pizza", 857.91m, 41 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 10, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(8941), "Handmade Fresh Chair", 753.17m, 31 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 4, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(8985), "Rustic Plastic Chair", 11.91m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 7, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(9026), "Licensed Rubber Tuna", 635.90m, 41 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(9066), "Practical Soft Towels", 390.86m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 9, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(9107), "Rustic Metal Chips", 320.12m, 47 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 10, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(9146), "Handcrafted Granite Fish", 775.13m, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(9186), "Generic Rubber Bike", 347.16m, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(9255), "Unbranded Fresh Computer", 487.23m, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(9296), "Awesome Plastic Car", 118.28m, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 9, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(9336), "Sleek Granite Sausages", 403.35m, 31 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 9, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(9376), "Intelligent Wooden Cheese", 163.50m, 39 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(9420), "Gorgeous Steel Pants", 202.08m, 42 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(9459), "Generic Cotton Keyboard", 662.54m, 40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(9497), "Intelligent Cotton Towels", 231.45m, 31 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { 10, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(9565), "Refined Rubber Computer", 675.18m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(9603), "Fantastic Frozen Bike", 975.21m, 49 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(9642), "Generic Granite Tuna", 526.34m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 7, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(9680), "Gorgeous Steel Cheese", 945.70m, 27 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(9719), "Incredible Metal Table", 660.21m, 32 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(9757), "Handcrafted Plastic Chair", 619.28m, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(9795), "Intelligent Steel Salad", 220.40m, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(9862), "Tasty Plastic Sausages", 224.42m, 37 });
        }
    }
}
