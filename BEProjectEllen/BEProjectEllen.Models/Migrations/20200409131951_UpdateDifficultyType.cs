using Microsoft.EntityFrameworkCore.Migrations;

namespace BEProjectEllen.Core.Migrations
{
    public partial class UpdateDifficultyType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quizzes_Difficulties_DifficultyId1",
                table: "Quizzes");

            migrationBuilder.DropIndex(
                name: "IX_Quizzes_DifficultyId1",
                table: "Quizzes");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "097d048b-9c6e-4772-8bbb-35c73134044f");

            migrationBuilder.DropColumn(
                name: "DifficultyId1",
                table: "Quizzes");

            migrationBuilder.AlterColumn<int>(
                name: "DifficultyId",
                table: "Quizzes",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "90eeba1f-6bd0-4a00-9bc6-28680d314f0c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9a9a1a52-e08b-4042-b934-66cbbcbe7c77", "ef3f244b-44ab-4289-a512-00df7c843f2a", "User", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af2a5497-26d0-41be-9b0d-d973450c86c8", "AQAAAAEAACcQAAAAEK+WtAHpwJ0gkkHaXEAjCsIDUzH7cgDYUbZ/zs9mwBG8HZc73PNZj20/5TrOrS7Pzg==", "2fc79102-4c7f-4f51-b72e-ae0a30bc562b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-15bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac6cf895-9c5c-42cd-b70b-38716c55694e", "AQAAAAEAACcQAAAAEMnnj0zhghgF9lCY9cdVSCH7pxXE7PmLQxZMMxbu2wDnbEGFNUjw78KjoREchXwS9g==", "239d5981-0d02-42a3-9d68-2ce6fc771626" });

            migrationBuilder.CreateIndex(
                name: "IX_Quizzes_DifficultyId",
                table: "Quizzes",
                column: "DifficultyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Quizzes_Difficulties_DifficultyId",
                table: "Quizzes",
                column: "DifficultyId",
                principalTable: "Difficulties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quizzes_Difficulties_DifficultyId",
                table: "Quizzes");

            migrationBuilder.DropIndex(
                name: "IX_Quizzes_DifficultyId",
                table: "Quizzes");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a9a1a52-e08b-4042-b934-66cbbcbe7c77");

            migrationBuilder.AlterColumn<string>(
                name: "DifficultyId",
                table: "Quizzes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "DifficultyId1",
                table: "Quizzes",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "0f460b9f-e5b6-42a5-8243-3364135cd7bb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "097d048b-9c6e-4772-8bbb-35c73134044f", "1e2c771c-9538-464b-a8d6-a07d617a081c", "User", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e15bf588-ef5c-4f9b-94a9-c41368f0c020", "AQAAAAEAACcQAAAAEHjqofNmuTTJ5KWrsPAWwFJHdJCkNGcnKBlHdYNEzLbBPo2ALM6JFQm9BqYDvIgvXg==", "5c00d135-ce82-4167-91ce-b2a3c0ed8bc0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-15bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac406eb1-648a-4c0e-8782-374bfacf5307", "AQAAAAEAACcQAAAAEFrNPVvOEGgRCI088JUgUfUt4bU9n+rou8psGSMbkD4qjEEut/TwB8O8pJD8yV1urg==", "f328c744-a41f-4cf6-adda-e004a59c0007" });

            migrationBuilder.CreateIndex(
                name: "IX_Quizzes_DifficultyId1",
                table: "Quizzes",
                column: "DifficultyId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Quizzes_Difficulties_DifficultyId1",
                table: "Quizzes",
                column: "DifficultyId1",
                principalTable: "Difficulties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
