using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.migrations.utilities
{
    public partial class AddOrderByInPermMenuTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderBy",
                table: "Perm_Menu",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8420), new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8421) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8422), new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8423) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8424), new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8424) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8426), new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8426) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8427), new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8428) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8278), new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8288) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8289), new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8290) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8291), new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8292) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8293), new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8293) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8294), new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8295) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8401), new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8402) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8403), new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8404) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8405), new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8406) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8407), new DateTime(2022, 8, 14, 12, 8, 30, 764, DateTimeKind.Local).AddTicks(8407) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderBy",
                table: "Perm_Menu");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 15, 54, 14, 74, DateTimeKind.Local).AddTicks(3610), new DateTime(2022, 8, 9, 15, 54, 14, 74, DateTimeKind.Local).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 15, 54, 14, 74, DateTimeKind.Local).AddTicks(3612), new DateTime(2022, 8, 9, 15, 54, 14, 74, DateTimeKind.Local).AddTicks(3612) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 15, 54, 14, 74, DateTimeKind.Local).AddTicks(3613), new DateTime(2022, 8, 9, 15, 54, 14, 74, DateTimeKind.Local).AddTicks(3614) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 15, 54, 14, 74, DateTimeKind.Local).AddTicks(3615), new DateTime(2022, 8, 9, 15, 54, 14, 74, DateTimeKind.Local).AddTicks(3615) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 15, 54, 14, 74, DateTimeKind.Local).AddTicks(3617), new DateTime(2022, 8, 9, 15, 54, 14, 74, DateTimeKind.Local).AddTicks(3617) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 15, 54, 14, 74, DateTimeKind.Local).AddTicks(3426), new DateTime(2022, 8, 9, 15, 54, 14, 74, DateTimeKind.Local).AddTicks(3435) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 15, 54, 14, 74, DateTimeKind.Local).AddTicks(3436), new DateTime(2022, 8, 9, 15, 54, 14, 74, DateTimeKind.Local).AddTicks(3437) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 15, 54, 14, 74, DateTimeKind.Local).AddTicks(3438), new DateTime(2022, 8, 9, 15, 54, 14, 74, DateTimeKind.Local).AddTicks(3439) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 15, 54, 14, 74, DateTimeKind.Local).AddTicks(3440), new DateTime(2022, 8, 9, 15, 54, 14, 74, DateTimeKind.Local).AddTicks(3440) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 15, 54, 14, 74, DateTimeKind.Local).AddTicks(3481), new DateTime(2022, 8, 9, 15, 54, 14, 74, DateTimeKind.Local).AddTicks(3481) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 15, 54, 14, 74, DateTimeKind.Local).AddTicks(3588), new DateTime(2022, 8, 9, 15, 54, 14, 74, DateTimeKind.Local).AddTicks(3588) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 15, 54, 14, 74, DateTimeKind.Local).AddTicks(3590), new DateTime(2022, 8, 9, 15, 54, 14, 74, DateTimeKind.Local).AddTicks(3590) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 15, 54, 14, 74, DateTimeKind.Local).AddTicks(3592), new DateTime(2022, 8, 9, 15, 54, 14, 74, DateTimeKind.Local).AddTicks(3592) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 15, 54, 14, 74, DateTimeKind.Local).AddTicks(3593), new DateTime(2022, 8, 9, 15, 54, 14, 74, DateTimeKind.Local).AddTicks(3594) });
        }
    }
}
