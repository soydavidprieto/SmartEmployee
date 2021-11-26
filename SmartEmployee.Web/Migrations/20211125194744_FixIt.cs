using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartEmployee.Web.Migrations
{
    public partial class FixIt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_AspNetUsers_userId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_userId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "Employees");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "userId",
                table: "Employees",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_userId",
                table: "Employees",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_AspNetUsers_userId",
                table: "Employees",
                column: "userId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
