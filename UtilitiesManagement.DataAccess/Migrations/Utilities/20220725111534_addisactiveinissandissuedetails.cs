using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class addisactiveinissandissuedetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Bill_Issues",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Bill_IssueDetail",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4825), new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4825) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4827), new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4828) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4829), new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4830) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4831), new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4832) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4833), new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4834) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4644), new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4650) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4652), new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4653) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4655), new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4656) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4657), new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4658) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4659), new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4660) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4797), new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4798) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4800), new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4800) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4802), new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4803) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4805), new DateTime(2022, 7, 25, 13, 15, 34, 303, DateTimeKind.Local).AddTicks(4805) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Bill_Issues");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Bill_IssueDetail");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1289), new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1289) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1291), new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1292) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1293), new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1294) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1295), new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1296) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1297), new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1298) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1112), new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1120) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1123), new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1126), new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1126) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1128), new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1128) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1130), new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1130) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1262), new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1262) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1265), new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1265) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1267), new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1267) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1269), new DateTime(2022, 7, 25, 13, 2, 42, 438, DateTimeKind.Local).AddTicks(1270) });
        }
    }
}
