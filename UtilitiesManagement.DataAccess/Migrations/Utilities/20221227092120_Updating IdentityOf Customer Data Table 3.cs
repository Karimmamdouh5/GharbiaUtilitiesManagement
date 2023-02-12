using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class UpdatingIdentityOfCustomerDataTable3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cust_CustomerStatus",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 21, 19, 555, DateTimeKind.Local).AddTicks(5595), new DateTime(2022, 12, 27, 11, 21, 19, 555, DateTimeKind.Local).AddTicks(5596) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 21, 19, 555, DateTimeKind.Local).AddTicks(5636), new DateTime(2022, 12, 27, 11, 21, 19, 555, DateTimeKind.Local).AddTicks(5637) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 21, 19, 555, DateTimeKind.Local).AddTicks(5639), new DateTime(2022, 12, 27, 11, 21, 19, 555, DateTimeKind.Local).AddTicks(5639) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 21, 19, 555, DateTimeKind.Local).AddTicks(5641), new DateTime(2022, 12, 27, 11, 21, 19, 555, DateTimeKind.Local).AddTicks(5641) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 21, 19, 555, DateTimeKind.Local).AddTicks(5642), new DateTime(2022, 12, 27, 11, 21, 19, 555, DateTimeKind.Local).AddTicks(5643) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 21, 19, 555, DateTimeKind.Local).AddTicks(5644), new DateTime(2022, 12, 27, 11, 21, 19, 555, DateTimeKind.Local).AddTicks(5645) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 21, 19, 555, DateTimeKind.Local).AddTicks(5442), new DateTime(2022, 12, 27, 11, 21, 19, 555, DateTimeKind.Local).AddTicks(5451) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 21, 19, 555, DateTimeKind.Local).AddTicks(5453), new DateTime(2022, 12, 27, 11, 21, 19, 555, DateTimeKind.Local).AddTicks(5454) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 21, 19, 555, DateTimeKind.Local).AddTicks(5455), new DateTime(2022, 12, 27, 11, 21, 19, 555, DateTimeKind.Local).AddTicks(5456) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 21, 19, 555, DateTimeKind.Local).AddTicks(5457), new DateTime(2022, 12, 27, 11, 21, 19, 555, DateTimeKind.Local).AddTicks(5458) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 21, 19, 555, DateTimeKind.Local).AddTicks(5459), new DateTime(2022, 12, 27, 11, 21, 19, 555, DateTimeKind.Local).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 21, 19, 555, DateTimeKind.Local).AddTicks(5615), new DateTime(2022, 12, 27, 11, 21, 19, 555, DateTimeKind.Local).AddTicks(5616) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 21, 19, 555, DateTimeKind.Local).AddTicks(5618), new DateTime(2022, 12, 27, 11, 21, 19, 555, DateTimeKind.Local).AddTicks(5618) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 21, 19, 555, DateTimeKind.Local).AddTicks(5620), new DateTime(2022, 12, 27, 11, 21, 19, 555, DateTimeKind.Local).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 21, 19, 555, DateTimeKind.Local).AddTicks(5622), new DateTime(2022, 12, 27, 11, 21, 19, 555, DateTimeKind.Local).AddTicks(5622) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cust_CustomerStatus",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 10, 55, 90, DateTimeKind.Local).AddTicks(2029), new DateTime(2022, 12, 27, 11, 10, 55, 90, DateTimeKind.Local).AddTicks(2030) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 10, 55, 90, DateTimeKind.Local).AddTicks(2098), new DateTime(2022, 12, 27, 11, 10, 55, 90, DateTimeKind.Local).AddTicks(2099) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 10, 55, 90, DateTimeKind.Local).AddTicks(2102), new DateTime(2022, 12, 27, 11, 10, 55, 90, DateTimeKind.Local).AddTicks(2103) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 10, 55, 90, DateTimeKind.Local).AddTicks(2105), new DateTime(2022, 12, 27, 11, 10, 55, 90, DateTimeKind.Local).AddTicks(2106) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 10, 55, 90, DateTimeKind.Local).AddTicks(2109), new DateTime(2022, 12, 27, 11, 10, 55, 90, DateTimeKind.Local).AddTicks(2109) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 10, 55, 90, DateTimeKind.Local).AddTicks(2111), new DateTime(2022, 12, 27, 11, 10, 55, 90, DateTimeKind.Local).AddTicks(2112) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 10, 55, 90, DateTimeKind.Local).AddTicks(1813), new DateTime(2022, 12, 27, 11, 10, 55, 90, DateTimeKind.Local).AddTicks(1829) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 10, 55, 90, DateTimeKind.Local).AddTicks(1832), new DateTime(2022, 12, 27, 11, 10, 55, 90, DateTimeKind.Local).AddTicks(1833) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 10, 55, 90, DateTimeKind.Local).AddTicks(1835), new DateTime(2022, 12, 27, 11, 10, 55, 90, DateTimeKind.Local).AddTicks(1836) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 10, 55, 90, DateTimeKind.Local).AddTicks(1839), new DateTime(2022, 12, 27, 11, 10, 55, 90, DateTimeKind.Local).AddTicks(1840) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 10, 55, 90, DateTimeKind.Local).AddTicks(1842), new DateTime(2022, 12, 27, 11, 10, 55, 90, DateTimeKind.Local).AddTicks(1843) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 10, 55, 90, DateTimeKind.Local).AddTicks(2060), new DateTime(2022, 12, 27, 11, 10, 55, 90, DateTimeKind.Local).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 10, 55, 90, DateTimeKind.Local).AddTicks(2064), new DateTime(2022, 12, 27, 11, 10, 55, 90, DateTimeKind.Local).AddTicks(2065) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 10, 55, 90, DateTimeKind.Local).AddTicks(2067), new DateTime(2022, 12, 27, 11, 10, 55, 90, DateTimeKind.Local).AddTicks(2068) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 10, 55, 90, DateTimeKind.Local).AddTicks(2071), new DateTime(2022, 12, 27, 11, 10, 55, 90, DateTimeKind.Local).AddTicks(2072) });
        }
    }
}
