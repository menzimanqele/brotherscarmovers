using Microsoft.EntityFrameworkCore.Migrations;

namespace BrothersCarMovers.Data.Migrations
{
    public partial class update_JobTitle_Property_To_RoleId_In_UserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_JobTitleId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "JobTitleId",
                table: "Users",
                newName: "RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_JobTitleId",
                table: "Users",
                newName: "IX_Users_RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "Users",
                newName: "JobTitleId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                newName: "IX_Users_JobTitleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_JobTitleId",
                table: "Users",
                column: "JobTitleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
