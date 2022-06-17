using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BrothersCarMovers.Data.Migrations
{
    public partial class Init_UserSave : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateTime",
                value: new DateTime(2022, 6, 17, 17, 22, 48, 730, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateTime",
                value: new DateTime(2022, 6, 17, 17, 22, 48, 731, DateTimeKind.Local).AddTicks(3752));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateTime",
                value: new DateTime(2022, 6, 17, 17, 22, 48, 731, DateTimeKind.Local).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateTime",
                value: new DateTime(2022, 6, 17, 17, 22, 48, 731, DateTimeKind.Local).AddTicks(3781));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateTime",
                value: new DateTime(2022, 6, 17, 15, 51, 12, 853, DateTimeKind.Local).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateTime",
                value: null);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateTime",
                value: null);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateTime",
                value: null);
        }
    }
}
