using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PAP.Mvc.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialIdentitySetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3a93b02-ac1d-410d-9d33-58244a74c7cd");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "550b8900-4527-4f69-99d0-24dca683c1dd", "b6735b60-8aae-4d03-8b4d-18df5b85d99b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "550b8900-4527-4f69-99d0-24dca683c1dd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6735b60-8aae-4d03-8b4d-18df5b85d99b");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "550b8900-4527-4f69-99d0-24dca683c1dd", null, "Admin", "ADMIN" },
                    { "e3a93b02-ac1d-410d-9d33-58244a74c7cd", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b6735b60-8aae-4d03-8b4d-18df5b85d99b", 0, "32d1cdab-dfef-4e42-8287-ad230a3837cd", "admin@domain.com", true, false, null, "ADMIN@DOMAIN.COM", "ADMIN@DOMAIN.COM", null, null, false, "7a96aeae-1f61-454d-93e5-711aa62bd8fe", false, "admin@domain.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "550b8900-4527-4f69-99d0-24dca683c1dd", "b6735b60-8aae-4d03-8b4d-18df5b85d99b" });
        }
    }
}
