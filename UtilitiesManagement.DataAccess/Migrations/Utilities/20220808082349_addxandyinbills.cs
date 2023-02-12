using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class addxandyinbills : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "X",
                table: "Bill_Payment",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Y",
                table: "Bill_Payment",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5326), new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5327) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5329), new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5329) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5331), new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5331) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5333), new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5333) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5335), new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5335) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5150), new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5162) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5164), new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5165) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5167), new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5167) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5169), new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5170) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5171), new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5172) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5300), new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5301) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5303), new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5303) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5305), new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5305) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5307), new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5307) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "X",
                table: "Bill_Payment");

            migrationBuilder.DropColumn(
                name: "Y",
                table: "Bill_Payment");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1644), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1644) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1646), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1649), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1650) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1651), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1652) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1654), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1654) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1430), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1442) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1444), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1445) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1447), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1448) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1450), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1450) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1452), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1453) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1595), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1599), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1599) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1605), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1608), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1608) });
        }
    }
}
