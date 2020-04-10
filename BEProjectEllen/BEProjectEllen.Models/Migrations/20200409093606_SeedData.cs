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
                    { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "0f460b9f-e5b6-42a5-8243-3364135cd7bb", "Admin", "ADMIN" },
                    { "097d048b-9c6e-4772-8bbb-35c73134044f", "1e2c771c-9538-464b-a8d6-a07d617a081c", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a18be9c0-aa65-4af8-bd17-00bd9344e575", 0, "e15bf588-ef5c-4f9b-94a9-c41368f0c020", "ellen@student.com", true, false, null, "ELLEN@STUDENT.COM", "ELLENCARDOEN", "AQAAAAEAACcQAAAAEHjqofNmuTTJ5KWrsPAWwFJHdJCkNGcnKBlHdYNEzLbBPo2ALM6JFQm9BqYDvIgvXg==", null, false, "5c00d135-ce82-4167-91ce-b2a3c0ed8bc0", false, "Ellen" },
                    { "a18be9c0-aa65-4af8-bd17-15bd9344e575", 0, "ac406eb1-648a-4c0e-8782-374bfacf5307", "docent@MCT.com", true, false, null, "DOCENT@MCT.COM", "DOCENTMCT", "AQAAAAEAACcQAAAAEFrNPVvOEGgRCI088JUgUfUt4bU9n+rou8psGSMbkD4qjEEut/TwB8O8pJD8yV1urg==", null, false, "f328c744-a41f-4cf6-adda-e004a59c0007", false, "Docent@MCT" }
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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "a18be9c0-aa65-4af8-bd17-00bd9344e575" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-15bd9344e575", "a18be9c0-aa65-4af8-bd17-00bd9344e575" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "097d048b-9c6e-4772-8bbb-35c73134044f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "a18be9c0-aa65-4af8-bd17-00bd9344e575" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-15bd9344e575", "a18be9c0-aa65-4af8-bd17-00bd9344e575" });

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

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-15bd9344e575");
        }
    }
}
