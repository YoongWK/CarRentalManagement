using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "437a07c5-dab2-4e02-9095-fad596c1c39f", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEAxKs9p067y7eZUes1FPvdgWXtwr9U1EG8Zoxrm0jSEcHIUa0acJdfkgUAVhGUwgLg==", null, false, "aeb3e6d7-8d1d-4e7c-a71f-d8deb1ecc714", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 15, 16, 48, 35, 659, DateTimeKind.Local).AddTicks(2503), new DateTime(2023, 11, 15, 16, 48, 35, 659, DateTimeKind.Local).AddTicks(2513), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 15, 16, 48, 35, 659, DateTimeKind.Local).AddTicks(2514), new DateTime(2023, 11, 15, 16, 48, 35, 659, DateTimeKind.Local).AddTicks(2515), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 15, 16, 48, 35, 659, DateTimeKind.Local).AddTicks(2718), new DateTime(2023, 11, 15, 16, 48, 35, 659, DateTimeKind.Local).AddTicks(2718), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 15, 16, 48, 35, 659, DateTimeKind.Local).AddTicks(2720), new DateTime(2023, 11, 15, 16, 48, 35, 659, DateTimeKind.Local).AddTicks(2720), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 15, 16, 48, 35, 659, DateTimeKind.Local).AddTicks(2849), new DateTime(2023, 11, 15, 16, 48, 35, 659, DateTimeKind.Local).AddTicks(2849), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 15, 16, 48, 35, 659, DateTimeKind.Local).AddTicks(2850), new DateTime(2023, 11, 15, 16, 48, 35, 659, DateTimeKind.Local).AddTicks(2851), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 15, 16, 48, 35, 659, DateTimeKind.Local).AddTicks(2852), new DateTime(2023, 11, 15, 16, 48, 35, 659, DateTimeKind.Local).AddTicks(2852), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 15, 16, 48, 35, 659, DateTimeKind.Local).AddTicks(2853), new DateTime(2023, 11, 15, 16, 48, 35, 659, DateTimeKind.Local).AddTicks(2854), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
