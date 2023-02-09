using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class AddingIsReaderFlagToEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsReader",
                table: "Hr_Employees",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Cust_CustomerStatus",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(7180), new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(7185) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(7348), new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(7348) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(7353), new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(7357) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(7357), new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(7362) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(7362), new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(7362) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(7366), new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(7371) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(6729), new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(6766) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(6771), new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(6771) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(6775), new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(6780), new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(6780) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(7250), new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(7255) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(7259), new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(7259) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(7264), new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(7264) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(7269), new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(7269) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsReader",
                table: "Hr_Employees");

            migrationBuilder.UpdateData(
                table: "Cust_CustomerStatus",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 43, 21, 968, DateTimeKind.Local).AddTicks(7219), new DateTime(2023, 1, 29, 22, 43, 21, 968, DateTimeKind.Local).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 43, 21, 968, DateTimeKind.Local).AddTicks(7392), new DateTime(2023, 1, 29, 22, 43, 21, 968, DateTimeKind.Local).AddTicks(7392) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 43, 21, 968, DateTimeKind.Local).AddTicks(7401), new DateTime(2023, 1, 29, 22, 43, 21, 968, DateTimeKind.Local).AddTicks(7401) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 43, 21, 968, DateTimeKind.Local).AddTicks(7406), new DateTime(2023, 1, 29, 22, 43, 21, 968, DateTimeKind.Local).AddTicks(7406) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 43, 21, 968, DateTimeKind.Local).AddTicks(7406), new DateTime(2023, 1, 29, 22, 43, 21, 968, DateTimeKind.Local).AddTicks(7410) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 43, 21, 968, DateTimeKind.Local).AddTicks(7410), new DateTime(2023, 1, 29, 22, 43, 21, 968, DateTimeKind.Local).AddTicks(7415) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 43, 21, 968, DateTimeKind.Local).AddTicks(6810), new DateTime(2023, 1, 29, 22, 43, 21, 968, DateTimeKind.Local).AddTicks(6847) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 43, 21, 968, DateTimeKind.Local).AddTicks(6852), new DateTime(2023, 1, 29, 22, 43, 21, 968, DateTimeKind.Local).AddTicks(6852) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 43, 21, 968, DateTimeKind.Local).AddTicks(6856), new DateTime(2023, 1, 29, 22, 43, 21, 968, DateTimeKind.Local).AddTicks(6856) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 43, 21, 968, DateTimeKind.Local).AddTicks(6861), new DateTime(2023, 1, 29, 22, 43, 21, 968, DateTimeKind.Local).AddTicks(6861) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 43, 21, 968, DateTimeKind.Local).AddTicks(7285), new DateTime(2023, 1, 29, 22, 43, 21, 968, DateTimeKind.Local).AddTicks(7285) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 43, 21, 968, DateTimeKind.Local).AddTicks(7289), new DateTime(2023, 1, 29, 22, 43, 21, 968, DateTimeKind.Local).AddTicks(7289) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 43, 21, 968, DateTimeKind.Local).AddTicks(7294), new DateTime(2023, 1, 29, 22, 43, 21, 968, DateTimeKind.Local).AddTicks(7294) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 43, 21, 968, DateTimeKind.Local).AddTicks(7299), new DateTime(2023, 1, 29, 22, 43, 21, 968, DateTimeKind.Local).AddTicks(7299) });
        }
    }
}
