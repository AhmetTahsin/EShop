using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShop.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Profile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppUserProfiles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserProfiles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AppUserProfiles_AspNetUsers_ID",
                        column: x => x.ID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "5b8305ae-73cc-4792-9985-8b9ffa84c273");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "69f2fd67-ecd7-4aa5-9ee0-d0b74bcd0344");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "7784d274-6a5a-4f99-a6ea-9055cbdeb72e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42e5b733-e168-4194-9db0-1e29f8004332", new DateTime(2023, 12, 28, 18, 19, 20, 895, DateTimeKind.Utc).AddTicks(7263), "AQAAAAIAAYagAAAAEL5Q58w3BFBG1oCN+Rx1W/tizzow1Z3rUT7A569W9rEyH55qFFGvEdTKaApchECVlw==", "1a964622-b5fa-4223-b708-f4e6a7ea8ef2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f97928ec-f20a-48dc-9986-3d80294cb4ab", new DateTime(2023, 12, 28, 18, 19, 20, 966, DateTimeKind.Utc).AddTicks(9441), "AQAAAAIAAYagAAAAEG+4B5bUEkhmZPSWUz/X+0ddS8llH2XkLoNZCfFzCDJz7pAob9l6TKWo+DyGQE4hkQ==", "97d860b3-1c03-4aa3-8357-ca8cab7ee95e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62b18f19-0623-4ad5-a5e7-5f9501317c38", new DateTime(2023, 12, 28, 18, 19, 21, 39, DateTimeKind.Utc).AddTicks(2559), "AQAAAAIAAYagAAAAECdmQfzHY0UfmKa8ugGxCcTR1gp8HrPysLZm90V1QbsUXtNfngADB0HuA2+aL7JC8g==", "edfabdc4-ef10-44d0-a647-218bd64028a8" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Toys", new DateTime(2023, 12, 28, 18, 19, 20, 895, DateTimeKind.Utc).AddTicks(6120), "Dağılımı incidunt esse sunt öyle kulu mi quis quae commodi." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Electronics", new DateTime(2023, 12, 28, 18, 19, 20, 895, DateTimeKind.Utc).AddTicks(6464), "Otobüs voluptatem lakin dolore yazın iusto mutlu explicabo sit çarpan." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Computers", new DateTime(2023, 12, 28, 18, 19, 20, 895, DateTimeKind.Utc).AddTicks(6535), "Gördüm et kapının odit magni ışık anlamsız ekşili ad alias." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Home", new DateTime(2023, 12, 28, 18, 19, 20, 895, DateTimeKind.Utc).AddTicks(6628), "Koyun yaptı quis ipsa voluptatem commodi un doğru mıknatıslı neque." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Tools", new DateTime(2023, 12, 28, 18, 19, 20, 895, DateTimeKind.Utc).AddTicks(6690), "Quae inventore ab nihil türemiş dışarı minima ducimus bundan gördüm." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Toys", new DateTime(2023, 12, 28, 18, 19, 20, 895, DateTimeKind.Utc).AddTicks(6788), "Yaptı dışarı beğendim hesap çobanın sed ea sed perferendis minima." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Electronics", new DateTime(2023, 12, 28, 18, 19, 20, 895, DateTimeKind.Utc).AddTicks(6848), "Sarmal ea quis aut değerli et çıktılar ut karşıdakine adanaya." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Garden", new DateTime(2023, 12, 28, 18, 19, 20, 895, DateTimeKind.Utc).AddTicks(6903), "Quia filmini in patlıcan consequuntur voluptate gitti çünkü reprehenderit ex." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Garden", new DateTime(2023, 12, 28, 18, 19, 20, 895, DateTimeKind.Utc).AddTicks(6962), "Voluptatem patlıcan quia laudantium qui göze qui magni eos architecto." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Automotive", new DateTime(2023, 12, 28, 18, 19, 20, 895, DateTimeKind.Utc).AddTicks(7017), "Telefonu aut enim beğendim ama ea öyle ve doğru telefonu." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2023, 12, 28, 18, 19, 21, 113, DateTimeKind.Utc).AddTicks(3717), "Handcrafted Fresh Shoes", 253.41m, 22 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 7, new DateTime(2023, 12, 28, 18, 19, 21, 113, DateTimeKind.Utc).AddTicks(4393), "Sleek Granite Sausages", 671.59m, 29 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2023, 12, 28, 18, 19, 21, 113, DateTimeKind.Utc).AddTicks(5448), "Licensed Steel Shoes", 183.80m, 28 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2023, 12, 28, 18, 19, 21, 113, DateTimeKind.Utc).AddTicks(5602), "Licensed Cotton Salad", 63.90m, 46 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 4, new DateTime(2023, 12, 28, 18, 19, 21, 113, DateTimeKind.Utc).AddTicks(5685), "Licensed Plastic Chicken", 957.66m, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 28, 18, 19, 21, 113, DateTimeKind.Utc).AddTicks(5809), "Unbranded Cotton Bike", 813.32m, 40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2023, 12, 28, 18, 19, 21, 113, DateTimeKind.Utc).AddTicks(5884), "Licensed Frozen Shoes", 345.91m, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2023, 12, 28, 18, 19, 21, 113, DateTimeKind.Utc).AddTicks(6035), "Generic Frozen Fish", 971.10m, 39 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 7, new DateTime(2023, 12, 28, 18, 19, 21, 113, DateTimeKind.Utc).AddTicks(6142), "Ergonomic Frozen Shoes", 747.84m, 45 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2023, 12, 28, 18, 19, 21, 113, DateTimeKind.Utc).AddTicks(6203), "Handmade Rubber Keyboard", 922.76m, 39 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2023, 12, 28, 18, 19, 21, 113, DateTimeKind.Utc).AddTicks(6329), "Gorgeous Granite Mouse", 947.19m, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 7, new DateTime(2023, 12, 28, 18, 19, 21, 113, DateTimeKind.Utc).AddTicks(6388), "Handmade Concrete Chicken", 447.57m, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 3, new DateTime(2023, 12, 28, 18, 19, 21, 113, DateTimeKind.Utc).AddTicks(6444), "Handmade Cotton Soap", 856.43m, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 28, 18, 19, 21, 113, DateTimeKind.Utc).AddTicks(6506), "Small Cotton Mouse", 222.71m, 43 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { 1, new DateTime(2023, 12, 28, 18, 19, 21, 113, DateTimeKind.Utc).AddTicks(6604), "Ergonomic Rubber Pants", 772.36m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 7, new DateTime(2023, 12, 28, 18, 19, 21, 113, DateTimeKind.Utc).AddTicks(6872), "Handmade Metal Tuna", 421.06m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 28, 18, 19, 21, 113, DateTimeKind.Utc).AddTicks(6938), "Unbranded Rubber Hat", 459.31m, 36 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 9, new DateTime(2023, 12, 28, 18, 19, 21, 113, DateTimeKind.Utc).AddTicks(6998), "Handcrafted Concrete Ball", 735.26m, 44 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 4, new DateTime(2023, 12, 28, 18, 19, 21, 113, DateTimeKind.Utc).AddTicks(7056), "Ergonomic Rubber Sausages", 156.62m, 38 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 10, new DateTime(2023, 12, 28, 18, 19, 21, 113, DateTimeKind.Utc).AddTicks(7112), "Handcrafted Fresh Pizza", 91.35m, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2023, 12, 28, 18, 19, 21, 113, DateTimeKind.Utc).AddTicks(7208), "Intelligent Metal Computer", 616.67m, 39 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 28, 18, 19, 21, 113, DateTimeKind.Utc).AddTicks(7268), "Rustic Metal Bacon", 51.22m, 33 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2023, 12, 28, 18, 19, 21, 113, DateTimeKind.Utc).AddTicks(7327), "Rustic Steel Computer", 664.38m, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2023, 12, 28, 18, 19, 21, 113, DateTimeKind.Utc).AddTicks(7382), "Rustic Plastic Chips", 292.77m, 23 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2023, 12, 28, 18, 19, 21, 113, DateTimeKind.Utc).AddTicks(7438), "Small Granite Fish", 86.80m, 36 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 3, new DateTime(2023, 12, 28, 18, 19, 21, 113, DateTimeKind.Utc).AddTicks(7492), "Gorgeous Wooden Fish", 250.62m, 29 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2023, 12, 28, 18, 19, 21, 113, DateTimeKind.Utc).AddTicks(7551), "Awesome Wooden Sausages", 60.75m, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 28, 18, 19, 21, 113, DateTimeKind.Utc).AddTicks(7637), "Small Rubber Soap", 219.73m, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 28, 18, 19, 21, 113, DateTimeKind.Utc).AddTicks(7696), "Intelligent Granite Computer", 104.38m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 28, 18, 19, 21, 113, DateTimeKind.Utc).AddTicks(7760), "Rustic Rubber Shoes", 574.82m, 10 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUserProfiles");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "2dcee76e-ceaf-4bd1-91b1-b9f41fda3d30");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "6077887d-9336-4348-8474-c150fdd8b797");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "bd23d7c1-5e06-426c-81a8-648295cb9e8c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "288ec58b-eaa2-4417-b46e-3042df443bb2", new DateTime(2023, 12, 27, 21, 52, 5, 672, DateTimeKind.Utc).AddTicks(1380), "AQAAAAIAAYagAAAAEG+46XhfLKOuPOdm+z98wO24gGqcdDhydZlRkIoGtTwyJDlY54Pt2Ws3AYWzr4uJqA==", "efc547dd-4b14-4777-87af-b0b6ca4ad86a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f148ba7b-5cac-4420-9b73-684f55cc44c8", new DateTime(2023, 12, 27, 21, 52, 5, 736, DateTimeKind.Utc).AddTicks(3873), "AQAAAAIAAYagAAAAEHGbZR9jclUf+vrn2aqy4AO0h4eYO/0llbwDlPk4wnFcnireRWp9eW7naY8SgOyCFQ==", "e1f33031-af4b-4e22-ab2e-c481d7f20235" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f0bcd1e-a79b-4032-993b-b4229264d911", new DateTime(2023, 12, 27, 21, 52, 5, 802, DateTimeKind.Utc).AddTicks(4103), "AQAAAAIAAYagAAAAELht83jsZ9iuc2C5GAVA3eUnirl4+PfCn6eZ2FNHCnYSZY/DWBm0eFr7epKYezQKVQ==", "67ee0326-db59-4a89-a6fe-82dbdd5c5455" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Music", new DateTime(2023, 12, 27, 21, 52, 5, 671, DateTimeKind.Utc).AddTicks(9283), "Gül ipsam layıkıyla amet göze et velit cezbelendi sokaklarda labore." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Automotive", new DateTime(2023, 12, 27, 21, 52, 5, 672, DateTimeKind.Utc).AddTicks(4), "Öyle velit incidunt velit qui quis otobüs iusto doğru çıktılar." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Shoes", new DateTime(2023, 12, 27, 21, 52, 5, 672, DateTimeKind.Utc).AddTicks(73), "Eve eaque lakin ki laboriosam filmini quasi reprehenderit şafak voluptatem." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Movies", new DateTime(2023, 12, 27, 21, 52, 5, 672, DateTimeKind.Utc).AddTicks(328), "Sevindi iure velit quia quae umut laudantium exercitationem voluptatem orta." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Movies", new DateTime(2023, 12, 27, 21, 52, 5, 672, DateTimeKind.Utc).AddTicks(534), "Karşıdakine aut ullam lakin consequatur çarpan filmini de aspernatur lakin." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Movies", new DateTime(2023, 12, 27, 21, 52, 5, 672, DateTimeKind.Utc).AddTicks(588), "Beğendim de nesciunt yazın laboriosam makinesi telefonu camisi alias balıkhaneye." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Baby", new DateTime(2023, 12, 27, 21, 52, 5, 672, DateTimeKind.Utc).AddTicks(855), "Bahar sevindi duyulmamış voluptatem otobüs consectetur fugit ad olduğu ki." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Automotive", new DateTime(2023, 12, 27, 21, 52, 5, 672, DateTimeKind.Utc).AddTicks(906), "Koştum için lambadaki quia autem karşıdakine dignissimos architecto accusantium aut." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Grocery", new DateTime(2023, 12, 27, 21, 52, 5, 672, DateTimeKind.Utc).AddTicks(978), "Dicta dolore laudantium laboriosam nemo cesurca telefonu uzattı exercitationem et." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Music", new DateTime(2023, 12, 27, 21, 52, 5, 672, DateTimeKind.Utc).AddTicks(1027), "Düşünüyor gülüyorum ötekinden dağılımı dolores filmini anlamsız vitae qui oldular." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(3026), "Awesome Concrete Tuna", 444.59m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 10, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(3584), "Ergonomic Cotton Chicken", 632.31m, 37 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(3722), "Unbranded Rubber Table", 868.87m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(3815), "Practical Wooden Chips", 736.20m, 28 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 9, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(3940), "Handmade Soft Ball", 63.85m, 21 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(4041), "Small Fresh Salad", 506.41m, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(4110), "Unbranded Concrete Soap", 165.32m, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 4, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(4169), "Practical Cotton Car", 740.04m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(7894), "Generic Metal Mouse", 341.55m, 41 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(7967), "Ergonomic Concrete Table", 209.84m, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(8162), "Gorgeous Fresh Chicken", 588.63m, 21 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 1, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(8223), "Unbranded Steel Tuna", 104.24m, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(8273), "Ergonomic Cotton Ball", 830.37m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(8340), "Handcrafted Metal Computer", 833.63m, 42 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { 3, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(8391), "Fantastic Granite Tuna", 169.04m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(8621), "Intelligent Soft Chicken", 286.51m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(8678), "Handcrafted Cotton Cheese", 118.74m, 26 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 7, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(8759), "Refined Metal Shoes", 485.55m, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 1, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(8810), "Practical Fresh Salad", 444.71m, 25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(8859), "Fantastic Fresh Cheese", 500.75m, 22 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 9, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(8907), "Handmade Frozen Soap", 39.62m, 31 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(8957), "Handmade Granite Bacon", 341.47m, 24 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(9005), "Generic Granite Keyboard", 708.01m, 20 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 1, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(9076), "Gorgeous Steel Gloves", 162.87m, 40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(9129), "Sleek Rubber Shirt", 456.13m, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 7, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(9179), "Licensed Wooden Keyboard", 103.04m, 25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(9233), "Gorgeous Granite Tuna", 850.52m, 34 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(9280), "Small Concrete Bacon", 78.51m, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(9330), "Practical Rubber Pizza", 110.14m, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(9383), "Unbranded Concrete Mouse", 780.97m, 6 });
        }
    }
}
