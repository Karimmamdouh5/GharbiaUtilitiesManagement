using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class AddingEmployeeBlocks4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "ID",
                table: "Hr_EmployeeBlocks",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 16, 24, 755, DateTimeKind.Local).AddTicks(6970), new DateTime(2022, 12, 20, 11, 16, 24, 755, DateTimeKind.Local).AddTicks(6970) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 16, 24, 755, DateTimeKind.Local).AddTicks(6972), new DateTime(2022, 12, 20, 11, 16, 24, 755, DateTimeKind.Local).AddTicks(6972) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 16, 24, 755, DateTimeKind.Local).AddTicks(6973), new DateTime(2022, 12, 20, 11, 16, 24, 755, DateTimeKind.Local).AddTicks(6974) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 16, 24, 755, DateTimeKind.Local).AddTicks(6975), new DateTime(2022, 12, 20, 11, 16, 24, 755, DateTimeKind.Local).AddTicks(6975) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 16, 24, 755, DateTimeKind.Local).AddTicks(6977), new DateTime(2022, 12, 20, 11, 16, 24, 755, DateTimeKind.Local).AddTicks(6977) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 16, 24, 755, DateTimeKind.Local).AddTicks(6823), new DateTime(2022, 12, 20, 11, 16, 24, 755, DateTimeKind.Local).AddTicks(6831) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 16, 24, 755, DateTimeKind.Local).AddTicks(6832), new DateTime(2022, 12, 20, 11, 16, 24, 755, DateTimeKind.Local).AddTicks(6833) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 16, 24, 755, DateTimeKind.Local).AddTicks(6834), new DateTime(2022, 12, 20, 11, 16, 24, 755, DateTimeKind.Local).AddTicks(6834) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 16, 24, 755, DateTimeKind.Local).AddTicks(6835), new DateTime(2022, 12, 20, 11, 16, 24, 755, DateTimeKind.Local).AddTicks(6836) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 16, 24, 755, DateTimeKind.Local).AddTicks(6837), new DateTime(2022, 12, 20, 11, 16, 24, 755, DateTimeKind.Local).AddTicks(6837) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 16, 24, 755, DateTimeKind.Local).AddTicks(6950), new DateTime(2022, 12, 20, 11, 16, 24, 755, DateTimeKind.Local).AddTicks(6950) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 16, 24, 755, DateTimeKind.Local).AddTicks(6952), new DateTime(2022, 12, 20, 11, 16, 24, 755, DateTimeKind.Local).AddTicks(6952) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 16, 24, 755, DateTimeKind.Local).AddTicks(6953), new DateTime(2022, 12, 20, 11, 16, 24, 755, DateTimeKind.Local).AddTicks(6954) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 16, 24, 755, DateTimeKind.Local).AddTicks(6955), new DateTime(2022, 12, 20, 11, 16, 24, 755, DateTimeKind.Local).AddTicks(6955) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "ID",
                table: "Hr_EmployeeBlocks",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1472), new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1472) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1474), new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1474) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1498), new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1499) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1500), new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1500) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1502), new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1502) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1324), new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1331) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1333), new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1334) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1335), new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1335) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1337), new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1337) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1338), new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1339) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1452), new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1452) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1454), new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1455) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1456), new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1456) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1458), new DateTime(2022, 12, 20, 10, 52, 44, 455, DateTimeKind.Local).AddTicks(1458) });
        }
    }
}
