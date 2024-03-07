using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class UniqueConstraintForPhoneNumberAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6caf83f4-cd1e-44be-9806-ec13643ba7c9", "AQAAAAEAACcQAAAAENS0lzbw9OWav7iYe1rPEBpSarUt1dofwwQekkVBVTFxGQzFXRQwu2Tcegn6LOinuA==", "f7190976-0dd3-4b8a-953b-ea8f95e84bf1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "668355e0-6143-46b6-9e47-39aa5a43cb99", "AQAAAAEAACcQAAAAEHYbN22EBIsAmJ+g5CDF9yO/Z0/A1MYmUOiJ5G287X+HRTluJqtki/5n6pnZJm7I9Q==", "de7dd45c-d7a6-44cd-bb0a-0d6e629fbb8f" });

            migrationBuilder.CreateIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents",
                column: "PhoneNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "334a175b-2f04-48de-94d4-ce2288a32acc", "AQAAAAEAACcQAAAAEAZSn3+LNOMXvesnFy5DlyttQcdOrIm5gE/PaVyfZWWI3Wd4fjmKX8qEME4mp9lloQ==", "6e243343-d92a-4dc8-9b19-31f48c5410cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14a7bab5-7ea9-4bde-bca6-bcba6f68bb4c", "AQAAAAEAACcQAAAAECz27o20bVSV0YN/plsZnLbKzxwVlN0RmW0n+dV/czCKiNpKd9uGswca19zE4UO9qw==", "65958a59-865e-4621-90b5-c964a1eef81a" });
        }
    }
}
