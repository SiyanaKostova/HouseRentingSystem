using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class IsApprovedAddedToHouse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Houses",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Shows whether house approved by admin");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "328be534-f9b9-429c-b7c5-5196e166664b", "AQAAAAEAACcQAAAAEMLmHc7QwQKtJelW79GARrYHH2wTWCOiufhUxoErmIrPaDv4SgaPvSTLLaCsu+mq0Q==", "3c0063e3-b84e-4be8-92cc-9a75e8f68588" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c719f0d-5066-4142-a60d-aa959739fa77", "AQAAAAEAACcQAAAAECo6tou9HXOF5pFHBYCnc5rxSmcGr7bvTqUgi9BxhKlE93PxcQTbm5wl1wuc5kAGQA==", "d2bf0e9f-139d-4c7f-9fe0-dd31e4c8d8cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e43ce836-997d-4927-ac59-74e8c41bbfd3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3dd8194-26d5-4e37-ab23-ca65804bfc3c", "AQAAAAEAACcQAAAAEFjOTQNzNR8iTK95MDS6SPPqCl+6JhJmsWyx5fy/CN2xaxYIB2icPP1INEfp4jsQuQ==", "cfd7c299-b158-4c96-bcaa-12fc9a25e097" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Houses");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b6c4eb1-4072-4d82-a2ab-844ccc22993a", "AQAAAAEAACcQAAAAEEkp8riAsRSkBetti6sluQNV5rxuicf1OfY/zFGvbCMfMmVWwYQWe15Ig+vqSH5wug==", "9c540a9a-95d9-4659-a88a-0fdb733a9b0a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d73f7ead-6484-4fbc-b10a-b75facd8a20e", "AQAAAAEAACcQAAAAEIKAXutgiy7xU5Z0to2L8DPMBhxbXTWVdXmaN5OMArRPKT+b2kHwDY4sg0Cho8DJjg==", "72d3dfed-7716-4a57-bd7c-c591e44a0886" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e43ce836-997d-4927-ac59-74e8c41bbfd3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "689d9d5a-0e3b-4c35-aef3-66dfe61cf369", "AQAAAAEAACcQAAAAEKMx9t67yLZWkASthf9szNE+2hkUFnt6N8z7ga19gYJpIoJ8wJyLnhG9lS7miyqppw==", "dc636460-51fe-481b-9060-8fefb09d4e10" });
        }
    }
}
