using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BasicCrud.Migrations
{
    /// <inheritdoc />
    public partial class AdminSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "480788d7-b903-4fc9-84ce-c6be1d183bfc", null, "Editor", "EDITOR" },
                    { "5c30268a-8dff-40c6-8649-17551da6e681", null, "PublicUser", "PUBLICUSER" },
                    { "644aa6e7-45aa-4b6a-bb4c-8d4e33f7987a", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[] { "dec406ea-1bd1-4ab6-94b3-0efce668f8cf", 0, "7be8db83-af5d-400f-9bdc-8f9bedd2a0eb", new DateTime(2025, 1, 31, 14, 0, 37, 704, DateTimeKind.Local).AddTicks(6710), "aayushadhikari601@gmail.com", true, "Admin", false, null, "AAYUSHADHIKARI601@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEJfNdXPoz4IMmErbun7bYcPRy/ZzeyZdqNEsPcfncYduDTips8gDCpa4D2Jyv+BOBQ==", "9876543210", false, "0bcd67cf-27da-4529-9db4-7ccd9422e708", false, new DateTime(2025, 1, 31, 14, 0, 37, 704, DateTimeKind.Local).AddTicks(6733), "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "644aa6e7-45aa-4b6a-bb4c-8d4e33f7987a", "dec406ea-1bd1-4ab6-94b3-0efce668f8cf" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "480788d7-b903-4fc9-84ce-c6be1d183bfc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c30268a-8dff-40c6-8649-17551da6e681");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "644aa6e7-45aa-4b6a-bb4c-8d4e33f7987a", "dec406ea-1bd1-4ab6-94b3-0efce668f8cf" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "644aa6e7-45aa-4b6a-bb4c-8d4e33f7987a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dec406ea-1bd1-4ab6-94b3-0efce668f8cf");
        }
    }
}
