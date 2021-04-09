using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EcommerceWebsite.Backend.Migrations
{
    public partial class UpdateModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_UsersId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_UsersId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "UnitsInStock",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<decimal>(
                name: "UnitPrice",
                table: "OrderDetails",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 1,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 9, 10, 55, 18, 719, DateTimeKind.Local).AddTicks(4959));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 2,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 9, 10, 55, 18, 719, DateTimeKind.Local).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 3,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 9, 10, 55, 18, 719, DateTimeKind.Local).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 4,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 9, 10, 55, 18, 719, DateTimeKind.Local).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 5,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 9, 10, 55, 18, 719, DateTimeKind.Local).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 6,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 9, 10, 55, 18, 719, DateTimeKind.Local).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 7,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 9, 10, 55, 18, 719, DateTimeKind.Local).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 8,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 9, 10, 55, 18, 719, DateTimeKind.Local).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 9,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 9, 10, 55, 18, 719, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 10,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 9, 10, 55, 18, 719, DateTimeKind.Local).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 11,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 9, 10, 55, 18, 719, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 12,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 9, 10, 55, 18, 719, DateTimeKind.Local).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 9, 10, 55, 18, 717, DateTimeKind.Local).AddTicks(1148), new DateTime(2021, 4, 9, 10, 55, 18, 718, DateTimeKind.Local).AddTicks(9810) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 9, 10, 55, 18, 719, DateTimeKind.Local).AddTicks(1591), new DateTime(2021, 4, 9, 10, 55, 18, 719, DateTimeKind.Local).AddTicks(1603) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 9, 10, 55, 18, 719, DateTimeKind.Local).AddTicks(1607), new DateTime(2021, 4, 9, 10, 55, 18, 719, DateTimeKind.Local).AddTicks(1610) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 9, 10, 55, 18, 719, DateTimeKind.Local).AddTicks(1613), new DateTime(2021, 4, 9, 10, 55, 18, 719, DateTimeKind.Local).AddTicks(1615) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 9, 10, 55, 18, 719, DateTimeKind.Local).AddTicks(1618), new DateTime(2021, 4, 9, 10, 55, 18, 719, DateTimeKind.Local).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 9, 10, 55, 18, 719, DateTimeKind.Local).AddTicks(1623), new DateTime(2021, 4, 9, 10, 55, 18, 719, DateTimeKind.Local).AddTicks(1625) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 9, 10, 55, 18, 719, DateTimeKind.Local).AddTicks(1628), new DateTime(2021, 4, 9, 10, 55, 18, 719, DateTimeKind.Local).AddTicks(1630) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 9, 10, 55, 18, 719, DateTimeKind.Local).AddTicks(1633), new DateTime(2021, 4, 9, 10, 55, 18, 719, DateTimeKind.Local).AddTicks(1635) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 9, 10, 55, 18, 719, DateTimeKind.Local).AddTicks(1638), new DateTime(2021, 4, 9, 10, 55, 18, 719, DateTimeKind.Local).AddTicks(1640) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 9, 10, 55, 18, 719, DateTimeKind.Local).AddTicks(1642), new DateTime(2021, 4, 9, 10, 55, 18, 719, DateTimeKind.Local).AddTicks(1645) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 9, 10, 55, 18, 719, DateTimeKind.Local).AddTicks(1647), new DateTime(2021, 4, 9, 10, 55, 18, 719, DateTimeKind.Local).AddTicks(1649) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 9, 10, 55, 18, 719, DateTimeKind.Local).AddTicks(1652), new DateTime(2021, 4, 9, 10, 55, 18, 719, DateTimeKind.Local).AddTicks(1655) });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_UserId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "UnitsInStock",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UnitPrice",
                table: "OrderDetails");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsersId",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 1,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 6, 15, 23, 4, 197, DateTimeKind.Local).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 2,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 6, 15, 23, 4, 197, DateTimeKind.Local).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 3,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 6, 15, 23, 4, 197, DateTimeKind.Local).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 4,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 6, 15, 23, 4, 197, DateTimeKind.Local).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 5,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 6, 15, 23, 4, 197, DateTimeKind.Local).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 6,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 6, 15, 23, 4, 197, DateTimeKind.Local).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 7,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 6, 15, 23, 4, 197, DateTimeKind.Local).AddTicks(3684));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 8,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 6, 15, 23, 4, 197, DateTimeKind.Local).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 9,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 6, 15, 23, 4, 197, DateTimeKind.Local).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 10,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 6, 15, 23, 4, 197, DateTimeKind.Local).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 11,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 6, 15, 23, 4, 197, DateTimeKind.Local).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 12,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 6, 15, 23, 4, 197, DateTimeKind.Local).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 6, 15, 23, 4, 195, DateTimeKind.Local).AddTicks(1508), new DateTime(2021, 4, 6, 15, 23, 4, 196, DateTimeKind.Local).AddTicks(7192) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 6, 15, 23, 4, 196, DateTimeKind.Local).AddTicks(8904), new DateTime(2021, 4, 6, 15, 23, 4, 196, DateTimeKind.Local).AddTicks(8914) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 6, 15, 23, 4, 196, DateTimeKind.Local).AddTicks(8918), new DateTime(2021, 4, 6, 15, 23, 4, 196, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 6, 15, 23, 4, 196, DateTimeKind.Local).AddTicks(8923), new DateTime(2021, 4, 6, 15, 23, 4, 196, DateTimeKind.Local).AddTicks(8925) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 6, 15, 23, 4, 196, DateTimeKind.Local).AddTicks(8928), new DateTime(2021, 4, 6, 15, 23, 4, 196, DateTimeKind.Local).AddTicks(8931) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 6, 15, 23, 4, 196, DateTimeKind.Local).AddTicks(8934), new DateTime(2021, 4, 6, 15, 23, 4, 196, DateTimeKind.Local).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 6, 15, 23, 4, 196, DateTimeKind.Local).AddTicks(8939), new DateTime(2021, 4, 6, 15, 23, 4, 196, DateTimeKind.Local).AddTicks(8941) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 6, 15, 23, 4, 196, DateTimeKind.Local).AddTicks(8944), new DateTime(2021, 4, 6, 15, 23, 4, 196, DateTimeKind.Local).AddTicks(8945) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 6, 15, 23, 4, 196, DateTimeKind.Local).AddTicks(8949), new DateTime(2021, 4, 6, 15, 23, 4, 196, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 6, 15, 23, 4, 196, DateTimeKind.Local).AddTicks(8953), new DateTime(2021, 4, 6, 15, 23, 4, 196, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 6, 15, 23, 4, 196, DateTimeKind.Local).AddTicks(8958), new DateTime(2021, 4, 6, 15, 23, 4, 196, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 6, 15, 23, 4, 196, DateTimeKind.Local).AddTicks(8963), new DateTime(2021, 4, 6, 15, 23, 4, 196, DateTimeKind.Local).AddTicks(8965) });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UsersId",
                table: "Orders",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_UsersId",
                table: "Orders",
                column: "UsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
