using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class UpdatePermMenuTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "ParentId",
                table: "Perm_Menu",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 23, 39, 989, DateTimeKind.Local).AddTicks(6828), new DateTime(2022, 8, 9, 13, 23, 39, 989, DateTimeKind.Local).AddTicks(6828) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 23, 39, 989, DateTimeKind.Local).AddTicks(6829), new DateTime(2022, 8, 9, 13, 23, 39, 989, DateTimeKind.Local).AddTicks(6830) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 23, 39, 989, DateTimeKind.Local).AddTicks(6831), new DateTime(2022, 8, 9, 13, 23, 39, 989, DateTimeKind.Local).AddTicks(6831) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 23, 39, 989, DateTimeKind.Local).AddTicks(6832), new DateTime(2022, 8, 9, 13, 23, 39, 989, DateTimeKind.Local).AddTicks(6833) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 23, 39, 989, DateTimeKind.Local).AddTicks(6834), new DateTime(2022, 8, 9, 13, 23, 39, 989, DateTimeKind.Local).AddTicks(6834) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 23, 39, 989, DateTimeKind.Local).AddTicks(6673), new DateTime(2022, 8, 9, 13, 23, 39, 989, DateTimeKind.Local).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 23, 39, 989, DateTimeKind.Local).AddTicks(6682), new DateTime(2022, 8, 9, 13, 23, 39, 989, DateTimeKind.Local).AddTicks(6682) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 23, 39, 989, DateTimeKind.Local).AddTicks(6684), new DateTime(2022, 8, 9, 13, 23, 39, 989, DateTimeKind.Local).AddTicks(6684) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 23, 39, 989, DateTimeKind.Local).AddTicks(6685), new DateTime(2022, 8, 9, 13, 23, 39, 989, DateTimeKind.Local).AddTicks(6685) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 23, 39, 989, DateTimeKind.Local).AddTicks(6686), new DateTime(2022, 8, 9, 13, 23, 39, 989, DateTimeKind.Local).AddTicks(6687) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 23, 39, 989, DateTimeKind.Local).AddTicks(6807), new DateTime(2022, 8, 9, 13, 23, 39, 989, DateTimeKind.Local).AddTicks(6807) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 23, 39, 989, DateTimeKind.Local).AddTicks(6809), new DateTime(2022, 8, 9, 13, 23, 39, 989, DateTimeKind.Local).AddTicks(6809) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 23, 39, 989, DateTimeKind.Local).AddTicks(6811), new DateTime(2022, 8, 9, 13, 23, 39, 989, DateTimeKind.Local).AddTicks(6811) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 23, 39, 989, DateTimeKind.Local).AddTicks(6812), new DateTime(2022, 8, 9, 13, 23, 39, 989, DateTimeKind.Local).AddTicks(6812) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "ParentId",
                table: "Perm_Menu",
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
                values: new object[] { new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5591), new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5592) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5593), new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5593) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5595), new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5595) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5596), new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5596) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5598), new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5598) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5443), new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5452) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5453), new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5454) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5455), new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5455) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5456), new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5457) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5458), new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5458) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5568), new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5569) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5570), new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5571), new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5572) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5573), new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5573) });
        }
    }
}
