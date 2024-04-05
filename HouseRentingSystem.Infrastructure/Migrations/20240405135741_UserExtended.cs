using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class UserExtended : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Agents_UserId",
                table: "Agents");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.CreateIndex(
                name: "IX_Agents_UserId",
                table: "Agents",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Agents_UserId",
                table: "Agents");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

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
                name: "IX_Agents_UserId",
                table: "Agents",
                column: "UserId");
        }
    }
}
