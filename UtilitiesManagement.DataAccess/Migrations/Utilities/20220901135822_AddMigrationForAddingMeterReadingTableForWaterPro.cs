using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class AddMigrationForAddingMeterReadingTableForWaterPro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Opr_MeterReadings_Logs",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(type: "float", nullable: false),
                    NewValue = table.Column<double>(type: "float", nullable: false),
                    MeterReadings_Id = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_Opr_MeterReadings_Logs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Opr_MeterReadings_Logs_Opr_MeterReadings_MeterReadings_Id",
                        column: x => x.MeterReadings_Id,
                        principalTable: "Opr_MeterReadings",
                        principalColumn: "ID");
                });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5706), new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5708) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5711), new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5712) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5715), new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5716) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5720), new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5721) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5724), new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5255), new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5285), new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5287) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5291), new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5293) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5296), new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5297) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5301), new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5302) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5634), new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5637) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5641), new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5642) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5645), new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5647) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5651), new DateTime(2022, 9, 1, 15, 58, 21, 426, DateTimeKind.Local).AddTicks(5652) });

            migrationBuilder.CreateIndex(
                name: "IX_Opr_MeterReadings_Logs_MeterReadings_Id",
                table: "Opr_MeterReadings_Logs",
                column: "MeterReadings_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Opr_MeterReadings_Logs");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1318), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1318) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1320), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1320) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1321), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1322) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1323), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1324), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1325) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1131), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1139) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1140), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1141) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1142), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1142) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1144), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1144) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1145), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1145) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1276), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1277) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1278), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1279) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1302), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1302) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1303), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1304) });
        }
    }
}
