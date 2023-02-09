using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class AddingUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CollectorName",
                table: "Hr_EmployeeBlocks");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1472), new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1472) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1474), new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1474) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1498), new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1499) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1500), new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1500) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1502), new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1502) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1324), new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1331) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1333), new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1334) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1335), new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1335) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1337), new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1337) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1338), new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1339) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1452), new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1452) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1454), new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1455) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1456), new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1456) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1458), new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1458) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CollectorName",
                table: "Hr_EmployeeBlocks",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "");

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
    }
}
