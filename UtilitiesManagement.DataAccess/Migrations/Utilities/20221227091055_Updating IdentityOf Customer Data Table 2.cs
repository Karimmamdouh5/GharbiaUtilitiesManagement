using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class UpdatingIdentityOfCustomerDataTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PreviousReadingIssueNumber",
                table: "Cust_CustomerData",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PreviousReading",
                table: "Cust_CustomerData",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MeterStartIssue",
                table: "Cust_CustomerData",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "MeterDiameter",
                table: "Cust_CustomerData",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Cust_CustomerData",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "ActivityStarIssue",
                table: "Cust_CustomerData",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PreviousReadingIssueNumber",
                table: "Cust_CustomerData",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PreviousReading",
                table: "Cust_CustomerData",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MeterStartIssue",
                table: "Cust_CustomerData",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "MeterDiameter",
                table: "Cust_CustomerData",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Cust_CustomerData",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ActivityStarIssue",
                table: "Cust_CustomerData",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

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
    }
}
