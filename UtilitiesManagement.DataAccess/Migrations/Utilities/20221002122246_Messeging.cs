using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class Messeging : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(4007), new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(4008) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(4009), new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(4009) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(4011), new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(4011) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(4012), new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(4012) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(4013), new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(4014) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(3851), new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(3861) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(3863), new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(3863) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(3864), new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(3865) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(3866), new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(3866) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(3867), new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(3868) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(3978), new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(3979) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(3980), new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(3981) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(3984), new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(3984) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(3985), new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(3986) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 11, 29, 20, 1, DateTimeKind.Local).AddTicks(7233), new DateTime(2022, 10, 2, 11, 29, 20, 1, DateTimeKind.Local).AddTicks(7235) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 11, 29, 20, 1, DateTimeKind.Local).AddTicks(7238), new DateTime(2022, 10, 2, 11, 29, 20, 1, DateTimeKind.Local).AddTicks(7239) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 11, 29, 20, 1, DateTimeKind.Local).AddTicks(7242), new DateTime(2022, 10, 2, 11, 29, 20, 1, DateTimeKind.Local).AddTicks(7243) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 11, 29, 20, 1, DateTimeKind.Local).AddTicks(7245), new DateTime(2022, 10, 2, 11, 29, 20, 1, DateTimeKind.Local).AddTicks(7246) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 11, 29, 20, 1, DateTimeKind.Local).AddTicks(7249), new DateTime(2022, 10, 2, 11, 29, 20, 1, DateTimeKind.Local).AddTicks(7250) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 11, 29, 20, 1, DateTimeKind.Local).AddTicks(6932), new DateTime(2022, 10, 2, 11, 29, 20, 1, DateTimeKind.Local).AddTicks(6947) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 11, 29, 20, 1, DateTimeKind.Local).AddTicks(6951), new DateTime(2022, 10, 2, 11, 29, 20, 1, DateTimeKind.Local).AddTicks(6952) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 11, 29, 20, 1, DateTimeKind.Local).AddTicks(6955), new DateTime(2022, 10, 2, 11, 29, 20, 1, DateTimeKind.Local).AddTicks(6956) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 11, 29, 20, 1, DateTimeKind.Local).AddTicks(6959), new DateTime(2022, 10, 2, 11, 29, 20, 1, DateTimeKind.Local).AddTicks(6960) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 11, 29, 20, 1, DateTimeKind.Local).AddTicks(6962), new DateTime(2022, 10, 2, 11, 29, 20, 1, DateTimeKind.Local).AddTicks(6963) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 11, 29, 20, 1, DateTimeKind.Local).AddTicks(7190), new DateTime(2022, 10, 2, 11, 29, 20, 1, DateTimeKind.Local).AddTicks(7192) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 11, 29, 20, 1, DateTimeKind.Local).AddTicks(7195), new DateTime(2022, 10, 2, 11, 29, 20, 1, DateTimeKind.Local).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 11, 29, 20, 1, DateTimeKind.Local).AddTicks(7199), new DateTime(2022, 10, 2, 11, 29, 20, 1, DateTimeKind.Local).AddTicks(7200) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 11, 29, 20, 1, DateTimeKind.Local).AddTicks(7203), new DateTime(2022, 10, 2, 11, 29, 20, 1, DateTimeKind.Local).AddTicks(7204) });
        }
    }
}
