using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class UpdateOprComplaint5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Opr_Complaints_Shar_Blocks_PublicBlock_Id",
                table: "Opr_Complaints");

            migrationBuilder.RenameColumn(
                name: "PublicBlock_Id",
                table: "Opr_Complaints",
                newName: "BlockId");

            migrationBuilder.RenameIndex(
                name: "IX_Opr_Complaints_PublicBlock_Id",
                table: "Opr_Complaints",
                newName: "IX_Opr_Complaints_BlockId");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(391), new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(392) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(393), new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(393) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(395), new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(395) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(396), new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(397) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(398), new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(398) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(252), new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(261) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(262), new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(263) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(264), new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(265) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(266), new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(266) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(267), new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(268) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(372), new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(374), new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(374) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(376), new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(376) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(378), new DateTime(2022, 9, 11, 17, 4, 45, 325, DateTimeKind.Local).AddTicks(378) });

            migrationBuilder.AddForeignKey(
                name: "FK_Opr_Complaints_Shar_Blocks_BlockId",
                table: "Opr_Complaints",
                column: "BlockId",
                principalTable: "Shar_Blocks",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Opr_Complaints_Shar_Blocks_BlockId",
                table: "Opr_Complaints");

            migrationBuilder.RenameColumn(
                name: "BlockId",
                table: "Opr_Complaints",
                newName: "PublicBlock_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Opr_Complaints_BlockId",
                table: "Opr_Complaints",
                newName: "IX_Opr_Complaints_PublicBlock_Id");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 53, 46, 78, DateTimeKind.Local).AddTicks(1550), new DateTime(2022, 9, 11, 16, 53, 46, 78, DateTimeKind.Local).AddTicks(1551) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 53, 46, 78, DateTimeKind.Local).AddTicks(1552), new DateTime(2022, 9, 11, 16, 53, 46, 78, DateTimeKind.Local).AddTicks(1552) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 53, 46, 78, DateTimeKind.Local).AddTicks(1553), new DateTime(2022, 9, 11, 16, 53, 46, 78, DateTimeKind.Local).AddTicks(1554) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 53, 46, 78, DateTimeKind.Local).AddTicks(1555), new DateTime(2022, 9, 11, 16, 53, 46, 78, DateTimeKind.Local).AddTicks(1555) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 53, 46, 78, DateTimeKind.Local).AddTicks(1556), new DateTime(2022, 9, 11, 16, 53, 46, 78, DateTimeKind.Local).AddTicks(1557) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 53, 46, 78, DateTimeKind.Local).AddTicks(1397), new DateTime(2022, 9, 11, 16, 53, 46, 78, DateTimeKind.Local).AddTicks(1410) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 53, 46, 78, DateTimeKind.Local).AddTicks(1412), new DateTime(2022, 9, 11, 16, 53, 46, 78, DateTimeKind.Local).AddTicks(1412) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 53, 46, 78, DateTimeKind.Local).AddTicks(1413), new DateTime(2022, 9, 11, 16, 53, 46, 78, DateTimeKind.Local).AddTicks(1414) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 53, 46, 78, DateTimeKind.Local).AddTicks(1415), new DateTime(2022, 9, 11, 16, 53, 46, 78, DateTimeKind.Local).AddTicks(1415) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 53, 46, 78, DateTimeKind.Local).AddTicks(1416), new DateTime(2022, 9, 11, 16, 53, 46, 78, DateTimeKind.Local).AddTicks(1416) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 53, 46, 78, DateTimeKind.Local).AddTicks(1521), new DateTime(2022, 9, 11, 16, 53, 46, 78, DateTimeKind.Local).AddTicks(1522) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 53, 46, 78, DateTimeKind.Local).AddTicks(1523), new DateTime(2022, 9, 11, 16, 53, 46, 78, DateTimeKind.Local).AddTicks(1524) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 53, 46, 78, DateTimeKind.Local).AddTicks(1530), new DateTime(2022, 9, 11, 16, 53, 46, 78, DateTimeKind.Local).AddTicks(1531) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 53, 46, 78, DateTimeKind.Local).AddTicks(1532), new DateTime(2022, 9, 11, 16, 53, 46, 78, DateTimeKind.Local).AddTicks(1532) });

            migrationBuilder.AddForeignKey(
                name: "FK_Opr_Complaints_Shar_Blocks_PublicBlock_Id",
                table: "Opr_Complaints",
                column: "PublicBlock_Id",
                principalTable: "Shar_Blocks",
                principalColumn: "ID");
        }
    }
}
