using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class SharedTempBillTable_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Bill_ID",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Bill_ID",
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
                values: new object[] { new DateTime(2023, 1, 29, 11, 47, 24, 109, DateTimeKind.Local).AddTicks(526), new DateTime(2023, 1, 29, 11, 47, 24, 109, DateTimeKind.Local).AddTicks(531) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 47, 24, 109, DateTimeKind.Local).AddTicks(689), new DateTime(2023, 1, 29, 11, 47, 24, 109, DateTimeKind.Local).AddTicks(689) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 47, 24, 109, DateTimeKind.Local).AddTicks(698), new DateTime(2023, 1, 29, 11, 47, 24, 109, DateTimeKind.Local).AddTicks(698) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 47, 24, 109, DateTimeKind.Local).AddTicks(698), new DateTime(2023, 1, 29, 11, 47, 24, 109, DateTimeKind.Local).AddTicks(703) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 47, 24, 109, DateTimeKind.Local).AddTicks(703), new DateTime(2023, 1, 29, 11, 47, 24, 109, DateTimeKind.Local).AddTicks(708) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 47, 24, 109, DateTimeKind.Local).AddTicks(708), new DateTime(2023, 1, 29, 11, 47, 24, 109, DateTimeKind.Local).AddTicks(708) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 47, 24, 109, DateTimeKind.Local).AddTicks(70), new DateTime(2023, 1, 29, 11, 47, 24, 109, DateTimeKind.Local).AddTicks(103) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 47, 24, 109, DateTimeKind.Local).AddTicks(107), new DateTime(2023, 1, 29, 11, 47, 24, 109, DateTimeKind.Local).AddTicks(112) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 47, 24, 109, DateTimeKind.Local).AddTicks(112), new DateTime(2023, 1, 29, 11, 47, 24, 109, DateTimeKind.Local).AddTicks(117) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 47, 24, 109, DateTimeKind.Local).AddTicks(117), new DateTime(2023, 1, 29, 11, 47, 24, 109, DateTimeKind.Local).AddTicks(121) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 47, 24, 109, DateTimeKind.Local).AddTicks(587), new DateTime(2023, 1, 29, 11, 47, 24, 109, DateTimeKind.Local).AddTicks(591) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 47, 24, 109, DateTimeKind.Local).AddTicks(591), new DateTime(2023, 1, 29, 11, 47, 24, 109, DateTimeKind.Local).AddTicks(596) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 47, 24, 109, DateTimeKind.Local).AddTicks(596), new DateTime(2023, 1, 29, 11, 47, 24, 109, DateTimeKind.Local).AddTicks(601) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 47, 24, 109, DateTimeKind.Local).AddTicks(601), new DateTime(2023, 1, 29, 11, 47, 24, 109, DateTimeKind.Local).AddTicks(605) });
        }
    }
}
