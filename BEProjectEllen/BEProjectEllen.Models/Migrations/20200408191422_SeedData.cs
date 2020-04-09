using Microsoft.EntityFrameworkCore.Migrations;

namespace BEProjectEllen.Core.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6a7fc18d-3442-4144-a737-e7e263842d1c", "2f05d5f4-4ec0-40e6-a2b0-febeb57363d2", "Admin", "ADMIN" },
                    { "10f32c2b-8158-492f-a6a6-5578bef05cb2", "3b6222a3-f2a8-4068-827d-65b06803eda2", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b163ed5f-6559-4dbb-ac82-1427bbc64fc6", 0, "d3c1259a-628f-41c6-85ae-7ebe63a2dc41", "ellen@student.com", true, false, null, "ELLEN@STUDENT.COM", "ELLENCARDOEN", "AQAAAAEAACcQAAAAEAJOyEuCBEVptPmyzSNM05W4xckFO9LGpQppJuPc7vFn4FsE2ncDsyXZy4kIaGYA9A==", null, false, "b421c753-0292-40de-9a0a-9ebc360c38f4", false, "Ellen" },
                    { "da8a2cf5-bd2f-441c-aa86-0e4c8c4d8e7c", 0, "c4cfbdd6-36cd-4754-ab42-f9f5e2be34ba", "johan@docent.com", true, false, null, "JOHAN@DOCENT.COM", "JOHANMCT", "AQAAAAEAACcQAAAAEPQPZcyMHqTU4J6Lrfg0xBty9YUFB5f8XLymRZhAa9pY1Fpq3yErJ5jZnV/wA7QpHQ==", null, false, "86bdc4ff-f9f6-4a43-8693-c59284f54e0e", false, "Johan" }
                });

            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Level" },
                values: new object[,]
                {
                    { 1, "Easy" },
                    { 2, "Normal" },
                    { 3, "Hard" },
                    { 4, "Challenging" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10f32c2b-8158-492f-a6a6-5578bef05cb2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6a7fc18d-3442-4144-a737-e7e263842d1c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b163ed5f-6559-4dbb-ac82-1427bbc64fc6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da8a2cf5-bd2f-441c-aa86-0e4c8c4d8e7c");

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
