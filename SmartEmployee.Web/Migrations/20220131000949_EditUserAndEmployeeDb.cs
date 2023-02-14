using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartEmployee.Web.Migrations
{
    public partial class EditUserAndEmployeeDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "temPasswordUser",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "userImageUrl",
                table: "AspNetUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "temPasswordUser",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "userImageUrl",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
