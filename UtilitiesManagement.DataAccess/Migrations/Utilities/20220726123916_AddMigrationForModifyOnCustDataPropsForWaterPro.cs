using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class AddMigrationForModifyOnCustDataPropsForWaterPro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActivityStartDate",
                table: "Cust_CustomerData");

            migrationBuilder.DropColumn(
                name: "StartIssueDate",
                table: "Cust_CustomerData");

            migrationBuilder.AlterColumn<string>(
                name: "MeterStartIssue",
                table: "Cust_CustomerData",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "MeterDiameter",
                table: "Cust_CustomerData",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "ActivityStarIssue",
                table: "Cust_CustomerData",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CustomerStartIssue",
                table: "Cust_CustomerData",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2993), new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2993) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2995), new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2996) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2998), new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(3000), new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(3001) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(3003), new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(3003) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2747), new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2759) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2763), new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2763) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2766), new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2766) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2768), new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2769) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2771), new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2771) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2957), new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2961), new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2961) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2963), new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2964) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2966), new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2967) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActivityStarIssue",
                table: "Cust_CustomerData");

            migrationBuilder.DropColumn(
                name: "CustomerStartIssue",
                table: "Cust_CustomerData");

            migrationBuilder.AlterColumn<DateTime>(
                name: "MeterStartIssue",
                table: "Cust_CustomerData",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "MeterDiameter",
                table: "Cust_CustomerData",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "ActivityStartDate",
                table: "Cust_CustomerData",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartIssueDate",
                table: "Cust_CustomerData",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9614), new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9614) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9616), new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9616) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9618), new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9618) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9620), new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9621), new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9622) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9452), new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9459) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9462), new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9462) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9464), new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9464) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9466), new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9467) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9468), new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9468) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9589), new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9592), new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9592) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9594), new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9594) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9596), new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9596) });
        }
    }
}
