using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class TestingCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.UpdateData(
                table: "Cust_CustomerStatus",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 48, 21, 964, DateTimeKind.Local).AddTicks(4901), new DateTime(2022, 12, 27, 10, 48, 21, 964, DateTimeKind.Local).AddTicks(4902) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 48, 21, 964, DateTimeKind.Local).AddTicks(4940), new DateTime(2022, 12, 27, 10, 48, 21, 964, DateTimeKind.Local).AddTicks(4941) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 48, 21, 964, DateTimeKind.Local).AddTicks(4942), new DateTime(2022, 12, 27, 10, 48, 21, 964, DateTimeKind.Local).AddTicks(4942) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 48, 21, 964, DateTimeKind.Local).AddTicks(4943), new DateTime(2022, 12, 27, 10, 48, 21, 964, DateTimeKind.Local).AddTicks(4944) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 48, 21, 964, DateTimeKind.Local).AddTicks(4945), new DateTime(2022, 12, 27, 10, 48, 21, 964, DateTimeKind.Local).AddTicks(4946) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 48, 21, 964, DateTimeKind.Local).AddTicks(4947), new DateTime(2022, 12, 27, 10, 48, 21, 964, DateTimeKind.Local).AddTicks(4947) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 48, 21, 964, DateTimeKind.Local).AddTicks(4759), new DateTime(2022, 12, 27, 10, 48, 21, 964, DateTimeKind.Local).AddTicks(4767) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 48, 21, 964, DateTimeKind.Local).AddTicks(4768), new DateTime(2022, 12, 27, 10, 48, 21, 964, DateTimeKind.Local).AddTicks(4769) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 48, 21, 964, DateTimeKind.Local).AddTicks(4770), new DateTime(2022, 12, 27, 10, 48, 21, 964, DateTimeKind.Local).AddTicks(4771) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 48, 21, 964, DateTimeKind.Local).AddTicks(4772), new DateTime(2022, 12, 27, 10, 48, 21, 964, DateTimeKind.Local).AddTicks(4772) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 48, 21, 964, DateTimeKind.Local).AddTicks(4774), new DateTime(2022, 12, 27, 10, 48, 21, 964, DateTimeKind.Local).AddTicks(4774) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 48, 21, 964, DateTimeKind.Local).AddTicks(4920), new DateTime(2022, 12, 27, 10, 48, 21, 964, DateTimeKind.Local).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 48, 21, 964, DateTimeKind.Local).AddTicks(4922), new DateTime(2022, 12, 27, 10, 48, 21, 964, DateTimeKind.Local).AddTicks(4923) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 48, 21, 964, DateTimeKind.Local).AddTicks(4924), new DateTime(2022, 12, 27, 10, 48, 21, 964, DateTimeKind.Local).AddTicks(4924) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 48, 21, 964, DateTimeKind.Local).AddTicks(4925), new DateTime(2022, 12, 27, 10, 48, 21, 964, DateTimeKind.Local).AddTicks(4926) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.UpdateData(
                table: "Cust_CustomerStatus",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9215), new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9215) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9262), new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9262) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9264), new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9264) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9267), new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9267) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9270), new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9270) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9279), new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9282) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9080), new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9091) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9097), new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9099), new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9100), new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9101) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9102), new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9102) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9232), new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9232) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9235), new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9236) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9237), new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9237) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9239), new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9240) });
        }
    }
}
