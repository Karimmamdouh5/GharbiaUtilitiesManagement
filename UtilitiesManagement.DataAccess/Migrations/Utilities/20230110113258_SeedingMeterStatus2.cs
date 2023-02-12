using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class SeedingMeterStatus2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cust_CustomerStatus",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2582), new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2583) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2621), new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2622) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2623), new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2623) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2625), new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2625) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2627), new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2627) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2628), new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2629) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2438), new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2447) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2449), new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2451), new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2452) });

            migrationBuilder.InsertData(
                table: "Opr_MeterStatus",
                columns: new[] { "ID", "CompanyTenantId", "DeleteBy", "DeleteDate", "InsertBy", "InsertDate", "IsDeleted", "Name", "UpdateBy", "UpdateDate" },
                values: new object[] { 18, null, null, null, null, new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2453), false, "صحيحة", null, new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2453) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2599), new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2599) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2603), new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2604) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2605), new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2606) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2607), new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2607) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.UpdateData(
                table: "Cust_CustomerStatus",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 8, 47, 543, DateTimeKind.Local).AddTicks(2215), new DateTime(2023, 1, 10, 12, 8, 47, 543, DateTimeKind.Local).AddTicks(2216) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 8, 47, 543, DateTimeKind.Local).AddTicks(2255), new DateTime(2023, 1, 10, 12, 8, 47, 543, DateTimeKind.Local).AddTicks(2256) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 8, 47, 543, DateTimeKind.Local).AddTicks(2258), new DateTime(2023, 1, 10, 12, 8, 47, 543, DateTimeKind.Local).AddTicks(2258) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 8, 47, 543, DateTimeKind.Local).AddTicks(2259), new DateTime(2023, 1, 10, 12, 8, 47, 543, DateTimeKind.Local).AddTicks(2260) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 8, 47, 543, DateTimeKind.Local).AddTicks(2261), new DateTime(2023, 1, 10, 12, 8, 47, 543, DateTimeKind.Local).AddTicks(2262) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 8, 47, 543, DateTimeKind.Local).AddTicks(2263), new DateTime(2023, 1, 10, 12, 8, 47, 543, DateTimeKind.Local).AddTicks(2263) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 8, 47, 543, DateTimeKind.Local).AddTicks(2089), new DateTime(2023, 1, 10, 12, 8, 47, 543, DateTimeKind.Local).AddTicks(2098) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 8, 47, 543, DateTimeKind.Local).AddTicks(2101), new DateTime(2023, 1, 10, 12, 8, 47, 543, DateTimeKind.Local).AddTicks(2101) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 8, 47, 543, DateTimeKind.Local).AddTicks(2102), new DateTime(2023, 1, 10, 12, 8, 47, 543, DateTimeKind.Local).AddTicks(2103) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 8, 47, 543, DateTimeKind.Local).AddTicks(2232), new DateTime(2023, 1, 10, 12, 8, 47, 543, DateTimeKind.Local).AddTicks(2232) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 8, 47, 543, DateTimeKind.Local).AddTicks(2234), new DateTime(2023, 1, 10, 12, 8, 47, 543, DateTimeKind.Local).AddTicks(2234) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 8, 47, 543, DateTimeKind.Local).AddTicks(2235), new DateTime(2023, 1, 10, 12, 8, 47, 543, DateTimeKind.Local).AddTicks(2236) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 8, 47, 543, DateTimeKind.Local).AddTicks(2237), new DateTime(2023, 1, 10, 12, 8, 47, 543, DateTimeKind.Local).AddTicks(2238) });
        }
    }
}
