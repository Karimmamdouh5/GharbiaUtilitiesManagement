using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class AddPrintLogsUpdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PrintDate",
                table: "Bill_PrintLog",
                newName: "LogDate");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LogDate",
                table: "Bill_PrintLog",
                newName: "PrintDate");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7538), new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7539) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7540), new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7542), new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7542) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7543), new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7544) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7546), new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7547) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7388), new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7398) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7400), new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7400) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7402), new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7402) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7403), new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7404) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7405), new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7405) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7516), new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7517) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7518), new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7519) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7520), new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7520) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7522), new DateTime(2022, 9, 5, 23, 50, 59, 494, DateTimeKind.Local).AddTicks(7522) });
        }
    }
}
