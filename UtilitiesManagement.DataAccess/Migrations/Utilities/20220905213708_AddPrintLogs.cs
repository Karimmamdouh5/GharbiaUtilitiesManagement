using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class AddPrintLogs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsRePrint",
                table: "Bill_Payment",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Bill_PrintLog",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillPayment_Id = table.Column<long>(type: "bigint", nullable: false),
                    Disc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrintDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InsertBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DeleteBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CompanyTenantId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bill_PrintLog", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Bill_PrintLog_Bill_Payment_BillPayment_Id",
                        column: x => x.BillPayment_Id,
                        principalTable: "Bill_Payment",
                        principalColumn: "ID");
                });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3427), new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3428) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3429), new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3429) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3431), new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3431) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3432), new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3433) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3434), new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3434) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3278), new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3292), new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3292) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3293), new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3294) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3295), new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3295) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3296), new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3297) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3403), new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3403) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3406), new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3408), new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3408) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3409), new DateTime(2022, 9, 5, 23, 37, 8, 397, DateTimeKind.Local).AddTicks(3410) });

            migrationBuilder.CreateIndex(
                name: "IX_Bill_PrintLog_BillPayment_Id",
                table: "Bill_PrintLog",
                column: "BillPayment_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bill_PrintLog");

            migrationBuilder.DropColumn(
                name: "IsRePrint",
                table: "Bill_Payment");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1956), new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1960), new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1961) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1964), new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1965) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1968), new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1969) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1971), new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1972) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1639), new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1660) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1665), new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1666) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1669), new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1670) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1672), new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1673) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1676), new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1677) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1907), new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1910) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1913), new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1914) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1917), new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1918) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1922), new DateTime(2022, 9, 1, 16, 10, 27, 216, DateTimeKind.Local).AddTicks(1922) });
        }
    }
}
