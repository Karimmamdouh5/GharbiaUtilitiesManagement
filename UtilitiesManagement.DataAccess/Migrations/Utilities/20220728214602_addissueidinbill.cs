using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class addissueidinbill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "BillIssue_Id",
                table: "Bill_BillPayment",
                type: "bigint",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 28, 23, 46, 2, 202, DateTimeKind.Local).AddTicks(2493), new DateTime(2022, 7, 28, 23, 46, 2, 202, DateTimeKind.Local).AddTicks(2494) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 28, 23, 46, 2, 202, DateTimeKind.Local).AddTicks(2496), new DateTime(2022, 7, 28, 23, 46, 2, 202, DateTimeKind.Local).AddTicks(2496) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 28, 23, 46, 2, 202, DateTimeKind.Local).AddTicks(2498), new DateTime(2022, 7, 28, 23, 46, 2, 202, DateTimeKind.Local).AddTicks(2498) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 28, 23, 46, 2, 202, DateTimeKind.Local).AddTicks(2500), new DateTime(2022, 7, 28, 23, 46, 2, 202, DateTimeKind.Local).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 28, 23, 46, 2, 202, DateTimeKind.Local).AddTicks(2502), new DateTime(2022, 7, 28, 23, 46, 2, 202, DateTimeKind.Local).AddTicks(2502) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 28, 23, 46, 2, 202, DateTimeKind.Local).AddTicks(2336), new DateTime(2022, 7, 28, 23, 46, 2, 202, DateTimeKind.Local).AddTicks(2344) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 28, 23, 46, 2, 202, DateTimeKind.Local).AddTicks(2347), new DateTime(2022, 7, 28, 23, 46, 2, 202, DateTimeKind.Local).AddTicks(2347) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 28, 23, 46, 2, 202, DateTimeKind.Local).AddTicks(2349), new DateTime(2022, 7, 28, 23, 46, 2, 202, DateTimeKind.Local).AddTicks(2350) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 28, 23, 46, 2, 202, DateTimeKind.Local).AddTicks(2351), new DateTime(2022, 7, 28, 23, 46, 2, 202, DateTimeKind.Local).AddTicks(2352) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 28, 23, 46, 2, 202, DateTimeKind.Local).AddTicks(2353), new DateTime(2022, 7, 28, 23, 46, 2, 202, DateTimeKind.Local).AddTicks(2354) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 28, 23, 46, 2, 202, DateTimeKind.Local).AddTicks(2471), new DateTime(2022, 7, 28, 23, 46, 2, 202, DateTimeKind.Local).AddTicks(2472) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 28, 23, 46, 2, 202, DateTimeKind.Local).AddTicks(2474), new DateTime(2022, 7, 28, 23, 46, 2, 202, DateTimeKind.Local).AddTicks(2475) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 28, 23, 46, 2, 202, DateTimeKind.Local).AddTicks(2476), new DateTime(2022, 7, 28, 23, 46, 2, 202, DateTimeKind.Local).AddTicks(2477) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 28, 23, 46, 2, 202, DateTimeKind.Local).AddTicks(2478), new DateTime(2022, 7, 28, 23, 46, 2, 202, DateTimeKind.Local).AddTicks(2479) });

            migrationBuilder.CreateIndex(
                name: "IX_Bill_BillPayment_BillIssue_Id",
                table: "Bill_BillPayment",
                column: "BillIssue_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_BillPayment_Bill_Issues_BillIssue_Id",
                table: "Bill_BillPayment",
                column: "BillIssue_Id",
                principalTable: "Bill_Issues",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_BillPayment_Bill_Issues_BillIssue_Id",
                table: "Bill_BillPayment");

            migrationBuilder.DropIndex(
                name: "IX_Bill_BillPayment_BillIssue_Id",
                table: "Bill_BillPayment");

            migrationBuilder.DropColumn(
                name: "BillIssue_Id",
                table: "Bill_BillPayment");

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
    }
}
