using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class addissueidupdatedcustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Issue_Id",
                table: "Opr_UpdatedCustomers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3238), new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3239) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3241), new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3241) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3243), new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3243) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3245), new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3245) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3247), new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3247) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3086), new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3093) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3095), new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3096) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3097), new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3098) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3099), new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3100) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3102), new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3102) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3215), new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3216) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3218), new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3218) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3220), new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3222), new DateTime(2022, 8, 2, 11, 15, 1, 923, DateTimeKind.Local).AddTicks(3223) });

            migrationBuilder.CreateIndex(
                name: "IX_Opr_UpdatedCustomers_Issue_Id",
                table: "Opr_UpdatedCustomers",
                column: "Issue_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Opr_UpdatedCustomers_Bill_Issues_Issue_Id",
                table: "Opr_UpdatedCustomers",
                column: "Issue_Id",
                principalTable: "Bill_Issues",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Opr_UpdatedCustomers_Bill_Issues_Issue_Id",
                table: "Opr_UpdatedCustomers");

            migrationBuilder.DropIndex(
                name: "IX_Opr_UpdatedCustomers_Issue_Id",
                table: "Opr_UpdatedCustomers");

            migrationBuilder.DropColumn(
                name: "Issue_Id",
                table: "Opr_UpdatedCustomers");

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
