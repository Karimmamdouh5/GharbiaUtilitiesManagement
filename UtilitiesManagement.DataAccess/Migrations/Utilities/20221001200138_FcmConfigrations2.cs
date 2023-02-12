using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class FcmConfigrations2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PublicKey",
                table: "Noti_FcmConfig",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SenderId",
                table: "Noti_FcmConfig",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ServerKey",
                table: "Noti_FcmConfig",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublicKey",
                table: "Noti_FcmConfig");

            migrationBuilder.DropColumn(
                name: "SenderId",
                table: "Noti_FcmConfig");

            migrationBuilder.DropColumn(
                name: "ServerKey",
                table: "Noti_FcmConfig");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7637), new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7638) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7639), new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7641), new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7642) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7643), new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7643) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7644), new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7645) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7462), new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7472), new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7473) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7474), new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7474) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7476), new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7476) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7477), new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7478) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7613), new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7614) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7616), new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7616) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7617), new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7618) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7619), new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7620) });
        }
    }
}
