using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class DropBillIssueTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 3, 48, 730, DateTimeKind.Local).AddTicks(6682), new DateTime(2022, 12, 21, 16, 3, 48, 730, DateTimeKind.Local).AddTicks(6683) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 3, 48, 730, DateTimeKind.Local).AddTicks(6684), new DateTime(2022, 12, 21, 16, 3, 48, 730, DateTimeKind.Local).AddTicks(6685) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 3, 48, 730, DateTimeKind.Local).AddTicks(6686), new DateTime(2022, 12, 21, 16, 3, 48, 730, DateTimeKind.Local).AddTicks(6686) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 3, 48, 730, DateTimeKind.Local).AddTicks(6687), new DateTime(2022, 12, 21, 16, 3, 48, 730, DateTimeKind.Local).AddTicks(6688) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 3, 48, 730, DateTimeKind.Local).AddTicks(6689), new DateTime(2022, 12, 21, 16, 3, 48, 730, DateTimeKind.Local).AddTicks(6689) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 3, 48, 730, DateTimeKind.Local).AddTicks(6221), new DateTime(2022, 12, 21, 16, 3, 48, 730, DateTimeKind.Local).AddTicks(6411) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 3, 48, 730, DateTimeKind.Local).AddTicks(6413), new DateTime(2022, 12, 21, 16, 3, 48, 730, DateTimeKind.Local).AddTicks(6414) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 3, 48, 730, DateTimeKind.Local).AddTicks(6415), new DateTime(2022, 12, 21, 16, 3, 48, 730, DateTimeKind.Local).AddTicks(6416) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 3, 48, 730, DateTimeKind.Local).AddTicks(6417), new DateTime(2022, 12, 21, 16, 3, 48, 730, DateTimeKind.Local).AddTicks(6417) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 3, 48, 730, DateTimeKind.Local).AddTicks(6419), new DateTime(2022, 12, 21, 16, 3, 48, 730, DateTimeKind.Local).AddTicks(6419) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 3, 48, 730, DateTimeKind.Local).AddTicks(6665), new DateTime(2022, 12, 21, 16, 3, 48, 730, DateTimeKind.Local).AddTicks(6665) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 3, 48, 730, DateTimeKind.Local).AddTicks(6667), new DateTime(2022, 12, 21, 16, 3, 48, 730, DateTimeKind.Local).AddTicks(6667) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 3, 48, 730, DateTimeKind.Local).AddTicks(6669), new DateTime(2022, 12, 21, 16, 3, 48, 730, DateTimeKind.Local).AddTicks(6669) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 3, 48, 730, DateTimeKind.Local).AddTicks(6670), new DateTime(2022, 12, 21, 16, 3, 48, 730, DateTimeKind.Local).AddTicks(6670) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 0, 8, 736, DateTimeKind.Local).AddTicks(5091), new DateTime(2022, 12, 21, 16, 0, 8, 736, DateTimeKind.Local).AddTicks(5091) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 0, 8, 736, DateTimeKind.Local).AddTicks(5093), new DateTime(2022, 12, 21, 16, 0, 8, 736, DateTimeKind.Local).AddTicks(5093) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 0, 8, 736, DateTimeKind.Local).AddTicks(5094), new DateTime(2022, 12, 21, 16, 0, 8, 736, DateTimeKind.Local).AddTicks(5095) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 0, 8, 736, DateTimeKind.Local).AddTicks(5096), new DateTime(2022, 12, 21, 16, 0, 8, 736, DateTimeKind.Local).AddTicks(5096) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 0, 8, 736, DateTimeKind.Local).AddTicks(5097), new DateTime(2022, 12, 21, 16, 0, 8, 736, DateTimeKind.Local).AddTicks(5098) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 0, 8, 736, DateTimeKind.Local).AddTicks(4930), new DateTime(2022, 12, 21, 16, 0, 8, 736, DateTimeKind.Local).AddTicks(4939) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 0, 8, 736, DateTimeKind.Local).AddTicks(4941), new DateTime(2022, 12, 21, 16, 0, 8, 736, DateTimeKind.Local).AddTicks(4942) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 0, 8, 736, DateTimeKind.Local).AddTicks(4943), new DateTime(2022, 12, 21, 16, 0, 8, 736, DateTimeKind.Local).AddTicks(4943) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 0, 8, 736, DateTimeKind.Local).AddTicks(4945), new DateTime(2022, 12, 21, 16, 0, 8, 736, DateTimeKind.Local).AddTicks(4945) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 0, 8, 736, DateTimeKind.Local).AddTicks(4946), new DateTime(2022, 12, 21, 16, 0, 8, 736, DateTimeKind.Local).AddTicks(4947) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 0, 8, 736, DateTimeKind.Local).AddTicks(5068), new DateTime(2022, 12, 21, 16, 0, 8, 736, DateTimeKind.Local).AddTicks(5069) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 0, 8, 736, DateTimeKind.Local).AddTicks(5070), new DateTime(2022, 12, 21, 16, 0, 8, 736, DateTimeKind.Local).AddTicks(5071) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 0, 8, 736, DateTimeKind.Local).AddTicks(5072), new DateTime(2022, 12, 21, 16, 0, 8, 736, DateTimeKind.Local).AddTicks(5072) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 0, 8, 736, DateTimeKind.Local).AddTicks(5074), new DateTime(2022, 12, 21, 16, 0, 8, 736, DateTimeKind.Local).AddTicks(5074) });
        }
    }
}
