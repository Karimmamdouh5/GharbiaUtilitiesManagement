using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class changetableisse_detailsinreading : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Opr_MeterReadings_Bill_Issues_Issue_Id",
                table: "Opr_MeterReadings");

            migrationBuilder.AddColumn<string>(
                name: "InternetSpeed",
                table: "Opr_UpdatedCustomers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InternetSpeed",
                table: "Opr_MeterReadings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Issue_Details_Id",
                table: "Opr_MeterReadings",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "InternetSpeed",
                table: "Opr_ComplaintImages",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Opr_MeterReadings_Bill_IssueDetail_Issue_Id",
                table: "Opr_MeterReadings",
                column: "Issue_Id",
                principalTable: "Bill_IssueDetail",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Opr_MeterReadings_Bill_IssueDetail_Issue_Id",
                table: "Opr_MeterReadings");

            migrationBuilder.DropColumn(
                name: "InternetSpeed",
                table: "Opr_UpdatedCustomers");

            migrationBuilder.DropColumn(
                name: "InternetSpeed",
                table: "Opr_MeterReadings");

            migrationBuilder.DropColumn(
                name: "Issue_Details_Id",
                table: "Opr_MeterReadings");

            migrationBuilder.DropColumn(
                name: "InternetSpeed",
                table: "Opr_ComplaintImages");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2885), new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2885) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2888), new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2888) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2890), new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2891) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2892), new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2893) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2895), new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2896) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2657), new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2668) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2671), new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2672) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2674), new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2675) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2677), new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2678) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2680), new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2681) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2843), new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2844) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2847), new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2848) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2855), new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2856) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2858), new DateTime(2022, 7, 25, 15, 46, 26, 5, DateTimeKind.Local).AddTicks(2859) });

            migrationBuilder.AddForeignKey(
                name: "FK_Opr_MeterReadings_Bill_Issues_Issue_Id",
                table: "Opr_MeterReadings",
                column: "Issue_Id",
                principalTable: "Bill_Issues",
                principalColumn: "ID");
        }
    }
}
