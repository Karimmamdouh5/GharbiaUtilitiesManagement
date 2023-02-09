using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class changepropname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_BillData_Cust_CustomerData_Cutomer_Id",
                table: "Bill_BillData");

            migrationBuilder.RenameColumn(
                name: "IsPotsed",
                table: "Opr_MeterReadings",
                newName: "IsPosted");

            migrationBuilder.RenameColumn(
                name: "Cutomer_Id",
                table: "Bill_BillData",
                newName: "Customer_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Bill_BillData_Cutomer_Id",
                table: "Bill_BillData",
                newName: "IX_Bill_BillData_Customer_Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_BillData_Cust_CustomerData_Customer_Id",
                table: "Bill_BillData",
                column: "Customer_Id",
                principalTable: "Cust_CustomerData",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_BillData_Cust_CustomerData_Customer_Id",
                table: "Bill_BillData");

            migrationBuilder.RenameColumn(
                name: "IsPosted",
                table: "Opr_MeterReadings",
                newName: "IsPotsed");

            migrationBuilder.RenameColumn(
                name: "Customer_Id",
                table: "Bill_BillData",
                newName: "Cutomer_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Bill_BillData_Customer_Id",
                table: "Bill_BillData",
                newName: "IX_Bill_BillData_Cutomer_Id");

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
                name: "FK_Bill_BillData_Cust_CustomerData_Cutomer_Id",
                table: "Bill_BillData",
                column: "Cutomer_Id",
                principalTable: "Cust_CustomerData",
                principalColumn: "ID");
        }
    }
}
