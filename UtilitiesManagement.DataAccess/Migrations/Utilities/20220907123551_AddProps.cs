using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class AddProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "CurrentReading",
                table: "Bill_BillData",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PrevReading",
                table: "Bill_BillData",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8474), new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8475) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8477), new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8478) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8479), new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8480) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8482), new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8482) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8484), new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8485) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8279), new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8293) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8296), new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8297) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8298), new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8299) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8301), new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8301) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8303), new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8303) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8444), new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8445) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8447), new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8450), new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8450) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8452), new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8453) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentReading",
                table: "Bill_BillData");

            migrationBuilder.DropColumn(
                name: "PrevReading",
                table: "Bill_BillData");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4786), new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4786) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4788), new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4788) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4789), new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4791), new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4793), new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4793) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4606), new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4616) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4618), new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4618) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4621), new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4621) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4623), new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4623) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4628), new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4628) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4759), new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4760) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4762), new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4762) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4764), new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4764) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4765), new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4766) });
        }
    }
}
