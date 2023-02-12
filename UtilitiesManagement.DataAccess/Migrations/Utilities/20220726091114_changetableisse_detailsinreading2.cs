using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class changetableisse_detailsinreading2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Opr_MeterReadings_Bill_IssueDetail_Issue_Id",
                table: "Opr_MeterReadings");

            migrationBuilder.DropIndex(
                name: "IX_Opr_MeterReadings_Issue_Id",
                table: "Opr_MeterReadings");

            migrationBuilder.DropColumn(
                name: "Issue_Id",
                table: "Opr_MeterReadings");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9614), new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9614) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9616), new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9616) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9618), new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9618) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9620), new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9621), new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9622) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9452), new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9459) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9462), new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9462) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9464), new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9464) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9466), new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9467) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9468), new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9468) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9589), new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9592), new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9592) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9594), new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9594) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9596), new DateTime(2022, 7, 26, 11, 11, 13, 748, DateTimeKind.Local).AddTicks(9596) });

            migrationBuilder.CreateIndex(
                name: "IX_Opr_MeterReadings_Issue_Details_Id",
                table: "Opr_MeterReadings",
                column: "Issue_Details_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Opr_MeterReadings_Bill_IssueDetail_Issue_Details_Id",
                table: "Opr_MeterReadings",
                column: "Issue_Details_Id",
                principalTable: "Bill_IssueDetail",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Opr_MeterReadings_Bill_IssueDetail_Issue_Details_Id",
                table: "Opr_MeterReadings");

            migrationBuilder.DropIndex(
                name: "IX_Opr_MeterReadings_Issue_Details_Id",
                table: "Opr_MeterReadings");

            migrationBuilder.AddColumn<long>(
                name: "Issue_Id",
                table: "Opr_MeterReadings",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 6, 25, 934, DateTimeKind.Local).AddTicks(5217), new DateTime(2022, 7, 26, 11, 6, 25, 934, DateTimeKind.Local).AddTicks(5218) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 6, 25, 934, DateTimeKind.Local).AddTicks(5219), new DateTime(2022, 7, 26, 11, 6, 25, 934, DateTimeKind.Local).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 6, 25, 934, DateTimeKind.Local).AddTicks(5221), new DateTime(2022, 7, 26, 11, 6, 25, 934, DateTimeKind.Local).AddTicks(5222) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 6, 25, 934, DateTimeKind.Local).AddTicks(5223), new DateTime(2022, 7, 26, 11, 6, 25, 934, DateTimeKind.Local).AddTicks(5224) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 6, 25, 934, DateTimeKind.Local).AddTicks(5225), new DateTime(2022, 7, 26, 11, 6, 25, 934, DateTimeKind.Local).AddTicks(5226) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 6, 25, 934, DateTimeKind.Local).AddTicks(5048), new DateTime(2022, 7, 26, 11, 6, 25, 934, DateTimeKind.Local).AddTicks(5055) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 6, 25, 934, DateTimeKind.Local).AddTicks(5058), new DateTime(2022, 7, 26, 11, 6, 25, 934, DateTimeKind.Local).AddTicks(5058) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 6, 25, 934, DateTimeKind.Local).AddTicks(5060), new DateTime(2022, 7, 26, 11, 6, 25, 934, DateTimeKind.Local).AddTicks(5061) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 6, 25, 934, DateTimeKind.Local).AddTicks(5063), new DateTime(2022, 7, 26, 11, 6, 25, 934, DateTimeKind.Local).AddTicks(5063) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 6, 25, 934, DateTimeKind.Local).AddTicks(5065), new DateTime(2022, 7, 26, 11, 6, 25, 934, DateTimeKind.Local).AddTicks(5065) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 6, 25, 934, DateTimeKind.Local).AddTicks(5192), new DateTime(2022, 7, 26, 11, 6, 25, 934, DateTimeKind.Local).AddTicks(5193) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 6, 25, 934, DateTimeKind.Local).AddTicks(5195), new DateTime(2022, 7, 26, 11, 6, 25, 934, DateTimeKind.Local).AddTicks(5195) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 6, 25, 934, DateTimeKind.Local).AddTicks(5197), new DateTime(2022, 7, 26, 11, 6, 25, 934, DateTimeKind.Local).AddTicks(5198) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 11, 6, 25, 934, DateTimeKind.Local).AddTicks(5199), new DateTime(2022, 7, 26, 11, 6, 25, 934, DateTimeKind.Local).AddTicks(5200) });

            migrationBuilder.CreateIndex(
                name: "IX_Opr_MeterReadings_Issue_Id",
                table: "Opr_MeterReadings",
                column: "Issue_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Opr_MeterReadings_Bill_IssueDetail_Issue_Id",
                table: "Opr_MeterReadings",
                column: "Issue_Id",
                principalTable: "Bill_IssueDetail",
                principalColumn: "ID");
        }
    }
}
