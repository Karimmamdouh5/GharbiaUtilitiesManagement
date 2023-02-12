using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class UpdatingAreaCodeItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AreaCode",
                table: "Shar_Areas",
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
                values: new object[] { new DateTime(2022, 12, 10, 23, 31, 55, 238, DateTimeKind.Local).AddTicks(7669), new DateTime(2022, 12, 10, 23, 31, 55, 238, DateTimeKind.Local).AddTicks(7669) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 31, 55, 238, DateTimeKind.Local).AddTicks(7670), new DateTime(2022, 12, 10, 23, 31, 55, 238, DateTimeKind.Local).AddTicks(7671) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 31, 55, 238, DateTimeKind.Local).AddTicks(7672), new DateTime(2022, 12, 10, 23, 31, 55, 238, DateTimeKind.Local).AddTicks(7672) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 31, 55, 238, DateTimeKind.Local).AddTicks(7673), new DateTime(2022, 12, 10, 23, 31, 55, 238, DateTimeKind.Local).AddTicks(7674) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 31, 55, 238, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 12, 10, 23, 31, 55, 238, DateTimeKind.Local).AddTicks(7676) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 31, 55, 238, DateTimeKind.Local).AddTicks(7521), new DateTime(2022, 12, 10, 23, 31, 55, 238, DateTimeKind.Local).AddTicks(7529) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 31, 55, 238, DateTimeKind.Local).AddTicks(7531), new DateTime(2022, 12, 10, 23, 31, 55, 238, DateTimeKind.Local).AddTicks(7531) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 31, 55, 238, DateTimeKind.Local).AddTicks(7532), new DateTime(2022, 12, 10, 23, 31, 55, 238, DateTimeKind.Local).AddTicks(7533) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 31, 55, 238, DateTimeKind.Local).AddTicks(7534), new DateTime(2022, 12, 10, 23, 31, 55, 238, DateTimeKind.Local).AddTicks(7534) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 31, 55, 238, DateTimeKind.Local).AddTicks(7536), new DateTime(2022, 12, 10, 23, 31, 55, 238, DateTimeKind.Local).AddTicks(7536) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 31, 55, 238, DateTimeKind.Local).AddTicks(7644), new DateTime(2022, 12, 10, 23, 31, 55, 238, DateTimeKind.Local).AddTicks(7645) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 31, 55, 238, DateTimeKind.Local).AddTicks(7646), new DateTime(2022, 12, 10, 23, 31, 55, 238, DateTimeKind.Local).AddTicks(7647) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 31, 55, 238, DateTimeKind.Local).AddTicks(7648), new DateTime(2022, 12, 10, 23, 31, 55, 238, DateTimeKind.Local).AddTicks(7649) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 31, 55, 238, DateTimeKind.Local).AddTicks(7650), new DateTime(2022, 12, 10, 23, 31, 55, 238, DateTimeKind.Local).AddTicks(7650) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AreaCode",
                table: "Shar_Areas",
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
    }
}
