using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class AddPrintLogsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7538), new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7539) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7540), new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7542), new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7542) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7543), new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7544) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7546), new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7547) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7388), new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7398) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7400), new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7400) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7402), new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7402) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7403), new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7404) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7405), new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7405) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7516), new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7517) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7518), new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7519) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7520), new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7520) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7522), new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7522) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3427), new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3428) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3429), new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3429) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3431), new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3431) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3432), new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3433) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3434), new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3434) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3278), new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3292), new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3292) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3293), new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3294) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3295), new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3295) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3296), new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3297) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3403), new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3403) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3406), new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3408), new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3408) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3409), new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3410) });
        }
    }
}
