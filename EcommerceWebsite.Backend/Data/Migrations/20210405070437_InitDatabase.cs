using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EcommerceWebsite.Backend.Migrations
{
    public partial class InitDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
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
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(300)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImageFiles",
                columns: table => new
                {
                    ImageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageLocation = table.Column<string>(type: "nvarchar(300)", nullable: true),
                    UploadedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageFiles", x => x.ImageId);
                    table.ForeignKey(
                        name: "FK_ImageFiles_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => new { x.ProductID, x.OrderID });
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    RatingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    RatingPoint = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    UploadedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.RatingId);
                    table.ForeignKey(
                        name: "FK_Ratings_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ratings_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName", "Description" },
                values: new object[] { 1, "Chuột", "Cung cấp các mặt hàng chuột chất lượng nhất đến từ các hãng uy tín hiện nay. Đảm bảo chính hãng và bảo hành 6 tháng." });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName", "Description" },
                values: new object[] { 2, "Bàn phím", "Cung cấp các mặt hàng bàn phím chất lượng nhất đến từ các hãng uy tín hiện nay. Đảm bảo chính hãng và bảo hành 6 tháng." });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName", "Description" },
                values: new object[] { 3, "Màn hình", "Cung cấp các mặt hàng màn hình chất lượng nhất đến từ các hãng uy tín hiện nay. Đảm bảo chính hãng và bảo hành 6 tháng." });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "CreatedDate", "Description", "Price", "ProductName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 4, 5, 14, 4, 36, 963, DateTimeKind.Local).AddTicks(3326), "Khi lưu các cấu hình vào bộ nhớ trong bằng phần mềm HUB G của Chuột Logitech, bạn có thể sử dụng nó trên các máy tính khác mà không cần cài đặt phần mềm hoặc các cấu hình lại một lần nữa. Cắm vào là sử dụng theo ý thích của bạn.", 400m, "Chuột Logitech G102 Lightsync RGB Black", new DateTime(2021, 4, 5, 14, 4, 36, 964, DateTimeKind.Local).AddTicks(8887) },
                    { 2, 1, new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(710), "Ngoài hiệu suất cốt lõi và các tính năng cá nhân, nhiều chi tiết được thiết kế và chế tạo với sự tận tâm. Logitech G502 Hero là một trong những dòng chuột gaming giá rẻ so với các sản phẩm ở cùng phân khúc với dây bện với nút buộc dây có khóa nhám, phần cầm nắm bên có viền cao su, cửa từ vào khoang để khối nặng và nhiều hơn nữa.", 400m, "Chuột Logitech G502 Hero", new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(720) },
                    { 3, 1, new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(724), "Logitech G302 Daedalus Prime là một trong những sản phẩm tiêu biểu trong phong cách thiết kế đơn giản, tập trung vào tốc độ, sự chính xác và tính hiệu quả trong mỗi cú nhấn chuột của game thủ, đặc biệt với thể loại game MOBA.", 590m, "Chuột Logitech G302 Daedalus Prime", new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(726) },
                    { 4, 1, new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(730), "Chuột Logitech G402 sở hữu tốc độ quét lên tới 500 IPS, sử dụng công nghệ cảm biến mới nhất của Logitech là Fusion Engine cho độ chính xác cực cao khi sử dụng.", 640m, "Chuột Logitech G402 Hyperion", new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(732) },
                    { 5, 2, new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(736), "Đã đến lúc trở nên quyết đoán hơn trong từng cú bấm phím mang tới khả năng chiến thắng trong mọi trận đấu. Với bộ nâng cấp Keycap Razer PBT. Được thiết kế để sử dụng trong những trò chơi khốc liệt nhất, những chiếc keycaps PBT doubleshot này được thiết kế để giành chiến thắng trong mọi trận chiến.", 890m, "Razer PBT Keycap Upgrade Set", new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(738) },
                    { 6, 2, new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(741), "Sản phẩm đầu tiên trong combo sẽ là chiếc bàn phím giả cơ Razer Cynosa Lite. Sở hữu thiết kế đơn giản, tông màu đen huyền bí và khả năng tùy biến LED RGB Razer Chroma cho Cynosa Lite vẻ đẹp bắt mắt không thua kém những chiếc bàn phím cơ Razer khác. Các phím được lập trình sẵn những chức năng hữu ích macro cho bàn phím Cynosa Lite thuận tiện hơn trong việc sử dụng.", 199m, "Razer Level Up Bundle (Cynosa Lite + Viper Mini + Gigantus V2 Medium)", new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(744) },
                    { 7, 2, new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(747), "Razer™ Mechanical Switches with 50g actuation force", 199m, "Bàn phím Razer Blackwidow Lite", new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(749) },
                    { 8, 2, new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(752), "Razer™ Mechanical Switches with 50g actuation force", 299m, "Bàn phím Razer Blackwidow Lite Mercury", new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(755) },
                    { 9, 3, new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(758), "Giảm ánh sáng xanh nhằm giúp làm giảm sự mệt mỏi của mắt, Chế độ đọc sách mang đến điều kiện đọc sách tối ưu. Với điều khiển tay cầm dễ dàng, bạn có đọc thoải mái hơn màn hình của bạn.", 1299m, "Màn hình LG 20MK400H-B 19.5 - HD TN", new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(760) },
                    { 10, 3, new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(763), "LG 22MN430M-B là một mẫu màn hình hướng đến đối tượng là dân văn phòng, đáp ứng được những nhu cầu cơ bản, cho bạn một khung nhìn để làm việc, cũng như xem phim, chơi game với một mức giá bình dân nhất có thể. ", 2800m, "Màn hình LG 22MN430M-B 22 IPS 75Hz FreeSync", new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(765) },
                    { 11, 3, new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(768), "LG 24MK430H-B là một mẫu màn hình hướng đến đối tượng là dân văn phòng, đáp ứng được những nhu cầu cơ bản, cho bạn một khung nhìn để làm việc, cũng như xem phim, chơi game mới một mức giá bình dân nhất có thể.", 3000m, "Màn hình LG 24MK430H-B 24 IPS 75Hz OC FreeSyn", new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(770) },
                    { 12, 3, new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(773), "Đa số game thủ bình dân đều muốn có cho mình một chiếc màn hình vừa phải có mức giá phải chăng dễ tiếp cận, vừa có những thông số kỹ thuật cân bằng để phục vụ không chỉ việc chơi game mà còn có thể xem phim và làm nhiều chuyện khác nữa. Hiểu được điều đó, LG đã cho ra mắt LG 24MP59G-P - một sự lựa chọn sáng giá trong phân khúc bình dân.", 3200m, "Màn hình LG 24MP59G-P 24 IPS 75Hz Freesync chuyên game", new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(775) }
                });

            migrationBuilder.InsertData(
                table: "ImageFiles",
                columns: new[] { "ImageId", "ImageLocation", "ProductID", "UploadedTime" },
                values: new object[,]
                {
                    { 1, "/images/g102-g20315.png", 1, new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(4028) },
                    { 2, "/images/logitech-g502.jpg", 2, new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(5536) },
                    { 3, "/images/logitech-g302_1.jpg", 3, new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(5545) },
                    { 4, "/images/logitech-g402", 4, new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(5548) },
                    { 5, "/images/Razer-PBT-Keycap-Upgrade-Set-Classic-Black.jpg", 5, new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(5552) },
                    { 6, "/images/Razer-Level-Up-Bundle_cynosa_lite_viper_mini_gigantus_v2.jpg", 6, new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(5555) },
                    { 7, "/images/Razer-Blackwidow-Lite-Mercury.jpg", 7, new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(5558) },
                    { 8, "/images/Razer_Blackwidow_Lite_Mercury_White.jpg", 8, new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(5560) },
                    { 9, "/images/lg_20mk400h_b_19_5inch_led_1_2.png", 9, new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(5563) },
                    { 10, "/images/LG-22MN430-new.jpg", 10, new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(5566) },
                    { 11, "/images/LG-24MK430H-B 24.jpg", 11, new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(5568) },
                    { 12, "/images/LG-24MP59G-P 24-IPS.jpg", 12, new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(5571) }
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
                name: "IX_ImageFiles_ProductID",
                table: "ImageFiles",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderID",
                table: "OrderDetails",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UsersId",
                table: "Orders",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_ProductID",
                table: "Ratings",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_UsersId",
                table: "Ratings",
                column: "UsersId");
        }

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
                name: "ImageFiles");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
