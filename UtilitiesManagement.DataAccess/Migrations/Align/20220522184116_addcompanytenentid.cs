using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace  UtilitiesManagement.DataAccess.Migrations.align
{
    public partial class addcompanytenentid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyTenantId",
                table: "Logging",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyTenantId",
                table: "AlignCompanies",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyTenantId",
                table: "Logging");

            migrationBuilder.DropColumn(
                name: "CompanyTenantId",
                table: "AlignCompanies");
        }
    }
}
