using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.migrations.utilities
{
    public partial class UpdatePermMenuTable22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Perm_Menu",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentId = table.Column<long>(type: "bigint", nullable: true),
                    IsLast = table.Column<bool>(type: "bit", nullable: true),
                    Route = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Permission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_Perm_Menu", x => x.ID);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
