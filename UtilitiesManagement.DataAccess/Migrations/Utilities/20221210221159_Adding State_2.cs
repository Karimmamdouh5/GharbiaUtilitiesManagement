using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class AddingState_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7475), new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7475) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7477), new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7477) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7478), new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7479) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7480), new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7481), new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7482) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7307), new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7315) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7340), new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7342), new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7342) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7343), new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7344) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7345), new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7345) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7450), new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7451) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7452), new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7453) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7454), new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7454) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7456), new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7456) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 57, 50, 837, DateTimeKind.Local).AddTicks(6937), new DateTime(2022, 12, 10, 23, 57, 50, 837, DateTimeKind.Local).AddTicks(6938) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 57, 50, 837, DateTimeKind.Local).AddTicks(6939), new DateTime(2022, 12, 10, 23, 57, 50, 837, DateTimeKind.Local).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 57, 50, 837, DateTimeKind.Local).AddTicks(6941), new DateTime(2022, 12, 10, 23, 57, 50, 837, DateTimeKind.Local).AddTicks(6941) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 57, 50, 837, DateTimeKind.Local).AddTicks(6942), new DateTime(2022, 12, 10, 23, 57, 50, 837, DateTimeKind.Local).AddTicks(6943) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 57, 50, 837, DateTimeKind.Local).AddTicks(6944), new DateTime(2022, 12, 10, 23, 57, 50, 837, DateTimeKind.Local).AddTicks(6944) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 57, 50, 837, DateTimeKind.Local).AddTicks(6786), new DateTime(2022, 12, 10, 23, 57, 50, 837, DateTimeKind.Local).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 57, 50, 837, DateTimeKind.Local).AddTicks(6795), new DateTime(2022, 12, 10, 23, 57, 50, 837, DateTimeKind.Local).AddTicks(6796) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 57, 50, 837, DateTimeKind.Local).AddTicks(6797), new DateTime(2022, 12, 10, 23, 57, 50, 837, DateTimeKind.Local).AddTicks(6798) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 57, 50, 837, DateTimeKind.Local).AddTicks(6799), new DateTime(2022, 12, 10, 23, 57, 50, 837, DateTimeKind.Local).AddTicks(6799) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 57, 50, 837, DateTimeKind.Local).AddTicks(6800), new DateTime(2022, 12, 10, 23, 57, 50, 837, DateTimeKind.Local).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 57, 50, 837, DateTimeKind.Local).AddTicks(6915), new DateTime(2022, 12, 10, 23, 57, 50, 837, DateTimeKind.Local).AddTicks(6915) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 57, 50, 837, DateTimeKind.Local).AddTicks(6917), new DateTime(2022, 12, 10, 23, 57, 50, 837, DateTimeKind.Local).AddTicks(6918) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 57, 50, 837, DateTimeKind.Local).AddTicks(6919), new DateTime(2022, 12, 10, 23, 57, 50, 837, DateTimeKind.Local).AddTicks(6919) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 57, 50, 837, DateTimeKind.Local).AddTicks(6920), new DateTime(2022, 12, 10, 23, 57, 50, 837, DateTimeKind.Local).AddTicks(6921) });
        }
    }
}
