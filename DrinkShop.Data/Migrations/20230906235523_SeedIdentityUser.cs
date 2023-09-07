using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrinkShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedIdentityUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("88cca786-c428-4a90-b955-9360aaab0238"), "dff28837-18b4-4a44-8084-ebc0217c3bbd", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("88cca786-c428-4a90-b955-9360aaab0238"), new Guid("704674ac-38e3-43ac-ae84-4ad2c3a2f701") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("704674ac-38e3-43ac-ae84-4ad2c3a2f701"), 0, "1112231a-1105-4029-ac9d-b4a12a206452", new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyenthivananh130723@gmail.com", true, "Nguyen", "Van Anh", false, null, "nguyenthivananh130723@gmail.com", "admin", "AQAAAAEAACcQAAAAEETVrLAxUIxWlB6Dx9mQjw0sr6WusjS9wdGe4BcEGeIQpbIOxq76E/YpIijSZjBsWQ==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 9, 7, 6, 55, 23, 749, DateTimeKind.Local).AddTicks(2195));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("88cca786-c428-4a90-b955-9360aaab0238"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("88cca786-c428-4a90-b955-9360aaab0238"), new Guid("704674ac-38e3-43ac-ae84-4ad2c3a2f701") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("704674ac-38e3-43ac-ae84-4ad2c3a2f701"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 8, 31, 3, 14, 50, 79, DateTimeKind.Local).AddTicks(8623));
        }
    }
}
