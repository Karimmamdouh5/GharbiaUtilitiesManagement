using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class updatecustomerdataandreading : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "MeterReadingDate",
                table: "Opr_MeterReadings",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PreviousReading",
                table: "Opr_MeterReadings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PreviousReadingIssueNumber",
                table: "Opr_MeterReadings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PreviousReading",
                table: "Cust_CustomerData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PreviousReadingIssueNumber",
                table: "Cust_CustomerData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7277), new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7278) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7279), new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7281), new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7282) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7283), new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7283) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7285), new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7286) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7132), new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7140) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7142), new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7142) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7144), new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7145) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7146), new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7147) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7148), new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7148) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7251), new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7252) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7254), new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7255) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7257), new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7257) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7259), new DateTime(2022, 7, 27, 15, 47, 14, 207, DateTimeKind.Local).AddTicks(7260) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MeterReadingDate",
                table: "Opr_MeterReadings");

            migrationBuilder.DropColumn(
                name: "PreviousReading",
                table: "Opr_MeterReadings");

            migrationBuilder.DropColumn(
                name: "PreviousReadingIssueNumber",
                table: "Opr_MeterReadings");

            migrationBuilder.DropColumn(
                name: "PreviousReading",
                table: "Cust_CustomerData");

            migrationBuilder.DropColumn(
                name: "PreviousReadingIssueNumber",
                table: "Cust_CustomerData");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2993), new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2993) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2995), new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2996) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2998), new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(3000), new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(3001) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(3003), new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(3003) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2747), new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2759) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2763), new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2763) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2766), new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2766) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2768), new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2769) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2771), new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2771) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2957), new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2961), new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2961) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2963), new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2964) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2966), new DateTime(2022, 7, 26, 14, 39, 16, 40, DateTimeKind.Local).AddTicks(2967) });
        }
    }
}
