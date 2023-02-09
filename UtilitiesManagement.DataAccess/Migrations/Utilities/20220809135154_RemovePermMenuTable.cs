using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.migrations.utilities
{
    public partial class RemovePermMenuTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Perm_Menu");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 15, 51, 54, 282, DateTimeKind.Local).AddTicks(6290), new DateTime(2022, 8, 9, 15, 51, 54, 282, DateTimeKind.Local).AddTicks(6290) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 15, 51, 54, 282, DateTimeKind.Local).AddTicks(6291), new DateTime(2022, 8, 9, 15, 51, 54, 282, DateTimeKind.Local).AddTicks(6292) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 15, 51, 54, 282, DateTimeKind.Local).AddTicks(6295), new DateTime(2022, 8, 9, 15, 51, 54, 282, DateTimeKind.Local).AddTicks(6295) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 15, 51, 54, 282, DateTimeKind.Local).AddTicks(6296), new DateTime(2022, 8, 9, 15, 51, 54, 282, DateTimeKind.Local).AddTicks(6297) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 15, 51, 54, 282, DateTimeKind.Local).AddTicks(6299), new DateTime(2022, 8, 9, 15, 51, 54, 282, DateTimeKind.Local).AddTicks(6299) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 15, 51, 54, 282, DateTimeKind.Local).AddTicks(6157), new DateTime(2022, 8, 9, 15, 51, 54, 282, DateTimeKind.Local).AddTicks(6165) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 15, 51, 54, 282, DateTimeKind.Local).AddTicks(6167), new DateTime(2022, 8, 9, 15, 51, 54, 282, DateTimeKind.Local).AddTicks(6168) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 15, 51, 54, 282, DateTimeKind.Local).AddTicks(6169), new DateTime(2022, 8, 9, 15, 51, 54, 282, DateTimeKind.Local).AddTicks(6169) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 15, 51, 54, 282, DateTimeKind.Local).AddTicks(6170), new DateTime(2022, 8, 9, 15, 51, 54, 282, DateTimeKind.Local).AddTicks(6171) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 15, 51, 54, 282, DateTimeKind.Local).AddTicks(6172), new DateTime(2022, 8, 9, 15, 51, 54, 282, DateTimeKind.Local).AddTicks(6172) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 15, 51, 54, 282, DateTimeKind.Local).AddTicks(6268), new DateTime(2022, 8, 9, 15, 51, 54, 282, DateTimeKind.Local).AddTicks(6268) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 15, 51, 54, 282, DateTimeKind.Local).AddTicks(6270), new DateTime(2022, 8, 9, 15, 51, 54, 282, DateTimeKind.Local).AddTicks(6270) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 15, 51, 54, 282, DateTimeKind.Local).AddTicks(6271), new DateTime(2022, 8, 9, 15, 51, 54, 282, DateTimeKind.Local).AddTicks(6272) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 15, 51, 54, 282, DateTimeKind.Local).AddTicks(6273), new DateTime(2022, 8, 9, 15, 51, 54, 282, DateTimeKind.Local).AddTicks(6273) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Perm_Menu",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyTenantId = table.Column<int>(type: "int", nullable: true),
                    DeleteBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsLast = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentId = table.Column<long>(type: "bigint", nullable: true),
                    Permission = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Route = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perm_Menu", x => x.ID);
                });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5326), new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5327) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5329), new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5329) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5331), new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5331) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5333), new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5333) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5335), new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5335) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5150), new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5162) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5164), new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5165) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5167), new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5167) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5169), new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5170) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5171), new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5172) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5300), new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5301) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5303), new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5303) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5305), new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5305) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5307), new DateTime(2022, 8, 8, 10, 23, 48, 410, DateTimeKind.Local).AddTicks(5307) });
        }
    }
}
