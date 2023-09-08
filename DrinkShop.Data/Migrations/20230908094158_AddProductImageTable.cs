using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrinkShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddProductImageTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "ProductImages",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Caption",
                table: "ProductImages",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("88cca786-c428-4a90-b955-9360aaab0238"),
                column: "ConcurrencyStamp",
                value: "ac8827b2-9a4f-48fa-a187-5d7480ad882e");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("704674ac-38e3-43ac-ae84-4ad2c3a2f701"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9a9abe22-95d2-4145-a328-19a3efe9927c", "AQAAAAEAACcQAAAAEHOQGTVLSOBZvbGSGg1Lxgwk0aLFsDpJ44ZupMg76m6GhRTA2dKEmOIs7MtjFpCpZQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 9, 8, 16, 41, 58, 750, DateTimeKind.Local).AddTicks(305));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "ProductImages",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Caption",
                table: "ProductImages",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("88cca786-c428-4a90-b955-9360aaab0238"),
                column: "ConcurrencyStamp",
                value: "dff28837-18b4-4a44-8084-ebc0217c3bbd");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("704674ac-38e3-43ac-ae84-4ad2c3a2f701"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1112231a-1105-4029-ac9d-b4a12a206452", "AQAAAAEAACcQAAAAEETVrLAxUIxWlB6Dx9mQjw0sr6WusjS9wdGe4BcEGeIQpbIOxq76E/YpIijSZjBsWQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 9, 7, 6, 55, 23, 749, DateTimeKind.Local).AddTicks(2195));
        }
    }
}
