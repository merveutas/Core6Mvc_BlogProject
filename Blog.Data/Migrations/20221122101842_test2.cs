using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreateBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("4c329cae-bc38-4c09-827b-4ca5f647873b"), new Guid("82e5f947-a236-4daa-b802-9eafea013177"), "Test içerik", "Admin Test", new DateTime(2022, 11, 22, 13, 18, 42, 729, DateTimeKind.Local).AddTicks(4611), "", null, new Guid("08c81641-4dac-4c9c-b243-a81968017166"), false, null, null, "Asp Net deneme makalesi", 15 },
                    { new Guid("6dfd102f-348a-4d0a-84ba-72f00ba3f8ae"), new Guid("82e5f947-a236-4daa-b802-9eafea013177"), "Test içerik visual studio", "Admin Test", new DateTime(2022, 11, 22, 13, 18, 42, 729, DateTimeKind.Local).AddTicks(4616), "", null, new Guid("08c81641-4dac-4c9c-b243-a81968017166"), false, null, null, "Visual Studio deneme makalesi", 15 },
                    { new Guid("80a1afb9-98a0-46a5-ac8c-bafac1be8ca6"), new Guid("1acac552-c55f-4b07-89a6-a9d799f12f5f"), "Test içerik c#", "Admin Test", new DateTime(2022, 11, 22, 13, 18, 42, 729, DateTimeKind.Local).AddTicks(4621), "", null, new Guid("d7559693-6702-4950-a2bf-152fcdb8700d"), false, null, null, "c# makalesi", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1acac552-c55f-4b07-89a6-a9d799f12f5f"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 18, 42, 729, DateTimeKind.Local).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("82e5f947-a236-4daa-b802-9eafea013177"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 18, 42, 729, DateTimeKind.Local).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("08c81641-4dac-4c9c-b243-a81968017166"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 18, 42, 729, DateTimeKind.Local).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d7559693-6702-4950-a2bf-152fcdb8700d"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 18, 42, 729, DateTimeKind.Local).AddTicks(6116));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("4c329cae-bc38-4c09-827b-4ca5f647873b"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("6dfd102f-348a-4d0a-84ba-72f00ba3f8ae"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("80a1afb9-98a0-46a5-ac8c-bafac1be8ca6"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreateBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("00923edb-4e1a-4d3d-9d24-249f56465374"), new Guid("1acac552-c55f-4b07-89a6-a9d799f12f5f"), "Test içerik c#", "Admin Test", new DateTime(2022, 11, 22, 10, 21, 28, 588, DateTimeKind.Local).AddTicks(3938), "", null, new Guid("d7559693-6702-4950-a2bf-152fcdb8700d"), false, null, null, "c# makalesi", 15 },
                    { new Guid("5df0f92d-d0cd-40a4-bf8c-3cc523f5a4ca"), new Guid("82e5f947-a236-4daa-b802-9eafea013177"), "Test içerik", "Admin Test", new DateTime(2022, 11, 22, 10, 21, 28, 588, DateTimeKind.Local).AddTicks(3919), "", null, new Guid("08c81641-4dac-4c9c-b243-a81968017166"), false, null, null, "Asp Net deneme makalesi", 15 },
                    { new Guid("76057454-f41f-49c8-b31d-4c9b77fb84dd"), new Guid("82e5f947-a236-4daa-b802-9eafea013177"), "Test içerik visual studio", "Admin Test", new DateTime(2022, 11, 22, 10, 21, 28, 588, DateTimeKind.Local).AddTicks(3924), "", null, new Guid("08c81641-4dac-4c9c-b243-a81968017166"), false, null, null, "Visual Studio deneme makalesi", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1acac552-c55f-4b07-89a6-a9d799f12f5f"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 10, 21, 28, 588, DateTimeKind.Local).AddTicks(4319));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("82e5f947-a236-4daa-b802-9eafea013177"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 10, 21, 28, 588, DateTimeKind.Local).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("08c81641-4dac-4c9c-b243-a81968017166"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 10, 21, 28, 588, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d7559693-6702-4950-a2bf-152fcdb8700d"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 10, 21, 28, 588, DateTimeKind.Local).AddTicks(4660));
        }
    }
}
