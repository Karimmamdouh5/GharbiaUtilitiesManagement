using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class addcompanyidinissutable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Company_Id",
                table: "Bill_Issues",
                type: "bigint",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(5101), new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(5101) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(5103), new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(5104) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(5111), new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(5111) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(5113), new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(5114) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(5115), new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(5116) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(4934), new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(4942) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(4945), new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(4945) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(4947), new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(4947) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(4949), new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(4949) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(4951), new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(4951) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(5072), new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(5073) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(5076), new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(5076) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(5078), new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(5078) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(5080), new DateTime(2022, 7, 25, 12, 50, 40, 908, DateTimeKind.Local).AddTicks(5080) });

            migrationBuilder.CreateIndex(
                name: "IX_Bill_Issues_Company_Id",
                table: "Bill_Issues",
                column: "Company_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_Issues_Shar_Company_Company_Id",
                table: "Bill_Issues",
                column: "Company_Id",
                principalTable: "Shar_Company",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_Issues_Shar_Company_Company_Id",
                table: "Bill_Issues");

            migrationBuilder.DropIndex(
                name: "IX_Bill_Issues_Company_Id",
                table: "Bill_Issues");

            migrationBuilder.DropColumn(
                name: "Company_Id",
                table: "Bill_Issues");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(281), new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(282) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(285), new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(285) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(288), new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(288) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(290), new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(291) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(293), new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(294) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(47), new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(57) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(60), new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(61) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(63), new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(64) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(67), new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(68) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(70), new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(70) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(233), new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(234) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(237), new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(237) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(245), new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(246) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(248), new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(249) });
        }
    }
}
