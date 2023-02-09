using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class UpdateEmployeeIdentityColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.UpdateData(
                table: "Cust_CustomerStatus",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(3693), new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(3697) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(4023), new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(4028) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(4033), new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(4033) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(4037), new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(4042) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(4047), new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(4047) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(4051), new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(4051) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(3069), new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(3116) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(3125), new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(3125) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(3130), new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(3134) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(3134), new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(3139) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(3870), new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(3874) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(3888), new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(3888) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(3893), new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(3898) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(3902), new DateTime(2023, 1, 29, 14, 24, 9, 90, DateTimeKind.Local).AddTicks(3902) });
        }
    }
}
