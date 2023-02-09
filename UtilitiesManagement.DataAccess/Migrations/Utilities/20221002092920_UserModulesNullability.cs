using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class UserModulesNullability : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "User_Id",
                table: "Noti_UserModule",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "Module_Id",
                table: "Noti_UserModule",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "User_Id",
                table: "Noti_UserModule",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Module_Id",
                table: "Noti_UserModule",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 10, 10, 28, 442, DateTimeKind.Local).AddTicks(7573), new DateTime(2022, 10, 2, 10, 10, 28, 442, DateTimeKind.Local).AddTicks(7573) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 10, 10, 28, 442, DateTimeKind.Local).AddTicks(7575), new DateTime(2022, 10, 2, 10, 10, 28, 442, DateTimeKind.Local).AddTicks(7575) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 10, 10, 28, 442, DateTimeKind.Local).AddTicks(7577), new DateTime(2022, 10, 2, 10, 10, 28, 442, DateTimeKind.Local).AddTicks(7577) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 10, 10, 28, 442, DateTimeKind.Local).AddTicks(7579), new DateTime(2022, 10, 2, 10, 10, 28, 442, DateTimeKind.Local).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 10, 10, 28, 442, DateTimeKind.Local).AddTicks(7581), new DateTime(2022, 10, 2, 10, 10, 28, 442, DateTimeKind.Local).AddTicks(7581) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 10, 10, 28, 442, DateTimeKind.Local).AddTicks(7401), new DateTime(2022, 10, 2, 10, 10, 28, 442, DateTimeKind.Local).AddTicks(7416) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 10, 10, 28, 442, DateTimeKind.Local).AddTicks(7418), new DateTime(2022, 10, 2, 10, 10, 28, 442, DateTimeKind.Local).AddTicks(7419) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 10, 10, 28, 442, DateTimeKind.Local).AddTicks(7420), new DateTime(2022, 10, 2, 10, 10, 28, 442, DateTimeKind.Local).AddTicks(7421) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 10, 10, 28, 442, DateTimeKind.Local).AddTicks(7422), new DateTime(2022, 10, 2, 10, 10, 28, 442, DateTimeKind.Local).AddTicks(7422) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 10, 10, 28, 442, DateTimeKind.Local).AddTicks(7424), new DateTime(2022, 10, 2, 10, 10, 28, 442, DateTimeKind.Local).AddTicks(7424) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 10, 10, 28, 442, DateTimeKind.Local).AddTicks(7548), new DateTime(2022, 10, 2, 10, 10, 28, 442, DateTimeKind.Local).AddTicks(7549) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 10, 10, 28, 442, DateTimeKind.Local).AddTicks(7551), new DateTime(2022, 10, 2, 10, 10, 28, 442, DateTimeKind.Local).AddTicks(7552) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 10, 10, 28, 442, DateTimeKind.Local).AddTicks(7553), new DateTime(2022, 10, 2, 10, 10, 28, 442, DateTimeKind.Local).AddTicks(7554) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 10, 10, 28, 442, DateTimeKind.Local).AddTicks(7555), new DateTime(2022, 10, 2, 10, 10, 28, 442, DateTimeKind.Local).AddTicks(7555) });
        }
    }
}
