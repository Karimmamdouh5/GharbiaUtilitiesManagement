using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class PermMenu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PermMenus",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentId = table.Column<long>(type: "bigint", nullable: false),
                    IsLast = table.Column<bool>(type: "bit", nullable: false),
                    Route = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Permission = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermMenus", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8306), new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8307) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8308), new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8308) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8309), new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8311), new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8311) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8312), new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8312) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8175), new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8183) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8185), new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8185) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8187), new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8187) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8188), new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8188) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8189), new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8190) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8283), new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8283) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8285), new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8285) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8287), new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8287) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8288), new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8289) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PermMenus");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1644), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1644) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1646), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1649), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1650) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1651), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1652) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1654), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1654) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1430), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1442) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1444), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1445) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1447), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1448) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1450), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1450) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1452), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1453) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1595), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1599), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1599) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1605), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1608), new DateTime(2022, 8, 7, 12, 14, 7, 429, DateTimeKind.Local).AddTicks(1608) });
        }
    }
}
