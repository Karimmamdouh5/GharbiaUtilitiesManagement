using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class UpdateEmployeeTemp2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hr_Employees_Temp",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                values: new object[] { new DateTime(2022, 12, 19, 11, 59, 14, 867, DateTimeKind.Local).AddTicks(2227), new DateTime(2022, 12, 19, 11, 59, 14, 867, DateTimeKind.Local).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 59, 14, 867, DateTimeKind.Local).AddTicks(2229), new DateTime(2022, 12, 19, 11, 59, 14, 867, DateTimeKind.Local).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 59, 14, 867, DateTimeKind.Local).AddTicks(2231), new DateTime(2022, 12, 19, 11, 59, 14, 867, DateTimeKind.Local).AddTicks(2231) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 59, 14, 867, DateTimeKind.Local).AddTicks(2232), new DateTime(2022, 12, 19, 11, 59, 14, 867, DateTimeKind.Local).AddTicks(2233) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 59, 14, 867, DateTimeKind.Local).AddTicks(2234), new DateTime(2022, 12, 19, 11, 59, 14, 867, DateTimeKind.Local).AddTicks(2235) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 59, 14, 867, DateTimeKind.Local).AddTicks(2040), new DateTime(2022, 12, 19, 11, 59, 14, 867, DateTimeKind.Local).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 59, 14, 867, DateTimeKind.Local).AddTicks(2091), new DateTime(2022, 12, 19, 11, 59, 14, 867, DateTimeKind.Local).AddTicks(2092) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 59, 14, 867, DateTimeKind.Local).AddTicks(2093), new DateTime(2022, 12, 19, 11, 59, 14, 867, DateTimeKind.Local).AddTicks(2094) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 59, 14, 867, DateTimeKind.Local).AddTicks(2095), new DateTime(2022, 12, 19, 11, 59, 14, 867, DateTimeKind.Local).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 59, 14, 867, DateTimeKind.Local).AddTicks(2097), new DateTime(2022, 12, 19, 11, 59, 14, 867, DateTimeKind.Local).AddTicks(2097) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 59, 14, 867, DateTimeKind.Local).AddTicks(2206), new DateTime(2022, 12, 19, 11, 59, 14, 867, DateTimeKind.Local).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 59, 14, 867, DateTimeKind.Local).AddTicks(2208), new DateTime(2022, 12, 19, 11, 59, 14, 867, DateTimeKind.Local).AddTicks(2209) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 59, 14, 867, DateTimeKind.Local).AddTicks(2210), new DateTime(2022, 12, 19, 11, 59, 14, 867, DateTimeKind.Local).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 59, 14, 867, DateTimeKind.Local).AddTicks(2212), new DateTime(2022, 12, 19, 11, 59, 14, 867, DateTimeKind.Local).AddTicks(2212) });
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
    }
}
