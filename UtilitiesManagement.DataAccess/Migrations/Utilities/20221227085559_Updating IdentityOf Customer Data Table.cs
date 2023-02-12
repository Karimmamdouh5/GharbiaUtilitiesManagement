using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class UpdatingIdentityOfCustomerDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.UpdateData(
                table: "Cust_CustomerStatus",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 55, 59, 144, DateTimeKind.Local).AddTicks(6645), new DateTime(2022, 12, 27, 10, 55, 59, 144, DateTimeKind.Local).AddTicks(6646) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 55, 59, 144, DateTimeKind.Local).AddTicks(6714), new DateTime(2022, 12, 27, 10, 55, 59, 144, DateTimeKind.Local).AddTicks(6715) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 55, 59, 144, DateTimeKind.Local).AddTicks(6716), new DateTime(2022, 12, 27, 10, 55, 59, 144, DateTimeKind.Local).AddTicks(6716) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 55, 59, 144, DateTimeKind.Local).AddTicks(6718), new DateTime(2022, 12, 27, 10, 55, 59, 144, DateTimeKind.Local).AddTicks(6718) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 55, 59, 144, DateTimeKind.Local).AddTicks(6719), new DateTime(2022, 12, 27, 10, 55, 59, 144, DateTimeKind.Local).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 55, 59, 144, DateTimeKind.Local).AddTicks(6729), new DateTime(2022, 12, 27, 10, 55, 59, 144, DateTimeKind.Local).AddTicks(6732) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 55, 59, 144, DateTimeKind.Local).AddTicks(6515), new DateTime(2022, 12, 27, 10, 55, 59, 144, DateTimeKind.Local).AddTicks(6525) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 55, 59, 144, DateTimeKind.Local).AddTicks(6527), new DateTime(2022, 12, 27, 10, 55, 59, 144, DateTimeKind.Local).AddTicks(6530) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 55, 59, 144, DateTimeKind.Local).AddTicks(6531), new DateTime(2022, 12, 27, 10, 55, 59, 144, DateTimeKind.Local).AddTicks(6532) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 55, 59, 144, DateTimeKind.Local).AddTicks(6534), new DateTime(2022, 12, 27, 10, 55, 59, 144, DateTimeKind.Local).AddTicks(6535) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 55, 59, 144, DateTimeKind.Local).AddTicks(6536), new DateTime(2022, 12, 27, 10, 55, 59, 144, DateTimeKind.Local).AddTicks(6537) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 55, 59, 144, DateTimeKind.Local).AddTicks(6662), new DateTime(2022, 12, 27, 10, 55, 59, 144, DateTimeKind.Local).AddTicks(6663) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 55, 59, 144, DateTimeKind.Local).AddTicks(6688), new DateTime(2022, 12, 27, 10, 55, 59, 144, DateTimeKind.Local).AddTicks(6688) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 55, 59, 144, DateTimeKind.Local).AddTicks(6690), new DateTime(2022, 12, 27, 10, 55, 59, 144, DateTimeKind.Local).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 55, 59, 144, DateTimeKind.Local).AddTicks(6692), new DateTime(2022, 12, 27, 10, 55, 59, 144, DateTimeKind.Local).AddTicks(6692) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
