using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class RemoveBlockNameAndCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BlockCode",
                table: "Hr_EmployeeBlocks");

            migrationBuilder.DropColumn(
                name: "BlockName",
                table: "Hr_EmployeeBlocks");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 19, 2, 868, DateTimeKind.Local).AddTicks(5629), new DateTime(2022, 12, 20, 10, 19, 2, 868, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 19, 2, 868, DateTimeKind.Local).AddTicks(5632), new DateTime(2022, 12, 20, 10, 19, 2, 868, DateTimeKind.Local).AddTicks(5632) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 19, 2, 868, DateTimeKind.Local).AddTicks(5633), new DateTime(2022, 12, 20, 10, 19, 2, 868, DateTimeKind.Local).AddTicks(5634) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 19, 2, 868, DateTimeKind.Local).AddTicks(5635), new DateTime(2022, 12, 20, 10, 19, 2, 868, DateTimeKind.Local).AddTicks(5635) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 19, 2, 868, DateTimeKind.Local).AddTicks(5636), new DateTime(2022, 12, 20, 10, 19, 2, 868, DateTimeKind.Local).AddTicks(5637) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 19, 2, 868, DateTimeKind.Local).AddTicks(5429), new DateTime(2022, 12, 20, 10, 19, 2, 868, DateTimeKind.Local).AddTicks(5442) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 19, 2, 868, DateTimeKind.Local).AddTicks(5444), new DateTime(2022, 12, 20, 10, 19, 2, 868, DateTimeKind.Local).AddTicks(5444) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 19, 2, 868, DateTimeKind.Local).AddTicks(5446), new DateTime(2022, 12, 20, 10, 19, 2, 868, DateTimeKind.Local).AddTicks(5446) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 19, 2, 868, DateTimeKind.Local).AddTicks(5447), new DateTime(2022, 12, 20, 10, 19, 2, 868, DateTimeKind.Local).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 19, 2, 868, DateTimeKind.Local).AddTicks(5449), new DateTime(2022, 12, 20, 10, 19, 2, 868, DateTimeKind.Local).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 19, 2, 868, DateTimeKind.Local).AddTicks(5608), new DateTime(2022, 12, 20, 10, 19, 2, 868, DateTimeKind.Local).AddTicks(5609) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 19, 2, 868, DateTimeKind.Local).AddTicks(5610), new DateTime(2022, 12, 20, 10, 19, 2, 868, DateTimeKind.Local).AddTicks(5611) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 19, 2, 868, DateTimeKind.Local).AddTicks(5612), new DateTime(2022, 12, 20, 10, 19, 2, 868, DateTimeKind.Local).AddTicks(5612) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 19, 2, 868, DateTimeKind.Local).AddTicks(5614), new DateTime(2022, 12, 20, 10, 19, 2, 868, DateTimeKind.Local).AddTicks(5615) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BlockCode",
                table: "Hr_EmployeeBlocks",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BlockName",
                table: "Hr_EmployeeBlocks",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

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
    }
}
