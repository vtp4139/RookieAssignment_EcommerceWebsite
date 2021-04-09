using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EcommerceWebsite.Backend.Migrations
{
    public partial class FixProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnitsInStock",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 1,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 9, 16, 1, 12, 472, DateTimeKind.Local).AddTicks(937));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 2,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 9, 16, 1, 12, 472, DateTimeKind.Local).AddTicks(2388));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 3,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 9, 16, 1, 12, 472, DateTimeKind.Local).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 4,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 9, 16, 1, 12, 472, DateTimeKind.Local).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 5,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 9, 16, 1, 12, 472, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 6,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 9, 16, 1, 12, 472, DateTimeKind.Local).AddTicks(2404));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 7,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 9, 16, 1, 12, 472, DateTimeKind.Local).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 8,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 9, 16, 1, 12, 472, DateTimeKind.Local).AddTicks(2409));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 9,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 9, 16, 1, 12, 472, DateTimeKind.Local).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 10,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 9, 16, 1, 12, 472, DateTimeKind.Local).AddTicks(2415));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 11,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 9, 16, 1, 12, 472, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 12,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 9, 16, 1, 12, 472, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 9, 16, 1, 12, 470, DateTimeKind.Local).AddTicks(405), new DateTime(2021, 4, 9, 16, 1, 12, 471, DateTimeKind.Local).AddTicks(5814) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 9, 16, 1, 12, 471, DateTimeKind.Local).AddTicks(7660), new DateTime(2021, 4, 9, 16, 1, 12, 471, DateTimeKind.Local).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 9, 16, 1, 12, 471, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 4, 9, 16, 1, 12, 471, DateTimeKind.Local).AddTicks(7677) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 9, 16, 1, 12, 471, DateTimeKind.Local).AddTicks(7681), new DateTime(2021, 4, 9, 16, 1, 12, 471, DateTimeKind.Local).AddTicks(7682) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 9, 16, 1, 12, 471, DateTimeKind.Local).AddTicks(7686), new DateTime(2021, 4, 9, 16, 1, 12, 471, DateTimeKind.Local).AddTicks(7688) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 9, 16, 1, 12, 471, DateTimeKind.Local).AddTicks(7691), new DateTime(2021, 4, 9, 16, 1, 12, 471, DateTimeKind.Local).AddTicks(7693) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 9, 16, 1, 12, 471, DateTimeKind.Local).AddTicks(7696), new DateTime(2021, 4, 9, 16, 1, 12, 471, DateTimeKind.Local).AddTicks(7698) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 9, 16, 1, 12, 471, DateTimeKind.Local).AddTicks(7701), new DateTime(2021, 4, 9, 16, 1, 12, 471, DateTimeKind.Local).AddTicks(7703) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 9, 16, 1, 12, 471, DateTimeKind.Local).AddTicks(7706), new DateTime(2021, 4, 9, 16, 1, 12, 471, DateTimeKind.Local).AddTicks(7708) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 9, 16, 1, 12, 471, DateTimeKind.Local).AddTicks(7714), new DateTime(2021, 4, 9, 16, 1, 12, 471, DateTimeKind.Local).AddTicks(7716) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 9, 16, 1, 12, 471, DateTimeKind.Local).AddTicks(7719), new DateTime(2021, 4, 9, 16, 1, 12, 471, DateTimeKind.Local).AddTicks(7721) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 9, 16, 1, 12, 471, DateTimeKind.Local).AddTicks(7724), new DateTime(2021, 4, 9, 16, 1, 12, 471, DateTimeKind.Local).AddTicks(7726) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UnitsInStock",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
        }
    }
}
