using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class changecustprop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MeterChassisNum",
                table: "Cust_CustomerData",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ActualName",
                table: "Cust_CustomerData",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<string>(
                name: "ActualActivity",
                table: "Cust_CustomerData",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(1057), new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(1058) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(1059), new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(1060) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(1062), new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(1062) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(1064), new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(1065) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(1066), new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(1067) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(882), new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(894), new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(894) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(896), new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(896) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(898), new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(899) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(900), new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(901) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(1031), new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(1032) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(1034), new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(1034) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(1036), new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(1036) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(1038), new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(1039) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "MeterChassisNum",
                table: "Cust_CustomerData",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ActualName",
                table: "Cust_CustomerData",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ActualActivity",
                table: "Cust_CustomerData",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8420), new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8421) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8422), new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8423) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8424), new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8424) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8426), new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8426) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8427), new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8428) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8278), new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8288) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8289), new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8290) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8291), new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8292) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8293), new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8293) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8294), new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8295) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8401), new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8402) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8403), new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8404) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8405), new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8406) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8407), new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8407) });
        }
    }
}
