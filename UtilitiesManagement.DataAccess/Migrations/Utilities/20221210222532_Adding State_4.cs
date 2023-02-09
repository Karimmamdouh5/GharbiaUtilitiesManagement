using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class AddingState_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StateCode",
                table: "Shar_States",
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
                values: new object[] { new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4574), new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4575) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4577), new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4577) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4579), new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4579) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4580), new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4581) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4582), new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4582) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4418), new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4427) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4429), new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4429) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4431), new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4431) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4433), new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4433) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4434), new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4435) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4547), new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4548) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4550), new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4550) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4552), new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4552) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4553), new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4554) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StateCode",
                table: "Shar_States",
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
                values: new object[] { new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(3052), new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(3052) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(3054), new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(3054) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(3055), new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(3056) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(3057), new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(3057) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(3058), new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(3059) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(2906), new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(2914) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(2916), new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(2916) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(2917), new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(2918) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(2919), new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(2920), new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(2921) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(3026), new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(3027) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(3029), new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(3029) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(3030), new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(3031) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(3032), new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(3032) });
        }
    }
}
