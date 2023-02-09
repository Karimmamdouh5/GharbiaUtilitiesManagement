using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class bUILDINGfIRSTsTATRTuP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4379), new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4379) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4381), new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4381) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4382), new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4383) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4384), new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4384) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4385), new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4385) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4250), new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4258) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4260), new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4261) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4262), new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4262) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4263), new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4264) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4265), new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4265) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4357), new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4358) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4359), new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4360) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4361), new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4361) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4362), new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4363) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2607), new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2608) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2609), new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2609) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2611), new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2611) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2613), new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2613) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2614), new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2614) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2466), new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2475) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2477), new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2478) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2479), new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2479) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2480), new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2481) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2482), new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2587), new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2588) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2589), new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2590) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2591), new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2591) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2592), new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2593) });
        }
    }
}
