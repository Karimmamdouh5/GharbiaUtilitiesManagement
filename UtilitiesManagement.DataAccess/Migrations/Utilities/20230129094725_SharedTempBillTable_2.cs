using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class SharedTempBillTable_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ACTIVITY_TYPE_Id",
                table: "Shar_Bills_Temp",
                type: "bigint",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ACTIVITY_TYPE_Id",
                table: "Shar_Bills_Temp");

            migrationBuilder.UpdateData(
                table: "Cust_CustomerStatus",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(4205), new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(4428), new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(4428) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(4433), new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(4433) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(4438), new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(4438) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(4442), new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(4442) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(4447), new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(4447) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(3823), new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(3846) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(3846), new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(3851) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(3851), new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(3851) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(3856), new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(3856) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(4265), new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(4265) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(4340), new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(4344) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(4344), new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(4349) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(4349), new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(4349) });
        }
    }
}
