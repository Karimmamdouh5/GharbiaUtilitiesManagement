using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class SeedingMeterStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040);

            migrationBuilder.DeleteData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131);

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

            migrationBuilder.InsertData(
                table: "Opr_MeterStatus",
                columns: new[] { "ID", "CompanyTenantId", "DeleteBy", "DeleteDate", "InsertBy", "InsertDate", "IsDeleted", "Name", "UpdateBy", "UpdateDate" },
                values: new object[,]
                {
                    { 15, null, null, null, null, new DateTime(2023, 1, 10, 12, 8, 47, 543, DateTimeKind.Local).AddTicks(2089), false, "متعذر", null, new DateTime(2023, 1, 10, 12, 8, 47, 543, DateTimeKind.Local).AddTicks(2098) },
                    { 16, null, null, null, null, new DateTime(2023, 1, 10, 12, 8, 47, 543, DateTimeKind.Local).AddTicks(2101), false, "غير مقروء", null, new DateTime(2023, 1, 10, 12, 8, 47, 543, DateTimeKind.Local).AddTicks(2101) },
                    { 17, null, null, null, null, new DateTime(2023, 1, 10, 12, 8, 47, 543, DateTimeKind.Local).AddTicks(2102), false, "تقديرية", null, new DateTime(2023, 1, 10, 12, 8, 47, 543, DateTimeKind.Local).AddTicks(2103) }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.UpdateData(
                table: "Cust_CustomerStatus",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6369), new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6448), new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6449) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6450), new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6451) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6452), new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6452) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6453), new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6453) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6465), new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6468) });

            migrationBuilder.InsertData(
                table: "Opr_MeterStatus",
                columns: new[] { "ID", "CompanyTenantId", "DeleteBy", "DeleteDate", "InsertBy", "InsertDate", "IsDeleted", "Name", "UpdateBy", "UpdateDate" },
                values: new object[,]
                {
                    { 12, null, null, null, null, new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6255), false, "متعذر", null, new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6264) },
                    { 13, null, null, null, null, new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6265), false, "معطل", null, new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6266) },
                    { 14, null, null, null, null, new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6267), false, "صالح", null, new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6267) },
                    { 10040, null, null, null, null, new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6269), false, "مغشى", null, new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6269) },
                    { 20131, null, null, null, null, new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6270), false, "انتظار", null, new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6271) }
                });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6385), new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6385) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6387), new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6387) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6424), new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6425) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6426), new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6426) });
        }
    }
}
