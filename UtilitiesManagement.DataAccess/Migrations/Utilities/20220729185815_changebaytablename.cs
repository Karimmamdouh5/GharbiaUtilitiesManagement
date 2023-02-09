using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class changebaytablename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_BillPayment_Bill_Issues_BillIssue_Id",
                table: "Bill_BillPayment");

            migrationBuilder.DropForeignKey(
                name: "FK_Bill_BillPayment_Cust_CustomerData_Cutomer_Id",
                table: "Bill_BillPayment");

            migrationBuilder.DropForeignKey(
                name: "FK_Bill_PaymentTransactions_Bill_BillPayment_Bill_Id",
                table: "Bill_PaymentTransactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bill_BillPayment",
                table: "Bill_BillPayment");

            migrationBuilder.RenameTable(
                name: "Bill_BillPayment",
                newName: "Bill_BillData");

            migrationBuilder.RenameIndex(
                name: "IX_Bill_BillPayment_Cutomer_Id",
                table: "Bill_BillData",
                newName: "IX_Bill_BillData_Cutomer_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Bill_BillPayment_BillIssue_Id",
                table: "Bill_BillData",
                newName: "IX_Bill_BillData_BillIssue_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bill_BillData",
                table: "Bill_BillData",
                column: "ID");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 29, 20, 58, 15, 129, DateTimeKind.Local).AddTicks(4168), new DateTime(2022, 7, 29, 20, 58, 15, 129, DateTimeKind.Local).AddTicks(4169) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 29, 20, 58, 15, 129, DateTimeKind.Local).AddTicks(4171), new DateTime(2022, 7, 29, 20, 58, 15, 129, DateTimeKind.Local).AddTicks(4171) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 29, 20, 58, 15, 129, DateTimeKind.Local).AddTicks(4173), new DateTime(2022, 7, 29, 20, 58, 15, 129, DateTimeKind.Local).AddTicks(4173) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 29, 20, 58, 15, 129, DateTimeKind.Local).AddTicks(4175), new DateTime(2022, 7, 29, 20, 58, 15, 129, DateTimeKind.Local).AddTicks(4175) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 29, 20, 58, 15, 129, DateTimeKind.Local).AddTicks(4177), new DateTime(2022, 7, 29, 20, 58, 15, 129, DateTimeKind.Local).AddTicks(4177) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 29, 20, 58, 15, 129, DateTimeKind.Local).AddTicks(3997), new DateTime(2022, 7, 29, 20, 58, 15, 129, DateTimeKind.Local).AddTicks(4004) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 29, 20, 58, 15, 129, DateTimeKind.Local).AddTicks(4006), new DateTime(2022, 7, 29, 20, 58, 15, 129, DateTimeKind.Local).AddTicks(4007) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 29, 20, 58, 15, 129, DateTimeKind.Local).AddTicks(4008), new DateTime(2022, 7, 29, 20, 58, 15, 129, DateTimeKind.Local).AddTicks(4009) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 29, 20, 58, 15, 129, DateTimeKind.Local).AddTicks(4010), new DateTime(2022, 7, 29, 20, 58, 15, 129, DateTimeKind.Local).AddTicks(4011) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 29, 20, 58, 15, 129, DateTimeKind.Local).AddTicks(4012), new DateTime(2022, 7, 29, 20, 58, 15, 129, DateTimeKind.Local).AddTicks(4013) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 29, 20, 58, 15, 129, DateTimeKind.Local).AddTicks(4144), new DateTime(2022, 7, 29, 20, 58, 15, 129, DateTimeKind.Local).AddTicks(4145) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 29, 20, 58, 15, 129, DateTimeKind.Local).AddTicks(4147), new DateTime(2022, 7, 29, 20, 58, 15, 129, DateTimeKind.Local).AddTicks(4147) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 29, 20, 58, 15, 129, DateTimeKind.Local).AddTicks(4149), new DateTime(2022, 7, 29, 20, 58, 15, 129, DateTimeKind.Local).AddTicks(4150) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 29, 20, 58, 15, 129, DateTimeKind.Local).AddTicks(4151), new DateTime(2022, 7, 29, 20, 58, 15, 129, DateTimeKind.Local).AddTicks(4152) });

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_BillData_Bill_Issues_BillIssue_Id",
                table: "Bill_BillData",
                column: "BillIssue_Id",
                principalTable: "Bill_Issues",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_BillData_Cust_CustomerData_Cutomer_Id",
                table: "Bill_BillData",
                column: "Cutomer_Id",
                principalTable: "Cust_CustomerData",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_PaymentTransactions_Bill_BillData_Bill_Id",
                table: "Bill_PaymentTransactions",
                column: "Bill_Id",
                principalTable: "Bill_BillData",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_BillData_Bill_Issues_BillIssue_Id",
                table: "Bill_BillData");

            migrationBuilder.DropForeignKey(
                name: "FK_Bill_BillData_Cust_CustomerData_Cutomer_Id",
                table: "Bill_BillData");

            migrationBuilder.DropForeignKey(
                name: "FK_Bill_PaymentTransactions_Bill_BillData_Bill_Id",
                table: "Bill_PaymentTransactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bill_BillData",
                table: "Bill_BillData");

            migrationBuilder.RenameTable(
                name: "Bill_BillData",
                newName: "Bill_BillPayment");

            migrationBuilder.RenameIndex(
                name: "IX_Bill_BillData_Cutomer_Id",
                table: "Bill_BillPayment",
                newName: "IX_Bill_BillPayment_Cutomer_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Bill_BillData_BillIssue_Id",
                table: "Bill_BillPayment",
                newName: "IX_Bill_BillPayment_BillIssue_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bill_BillPayment",
                table: "Bill_BillPayment",
                column: "ID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_BillPayment_Bill_Issues_BillIssue_Id",
                table: "Bill_BillPayment",
                column: "BillIssue_Id",
                principalTable: "Bill_Issues",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_BillPayment_Cust_CustomerData_Cutomer_Id",
                table: "Bill_BillPayment",
                column: "Cutomer_Id",
                principalTable: "Cust_CustomerData",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_PaymentTransactions_Bill_BillPayment_Bill_Id",
                table: "Bill_PaymentTransactions",
                column: "Bill_Id",
                principalTable: "Bill_BillPayment",
                principalColumn: "ID");
        }
    }
}
