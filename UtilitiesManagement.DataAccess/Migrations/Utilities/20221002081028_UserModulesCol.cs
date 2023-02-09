using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class UserModulesCol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyTenantId",
                table: "Noti_UserModule",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeleteBy",
                table: "Noti_UserModule",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "Noti_UserModule",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsertBy",
                table: "Noti_UserModule",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                table: "Noti_UserModule",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Noti_UserModule",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "Noti_UserModule",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Noti_UserModule",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyTenantId",
                table: "Noti_UserModule");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "Noti_UserModule");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "Noti_UserModule");

            migrationBuilder.DropColumn(
                name: "InsertBy",
                table: "Noti_UserModule");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                table: "Noti_UserModule");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Noti_UserModule");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "Noti_UserModule");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Noti_UserModule");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3324), new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3328), new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3328) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3330), new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3331) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3332), new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3333) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3335), new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3335) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3127), new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3138) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3141), new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3142) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3144), new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3146), new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3147) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3149), new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3149) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3293), new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3294) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3296), new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3297) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3299), new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3299) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3301), new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3302) });
        }
    }
}
