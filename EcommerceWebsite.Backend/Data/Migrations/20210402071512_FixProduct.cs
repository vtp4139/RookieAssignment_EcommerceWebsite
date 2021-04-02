using Microsoft.EntityFrameworkCore.Migrations;

namespace EcommerceWebsite.Backend.Migrations
{
    public partial class FixProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImageFile_Products_ProductID",
                table: "ImageFile");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Products_ProductID1",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Rating_AspNetUsers_UsersId",
                table: "Rating");

            migrationBuilder.DropForeignKey(
                name: "FK_Rating_Products_ProductID",
                table: "Rating");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductID1",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rating",
                table: "Rating");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImageFile",
                table: "ImageFile");

            migrationBuilder.DropColumn(
                name: "ProductID1",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Rating",
                newName: "Ratings");

            migrationBuilder.RenameTable(
                name: "ImageFile",
                newName: "ImageFiles");

            migrationBuilder.RenameIndex(
                name: "IX_Rating_UsersId",
                table: "Ratings",
                newName: "IX_Ratings_UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_Rating_ProductID",
                table: "Ratings",
                newName: "IX_Ratings_ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_ImageFile_ProductID",
                table: "ImageFiles",
                newName: "IX_ImageFiles_ProductID");

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Products",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ratings",
                table: "Ratings",
                column: "RatingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImageFiles",
                table: "ImageFiles",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_ImageFiles_Products_ProductID",
                table: "ImageFiles",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_AspNetUsers_UsersId",
                table: "Ratings",
                column: "UsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Products_ProductID",
                table: "Ratings",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImageFiles_Products_ProductID",
                table: "ImageFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_AspNetUsers_UsersId",
                table: "Ratings");

            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Products_ProductID",
                table: "Ratings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ratings",
                table: "Ratings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImageFiles",
                table: "ImageFiles");

            migrationBuilder.RenameTable(
                name: "Ratings",
                newName: "Rating");

            migrationBuilder.RenameTable(
                name: "ImageFiles",
                newName: "ImageFile");

            migrationBuilder.RenameIndex(
                name: "IX_Ratings_UsersId",
                table: "Rating",
                newName: "IX_Rating_UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_Ratings_ProductID",
                table: "Rating",
                newName: "IX_Rating_ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_ImageFiles_ProductID",
                table: "ImageFile",
                newName: "IX_ImageFile_ProductID");

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Products",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductID1",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rating",
                table: "Rating",
                column: "RatingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImageFile",
                table: "ImageFile",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductID1",
                table: "Products",
                column: "ProductID1");

            migrationBuilder.AddForeignKey(
                name: "FK_ImageFile_Products_ProductID",
                table: "ImageFile",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Products_ProductID1",
                table: "Products",
                column: "ProductID1",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_AspNetUsers_UsersId",
                table: "Rating",
                column: "UsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_Products_ProductID",
                table: "Rating",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
