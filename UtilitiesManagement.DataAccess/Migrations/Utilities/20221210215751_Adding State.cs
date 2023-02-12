using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class AddingState : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
