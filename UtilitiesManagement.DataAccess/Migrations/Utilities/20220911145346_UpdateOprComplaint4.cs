using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class UpdateOprComplaint4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateIndex(
                name: "IX_Opr_Complaints_PublicBlock_Id",
                table: "Opr_Complaints",
                column: "PublicBlock_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Opr_Complaints_Shar_Blocks_PublicBlock_Id",
                table: "Opr_Complaints",
                column: "PublicBlock_Id",
                principalTable: "Shar_Blocks",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Opr_Complaints_Shar_Blocks_PublicBlock_Id",
                table: "Opr_Complaints");

            migrationBuilder.DropIndex(
                name: "IX_Opr_Complaints_PublicBlock_Id",
                table: "Opr_Complaints");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4938), new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4939) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4940), new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4941) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4942), new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4943) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4944), new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4945) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4947), new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4947) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4789), new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4800) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4803), new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4803) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4804), new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4805) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4806), new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4806) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4808), new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4808) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4914), new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4917), new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4917) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4919), new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4919) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4920), new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4921) });
        }
    }
}
