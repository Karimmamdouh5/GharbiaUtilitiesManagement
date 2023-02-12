using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class SharBranch_Temp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(5090), new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(5091) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(5092), new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(5092) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(5093), new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(5094) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(5095), new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(5095) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(5096), new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(5097) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(4944), new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(4955) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(4957), new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(4958) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(4959), new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(4959) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(4960), new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(4961) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(4962), new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(4962) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(5069), new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(5070) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(5072), new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(5072) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(5073), new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(5074) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(5075), new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(5075) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(5998), new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(5998) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(6000), new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(6000) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(6001), new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(6002) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(6003), new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(6003) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(6049), new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(6049) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(5835), new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(5845) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(5847), new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(5848) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(5849), new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(5849) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(5851), new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(5851) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(5852), new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(5853) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(5971), new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(5972) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(5973), new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(5974) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(5975), new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(5975) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(5977), new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(5977) });
        }
    }
}
