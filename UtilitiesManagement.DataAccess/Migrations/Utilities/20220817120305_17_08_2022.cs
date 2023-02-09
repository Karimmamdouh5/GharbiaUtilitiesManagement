using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class _17_08_2022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 17, 14, 3, 5, 456, DateTimeKind.Local).AddTicks(4437), new DateTime(2022, 8, 17, 14, 3, 5, 456, DateTimeKind.Local).AddTicks(4438) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 17, 14, 3, 5, 456, DateTimeKind.Local).AddTicks(4439), new DateTime(2022, 8, 17, 14, 3, 5, 456, DateTimeKind.Local).AddTicks(4440) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 17, 14, 3, 5, 456, DateTimeKind.Local).AddTicks(4441), new DateTime(2022, 8, 17, 14, 3, 5, 456, DateTimeKind.Local).AddTicks(4442) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 17, 14, 3, 5, 456, DateTimeKind.Local).AddTicks(4443), new DateTime(2022, 8, 17, 14, 3, 5, 456, DateTimeKind.Local).AddTicks(4443) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 17, 14, 3, 5, 456, DateTimeKind.Local).AddTicks(4445), new DateTime(2022, 8, 17, 14, 3, 5, 456, DateTimeKind.Local).AddTicks(4445) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 17, 14, 3, 5, 456, DateTimeKind.Local).AddTicks(4288), new DateTime(2022, 8, 17, 14, 3, 5, 456, DateTimeKind.Local).AddTicks(4295) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 17, 14, 3, 5, 456, DateTimeKind.Local).AddTicks(4298), new DateTime(2022, 8, 17, 14, 3, 5, 456, DateTimeKind.Local).AddTicks(4298) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 17, 14, 3, 5, 456, DateTimeKind.Local).AddTicks(4300), new DateTime(2022, 8, 17, 14, 3, 5, 456, DateTimeKind.Local).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 17, 14, 3, 5, 456, DateTimeKind.Local).AddTicks(4302), new DateTime(2022, 8, 17, 14, 3, 5, 456, DateTimeKind.Local).AddTicks(4302) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 17, 14, 3, 5, 456, DateTimeKind.Local).AddTicks(4303), new DateTime(2022, 8, 17, 14, 3, 5, 456, DateTimeKind.Local).AddTicks(4304) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 17, 14, 3, 5, 456, DateTimeKind.Local).AddTicks(4414), new DateTime(2022, 8, 17, 14, 3, 5, 456, DateTimeKind.Local).AddTicks(4415) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 17, 14, 3, 5, 456, DateTimeKind.Local).AddTicks(4417), new DateTime(2022, 8, 17, 14, 3, 5, 456, DateTimeKind.Local).AddTicks(4417) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 17, 14, 3, 5, 456, DateTimeKind.Local).AddTicks(4419), new DateTime(2022, 8, 17, 14, 3, 5, 456, DateTimeKind.Local).AddTicks(4419) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 17, 14, 3, 5, 456, DateTimeKind.Local).AddTicks(4421), new DateTime(2022, 8, 17, 14, 3, 5, 456, DateTimeKind.Local).AddTicks(4421) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1318), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1318) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1320), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1320) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1321), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1322) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1323), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1324), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1325) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1131), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1139) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1140), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1141) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1142), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1142) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1144), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1144) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1145), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1145) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1276), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1277) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1278), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1279) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1302), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1302) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1303), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1304) });
        }
    }
}
