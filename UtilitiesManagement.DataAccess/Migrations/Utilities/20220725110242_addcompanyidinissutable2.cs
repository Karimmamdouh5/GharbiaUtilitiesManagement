using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class addcompanyidinissutable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Company_Id",
                table: "Bill_Issues",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1289), new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1289) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1291), new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1292) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1293), new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1294) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1295), new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1296) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1297), new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1298) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1112), new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1120) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1123), new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1126), new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1126) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1128), new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1128) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1130), new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1130) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1262), new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1262) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1265), new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1265) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1267), new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1267) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1269), new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1270) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Company_Id",
                table: "Bill_Issues",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(5101), new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(5101) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(5103), new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(5104) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(5111), new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(5111) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(5113), new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(5114) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(5115), new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(5116) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(4934), new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(4942) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(4945), new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(4945) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(4947), new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(4947) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(4949), new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(4949) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(4951), new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(4951) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(5072), new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(5073) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(5076), new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(5076) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(5078), new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(5078) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(5080), new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(5080) });
        }
    }
}
