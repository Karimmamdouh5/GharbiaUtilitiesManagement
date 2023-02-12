using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class ChangeStudentActivity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5284), new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5285) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5286), new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5286) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5288), new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5288) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5289), new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5289) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5291), new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5291) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5139), new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5147) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5149), new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5149) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5151), new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5151) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5152), new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5153) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5154), new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5154) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5261), new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5261) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5263), new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5264) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5265), new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5265) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5267), new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5267) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
