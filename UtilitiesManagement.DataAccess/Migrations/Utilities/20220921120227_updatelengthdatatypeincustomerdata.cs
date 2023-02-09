using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class updatelengthdatatypeincustomerdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PreviousReadingIssueNumber",
                table: "Cust_CustomerData",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PreviousReading",
                table: "Cust_CustomerData",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cust_CustomerData",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MeterStartIssue",
                table: "Cust_CustomerData",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MeterDiameter",
                table: "Cust_CustomerData",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerStartIssue",
                table: "Cust_CustomerData",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Cust_CustomerData",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "ActualName",
                table: "Cust_CustomerData",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ActivityStarIssue",
                table: "Cust_CustomerData",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8177), new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8177) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8179), new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8179) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8181), new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8181) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8182), new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8183) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8184), new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8185) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8024), new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8031) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8033), new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8034) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8035), new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8036) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8037), new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8037) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8039), new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8039) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8152), new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8153) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8154), new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8155) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8156), new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8157) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8158), new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8158) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PreviousReadingIssueNumber",
                table: "Cust_CustomerData",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PreviousReading",
                table: "Cust_CustomerData",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cust_CustomerData",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MeterStartIssue",
                table: "Cust_CustomerData",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "MeterDiameter",
                table: "Cust_CustomerData",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerStartIssue",
                table: "Cust_CustomerData",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Cust_CustomerData",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "ActualName",
                table: "Cust_CustomerData",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ActivityStarIssue",
                table: "Cust_CustomerData",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(601), new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(602) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(603), new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(604) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(606), new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(606) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(608), new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(608) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(610), new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(610) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(359), new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(368) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(371), new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(371) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(373), new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(373) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(375), new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(376) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(378), new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(378) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(519), new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(522), new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(522) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(576), new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(577) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(578), new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(579) });
        }
    }
}
