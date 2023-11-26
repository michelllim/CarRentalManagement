using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultAndUser : Migration
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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "075b39ad-deca-44d3-9353-9ffd8f49e4e2", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEClmYLgIOLxBKiawkAqTB09j8+J4o1yT8BHQSXJgoy1VmVI+XapQsb9P/c/FjAYICw==", null, false, "e3e47e75-785a-47f7-9b2f-2e49fb72d84d", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 20, 12, 50, 39, 654, DateTimeKind.Local).AddTicks(3504), new DateTime(2023, 11, 20, 12, 50, 39, 654, DateTimeKind.Local).AddTicks(3526), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 20, 12, 50, 39, 654, DateTimeKind.Local).AddTicks(3530), new DateTime(2023, 11, 20, 12, 50, 39, 654, DateTimeKind.Local).AddTicks(3531), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 20, 12, 50, 39, 654, DateTimeKind.Local).AddTicks(4170), new DateTime(2023, 11, 20, 12, 50, 39, 654, DateTimeKind.Local).AddTicks(4171), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 20, 12, 50, 39, 654, DateTimeKind.Local).AddTicks(4175), new DateTime(2023, 11, 20, 12, 50, 39, 654, DateTimeKind.Local).AddTicks(4175), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 20, 12, 50, 39, 654, DateTimeKind.Local).AddTicks(4455), new DateTime(2023, 11, 20, 12, 50, 39, 654, DateTimeKind.Local).AddTicks(4456), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 20, 12, 50, 39, 654, DateTimeKind.Local).AddTicks(4459), new DateTime(2023, 11, 20, 12, 50, 39, 654, DateTimeKind.Local).AddTicks(4460), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 20, 12, 50, 39, 654, DateTimeKind.Local).AddTicks(4462), new DateTime(2023, 11, 20, 12, 50, 39, 654, DateTimeKind.Local).AddTicks(4463), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 20, 12, 50, 39, 654, DateTimeKind.Local).AddTicks(4465), new DateTime(2023, 11, 20, 12, 50, 39, 654, DateTimeKind.Local).AddTicks(4466), "Rav4", "System" }
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
