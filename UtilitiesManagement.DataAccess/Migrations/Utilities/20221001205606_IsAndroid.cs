using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class IsAndroid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAndroid",
                table: "Perm_Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7378), new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7379) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7380), new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7383), new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7383) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7385), new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7385) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7387), new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7387) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7214), new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7229) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7230), new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7231) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7232), new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7232) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7234), new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7234) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7235), new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7236) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7349), new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7350) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7351), new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7353), new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7354) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7355), new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7355) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAndroid",
                table: "Perm_Users");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 1, 38, 283, DateTimeKind.Local).AddTicks(2878), new DateTime(2022, 10, 1, 22, 1, 38, 283, DateTimeKind.Local).AddTicks(2878) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 1, 38, 283, DateTimeKind.Local).AddTicks(2880), new DateTime(2022, 10, 1, 22, 1, 38, 283, DateTimeKind.Local).AddTicks(2880) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 1, 38, 283, DateTimeKind.Local).AddTicks(2881), new DateTime(2022, 10, 1, 22, 1, 38, 283, DateTimeKind.Local).AddTicks(2882) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 1, 38, 283, DateTimeKind.Local).AddTicks(2883), new DateTime(2022, 10, 1, 22, 1, 38, 283, DateTimeKind.Local).AddTicks(2883) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 1, 38, 283, DateTimeKind.Local).AddTicks(2884), new DateTime(2022, 10, 1, 22, 1, 38, 283, DateTimeKind.Local).AddTicks(2885) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 1, 38, 283, DateTimeKind.Local).AddTicks(2720), new DateTime(2022, 10, 1, 22, 1, 38, 283, DateTimeKind.Local).AddTicks(2732) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 1, 38, 283, DateTimeKind.Local).AddTicks(2734), new DateTime(2022, 10, 1, 22, 1, 38, 283, DateTimeKind.Local).AddTicks(2735) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 1, 38, 283, DateTimeKind.Local).AddTicks(2736), new DateTime(2022, 10, 1, 22, 1, 38, 283, DateTimeKind.Local).AddTicks(2736) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 1, 38, 283, DateTimeKind.Local).AddTicks(2738), new DateTime(2022, 10, 1, 22, 1, 38, 283, DateTimeKind.Local).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 1, 38, 283, DateTimeKind.Local).AddTicks(2740), new DateTime(2022, 10, 1, 22, 1, 38, 283, DateTimeKind.Local).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 1, 38, 283, DateTimeKind.Local).AddTicks(2854), new DateTime(2022, 10, 1, 22, 1, 38, 283, DateTimeKind.Local).AddTicks(2855) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 1, 38, 283, DateTimeKind.Local).AddTicks(2856), new DateTime(2022, 10, 1, 22, 1, 38, 283, DateTimeKind.Local).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 1, 38, 283, DateTimeKind.Local).AddTicks(2858), new DateTime(2022, 10, 1, 22, 1, 38, 283, DateTimeKind.Local).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 1, 38, 283, DateTimeKind.Local).AddTicks(2860), new DateTime(2022, 10, 1, 22, 1, 38, 283, DateTimeKind.Local).AddTicks(2860) });
        }
    }
}
