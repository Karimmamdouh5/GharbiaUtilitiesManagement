using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class notesinmeterreadingoptional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "OperationUserId",
                table: "Opr_MeterReadings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Opr_MeterReadings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 28, 1, 1, 45, 543, DateTimeKind.Local).AddTicks(3553), new DateTime(2022, 7, 28, 1, 1, 45, 543, DateTimeKind.Local).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 28, 1, 1, 45, 543, DateTimeKind.Local).AddTicks(3555), new DateTime(2022, 7, 28, 1, 1, 45, 543, DateTimeKind.Local).AddTicks(3555) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 28, 1, 1, 45, 543, DateTimeKind.Local).AddTicks(3557), new DateTime(2022, 7, 28, 1, 1, 45, 543, DateTimeKind.Local).AddTicks(3557) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 28, 1, 1, 45, 543, DateTimeKind.Local).AddTicks(3558), new DateTime(2022, 7, 28, 1, 1, 45, 543, DateTimeKind.Local).AddTicks(3559) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 28, 1, 1, 45, 543, DateTimeKind.Local).AddTicks(3560), new DateTime(2022, 7, 28, 1, 1, 45, 543, DateTimeKind.Local).AddTicks(3561) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 28, 1, 1, 45, 543, DateTimeKind.Local).AddTicks(3400), new DateTime(2022, 7, 28, 1, 1, 45, 543, DateTimeKind.Local).AddTicks(3407) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 28, 1, 1, 45, 543, DateTimeKind.Local).AddTicks(3408), new DateTime(2022, 7, 28, 1, 1, 45, 543, DateTimeKind.Local).AddTicks(3409) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 28, 1, 1, 45, 543, DateTimeKind.Local).AddTicks(3410), new DateTime(2022, 7, 28, 1, 1, 45, 543, DateTimeKind.Local).AddTicks(3411) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 28, 1, 1, 45, 543, DateTimeKind.Local).AddTicks(3412), new DateTime(2022, 7, 28, 1, 1, 45, 543, DateTimeKind.Local).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 28, 1, 1, 45, 543, DateTimeKind.Local).AddTicks(3414), new DateTime(2022, 7, 28, 1, 1, 45, 543, DateTimeKind.Local).AddTicks(3415) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 28, 1, 1, 45, 543, DateTimeKind.Local).AddTicks(3530), new DateTime(2022, 7, 28, 1, 1, 45, 543, DateTimeKind.Local).AddTicks(3531) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 28, 1, 1, 45, 543, DateTimeKind.Local).AddTicks(3532), new DateTime(2022, 7, 28, 1, 1, 45, 543, DateTimeKind.Local).AddTicks(3533) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 28, 1, 1, 45, 543, DateTimeKind.Local).AddTicks(3534), new DateTime(2022, 7, 28, 1, 1, 45, 543, DateTimeKind.Local).AddTicks(3535) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 28, 1, 1, 45, 543, DateTimeKind.Local).AddTicks(3537), new DateTime(2022, 7, 28, 1, 1, 45, 543, DateTimeKind.Local).AddTicks(3537) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "OperationUserId",
                table: "Opr_MeterReadings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Opr_MeterReadings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7277), new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7278) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7279), new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7281), new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7282) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7283), new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7283) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7285), new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7286) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7132), new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7140) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7142), new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7142) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7144), new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7145) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7146), new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7147) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7148), new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7148) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7251), new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7252) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7254), new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7255) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7257), new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7257) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7259), new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7260) });
        }
    }
}
