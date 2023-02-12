using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class addbaseentityinbills : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyTenantId",
                table: "Bill_BillData",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeleteBy",
                table: "Bill_BillData",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "Bill_BillData",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsertBy",
                table: "Bill_BillData",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                table: "Bill_BillData",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Bill_BillData",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "Bill_BillData",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Bill_BillData",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1644), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1644) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1646), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1649), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1650) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1651), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1652) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1654), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1654) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1430), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1442) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1444), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1445) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1447), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1448) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1450), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1450) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1452), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1453) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1595), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1599), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1599) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1605), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1608), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1608) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyTenantId",
                table: "Bill_BillData");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "Bill_BillData");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "Bill_BillData");

            migrationBuilder.DropColumn(
                name: "InsertBy",
                table: "Bill_BillData");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                table: "Bill_BillData");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Bill_BillData");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "Bill_BillData");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Bill_BillData");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3238), new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3239) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3241), new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3241) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3243), new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3243) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3245), new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3245) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3247), new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3247) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3086), new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3093) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3095), new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3096) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3097), new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3098) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3099), new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3100) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3102), new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3102) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3215), new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3216) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3218), new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3218) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3220), new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3222), new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3223) });
        }
    }
}
