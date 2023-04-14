using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bank.Data.Migrations
{
    /// <inheritdoc />
    public partial class newModell : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Statements_Employees_EmployeeId",
                table: "Statements");

            migrationBuilder.DropIndex(
                name: "IX_Statements_EmployeeId",
                table: "Statements");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Statements");

            migrationBuilder.CreateIndex(
                name: "IX_NumberOfContracts_EmployeeId",
                table: "NumberOfContracts",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_NumberOfContracts_Employees_EmployeeId",
                table: "NumberOfContracts",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NumberOfContracts_Employees_EmployeeId",
                table: "NumberOfContracts");

            migrationBuilder.DropIndex(
                name: "IX_NumberOfContracts_EmployeeId",
                table: "NumberOfContracts");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Statements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Statements_EmployeeId",
                table: "Statements",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Statements_Employees_EmployeeId",
                table: "Statements",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
