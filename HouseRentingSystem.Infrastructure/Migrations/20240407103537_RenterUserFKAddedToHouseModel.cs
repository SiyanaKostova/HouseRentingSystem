using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class RenterUserFKAddedToHouseModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RenterId",
                table: "Houses",
                type: "nvarchar(450)",
                nullable: true,
                comment: "User id of the renter",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "User id of the renter");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e589313a-b7e4-47f8-9979-c6f0afb6dabe", "AQAAAAEAACcQAAAAEIbTGAUdFvbNvM4hj4Y6TfWXEWZNQGvLMIHjPuqM+OJD/1t9nTUQhKyILvXrPpc4Eg==", "81f2232d-c8a4-42d0-ad03-7da40cbb6038" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "565e2c9e-cf12-4e43-bbdb-c8a312930902", "AQAAAAEAACcQAAAAELGUGr/EymepCYFBUVJcxLH0jS4/JO/EQhhT/X7VtzIoJpZQwZifrjySpKVyWR+J+Q==", "6a7eeae9-403b-4570-8782-fc576c6a9d92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e43ce836-997d-4927-ac59-74e8c41bbfd3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2712302-9f02-454f-ac6d-d0a5d9179fbe", "AQAAAAEAACcQAAAAEHDna59OEEmomp3Vfk2sye37SGwhzd85HTDn3iboFgBN57NIztkMHndgdO9HOQNmdA==", "894534ba-e0e6-46c0-a5ab-118b647000eb" });

            migrationBuilder.CreateIndex(
                name: "IX_Houses_RenterId",
                table: "Houses",
                column: "RenterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Houses_AspNetUsers_RenterId",
                table: "Houses",
                column: "RenterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Houses_AspNetUsers_RenterId",
                table: "Houses");

            migrationBuilder.DropIndex(
                name: "IX_Houses_RenterId",
                table: "Houses");

            migrationBuilder.AlterColumn<string>(
                name: "RenterId",
                table: "Houses",
                type: "nvarchar(max)",
                nullable: true,
                comment: "User id of the renter",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true,
                oldComment: "User id of the renter");

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
    }
}
