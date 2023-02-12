using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class addressforcustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Cust_CustomerData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(601), new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(602) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(603), new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(604) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(606), new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(606) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(608), new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(608) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(610), new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(610) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(359), new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(368) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(371), new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(371) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(373), new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(373) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(375), new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(376) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(378), new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(378) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(519), new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(522), new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(522) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(576), new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(577) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(578), new DateTime(2022, 9, 21, 11, 37, 13, 382, DateTimeKind.Local).AddTicks(579) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Cust_CustomerData");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(391), new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(392) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(393), new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(393) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(395), new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(395) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(396), new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(397) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(398), new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(398) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(252), new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(261) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(262), new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(263) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(264), new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(265) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(266), new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(266) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(267), new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(268) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(372), new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(374), new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(374) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(376), new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(376) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(378), new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(378) });
        }
    }
}
