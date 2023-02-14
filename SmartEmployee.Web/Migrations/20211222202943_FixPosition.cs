using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartEmployee.Web.Migrations
{
    public partial class FixPosition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "employeeEmail",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "employeeFirstName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "employeeSecondSurname",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "employeeSurname",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "userFirstName",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "userLastName",
                table: "AspNetUsers",
                newName: "firstName");

            migrationBuilder.AlterColumn<string>(
                name: "positionDescription",
                table: "Positions",
                type: "nvarchar(800)",
                maxLength: 800,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "generalFunctions",
                table: "Positions",
                type: "nvarchar(800)",
                maxLength: 800,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "positionName",
                table: "Positions",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "specificFunctions",
                table: "Positions",
                type: "nvarchar(800)",
                maxLength: 800,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Employees",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "secondSurname",
                table: "AspNetUsers",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "surname",
                table: "AspNetUsers",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_UserId",
                table: "Employees",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_AspNetUsers_UserId",
                table: "Employees",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_AspNetUsers_UserId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_UserId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "generalFunctions",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "positionName",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "specificFunctions",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "secondSurname",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "surname",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "firstName",
                table: "AspNetUsers",
                newName: "userLastName");

            migrationBuilder.AlterColumn<string>(
                name: "positionDescription",
                table: "Positions",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(800)",
                oldMaxLength: 800,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "employeeEmail",
                table: "Employees",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "employeeFirstName",
                table: "Employees",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "employeeSecondSurname",
                table: "Employees",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "employeeSurname",
                table: "Employees",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "userFirstName",
                table: "AspNetUsers",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");
        }
    }
}
