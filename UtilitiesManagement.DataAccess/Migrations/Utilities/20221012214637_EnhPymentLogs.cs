using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class EnhPymentLogs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_PayDataLogDetails_Bill_BillData_BillDataId",
                table: "Bill_PayDataLogDetails");

            migrationBuilder.DropIndex(
                name: "IX_Bill_PayDataLogDetails_BillDataId",
                table: "Bill_PayDataLogDetails");

            migrationBuilder.DropColumn(
                name: "BillDataId",
                table: "Bill_PayDataLogDetails");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2607), new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2608) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2609), new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2609) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2611), new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2611) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2613), new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2613) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2614), new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2614) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2466), new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2475) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2477), new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2478) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2479), new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2479) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2480), new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2481) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2482), new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2587), new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2588) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2589), new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2590) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2591), new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2591) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2592), new DateTime(2022, 10, 12, 23, 46, 36, 659, DateTimeKind.Local).AddTicks(2593) });

            migrationBuilder.CreateIndex(
                name: "IX_Bill_PayDataLogDetails_Bill_Id",
                table: "Bill_PayDataLogDetails",
                column: "Bill_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_PayDataLogDetails_Bill_BillData_Bill_Id",
                table: "Bill_PayDataLogDetails",
                column: "Bill_Id",
                principalTable: "Bill_BillData",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_PayDataLogDetails_Bill_BillData_Bill_Id",
                table: "Bill_PayDataLogDetails");

            migrationBuilder.DropIndex(
                name: "IX_Bill_PayDataLogDetails_Bill_Id",
                table: "Bill_PayDataLogDetails");

            migrationBuilder.AddColumn<long>(
                name: "BillDataId",
                table: "Bill_PayDataLogDetails",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3937), new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3938) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3939), new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3940) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3941), new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3941) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3943), new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3943) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3944), new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3945) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3791), new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3804) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3805), new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3806) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3807), new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3808) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3809), new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3809) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3810), new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3811) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3913), new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3914) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3915), new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3916) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3917), new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3917) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3919), new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3919) });

            migrationBuilder.CreateIndex(
                name: "IX_Bill_PayDataLogDetails_BillDataId",
                table: "Bill_PayDataLogDetails",
                column: "BillDataId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_PayDataLogDetails_Bill_BillData_BillDataId",
                table: "Bill_PayDataLogDetails",
                column: "BillDataId",
                principalTable: "Bill_BillData",
                principalColumn: "ID");
        }
    }
}
