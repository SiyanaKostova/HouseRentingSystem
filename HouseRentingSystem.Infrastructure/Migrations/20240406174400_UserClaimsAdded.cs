using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class UserClaimsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[] { 6, "user:fullname", "Guest Guestov", "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a79226e9-7b54-459c-823c-285f09b880c7", "AQAAAAEAACcQAAAAEM+MDgg+tCohM75rMblO0pG8MvTD+AdUfhKENsBjA/mNG1JpPuSXHoFVl2M29wUvXw==", "5f46912f-8b83-40de-96b5-39f93adb231f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13b69d04-80cd-42d9-a10d-f16d51530946", "AQAAAAEAACcQAAAAEC/aYDzEfvtCS/0ol2dOajgBkXHQ3CNa2KfOk3GcNegPWb6m5uq3HCYxp6vROMNXTw==", "954ca1df-a372-4336-83dc-33150b9bc4f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e43ce836-997d-4927-ac59-74e8c41bbfd3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2163ec5a-c835-4a81-b6e2-c49bf8f478a2", "AQAAAAEAACcQAAAAEJdItwtOvwLTM/1nTrP/g/iOAfWUshR9wFIhJlGceurnC49oXpopCWXtId3z1sKJFA==", "a4ef15ff-c725-43aa-bf1e-bb7263e33c4a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 6);

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
    }
}
