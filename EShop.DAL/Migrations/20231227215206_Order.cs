using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShop.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Order : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "KDV",
                table: "Products",
                type: "decimal(18,0)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "OTV",
                table: "Products",
                type: "decimal(18,0)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShippingAddress = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    NameDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AppUserID = table.Column<int>(type: "int", nullable: true),
                    PriceOfOrder = table.Column<decimal>(type: "money", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_AppUserID",
                        column: x => x.AppUserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "money", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => new { x.OrderID, x.ProductID });
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "CategoryID", "CreatedDate", "KDV", "OTV", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(3026), 10m, null, "Awesome Concrete Tuna", 444.59m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "KDV", "OTV", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(3584), 10m, null, "Ergonomic Cotton Chicken", 632.31m, 37 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryID", "CreatedDate", "KDV", "OTV", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(3722), 10m, null, "Unbranded Rubber Table", 868.87m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryID", "CreatedDate", "KDV", "OTV", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(3815), 10m, null, "Practical Wooden Chips", 736.20m, 28 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryID", "CreatedDate", "KDV", "OTV", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 9, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(3940), 10m, null, "Handmade Soft Ball", 63.85m, 21 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryID", "CreatedDate", "KDV", "OTV", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 10, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(4041), 10m, null, "Small Fresh Salad", 506.41m, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryID", "CreatedDate", "KDV", "OTV", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(4110), 10m, null, "Unbranded Concrete Soap", 165.32m, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryID", "CreatedDate", "KDV", "OTV", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 4, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(4169), 10m, null, "Practical Cotton Car", 740.04m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryID", "CreatedDate", "KDV", "OTV", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(7894), 10m, null, "Generic Metal Mouse", 341.55m, 41 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryID", "CreatedDate", "KDV", "OTV", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(7967), 10m, null, "Ergonomic Concrete Table", 209.84m, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CategoryID", "CreatedDate", "KDV", "OTV", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(8162), 10m, null, "Gorgeous Fresh Chicken", 588.63m, 21 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CategoryID", "CreatedDate", "KDV", "OTV", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 1, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(8223), 10m, null, "Unbranded Steel Tuna", 104.24m, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "KDV", "OTV", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(8273), 10m, null, "Ergonomic Cotton Ball", 830.37m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CategoryID", "CreatedDate", "KDV", "OTV", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 3, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(8340), 10m, null, "Handcrafted Metal Computer", 833.63m, 42 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CategoryID", "CreatedDate", "KDV", "OTV", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 3, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(8391), 10m, null, "Fantastic Granite Tuna", 169.04m, 25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CategoryID", "CreatedDate", "KDV", "OTV", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(8621), 10m, null, "Intelligent Soft Chicken", 286.51m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "KDV", "OTV", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(8678), 10m, null, "Handcrafted Cotton Cheese", 118.74m, 26 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CategoryID", "CreatedDate", "KDV", "OTV", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 7, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(8759), 10m, null, "Refined Metal Shoes", 485.55m, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CategoryID", "CreatedDate", "KDV", "OTV", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 1, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(8810), 10m, null, "Practical Fresh Salad", 444.71m, 25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CategoryID", "CreatedDate", "KDV", "OTV", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(8859), 10m, null, "Fantastic Fresh Cheese", 500.75m, 22 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CategoryID", "CreatedDate", "KDV", "OTV", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 9, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(8907), 10m, null, "Handmade Frozen Soap", 39.62m, 31 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CategoryID", "CreatedDate", "KDV", "OTV", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(8957), 10m, null, "Handmade Granite Bacon", 341.47m, 24 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CategoryID", "CreatedDate", "KDV", "OTV", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(9005), 10m, null, "Generic Granite Keyboard", 708.01m, 20 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CategoryID", "CreatedDate", "KDV", "OTV", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 1, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(9076), 10m, null, "Gorgeous Steel Gloves", 162.87m, 40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CategoryID", "CreatedDate", "KDV", "OTV", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(9129), 10m, null, "Sleek Rubber Shirt", 456.13m, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CategoryID", "CreatedDate", "KDV", "OTV", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 7, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(9179), 10m, null, "Licensed Wooden Keyboard", 103.04m, 25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CategoryID", "CreatedDate", "KDV", "OTV", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(9233), 10m, null, "Gorgeous Granite Tuna", 850.52m, 34 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CategoryID", "CreatedDate", "KDV", "OTV", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(9280), 10m, null, "Small Concrete Bacon", 78.51m, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CategoryID", "CreatedDate", "KDV", "OTV", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(9330), 10m, null, "Practical Rubber Pizza", 110.14m, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CategoryID", "CreatedDate", "KDV", "OTV", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 4, new DateTime(2023, 12, 27, 21, 52, 5, 871, DateTimeKind.Utc).AddTicks(9383), 10m, null, "Unbranded Concrete Mouse", 780.97m, 6 });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductID",
                table: "OrderDetails",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AppUserID",
                table: "Orders",
                column: "AppUserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropColumn(
                name: "KDV",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OTV",
                table: "Products");

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
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Outdoors", new DateTime(2023, 12, 26, 22, 13, 2, 344, DateTimeKind.Utc).AddTicks(1429), "Voluptate aspernatur voluptatem ut beğendim un sıla bilgisayarı bahar vel." });

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
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(5863), "Refined Frozen Chips", 249.35m, 34 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(6468), "Practical Rubber Bike", 632.03m, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 4, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(6574), "Handcrafted Steel Hat", 446.09m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(6664), "Ergonomic Metal Pizza", 7.40m, 31 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 7, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(6852), "Practical Fresh Hat", 921.52m, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(8496), "Tasty Plastic Shirt", 198.27m, 48 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 7, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(8590), "Gorgeous Wooden Chicken", 762.26m, 28 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 10, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(8647), "Handmade Plastic Fish", 460.66m, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 3, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(8751), "Generic Steel Bike", 903.52m, 31 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(8807), "Licensed Rubber Keyboard", 43.00m, 41 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(8990), "Ergonomic Frozen Keyboard", 814.30m, 20 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 9, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(9052), "Refined Granite Bacon", 952.94m, 22 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(9105), "Handcrafted Concrete Pizza", 16.74m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(9157), "Unbranded Soft Bacon", 922.39m, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 10, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(9207), "Handmade Plastic Cheese", 475.05m, 44 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 4, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(9474), "Fantastic Granite Salad", 466.05m, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(9541), "Generic Granite Shoes", 611.60m, 32 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 10, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(9629), "Small Steel Car", 254.29m, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 9, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(9686), "Intelligent Steel Bacon", 8.42m, 30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 3, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(9738), "Generic Plastic Chips", 298.17m, 42 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(9788), "Tasty Rubber Bacon", 777.11m, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 10, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(9836), "Handmade Steel Ball", 1.21m, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 1, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(9885), "Sleek Soft Mouse", 662.36m, 30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 3, new DateTime(2023, 12, 26, 22, 13, 2, 544, DateTimeKind.Utc).AddTicks(9935), "Ergonomic Concrete Car", 654.66m, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2023, 12, 26, 22, 13, 2, 545, DateTimeKind.Utc).AddTicks(18), "Awesome Fresh Shoes", 425.05m, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 4, new DateTime(2023, 12, 26, 22, 13, 2, 545, DateTimeKind.Utc).AddTicks(71), "Small Frozen Keyboard", 717.97m, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2023, 12, 26, 22, 13, 2, 545, DateTimeKind.Utc).AddTicks(122), "Fantastic Cotton Chair", 649.20m, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2023, 12, 26, 22, 13, 2, 545, DateTimeKind.Utc).AddTicks(173), "Sleek Metal Salad", 737.22m, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2023, 12, 26, 22, 13, 2, 545, DateTimeKind.Utc).AddTicks(221), "Rustic Fresh Bike", 691.35m, 26 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CategoryID", "CreatedDate", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2023, 12, 26, 22, 13, 2, 545, DateTimeKind.Utc).AddTicks(274), "Unbranded Concrete Shoes", 603.69m, 47 });
        }
    }
}
