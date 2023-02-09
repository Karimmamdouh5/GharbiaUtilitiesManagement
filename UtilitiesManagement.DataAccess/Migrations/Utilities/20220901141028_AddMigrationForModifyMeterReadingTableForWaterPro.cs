using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class AddMigrationForModifyMeterReadingTableForWaterPro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Value",
                table: "Opr_MeterReadings_Logs",
                newName: "OldValue");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1956), new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1960), new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1961) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1964), new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1965) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1968), new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1969) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1971), new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1972) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1639), new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1660) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1665), new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1666) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1669), new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1670) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1672), new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1673) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1676), new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1677) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1907), new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1910) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1913), new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1914) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1917), new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1918) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1922), new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1922) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OldValue",
                table: "Opr_MeterReadings_Logs",
                newName: "Value");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5706), new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5708) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5711), new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5712) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5715), new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5716) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5720), new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5721) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5724), new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5255), new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5285), new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5287) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5291), new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5293) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5296), new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5297) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5301), new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5302) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5634), new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5637) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5641), new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5642) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5645), new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5647) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5651), new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5652) });
        }
    }
}
