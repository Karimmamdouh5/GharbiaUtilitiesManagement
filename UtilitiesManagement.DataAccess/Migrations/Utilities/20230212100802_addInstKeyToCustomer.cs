using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GharbiaUtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class addInstKeyToCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InstKey",
                table: "Cust_CustomerData",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Cust_CustomerStatus",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 12, 12, 8, 1, 970, DateTimeKind.Local).AddTicks(9745), new DateTime(2023, 2, 12, 12, 8, 1, 970, DateTimeKind.Local).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 12, 12, 8, 1, 970, DateTimeKind.Local).AddTicks(9790), new DateTime(2023, 2, 12, 12, 8, 1, 970, DateTimeKind.Local).AddTicks(9790) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 12, 12, 8, 1, 970, DateTimeKind.Local).AddTicks(9792), new DateTime(2023, 2, 12, 12, 8, 1, 970, DateTimeKind.Local).AddTicks(9792) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 12, 12, 8, 1, 970, DateTimeKind.Local).AddTicks(9793), new DateTime(2023, 2, 12, 12, 8, 1, 970, DateTimeKind.Local).AddTicks(9794) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 12, 12, 8, 1, 970, DateTimeKind.Local).AddTicks(9796), new DateTime(2023, 2, 12, 12, 8, 1, 970, DateTimeKind.Local).AddTicks(9796) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 12, 12, 8, 1, 970, DateTimeKind.Local).AddTicks(9797), new DateTime(2023, 2, 12, 12, 8, 1, 970, DateTimeKind.Local).AddTicks(9798) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 12, 12, 8, 1, 970, DateTimeKind.Local).AddTicks(9614), new DateTime(2023, 2, 12, 12, 8, 1, 970, DateTimeKind.Local).AddTicks(9624) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 12, 12, 8, 1, 970, DateTimeKind.Local).AddTicks(9626), new DateTime(2023, 2, 12, 12, 8, 1, 970, DateTimeKind.Local).AddTicks(9626) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 12, 12, 8, 1, 970, DateTimeKind.Local).AddTicks(9628), new DateTime(2023, 2, 12, 12, 8, 1, 970, DateTimeKind.Local).AddTicks(9628) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 12, 12, 8, 1, 970, DateTimeKind.Local).AddTicks(9629), new DateTime(2023, 2, 12, 12, 8, 1, 970, DateTimeKind.Local).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 12, 12, 8, 1, 970, DateTimeKind.Local).AddTicks(9762), new DateTime(2023, 2, 12, 12, 8, 1, 970, DateTimeKind.Local).AddTicks(9762) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 12, 12, 8, 1, 970, DateTimeKind.Local).AddTicks(9764), new DateTime(2023, 2, 12, 12, 8, 1, 970, DateTimeKind.Local).AddTicks(9764) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 12, 12, 8, 1, 970, DateTimeKind.Local).AddTicks(9770), new DateTime(2023, 2, 12, 12, 8, 1, 970, DateTimeKind.Local).AddTicks(9771) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 12, 12, 8, 1, 970, DateTimeKind.Local).AddTicks(9772), new DateTime(2023, 2, 12, 12, 8, 1, 970, DateTimeKind.Local).AddTicks(9773) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InstKey",
                table: "Cust_CustomerData");

            migrationBuilder.UpdateData(
                table: "Cust_CustomerStatus",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(4332), new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(4453), new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(4453) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(4457), new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(4462) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(4462), new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(4467) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(4467), new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(4471), new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(3787), new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(3829) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(3838), new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(3838) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(3843), new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(3843) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(3922), new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(3927) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(4397), new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(4397) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(4401), new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(4401) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(4406), new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(4406) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(4411), new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(4411) });
        }
    }
}
