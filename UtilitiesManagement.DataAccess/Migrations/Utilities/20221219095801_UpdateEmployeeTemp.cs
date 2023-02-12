using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class UpdateEmployeeTemp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hr_Employees_Temp");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 58, 0, 887, DateTimeKind.Local).AddTicks(6196), new DateTime(2022, 12, 19, 11, 58, 0, 887, DateTimeKind.Local).AddTicks(6196) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 58, 0, 887, DateTimeKind.Local).AddTicks(6198), new DateTime(2022, 12, 19, 11, 58, 0, 887, DateTimeKind.Local).AddTicks(6198) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 58, 0, 887, DateTimeKind.Local).AddTicks(6199), new DateTime(2022, 12, 19, 11, 58, 0, 887, DateTimeKind.Local).AddTicks(6200) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 58, 0, 887, DateTimeKind.Local).AddTicks(6201), new DateTime(2022, 12, 19, 11, 58, 0, 887, DateTimeKind.Local).AddTicks(6201) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 58, 0, 887, DateTimeKind.Local).AddTicks(6202), new DateTime(2022, 12, 19, 11, 58, 0, 887, DateTimeKind.Local).AddTicks(6203) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 58, 0, 887, DateTimeKind.Local).AddTicks(6044), new DateTime(2022, 12, 19, 11, 58, 0, 887, DateTimeKind.Local).AddTicks(6057) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 58, 0, 887, DateTimeKind.Local).AddTicks(6059), new DateTime(2022, 12, 19, 11, 58, 0, 887, DateTimeKind.Local).AddTicks(6059) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 58, 0, 887, DateTimeKind.Local).AddTicks(6061), new DateTime(2022, 12, 19, 11, 58, 0, 887, DateTimeKind.Local).AddTicks(6061) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 58, 0, 887, DateTimeKind.Local).AddTicks(6062), new DateTime(2022, 12, 19, 11, 58, 0, 887, DateTimeKind.Local).AddTicks(6063) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 58, 0, 887, DateTimeKind.Local).AddTicks(6064), new DateTime(2022, 12, 19, 11, 58, 0, 887, DateTimeKind.Local).AddTicks(6064) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 58, 0, 887, DateTimeKind.Local).AddTicks(6173), new DateTime(2022, 12, 19, 11, 58, 0, 887, DateTimeKind.Local).AddTicks(6174) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 58, 0, 887, DateTimeKind.Local).AddTicks(6175), new DateTime(2022, 12, 19, 11, 58, 0, 887, DateTimeKind.Local).AddTicks(6176) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 58, 0, 887, DateTimeKind.Local).AddTicks(6177), new DateTime(2022, 12, 19, 11, 58, 0, 887, DateTimeKind.Local).AddTicks(6178) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 58, 0, 887, DateTimeKind.Local).AddTicks(6179), new DateTime(2022, 12, 19, 11, 58, 0, 887, DateTimeKind.Local).AddTicks(6179) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hr_Employees_Temp",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchID = table.Column<long>(type: "bigint", nullable: false),
                    CollectorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CollectorType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyTenantId = table.Column<int>(type: "int", nullable: true),
                    DeleteBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InsertBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
    }
}
