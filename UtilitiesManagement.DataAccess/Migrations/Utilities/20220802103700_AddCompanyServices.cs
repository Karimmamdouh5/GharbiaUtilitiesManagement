using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class AddCompanyServices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyServiceName",
                table: "Shar_Company",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 12, 37, 0, 166, DateTimeKind.Local).AddTicks(5771), new DateTime(2022, 8, 2, 12, 37, 0, 166, DateTimeKind.Local).AddTicks(5772) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 12, 37, 0, 166, DateTimeKind.Local).AddTicks(5773), new DateTime(2022, 8, 2, 12, 37, 0, 166, DateTimeKind.Local).AddTicks(5773) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 12, 37, 0, 166, DateTimeKind.Local).AddTicks(5775), new DateTime(2022, 8, 2, 12, 37, 0, 166, DateTimeKind.Local).AddTicks(5775) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 12, 37, 0, 166, DateTimeKind.Local).AddTicks(5776), new DateTime(2022, 8, 2, 12, 37, 0, 166, DateTimeKind.Local).AddTicks(5776) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 12, 37, 0, 166, DateTimeKind.Local).AddTicks(5778), new DateTime(2022, 8, 2, 12, 37, 0, 166, DateTimeKind.Local).AddTicks(5778) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 12, 37, 0, 166, DateTimeKind.Local).AddTicks(5643), new DateTime(2022, 8, 2, 12, 37, 0, 166, DateTimeKind.Local).AddTicks(5651) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 12, 37, 0, 166, DateTimeKind.Local).AddTicks(5653), new DateTime(2022, 8, 2, 12, 37, 0, 166, DateTimeKind.Local).AddTicks(5653) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 12, 37, 0, 166, DateTimeKind.Local).AddTicks(5654), new DateTime(2022, 8, 2, 12, 37, 0, 166, DateTimeKind.Local).AddTicks(5655) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 12, 37, 0, 166, DateTimeKind.Local).AddTicks(5656), new DateTime(2022, 8, 2, 12, 37, 0, 166, DateTimeKind.Local).AddTicks(5656) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 12, 37, 0, 166, DateTimeKind.Local).AddTicks(5657), new DateTime(2022, 8, 2, 12, 37, 0, 166, DateTimeKind.Local).AddTicks(5657) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 12, 37, 0, 166, DateTimeKind.Local).AddTicks(5748), new DateTime(2022, 8, 2, 12, 37, 0, 166, DateTimeKind.Local).AddTicks(5748) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 12, 37, 0, 166, DateTimeKind.Local).AddTicks(5750), new DateTime(2022, 8, 2, 12, 37, 0, 166, DateTimeKind.Local).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 12, 37, 0, 166, DateTimeKind.Local).AddTicks(5751), new DateTime(2022, 8, 2, 12, 37, 0, 166, DateTimeKind.Local).AddTicks(5752) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 12, 37, 0, 166, DateTimeKind.Local).AddTicks(5753), new DateTime(2022, 8, 2, 12, 37, 0, 166, DateTimeKind.Local).AddTicks(5753) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyServiceName",
                table: "Shar_Company");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 31, 10, 16, 48, 876, DateTimeKind.Local).AddTicks(3856), new DateTime(2022, 7, 31, 10, 16, 48, 876, DateTimeKind.Local).AddTicks(3858) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 31, 10, 16, 48, 876, DateTimeKind.Local).AddTicks(3865), new DateTime(2022, 7, 31, 10, 16, 48, 876, DateTimeKind.Local).AddTicks(3867) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 31, 10, 16, 48, 876, DateTimeKind.Local).AddTicks(3873), new DateTime(2022, 7, 31, 10, 16, 48, 876, DateTimeKind.Local).AddTicks(3875) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 31, 10, 16, 48, 876, DateTimeKind.Local).AddTicks(3881), new DateTime(2022, 7, 31, 10, 16, 48, 876, DateTimeKind.Local).AddTicks(3883) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 31, 10, 16, 48, 876, DateTimeKind.Local).AddTicks(3890), new DateTime(2022, 7, 31, 10, 16, 48, 876, DateTimeKind.Local).AddTicks(3892) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 31, 10, 16, 48, 876, DateTimeKind.Local).AddTicks(3192), new DateTime(2022, 7, 31, 10, 16, 48, 876, DateTimeKind.Local).AddTicks(3208) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 31, 10, 16, 48, 876, DateTimeKind.Local).AddTicks(3211), new DateTime(2022, 7, 31, 10, 16, 48, 876, DateTimeKind.Local).AddTicks(3212) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 31, 10, 16, 48, 876, DateTimeKind.Local).AddTicks(3215), new DateTime(2022, 7, 31, 10, 16, 48, 876, DateTimeKind.Local).AddTicks(3216) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 31, 10, 16, 48, 876, DateTimeKind.Local).AddTicks(3220), new DateTime(2022, 7, 31, 10, 16, 48, 876, DateTimeKind.Local).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 31, 10, 16, 48, 876, DateTimeKind.Local).AddTicks(3223), new DateTime(2022, 7, 31, 10, 16, 48, 876, DateTimeKind.Local).AddTicks(3224) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 31, 10, 16, 48, 876, DateTimeKind.Local).AddTicks(3585), new DateTime(2022, 7, 31, 10, 16, 48, 876, DateTimeKind.Local).AddTicks(3587) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 31, 10, 16, 48, 876, DateTimeKind.Local).AddTicks(3593), new DateTime(2022, 7, 31, 10, 16, 48, 876, DateTimeKind.Local).AddTicks(3595) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 31, 10, 16, 48, 876, DateTimeKind.Local).AddTicks(3600), new DateTime(2022, 7, 31, 10, 16, 48, 876, DateTimeKind.Local).AddTicks(3602) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 31, 10, 16, 48, 876, DateTimeKind.Local).AddTicks(3607), new DateTime(2022, 7, 31, 10, 16, 48, 876, DateTimeKind.Local).AddTicks(3609) });
        }
    }
}
