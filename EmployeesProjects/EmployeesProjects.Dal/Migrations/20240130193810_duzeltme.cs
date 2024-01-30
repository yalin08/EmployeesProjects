using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeesProjects.Dal.Migrations
{
    public partial class duzeltme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_EmployeeProject_EmployeeProjectID",
                table: "Project");

            migrationBuilder.DropIndex(
                name: "IX_Project_EmployeeProjectID",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "EmployeeProjectID",
                table: "Project");

            migrationBuilder.AddColumn<int>(
                name: "ProjectID",
                table: "EmployeeProject",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProject_ProjectID",
                table: "EmployeeProject",
                column: "ProjectID");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeProject_Project_ProjectID",
                table: "EmployeeProject",
                column: "ProjectID",
                principalTable: "Project",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeProject_Project_ProjectID",
                table: "EmployeeProject");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeProject_ProjectID",
                table: "EmployeeProject");

            migrationBuilder.DropColumn(
                name: "ProjectID",
                table: "EmployeeProject");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeProjectID",
                table: "Project",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Project_EmployeeProjectID",
                table: "Project",
                column: "EmployeeProjectID");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_EmployeeProject_EmployeeProjectID",
                table: "Project",
                column: "EmployeeProjectID",
                principalTable: "EmployeeProject",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
