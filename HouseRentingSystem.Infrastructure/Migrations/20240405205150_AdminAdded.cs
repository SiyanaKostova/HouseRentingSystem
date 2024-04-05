using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class AdminAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b6c4eb1-4072-4d82-a2ab-844ccc22993a", "Guest", "Guestov", "AQAAAAEAACcQAAAAEEkp8riAsRSkBetti6sluQNV5rxuicf1OfY/zFGvbCMfMmVWwYQWe15Ig+vqSH5wug==", "9c540a9a-95d9-4659-a88a-0fdb733a9b0a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d73f7ead-6484-4fbc-b10a-b75facd8a20e", "Agent", "Agentov", "AQAAAAEAACcQAAAAEIKAXutgiy7xU5Z0to2L8DPMBhxbXTWVdXmaN5OMArRPKT+b2kHwDY4sg0Cho8DJjg==", "72d3dfed-7716-4a57-bd7c-c591e44a0886" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e43ce836-997d-4927-ac59-74e8c41bbfd3", 0, "689d9d5a-0e3b-4c35-aef3-66dfe61cf369", "admin@mail.com", false, "Great", "Admin", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEKMx9t67yLZWkASthf9szNE+2hkUFnt6N8z7ga19gYJpIoJ8wJyLnhG9lS7miyqppw==", null, false, "dc636460-51fe-481b-9060-8fefb09d4e10", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "Agents",
                columns: new[] { "Id", "PhoneNumber", "UserId" },
                values: new object[] { 5, "+359888888887", "e43ce836-997d-4927-ac59-74e8c41bbfd3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e43ce836-997d-4927-ac59-74e8c41bbfd3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be779a5d-3df4-4702-b6c8-78492be81715", "", "", "AQAAAAEAACcQAAAAEGFYoRS0NQekWSGInXSmFWwYPTGv9n7CNzuusKT/hBALP8CNXMohhHFhPBsN49TsGw==", "9516a402-3da9-46c1-bdd2-7291dfe860c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e901cf3-8f41-42fa-bc0e-6221a6774205", "", "", "AQAAAAEAACcQAAAAEJ+NYlvAyL9ncEDKrVzPZXTByNsePYRaNQM7hPP0h+lmeRQtoOYXy8u+wDlSj1bFiA==", "7d1d7e35-d915-4285-be17-1ce4cd526b5d" });
        }
    }
}
