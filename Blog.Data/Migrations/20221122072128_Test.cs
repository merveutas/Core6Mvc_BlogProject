using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Images",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DeletedBy",
                table: "Images",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DeletedBy",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DeletedBy",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("1acac552-c55f-4b07-89a6-a9d799f12f5f"), "Admin Test", new DateTime(2022, 11, 22, 10, 21, 28, 588, DateTimeKind.Local).AddTicks(4319), "", null, false, null, null, "c#" },
                    { new Guid("82e5f947-a236-4daa-b802-9eafea013177"), "Admin Test", new DateTime(2022, 11, 22, 10, 21, 28, 588, DateTimeKind.Local).AddTicks(4316), "", null, false, null, null, "Visual Studio" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreateBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("08c81641-4dac-4c9c-b243-a81968017166"), "Admin Test", new DateTime(2022, 11, 22, 10, 21, 28, 588, DateTimeKind.Local).AddTicks(4656), "", null, "images/testvisualimage", "png", false, null, null },
                    { new Guid("d7559693-6702-4950-a2bf-152fcdb8700d"), "Admin Test", new DateTime(2022, 11, 22, 10, 21, 28, 588, DateTimeKind.Local).AddTicks(4660), "", null, "images/testimage", "png", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreateBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("00923edb-4e1a-4d3d-9d24-249f56465374"), new Guid("1acac552-c55f-4b07-89a6-a9d799f12f5f"), "Test içerik c#", "Admin Test", new DateTime(2022, 11, 22, 10, 21, 28, 588, DateTimeKind.Local).AddTicks(3938), "", null, new Guid("d7559693-6702-4950-a2bf-152fcdb8700d"), false, null, null, "c# makalesi", 15 },
                    { new Guid("5df0f92d-d0cd-40a4-bf8c-3cc523f5a4ca"), new Guid("82e5f947-a236-4daa-b802-9eafea013177"), "Test içerik", "Admin Test", new DateTime(2022, 11, 22, 10, 21, 28, 588, DateTimeKind.Local).AddTicks(3919), "", null, new Guid("08c81641-4dac-4c9c-b243-a81968017166"), false, null, null, "Asp Net deneme makalesi", 15 },
                    { new Guid("76057454-f41f-49c8-b31d-4c9b77fb84dd"), new Guid("82e5f947-a236-4daa-b802-9eafea013177"), "Test içerik visual studio", "Admin Test", new DateTime(2022, 11, 22, 10, 21, 28, 588, DateTimeKind.Local).AddTicks(3924), "", null, new Guid("08c81641-4dac-4c9c-b243-a81968017166"), false, null, null, "Visual Studio deneme makalesi", 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("00923edb-4e1a-4d3d-9d24-249f56465374"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("5df0f92d-d0cd-40a4-bf8c-3cc523f5a4ca"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("76057454-f41f-49c8-b31d-4c9b77fb84dd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1acac552-c55f-4b07-89a6-a9d799f12f5f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("82e5f947-a236-4daa-b802-9eafea013177"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("08c81641-4dac-4c9c-b243-a81968017166"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d7559693-6702-4950-a2bf-152fcdb8700d"));

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Images",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedBy",
                table: "Images",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedBy",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedBy",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
