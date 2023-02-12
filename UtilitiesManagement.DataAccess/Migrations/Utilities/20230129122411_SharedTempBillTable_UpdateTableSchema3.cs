using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class SharedTempBillTable_UpdateTableSchema3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AREA_Id",
                table: "Shar_Bills_Temp");

            migrationBuilder.DropColumn(
                name: "AREA_Name",
                table: "Shar_Bills_Temp");

            migrationBuilder.DropColumn(
                name: "City_Id",
                table: "Shar_Bills_Temp");

            migrationBuilder.DropColumn(
                name: "City_Name",
                table: "Shar_Bills_Temp");

            migrationBuilder.AlterColumn<string>(
                name: "NUMBER_OF_UNITS",
                table: "Shar_Bills_Temp",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LAST_READING",
                table: "Shar_Bills_Temp",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CUST_KEY",
                table: "Shar_Bills_Temp",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CUST_ID",
                table: "Shar_Bills_Temp",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CUSTOMER_NAME",
                table: "Shar_Bills_Temp",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CURRENT_READING",
                table: "Shar_Bills_Temp",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Block_Id",
                table: "Shar_Bills_Temp",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<long>(
                name: "Bill_ID",
                table: "Shar_Bills_Temp",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BRANCH_NAME",
                table: "Shar_Bills_Temp",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<long>(
                name: "BRANCH_Id",
                table: "Shar_Bills_Temp",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BILL_PRINTED_DATE",
                table: "Shar_Bills_Temp",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "BILL_KEY",
                table: "Shar_Bills_Temp",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "BILL_AMOUNT",
                table: "Shar_Bills_Temp",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ASSIGNED_TO",
                table: "Shar_Bills_Temp",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ADDRESS",
                table: "Shar_Bills_Temp",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ACTIVITY_TYPE",
                table: "Shar_Bills_Temp",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Cust_CustomerStatus",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(3693), new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(3697) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(4023), new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(4028) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(4033), new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(4033) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(4037), new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(4042) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(4047), new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(4047) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(4051), new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(4051) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(3069), new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(3116) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(3125), new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(3125) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(3130), new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(3134) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(3134), new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(3139) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(3870), new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(3874) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(3888), new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(3888) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(3893), new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(3898) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(3902), new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(3902) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NUMBER_OF_UNITS",
                table: "Shar_Bills_Temp",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "LAST_READING",
                table: "Shar_Bills_Temp",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "CUST_KEY",
                table: "Shar_Bills_Temp",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "CUST_ID",
                table: "Shar_Bills_Temp",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "CUSTOMER_NAME",
                table: "Shar_Bills_Temp",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "CURRENT_READING",
                table: "Shar_Bills_Temp",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Block_Id",
                table: "Shar_Bills_Temp",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Bill_ID",
                table: "Shar_Bills_Temp",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BRANCH_NAME",
                table: "Shar_Bills_Temp",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "BRANCH_Id",
                table: "Shar_Bills_Temp",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BILL_PRINTED_DATE",
                table: "Shar_Bills_Temp",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "BILL_KEY",
                table: "Shar_Bills_Temp",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "BILL_AMOUNT",
                table: "Shar_Bills_Temp",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "ASSIGNED_TO",
                table: "Shar_Bills_Temp",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "ADDRESS",
                table: "Shar_Bills_Temp",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "ACTIVITY_TYPE",
                table: "Shar_Bills_Temp",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AddColumn<string>(
                name: "AREA_Id",
                table: "Shar_Bills_Temp",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AREA_Name",
                table: "Shar_Bills_Temp",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City_Id",
                table: "Shar_Bills_Temp",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City_Name",
                table: "Shar_Bills_Temp",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Cust_CustomerStatus",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(9345), new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(9526), new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(9526) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(9531), new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(9536) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(9536), new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(9540) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(9540), new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(9540) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(9545), new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(9545) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(8954), new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(8973) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(8977), new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(8982) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(8987), new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(8987) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(8991), new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(8991) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(9419), new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(9419) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(9424), new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(9424) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(9429), new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(9433) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(9433), new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(9438) });
        }
    }
}
