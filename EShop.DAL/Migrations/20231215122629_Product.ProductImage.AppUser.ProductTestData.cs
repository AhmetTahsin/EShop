using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EShop.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ProductProductImageAppUserProductTestData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitsInStock = table.Column<int>(type: "int", nullable: false),
                    ProductImageID = table.Column<int>(type: "int", nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Products_ProductImages_ProductImageID",
                        column: x => x.ProductImageID,
                        principalTable: "ProductImages",
                        principalColumn: "ID");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "47a39032-f462-4aa2-8157-7613c6a90374", "Admin", "ADMIN" },
                    { 2, "44958d28-c726-4410-a36c-14a8cb65e5a0", "Member", "MEMBER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "ModifiedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "568a6063-114a-4454-ac02-edb3d1e6a1f0", new DateTime(2023, 12, 15, 12, 26, 28, 649, DateTimeKind.Utc).AddTicks(7836), null, "Admin@gmail.com", true, false, null, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAELWwukbkjf5h9CSRyj9cPXoChJsLgmMA6GZ93NhZJs398jNl/lxOoYQXp2ttAetW0Q==", null, false, "5099cba3-2776-4dc4-94b4-6598f6ec8302", 1, false, "Admin" },
                    { 2, 0, "c60824cd-697b-4812-ac8f-2ae93781429a", new DateTime(2023, 12, 15, 12, 26, 28, 712, DateTimeKind.Utc).AddTicks(3560), null, "member@gmail.com", true, false, null, null, "MEMBER@GMAIL.COM", "MEMBER", "AQAAAAIAAYagAAAAELs9ay2ar9Gw0/AmcS7kIEwUofABh+rfpusZMM8+T2Z5kXYQYcK9tkKpRZ86+vquBA==", null, false, "9314bf99-c135-429b-be7f-04d79d533ca0", 1, false, "member123" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CategoryName", "CreatedDate", "DeletedDate", "Description", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, "Kids", new DateTime(2023, 12, 15, 12, 26, 28, 649, DateTimeKind.Utc).AddTicks(6875), null, "Eve yazın mıknatıslı dergi vel dolor mutlu masaya molestiae mıknatıslı.", null, 1 },
                    { 2, "Movies", new DateTime(2023, 12, 15, 12, 26, 28, 649, DateTimeKind.Utc).AddTicks(7145), null, "İn iure çorba adanaya explicabo rem et beğendim ad ipsum.", null, 1 },
                    { 3, "Grocery", new DateTime(2023, 12, 15, 12, 26, 28, 649, DateTimeKind.Utc).AddTicks(7209), null, "Alias consequatur masaya quam labore mutlu aliquam suscipit yapacakmış alias.", null, 1 },
                    { 4, "Toys", new DateTime(2023, 12, 15, 12, 26, 28, 649, DateTimeKind.Utc).AddTicks(7260), null, "Sayfası tv in değerli olduğu minima dolor eum aspernatur sıradanlıktan.", null, 1 },
                    { 5, "Sports", new DateTime(2023, 12, 15, 12, 26, 28, 649, DateTimeKind.Utc).AddTicks(7318), null, "Patlıcan hesap ullam aliquam telefonu umut quis duyulmamış quia magnam.", null, 1 },
                    { 6, "Garden", new DateTime(2023, 12, 15, 12, 26, 28, 649, DateTimeKind.Utc).AddTicks(7394), null, "Ea yaptı voluptatem sokaklarda ducimus qui doloremque sit adresini fugit.", null, 1 },
                    { 7, "Home", new DateTime(2023, 12, 15, 12, 26, 28, 649, DateTimeKind.Utc).AddTicks(7452), null, "Eve türemiş et şafak blanditiis labore filmini non oldular exercitationem.", null, 1 },
                    { 8, "Electronics", new DateTime(2023, 12, 15, 12, 26, 28, 649, DateTimeKind.Utc).AddTicks(7503), null, "Çorba beatae batarya aperiam sed kutusu quia yapacakmış corporis ut.", null, 1 },
                    { 9, "Automotive", new DateTime(2023, 12, 15, 12, 26, 28, 649, DateTimeKind.Utc).AddTicks(7558), null, "Nemo gidecekmiş totam perferendis salladı lambadaki sit ipsa ratione öyle.", null, 1 },
                    { 10, "Clothing", new DateTime(2023, 12, 15, 12, 26, 28, 649, DateTimeKind.Utc).AddTicks(7653), null, "Teldeki gül laboriosam et quia orta quia mi voluptatem oldular.", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "ID", "CreatedDate", "DeletedDate", "ImagePath", "ModifiedDate", "Status" },
                values: new object[] { 1, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(8103), null, "/Images/ProductImages/Test.png", null, 1 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryID", "CreatedDate", "DeletedDate", "ModifiedDate", "ProductImageID", "ProductName", "Status", "UnitPrice", "UnitsInStock" },
                values: new object[,]
                {
                    { 1, 6, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(8160), null, null, 1, "Generic Fresh Chips", 1, 556.49m, 0 },
                    { 2, 10, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(8599), null, null, 1, "Gorgeous Plastic Keyboard", 1, 861.53m, 47 },
                    { 3, 5, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(8656), null, null, 1, "Gorgeous Steel Ball", 1, 909.42m, 4 },
                    { 4, 3, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(8696), null, null, 1, "Tasty Plastic Bike", 1, 672.53m, 46 },
                    { 5, 6, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(8738), null, null, 1, "Small Frozen Shirt", 1, 158.84m, 30 },
                    { 6, 4, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(8785), null, null, 1, "Generic Frozen Car", 1, 959.94m, 17 },
                    { 7, 8, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(8825), null, null, 1, "Handcrafted Concrete Salad", 1, 333.40m, 1 },
                    { 8, 2, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(8868), null, null, 1, "Gorgeous Granite Pizza", 1, 857.91m, 41 },
                    { 9, 10, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(8941), null, null, 1, "Handmade Fresh Chair", 1, 753.17m, 31 },
                    { 10, 4, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(8985), null, null, 1, "Rustic Plastic Chair", 1, 11.91m, 0 },
                    { 11, 7, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(9026), null, null, 1, "Licensed Rubber Tuna", 1, 635.90m, 41 },
                    { 12, 7, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(9066), null, null, 1, "Practical Soft Towels", 1, 390.86m, 0 },
                    { 13, 9, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(9107), null, null, 1, "Rustic Metal Chips", 1, 320.12m, 47 },
                    { 14, 10, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(9146), null, null, 1, "Handcrafted Granite Fish", 1, 775.13m, 6 },
                    { 15, 2, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(9186), null, null, 1, "Generic Rubber Bike", 1, 347.16m, 14 },
                    { 16, 2, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(9255), null, null, 1, "Unbranded Fresh Computer", 1, 487.23m, 8 },
                    { 17, 8, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(9296), null, null, 1, "Awesome Plastic Car", 1, 118.28m, 14 },
                    { 18, 9, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(9336), null, null, 1, "Sleek Granite Sausages", 1, 403.35m, 31 },
                    { 19, 9, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(9376), null, null, 1, "Intelligent Wooden Cheese", 1, 163.50m, 39 },
                    { 20, 5, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(9420), null, null, 1, "Gorgeous Steel Pants", 1, 202.08m, 42 },
                    { 21, 8, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(9459), null, null, 1, "Generic Cotton Keyboard", 1, 662.54m, 40 },
                    { 22, 8, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(9497), null, null, 1, "Intelligent Cotton Towels", 1, 231.45m, 31 },
                    { 23, 10, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(9565), null, null, 1, "Refined Rubber Computer", 1, 675.18m, 10 },
                    { 24, 6, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(9603), null, null, 1, "Fantastic Frozen Bike", 1, 975.21m, 49 },
                    { 25, 2, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(9642), null, null, 1, "Generic Granite Tuna", 1, 526.34m, 4 },
                    { 26, 7, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(9680), null, null, 1, "Gorgeous Steel Cheese", 1, 945.70m, 27 },
                    { 27, 6, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(9719), null, null, 1, "Incredible Metal Table", 1, 660.21m, 32 },
                    { 28, 8, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(9757), null, null, 1, "Handcrafted Plastic Chair", 1, 619.28m, 6 },
                    { 29, 8, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(9795), null, null, 1, "Intelligent Steel Salad", 1, 220.40m, 10 },
                    { 30, 6, new DateTime(2023, 12, 15, 12, 26, 28, 776, DateTimeKind.Utc).AddTicks(9862), null, null, 1, "Tasty Plastic Sausages", 1, 224.42m, 37 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductImageID",
                table: "Products",
                column: "ProductImageID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "ProductImages");
        }
    }
}
