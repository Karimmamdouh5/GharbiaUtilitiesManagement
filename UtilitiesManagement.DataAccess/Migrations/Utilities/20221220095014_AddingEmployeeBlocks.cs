using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class AddingEmployeeBlocks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hr_EmployeeBlocks",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Collector_Id = table.Column<long>(type: "bigint", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Block_Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hr_EmployeeBlocks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Hr_EmployeeBlocks_Hr_Employees_Collector_Id",
                        column: x => x.Collector_Id,
                        principalTable: "Hr_Employees",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Hr_EmployeeBlocks_Shar_Blocks_Block_Id",
                        column: x => x.Block_Id,
                        principalTable: "Shar_Blocks",
                        principalColumn: "ID");
                });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 50, 13, 881, DateTimeKind.Local).AddTicks(2736), new DateTime(2022, 12, 20, 11, 50, 13, 881, DateTimeKind.Local).AddTicks(2736) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 50, 13, 881, DateTimeKind.Local).AddTicks(2737), new DateTime(2022, 12, 20, 11, 50, 13, 881, DateTimeKind.Local).AddTicks(2738) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 50, 13, 881, DateTimeKind.Local).AddTicks(2739), new DateTime(2022, 12, 20, 11, 50, 13, 881, DateTimeKind.Local).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 50, 13, 881, DateTimeKind.Local).AddTicks(2740), new DateTime(2022, 12, 20, 11, 50, 13, 881, DateTimeKind.Local).AddTicks(2741) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 50, 13, 881, DateTimeKind.Local).AddTicks(2742), new DateTime(2022, 12, 20, 11, 50, 13, 881, DateTimeKind.Local).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 50, 13, 881, DateTimeKind.Local).AddTicks(2611), new DateTime(2022, 12, 20, 11, 50, 13, 881, DateTimeKind.Local).AddTicks(2619) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 50, 13, 881, DateTimeKind.Local).AddTicks(2621), new DateTime(2022, 12, 20, 11, 50, 13, 881, DateTimeKind.Local).AddTicks(2622) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 50, 13, 881, DateTimeKind.Local).AddTicks(2623), new DateTime(2022, 12, 20, 11, 50, 13, 881, DateTimeKind.Local).AddTicks(2623) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 50, 13, 881, DateTimeKind.Local).AddTicks(2625), new DateTime(2022, 12, 20, 11, 50, 13, 881, DateTimeKind.Local).AddTicks(2625) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 50, 13, 881, DateTimeKind.Local).AddTicks(2626), new DateTime(2022, 12, 20, 11, 50, 13, 881, DateTimeKind.Local).AddTicks(2627) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 50, 13, 881, DateTimeKind.Local).AddTicks(2719), new DateTime(2022, 12, 20, 11, 50, 13, 881, DateTimeKind.Local).AddTicks(2719) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 50, 13, 881, DateTimeKind.Local).AddTicks(2721), new DateTime(2022, 12, 20, 11, 50, 13, 881, DateTimeKind.Local).AddTicks(2721) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 50, 13, 881, DateTimeKind.Local).AddTicks(2722), new DateTime(2022, 12, 20, 11, 50, 13, 881, DateTimeKind.Local).AddTicks(2722) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 50, 13, 881, DateTimeKind.Local).AddTicks(2723), new DateTime(2022, 12, 20, 11, 50, 13, 881, DateTimeKind.Local).AddTicks(2724) });

            migrationBuilder.CreateIndex(
                name: "IX_Hr_EmployeeBlocks_Block_Id",
                table: "Hr_EmployeeBlocks",
                column: "Block_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Hr_EmployeeBlocks_Collector_Id",
                table: "Hr_EmployeeBlocks",
                column: "Collector_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hr_EmployeeBlocks");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 47, 48, 972, DateTimeKind.Local).AddTicks(6132), new DateTime(2022, 12, 20, 11, 47, 48, 972, DateTimeKind.Local).AddTicks(6132) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 47, 48, 972, DateTimeKind.Local).AddTicks(6134), new DateTime(2022, 12, 20, 11, 47, 48, 972, DateTimeKind.Local).AddTicks(6134) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 47, 48, 972, DateTimeKind.Local).AddTicks(6165), new DateTime(2022, 12, 20, 11, 47, 48, 972, DateTimeKind.Local).AddTicks(6165) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 47, 48, 972, DateTimeKind.Local).AddTicks(6167), new DateTime(2022, 12, 20, 11, 47, 48, 972, DateTimeKind.Local).AddTicks(6167) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 47, 48, 972, DateTimeKind.Local).AddTicks(6169), new DateTime(2022, 12, 20, 11, 47, 48, 972, DateTimeKind.Local).AddTicks(6169) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 47, 48, 972, DateTimeKind.Local).AddTicks(5974), new DateTime(2022, 12, 20, 11, 47, 48, 972, DateTimeKind.Local).AddTicks(5983) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 47, 48, 972, DateTimeKind.Local).AddTicks(5985), new DateTime(2022, 12, 20, 11, 47, 48, 972, DateTimeKind.Local).AddTicks(5985) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 47, 48, 972, DateTimeKind.Local).AddTicks(5987), new DateTime(2022, 12, 20, 11, 47, 48, 972, DateTimeKind.Local).AddTicks(5987) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 47, 48, 972, DateTimeKind.Local).AddTicks(5988), new DateTime(2022, 12, 20, 11, 47, 48, 972, DateTimeKind.Local).AddTicks(5989) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 47, 48, 972, DateTimeKind.Local).AddTicks(5990), new DateTime(2022, 12, 20, 11, 47, 48, 972, DateTimeKind.Local).AddTicks(5991) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 47, 48, 972, DateTimeKind.Local).AddTicks(6108), new DateTime(2022, 12, 20, 11, 47, 48, 972, DateTimeKind.Local).AddTicks(6108) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 47, 48, 972, DateTimeKind.Local).AddTicks(6111), new DateTime(2022, 12, 20, 11, 47, 48, 972, DateTimeKind.Local).AddTicks(6111) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 47, 48, 972, DateTimeKind.Local).AddTicks(6113), new DateTime(2022, 12, 20, 11, 47, 48, 972, DateTimeKind.Local).AddTicks(6113) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 20, 11, 47, 48, 972, DateTimeKind.Local).AddTicks(6114), new DateTime(2022, 12, 20, 11, 47, 48, 972, DateTimeKind.Local).AddTicks(6115) });
        }
    }
}
