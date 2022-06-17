using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BrothersCarMovers.Data.Migrations
{
    public partial class Seed_Role_Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreateDateTime", "Description", "IsCurrent", "IsDeleted", "IsNew", "IsSynced", "LastSyncClient", "LastSyncDateTime", "ModifiedDateTime", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 6, 17, 15, 51, 12, 853, DateTimeKind.Local).AddTicks(8752), "Driver", null, null, null, null, null, null, null, "Driver" },
                    { 2, null, "Client", null, null, null, null, null, null, null, "Client" },
                    { 3, null, "Admin", null, null, null, null, null, null, null, "Admin" },
                    { 4, null, "Manager", null, null, null, null, null, null, null, "Manager" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
