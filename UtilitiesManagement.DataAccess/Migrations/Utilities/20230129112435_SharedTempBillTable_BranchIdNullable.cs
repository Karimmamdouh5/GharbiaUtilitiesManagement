using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class SharedTempBillTable_BranchIdNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BRANCH_Id",
                table: "Shar_Bills_Temp",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Cust_CustomerStatus",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(9345), new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(9526), new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(9526) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(9531), new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(9536) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(9536), new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(9540) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(9540), new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(9540) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(9545), new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(9545) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(8954), new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(8973) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(8977), new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(8982) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(8987), new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(8987) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(8991), new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(8991) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(9419), new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(9419) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(9424), new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(9424) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(9429), new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(9433) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(9433), new DateTime(2023, 1, 29, 13, 24, 34, 171, DateTimeKind.Local).AddTicks(9438) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BRANCH_Id",
                table: "Shar_Bills_Temp",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Cust_CustomerStatus",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 5, 38, 475, DateTimeKind.Local).AddTicks(9355), new DateTime(2023, 1, 29, 13, 5, 38, 475, DateTimeKind.Local).AddTicks(9360) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 5, 38, 475, DateTimeKind.Local).AddTicks(9541), new DateTime(2023, 1, 29, 13, 5, 38, 475, DateTimeKind.Local).AddTicks(9541) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 5, 38, 475, DateTimeKind.Local).AddTicks(9546), new DateTime(2023, 1, 29, 13, 5, 38, 475, DateTimeKind.Local).AddTicks(9551) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 5, 38, 475, DateTimeKind.Local).AddTicks(9555), new DateTime(2023, 1, 29, 13, 5, 38, 475, DateTimeKind.Local).AddTicks(9555) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 5, 38, 475, DateTimeKind.Local).AddTicks(9560), new DateTime(2023, 1, 29, 13, 5, 38, 475, DateTimeKind.Local).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 5, 38, 475, DateTimeKind.Local).AddTicks(9565), new DateTime(2023, 1, 29, 13, 5, 38, 475, DateTimeKind.Local).AddTicks(9565) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 5, 38, 475, DateTimeKind.Local).AddTicks(8871), new DateTime(2023, 1, 29, 13, 5, 38, 475, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 5, 38, 475, DateTimeKind.Local).AddTicks(8899), new DateTime(2023, 1, 29, 13, 5, 38, 475, DateTimeKind.Local).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 5, 38, 475, DateTimeKind.Local).AddTicks(8904), new DateTime(2023, 1, 29, 13, 5, 38, 475, DateTimeKind.Local).AddTicks(8904) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 5, 38, 475, DateTimeKind.Local).AddTicks(8908), new DateTime(2023, 1, 29, 13, 5, 38, 475, DateTimeKind.Local).AddTicks(8908) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 5, 38, 475, DateTimeKind.Local).AddTicks(9430), new DateTime(2023, 1, 29, 13, 5, 38, 475, DateTimeKind.Local).AddTicks(9430) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 5, 38, 475, DateTimeKind.Local).AddTicks(9439), new DateTime(2023, 1, 29, 13, 5, 38, 475, DateTimeKind.Local).AddTicks(9439) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 5, 38, 475, DateTimeKind.Local).AddTicks(9444), new DateTime(2023, 1, 29, 13, 5, 38, 475, DateTimeKind.Local).AddTicks(9444) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 13, 5, 38, 475, DateTimeKind.Local).AddTicks(9448), new DateTime(2023, 1, 29, 13, 5, 38, 475, DateTimeKind.Local).AddTicks(9448) });
        }
    }
}
