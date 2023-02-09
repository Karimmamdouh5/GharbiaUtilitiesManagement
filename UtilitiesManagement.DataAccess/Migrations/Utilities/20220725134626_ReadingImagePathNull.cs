using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class ReadingImagePathNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ReadingImagePath",
                table: "Opr_MeterReadings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2885), new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2885) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2888), new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2888) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2890), new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2891) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2892), new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2893) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2895), new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2896) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2657), new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2668) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2671), new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2672) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2674), new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2675) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2677), new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2678) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2680), new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2681) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2843), new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2844) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2847), new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2848) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2855), new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2856) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2858), new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2859) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ReadingImagePath",
                table: "Opr_MeterReadings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 52, 31, 701, DateTimeKind.Local).AddTicks(2612), new DateTime(2022, 7, 25, 13, 52, 31, 701, DateTimeKind.Local).AddTicks(2613) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 52, 31, 701, DateTimeKind.Local).AddTicks(2615), new DateTime(2022, 7, 25, 13, 52, 31, 701, DateTimeKind.Local).AddTicks(2615) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 52, 31, 701, DateTimeKind.Local).AddTicks(2616), new DateTime(2022, 7, 25, 13, 52, 31, 701, DateTimeKind.Local).AddTicks(2617) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 52, 31, 701, DateTimeKind.Local).AddTicks(2618), new DateTime(2022, 7, 25, 13, 52, 31, 701, DateTimeKind.Local).AddTicks(2619) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 52, 31, 701, DateTimeKind.Local).AddTicks(2620), new DateTime(2022, 7, 25, 13, 52, 31, 701, DateTimeKind.Local).AddTicks(2621) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 52, 31, 701, DateTimeKind.Local).AddTicks(2391), new DateTime(2022, 7, 25, 13, 52, 31, 701, DateTimeKind.Local).AddTicks(2398) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 52, 31, 701, DateTimeKind.Local).AddTicks(2400), new DateTime(2022, 7, 25, 13, 52, 31, 701, DateTimeKind.Local).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 52, 31, 701, DateTimeKind.Local).AddTicks(2402), new DateTime(2022, 7, 25, 13, 52, 31, 701, DateTimeKind.Local).AddTicks(2403) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 52, 31, 701, DateTimeKind.Local).AddTicks(2404), new DateTime(2022, 7, 25, 13, 52, 31, 701, DateTimeKind.Local).AddTicks(2405) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 52, 31, 701, DateTimeKind.Local).AddTicks(2406), new DateTime(2022, 7, 25, 13, 52, 31, 701, DateTimeKind.Local).AddTicks(2407) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 52, 31, 701, DateTimeKind.Local).AddTicks(2536), new DateTime(2022, 7, 25, 13, 52, 31, 701, DateTimeKind.Local).AddTicks(2537) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 52, 31, 701, DateTimeKind.Local).AddTicks(2539), new DateTime(2022, 7, 25, 13, 52, 31, 701, DateTimeKind.Local).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 52, 31, 701, DateTimeKind.Local).AddTicks(2541), new DateTime(2022, 7, 25, 13, 52, 31, 701, DateTimeKind.Local).AddTicks(2542) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 52, 31, 701, DateTimeKind.Local).AddTicks(2591), new DateTime(2022, 7, 25, 13, 52, 31, 701, DateTimeKind.Local).AddTicks(2592) });
        }
    }
}
