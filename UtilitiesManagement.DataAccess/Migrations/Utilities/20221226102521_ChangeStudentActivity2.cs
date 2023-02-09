using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class ChangeStudentActivity2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Cust_CustomerActivities",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "ID",
                table: "Bill_Issues",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2941), new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2942) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2943), new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2943) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2945), new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2945) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2946), new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2947) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2948), new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2948) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2797), new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2806) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2807), new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2808) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2809), new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2811), new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2811) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2812), new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2813) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2918), new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2921), new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2921) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2922), new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2923) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2924), new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2924) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Cust_CustomerActivities",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "ID",
                table: "Bill_Issues",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5284), new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5285) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5286), new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5286) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5288), new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5288) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5289), new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5289) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5291), new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5291) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5139), new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5147) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5149), new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5149) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5151), new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5151) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5152), new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5153) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5154), new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5154) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5261), new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5261) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5263), new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5264) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5265), new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5265) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5267), new DateTime(2022, 12, 26, 12, 3, 6, 627, DateTimeKind.Local).AddTicks(5267) });
        }
    }
}
