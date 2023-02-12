using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class UpdatingIdentityOfCustomerDataTable4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.UpdateData(
                table: "Cust_CustomerStatus",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7765), new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7768) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7873), new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7875) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7880), new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7881) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7885), new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7890), new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7891) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7922), new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7929) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7402), new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7423) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7430), new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7431) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7435), new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7437) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7440), new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7442) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7446), new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7447) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7807), new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7809) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7814), new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7815) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7820), new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7821) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7825), new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7827) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
