using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class AddPrintLogsUpdate22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Bill_PrintLog",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4786), new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4786) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4788), new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4788) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4789), new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4791), new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4793), new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4793) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4606), new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4616) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4618), new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4618) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4621), new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4621) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4623), new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4623) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4628), new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4628) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4759), new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4760) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4762), new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4762) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4764), new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4764) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4765), new DateTime(2022, 9, 6, 0, 11, 13, 668, DateTimeKind.Local).AddTicks(4766) });

            migrationBuilder.CreateIndex(
                name: "IX_Bill_PrintLog_UserId",
                table: "Bill_PrintLog",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_PrintLog_Perm_Users_UserId",
                table: "Bill_PrintLog",
                column: "UserId",
                principalTable: "Perm_Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_PrintLog_Perm_Users_UserId",
                table: "Bill_PrintLog");

            migrationBuilder.DropIndex(
                name: "IX_Bill_PrintLog_UserId",
                table: "Bill_PrintLog");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Bill_PrintLog");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 3, 19, 76, DateTimeKind.Local).AddTicks(1013), new DateTime(2022, 9, 6, 0, 3, 19, 76, DateTimeKind.Local).AddTicks(1014) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 3, 19, 76, DateTimeKind.Local).AddTicks(1016), new DateTime(2022, 9, 6, 0, 3, 19, 76, DateTimeKind.Local).AddTicks(1017) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 3, 19, 76, DateTimeKind.Local).AddTicks(1018), new DateTime(2022, 9, 6, 0, 3, 19, 76, DateTimeKind.Local).AddTicks(1019) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 3, 19, 76, DateTimeKind.Local).AddTicks(1021), new DateTime(2022, 9, 6, 0, 3, 19, 76, DateTimeKind.Local).AddTicks(1021) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 3, 19, 76, DateTimeKind.Local).AddTicks(1023), new DateTime(2022, 9, 6, 0, 3, 19, 76, DateTimeKind.Local).AddTicks(1024) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 3, 19, 76, DateTimeKind.Local).AddTicks(837), new DateTime(2022, 9, 6, 0, 3, 19, 76, DateTimeKind.Local).AddTicks(847) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 3, 19, 76, DateTimeKind.Local).AddTicks(849), new DateTime(2022, 9, 6, 0, 3, 19, 76, DateTimeKind.Local).AddTicks(849) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 3, 19, 76, DateTimeKind.Local).AddTicks(851), new DateTime(2022, 9, 6, 0, 3, 19, 76, DateTimeKind.Local).AddTicks(852) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 3, 19, 76, DateTimeKind.Local).AddTicks(854), new DateTime(2022, 9, 6, 0, 3, 19, 76, DateTimeKind.Local).AddTicks(854) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 3, 19, 76, DateTimeKind.Local).AddTicks(856), new DateTime(2022, 9, 6, 0, 3, 19, 76, DateTimeKind.Local).AddTicks(857) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 3, 19, 76, DateTimeKind.Local).AddTicks(981), new DateTime(2022, 9, 6, 0, 3, 19, 76, DateTimeKind.Local).AddTicks(982) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 3, 19, 76, DateTimeKind.Local).AddTicks(984), new DateTime(2022, 9, 6, 0, 3, 19, 76, DateTimeKind.Local).AddTicks(985) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 3, 19, 76, DateTimeKind.Local).AddTicks(987), new DateTime(2022, 9, 6, 0, 3, 19, 76, DateTimeKind.Local).AddTicks(987) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 3, 19, 76, DateTimeKind.Local).AddTicks(989), new DateTime(2022, 9, 6, 0, 3, 19, 76, DateTimeKind.Local).AddTicks(989) });
        }
    }
}
