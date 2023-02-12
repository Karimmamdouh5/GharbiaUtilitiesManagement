using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class ReadingImagePath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReadingImagePath",
                table: "Opr_MeterReadings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReadingImagePath",
                table: "Opr_MeterReadings");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4825), new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4825) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4827), new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4828) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4829), new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4830) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4831), new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4832) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4833), new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4834) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4644), new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4650) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4652), new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4653) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4655), new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4656) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4657), new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4658) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4659), new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4660) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4797), new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4798) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4800), new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4800) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4802), new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4803) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4805), new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4805) });
        }
    }
}
