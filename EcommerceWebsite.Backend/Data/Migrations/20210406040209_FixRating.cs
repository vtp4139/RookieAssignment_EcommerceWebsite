using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EcommerceWebsite.Backend.Migrations
{
    public partial class FixRating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Ratings");

            migrationBuilder.AlterColumn<int>(
                name: "RatingPoint",
                table: "Ratings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 1,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 6, 11, 2, 7, 4, DateTimeKind.Local).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 2,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 6, 11, 2, 7, 4, DateTimeKind.Local).AddTicks(5839));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 3,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 6, 11, 2, 7, 4, DateTimeKind.Local).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 4,
                columns: new[] { "ImageLocation", "UploadedTime" },
                values: new object[] { "/images/logitech-g402.jpg", new DateTime(2021, 4, 6, 11, 2, 7, 4, DateTimeKind.Local).AddTicks(5852) });

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 5,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 6, 11, 2, 7, 4, DateTimeKind.Local).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 6,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 6, 11, 2, 7, 4, DateTimeKind.Local).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 7,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 6, 11, 2, 7, 4, DateTimeKind.Local).AddTicks(5861));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 8,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 6, 11, 2, 7, 4, DateTimeKind.Local).AddTicks(5863));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 9,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 6, 11, 2, 7, 4, DateTimeKind.Local).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 10,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 6, 11, 2, 7, 4, DateTimeKind.Local).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 11,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 6, 11, 2, 7, 4, DateTimeKind.Local).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 12,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 6, 11, 2, 7, 4, DateTimeKind.Local).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 6, 11, 2, 7, 2, DateTimeKind.Local).AddTicks(558), new DateTime(2021, 4, 6, 11, 2, 7, 3, DateTimeKind.Local).AddTicks(8962) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 6, 11, 2, 7, 4, DateTimeKind.Local).AddTicks(801), new DateTime(2021, 4, 6, 11, 2, 7, 4, DateTimeKind.Local).AddTicks(811) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 6, 11, 2, 7, 4, DateTimeKind.Local).AddTicks(815), new DateTime(2021, 4, 6, 11, 2, 7, 4, DateTimeKind.Local).AddTicks(817) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 6, 11, 2, 7, 4, DateTimeKind.Local).AddTicks(821), new DateTime(2021, 4, 6, 11, 2, 7, 4, DateTimeKind.Local).AddTicks(823) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 6, 11, 2, 7, 4, DateTimeKind.Local).AddTicks(826), new DateTime(2021, 4, 6, 11, 2, 7, 4, DateTimeKind.Local).AddTicks(828) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 6, 11, 2, 7, 4, DateTimeKind.Local).AddTicks(831), new DateTime(2021, 4, 6, 11, 2, 7, 4, DateTimeKind.Local).AddTicks(833) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 6, 11, 2, 7, 4, DateTimeKind.Local).AddTicks(836), new DateTime(2021, 4, 6, 11, 2, 7, 4, DateTimeKind.Local).AddTicks(838) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 6, 11, 2, 7, 4, DateTimeKind.Local).AddTicks(841), new DateTime(2021, 4, 6, 11, 2, 7, 4, DateTimeKind.Local).AddTicks(843) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 6, 11, 2, 7, 4, DateTimeKind.Local).AddTicks(846), new DateTime(2021, 4, 6, 11, 2, 7, 4, DateTimeKind.Local).AddTicks(848) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 6, 11, 2, 7, 4, DateTimeKind.Local).AddTicks(851), new DateTime(2021, 4, 6, 11, 2, 7, 4, DateTimeKind.Local).AddTicks(853) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 6, 11, 2, 7, 4, DateTimeKind.Local).AddTicks(856), new DateTime(2021, 4, 6, 11, 2, 7, 4, DateTimeKind.Local).AddTicks(858) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 6, 11, 2, 7, 4, DateTimeKind.Local).AddTicks(860), new DateTime(2021, 4, 6, 11, 2, 7, 4, DateTimeKind.Local).AddTicks(862) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RatingPoint",
                table: "Ratings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Ratings",
                type: "nvarchar(1000)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Ratings",
                type: "nvarchar(100)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 1,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 2,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 3,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 4,
                columns: new[] { "ImageLocation", "UploadedTime" },
                values: new object[] { "/images/logitech-g402", new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(5548) });

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 5,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 6,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 7,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 8,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 9,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 10,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 11,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(5568));

            migrationBuilder.UpdateData(
                table: "ImageFiles",
                keyColumn: "ImageId",
                keyValue: 12,
                column: "UploadedTime",
                value: new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 5, 14, 4, 36, 963, DateTimeKind.Local).AddTicks(3326), new DateTime(2021, 4, 5, 14, 4, 36, 964, DateTimeKind.Local).AddTicks(8887) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(710), new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(720) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(724), new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(726) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(730), new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(732) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(736), new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(738) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(741), new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(744) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(747), new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(749) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(752), new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(755) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(758), new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(760) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(763), new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(765) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(768), new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(770) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(773), new DateTime(2021, 4, 5, 14, 4, 36, 965, DateTimeKind.Local).AddTicks(775) });
        }
    }
}
