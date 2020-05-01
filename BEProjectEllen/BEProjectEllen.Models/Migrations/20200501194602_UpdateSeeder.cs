using Microsoft.EntityFrameworkCore.Migrations;

namespace BEProjectEllen.Core.Migrations
{
    public partial class UpdateSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9479975f-4b64-40eb-889f-817402c3a8d2");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "a18be9c0-aa65-4af8-bd17-00bd9344e575" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-15bd9344e575", "a18be9c0-aa65-4af8-bd17-00bd9344e575" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-15bd9344e575");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "31954e6b-4691-45dd-bd2c-df2d744a180c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-15bd9344e575", "1fd6003d-f2de-4e77-bdd1-ea13b7b5d313", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-15bd9344e575");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "1d92bb00-36a3-4f43-aec5-0dad72158046");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9479975f-4b64-40eb-889f-817402c3a8d2", "d988fa3d-9371-4275-9fe5-6af7a5b637e7", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a18be9c0-aa65-4af8-bd17-00bd9344e575", 0, "cf25dd30-6bca-4620-bcb8-85e334b5f661", "ellen@student.com", true, false, null, "ELLEN@STUDENT.COM", "ELLENCARDOEN", "AQAAAAEAACcQAAAAEL5WVo8RFlwmbCJwILL8eJlai/ZPwlVmQrjXKwqefXldDPcJ23/NUSwSutDrwDpagw==", null, false, "a67fe110-2812-4ec9-9b22-9080ea29f71a", false, "Ellen" },
                    { "a18be9c0-aa65-4af8-bd17-15bd9344e575", 0, "baf69a04-de97-40c8-bcd8-9368d335deaf", "docent@MCT.com", true, false, null, "DOCENT@MCT.COM", "DOCENTMCT", "AQAAAAEAACcQAAAAEP+PF0wAgRn2vdkyC3RMTH9Oar2f6fj+6k5o88u0ybxIxt/bw9Nopn1zc3OUoH5RoA==", null, false, "ef9776a2-01bc-469a-b0d6-6f2782f25e5b", false, "Docent@MCT" }
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
    }
}
