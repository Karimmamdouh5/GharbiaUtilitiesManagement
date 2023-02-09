using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class changeRelationEmployeeBlocks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hr_EmployeeBlocks_Shar_Blocks_Collector_Id",
                table: "Hr_EmployeeBlocks");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6960), new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6961) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6964), new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6964) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6967), new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6968) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6970), new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6970) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6973), new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6716), new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6723) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6735), new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6736) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6739), new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6742), new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6743) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6746), new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6746) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6918), new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6923), new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6924) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6926), new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6927) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6929), new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.AddForeignKey(
                name: "FK_Hr_EmployeeBlocks_Hr_Employees_Collector_Id",
                table: "Hr_EmployeeBlocks",
                column: "Collector_Id",
                principalTable: "Hr_Employees",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hr_EmployeeBlocks_Hr_Employees_Collector_Id",
                table: "Hr_EmployeeBlocks");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2823), new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2824) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2826), new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2827) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2829), new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2829) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2831), new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2832) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2833), new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2834) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2605), new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2615) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2618), new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2618) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2620), new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2621) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2623), new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2623) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2625), new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2782), new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2783) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2786), new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2787) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2794), new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2795) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2797), new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2797) });

            migrationBuilder.AddForeignKey(
                name: "FK_Hr_EmployeeBlocks_Shar_Blocks_Collector_Id",
                table: "Hr_EmployeeBlocks",
                column: "Collector_Id",
                principalTable: "Shar_Blocks",
                principalColumn: "ID");
        }
    }
}
