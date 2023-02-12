using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class AddingBlock2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BlockCode",
                table: "Shar_Blocks",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7977), new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7978) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7979), new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7980) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(8011), new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(8013), new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(8013) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(8014), new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(8015) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7834), new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7842) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7843), new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7844) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7845), new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7845) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7847), new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7847) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7848), new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7849) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7955), new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7956) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7958), new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7958) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7960), new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7960) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7961), new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7962) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BlockCode",
                table: "Shar_Blocks",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(3074), new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(3075) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(3076), new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(3077) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(3078), new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(3078) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(3080), new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(3081), new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(3082) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(2907), new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(2917) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(2918), new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(2920), new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(2922), new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(2922) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(2923), new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(3048), new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(3049) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(3051), new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(3051) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(3053), new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(3053) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(3054), new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(3055) });
        }
    }
}
