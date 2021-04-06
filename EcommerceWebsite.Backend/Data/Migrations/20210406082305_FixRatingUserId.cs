using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EcommerceWebsite.Backend.Migrations
{
    public partial class FixRatingUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_AspNetUsers_UsersId",
                table: "Ratings");

            migrationBuilder.DropIndex(
                name: "IX_Ratings_UsersId",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "Ratings");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Ratings",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
                name: "IX_Ratings_UserId",
                table: "Ratings",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_AspNetUsers_UserId",
                table: "Ratings",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_AspNetUsers_UserId",
                table: "Ratings");

            migrationBuilder.DropIndex(
                name: "IX_Ratings_UserId",
                table: "Ratings");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Ratings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsersId",
                table: "Ratings",
                type: "nvarchar(450)",
                nullable: true);

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
                column: "UploadedTime",
                value: new DateTime(2021, 4, 6, 11, 2, 7, 4, DateTimeKind.Local).AddTicks(5852));

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

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_UsersId",
                table: "Ratings",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_AspNetUsers_UsersId",
                table: "Ratings",
                column: "UsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
