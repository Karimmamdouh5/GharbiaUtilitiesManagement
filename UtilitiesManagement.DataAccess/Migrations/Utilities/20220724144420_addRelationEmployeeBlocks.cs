using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class addRelationEmployeeBlocks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hr_EmployeeBlocks_Shar_Blocks_BlockID",
                table: "Hr_EmployeeBlocks");

            migrationBuilder.RenameColumn(
                name: "CollectorID",
                table: "Hr_EmployeeBlocks",
                newName: "Collector_Id");

            migrationBuilder.RenameColumn(
                name: "BlockID",
                table: "Hr_EmployeeBlocks",
                newName: "Block_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Hr_EmployeeBlocks_BlockID",
                table: "Hr_EmployeeBlocks",
                newName: "IX_Hr_EmployeeBlocks_Block_Id");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2823), new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2824) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2826), new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2827) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2829), new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2829) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2831), new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2832) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2833), new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2834) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2605), new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2615) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2618), new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2618) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2620), new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2621) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2623), new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2623) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2625), new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2782), new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2783) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2786), new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2787) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2794), new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2795) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2797), new DateTime(2022, 7, 24, 16, 44, 20, 152, DateTimeKind.Local).AddTicks(2797) });

            migrationBuilder.CreateIndex(
                name: "IX_Hr_EmployeeBlocks_Collector_Id",
                table: "Hr_EmployeeBlocks",
                column: "Collector_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Hr_EmployeeBlocks_Shar_Blocks_Block_Id",
                table: "Hr_EmployeeBlocks",
                column: "Block_Id",
                principalTable: "Shar_Blocks",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Hr_EmployeeBlocks_Shar_Blocks_Collector_Id",
                table: "Hr_EmployeeBlocks",
                column: "Collector_Id",
                principalTable: "Shar_Blocks",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hr_EmployeeBlocks_Shar_Blocks_Block_Id",
                table: "Hr_EmployeeBlocks");

            migrationBuilder.DropForeignKey(
                name: "FK_Hr_EmployeeBlocks_Shar_Blocks_Collector_Id",
                table: "Hr_EmployeeBlocks");

            migrationBuilder.DropIndex(
                name: "IX_Hr_EmployeeBlocks_Collector_Id",
                table: "Hr_EmployeeBlocks");

            migrationBuilder.RenameColumn(
                name: "Collector_Id",
                table: "Hr_EmployeeBlocks",
                newName: "CollectorID");

            migrationBuilder.RenameColumn(
                name: "Block_Id",
                table: "Hr_EmployeeBlocks",
                newName: "BlockID");

            migrationBuilder.RenameIndex(
                name: "IX_Hr_EmployeeBlocks_Block_Id",
                table: "Hr_EmployeeBlocks",
                newName: "IX_Hr_EmployeeBlocks_BlockID");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 41, 56, 954, DateTimeKind.Local).AddTicks(104), new DateTime(2022, 7, 24, 16, 41, 56, 954, DateTimeKind.Local).AddTicks(105) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 41, 56, 954, DateTimeKind.Local).AddTicks(107), new DateTime(2022, 7, 24, 16, 41, 56, 954, DateTimeKind.Local).AddTicks(107) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 41, 56, 954, DateTimeKind.Local).AddTicks(109), new DateTime(2022, 7, 24, 16, 41, 56, 954, DateTimeKind.Local).AddTicks(109) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 41, 56, 954, DateTimeKind.Local).AddTicks(111), new DateTime(2022, 7, 24, 16, 41, 56, 954, DateTimeKind.Local).AddTicks(111) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 41, 56, 954, DateTimeKind.Local).AddTicks(112), new DateTime(2022, 7, 24, 16, 41, 56, 954, DateTimeKind.Local).AddTicks(113) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 41, 56, 953, DateTimeKind.Local).AddTicks(9917), new DateTime(2022, 7, 24, 16, 41, 56, 953, DateTimeKind.Local).AddTicks(9924) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 41, 56, 953, DateTimeKind.Local).AddTicks(9926), new DateTime(2022, 7, 24, 16, 41, 56, 953, DateTimeKind.Local).AddTicks(9927) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 41, 56, 953, DateTimeKind.Local).AddTicks(9929), new DateTime(2022, 7, 24, 16, 41, 56, 953, DateTimeKind.Local).AddTicks(9929) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 41, 56, 953, DateTimeKind.Local).AddTicks(9931), new DateTime(2022, 7, 24, 16, 41, 56, 953, DateTimeKind.Local).AddTicks(9931) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 41, 56, 953, DateTimeKind.Local).AddTicks(9932), new DateTime(2022, 7, 24, 16, 41, 56, 953, DateTimeKind.Local).AddTicks(9933) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 41, 56, 954, DateTimeKind.Local).AddTicks(69), new DateTime(2022, 7, 24, 16, 41, 56, 954, DateTimeKind.Local).AddTicks(70) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 41, 56, 954, DateTimeKind.Local).AddTicks(72), new DateTime(2022, 7, 24, 16, 41, 56, 954, DateTimeKind.Local).AddTicks(72) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 41, 56, 954, DateTimeKind.Local).AddTicks(80), new DateTime(2022, 7, 24, 16, 41, 56, 954, DateTimeKind.Local).AddTicks(81) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 41, 56, 954, DateTimeKind.Local).AddTicks(83), new DateTime(2022, 7, 24, 16, 41, 56, 954, DateTimeKind.Local).AddTicks(83) });

            migrationBuilder.AddForeignKey(
                name: "FK_Hr_EmployeeBlocks_Shar_Blocks_BlockID",
                table: "Hr_EmployeeBlocks",
                column: "BlockID",
                principalTable: "Shar_Blocks",
                principalColumn: "ID");
        }
    }
}
