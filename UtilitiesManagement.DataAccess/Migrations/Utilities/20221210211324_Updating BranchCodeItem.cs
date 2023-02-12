using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class UpdatingBranchCodeItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BranchCode",
                table: "Shar_Branches",
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
                values: new object[] { new DateTime(2022, 12, 10, 23, 13, 23, 912, DateTimeKind.Local).AddTicks(3936), new DateTime(2022, 12, 10, 23, 13, 23, 912, DateTimeKind.Local).AddTicks(3937) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 13, 23, 912, DateTimeKind.Local).AddTicks(3938), new DateTime(2022, 12, 10, 23, 13, 23, 912, DateTimeKind.Local).AddTicks(3939) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 13, 23, 912, DateTimeKind.Local).AddTicks(3940), new DateTime(2022, 12, 10, 23, 13, 23, 912, DateTimeKind.Local).AddTicks(3940) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 13, 23, 912, DateTimeKind.Local).AddTicks(3941), new DateTime(2022, 12, 10, 23, 13, 23, 912, DateTimeKind.Local).AddTicks(3941) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 13, 23, 912, DateTimeKind.Local).AddTicks(3942), new DateTime(2022, 12, 10, 23, 13, 23, 912, DateTimeKind.Local).AddTicks(3943) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 13, 23, 912, DateTimeKind.Local).AddTicks(3790), new DateTime(2022, 12, 10, 23, 13, 23, 912, DateTimeKind.Local).AddTicks(3798) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 13, 23, 912, DateTimeKind.Local).AddTicks(3800), new DateTime(2022, 12, 10, 23, 13, 23, 912, DateTimeKind.Local).AddTicks(3800) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 13, 23, 912, DateTimeKind.Local).AddTicks(3801), new DateTime(2022, 12, 10, 23, 13, 23, 912, DateTimeKind.Local).AddTicks(3802) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 13, 23, 912, DateTimeKind.Local).AddTicks(3803), new DateTime(2022, 12, 10, 23, 13, 23, 912, DateTimeKind.Local).AddTicks(3803) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 13, 23, 912, DateTimeKind.Local).AddTicks(3804), new DateTime(2022, 12, 10, 23, 13, 23, 912, DateTimeKind.Local).AddTicks(3804) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 13, 23, 912, DateTimeKind.Local).AddTicks(3913), new DateTime(2022, 12, 10, 23, 13, 23, 912, DateTimeKind.Local).AddTicks(3913) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 13, 23, 912, DateTimeKind.Local).AddTicks(3915), new DateTime(2022, 12, 10, 23, 13, 23, 912, DateTimeKind.Local).AddTicks(3916) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 13, 23, 912, DateTimeKind.Local).AddTicks(3917), new DateTime(2022, 12, 10, 23, 13, 23, 912, DateTimeKind.Local).AddTicks(3917) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 13, 23, 912, DateTimeKind.Local).AddTicks(3919), new DateTime(2022, 12, 10, 23, 13, 23, 912, DateTimeKind.Local).AddTicks(3919) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BranchCode",
                table: "Shar_Branches",
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
                values: new object[] { new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4379), new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4379) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4381), new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4381) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4382), new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4383) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4384), new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4384) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4385), new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4385) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4250), new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4258) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4260), new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4261) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4262), new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4262) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4263), new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4264) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4265), new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4265) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4357), new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4358) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4359), new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4360) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4361), new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4361) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4362), new DateTime(2022, 12, 10, 22, 37, 27, 452, DateTimeKind.Local).AddTicks(4363) });
        }
    }
}
