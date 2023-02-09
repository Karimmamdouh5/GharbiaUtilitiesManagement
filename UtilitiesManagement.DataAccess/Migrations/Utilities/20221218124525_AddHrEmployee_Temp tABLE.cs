using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class AddHrEmployee_TemptABLE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hr_Employees_Temp",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CollectorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CollectorType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchID = table.Column<long>(type: "bigint", nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InsertBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DeleteBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CompanyTenantId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hr_Employees_Temp", x => x.ID);
                });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 18, 14, 45, 24, 644, DateTimeKind.Local).AddTicks(9039), new DateTime(2022, 12, 18, 14, 45, 24, 644, DateTimeKind.Local).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 18, 14, 45, 24, 644, DateTimeKind.Local).AddTicks(9041), new DateTime(2022, 12, 18, 14, 45, 24, 644, DateTimeKind.Local).AddTicks(9042) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 18, 14, 45, 24, 644, DateTimeKind.Local).AddTicks(9043), new DateTime(2022, 12, 18, 14, 45, 24, 644, DateTimeKind.Local).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 18, 14, 45, 24, 644, DateTimeKind.Local).AddTicks(9044), new DateTime(2022, 12, 18, 14, 45, 24, 644, DateTimeKind.Local).AddTicks(9045) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 18, 14, 45, 24, 644, DateTimeKind.Local).AddTicks(9046), new DateTime(2022, 12, 18, 14, 45, 24, 644, DateTimeKind.Local).AddTicks(9046) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 18, 14, 45, 24, 644, DateTimeKind.Local).AddTicks(8858), new DateTime(2022, 12, 18, 14, 45, 24, 644, DateTimeKind.Local).AddTicks(8866) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 18, 14, 45, 24, 644, DateTimeKind.Local).AddTicks(8868), new DateTime(2022, 12, 18, 14, 45, 24, 644, DateTimeKind.Local).AddTicks(8868) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 18, 14, 45, 24, 644, DateTimeKind.Local).AddTicks(8870), new DateTime(2022, 12, 18, 14, 45, 24, 644, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 18, 14, 45, 24, 644, DateTimeKind.Local).AddTicks(8871), new DateTime(2022, 12, 18, 14, 45, 24, 644, DateTimeKind.Local).AddTicks(8872) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 18, 14, 45, 24, 644, DateTimeKind.Local).AddTicks(8873), new DateTime(2022, 12, 18, 14, 45, 24, 644, DateTimeKind.Local).AddTicks(8873) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 18, 14, 45, 24, 644, DateTimeKind.Local).AddTicks(8994), new DateTime(2022, 12, 18, 14, 45, 24, 644, DateTimeKind.Local).AddTicks(8994) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 18, 14, 45, 24, 644, DateTimeKind.Local).AddTicks(8996), new DateTime(2022, 12, 18, 14, 45, 24, 644, DateTimeKind.Local).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 18, 14, 45, 24, 644, DateTimeKind.Local).AddTicks(8998), new DateTime(2022, 12, 18, 14, 45, 24, 644, DateTimeKind.Local).AddTicks(8998) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 18, 14, 45, 24, 644, DateTimeKind.Local).AddTicks(9023), new DateTime(2022, 12, 18, 14, 45, 24, 644, DateTimeKind.Local).AddTicks(9024) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hr_Employees_Temp");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5405), new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5406) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5407), new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5407) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5408), new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5409) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5410), new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5411) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5412), new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5412) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5248), new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5256) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5258), new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5259) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5260), new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5261) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5262), new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5264), new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5264) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5380), new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5380) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5382), new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5382) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5384), new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5384) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5386), new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5386) });
        }
    }
}
