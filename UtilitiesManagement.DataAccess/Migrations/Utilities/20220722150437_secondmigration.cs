using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class secondmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IssueName",
                table: "Bill_Issues",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(6)",
                oldMaxLength: 6);

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2974), new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2975) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2977), new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2977) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2979), new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2979) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2981), new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2981) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2983), new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2798), new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2806) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2809), new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2809) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2811), new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2811) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2813), new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2814) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2815), new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2816) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2948), new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2949) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2951), new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2952) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2953), new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2954) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2956), new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2956) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IssueName",
                table: "Bill_Issues",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2635), new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2636) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2638), new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2638) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2640), new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2640) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2642), new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2642) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2644), new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2644) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2469), new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2476) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2478), new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2479) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2480), new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2481) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2482), new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2483) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2484), new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2485) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2611), new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2611) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2614), new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2614) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2616), new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2616) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2618), new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2618) });
        }
    }
}
