using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class SharBranch_TempwITHbASEeNTITY : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyTenantId",
                table: "Shar_Branches_Temp",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeleteBy",
                table: "Shar_Branches_Temp",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "Shar_Branches_Temp",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsertBy",
                table: "Shar_Branches_Temp",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                table: "Shar_Branches_Temp",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Shar_Branches_Temp",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "Shar_Branches_Temp",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Shar_Branches_Temp",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 12, 10, 52, 7, 914, DateTimeKind.Local).AddTicks(7416), new DateTime(2022, 12, 12, 10, 52, 7, 914, DateTimeKind.Local).AddTicks(7417) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 12, 10, 52, 7, 914, DateTimeKind.Local).AddTicks(7418), new DateTime(2022, 12, 12, 10, 52, 7, 914, DateTimeKind.Local).AddTicks(7418) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 12, 10, 52, 7, 914, DateTimeKind.Local).AddTicks(7420), new DateTime(2022, 12, 12, 10, 52, 7, 914, DateTimeKind.Local).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 12, 10, 52, 7, 914, DateTimeKind.Local).AddTicks(7421), new DateTime(2022, 12, 12, 10, 52, 7, 914, DateTimeKind.Local).AddTicks(7422) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 12, 10, 52, 7, 914, DateTimeKind.Local).AddTicks(7423), new DateTime(2022, 12, 12, 10, 52, 7, 914, DateTimeKind.Local).AddTicks(7423) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 12, 10, 52, 7, 914, DateTimeKind.Local).AddTicks(7237), new DateTime(2022, 12, 12, 10, 52, 7, 914, DateTimeKind.Local).AddTicks(7248) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 12, 10, 52, 7, 914, DateTimeKind.Local).AddTicks(7250), new DateTime(2022, 12, 12, 10, 52, 7, 914, DateTimeKind.Local).AddTicks(7251) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 12, 10, 52, 7, 914, DateTimeKind.Local).AddTicks(7252), new DateTime(2022, 12, 12, 10, 52, 7, 914, DateTimeKind.Local).AddTicks(7253) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 12, 10, 52, 7, 914, DateTimeKind.Local).AddTicks(7254), new DateTime(2022, 12, 12, 10, 52, 7, 914, DateTimeKind.Local).AddTicks(7254) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 12, 10, 52, 7, 914, DateTimeKind.Local).AddTicks(7256), new DateTime(2022, 12, 12, 10, 52, 7, 914, DateTimeKind.Local).AddTicks(7256) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 12, 10, 52, 7, 914, DateTimeKind.Local).AddTicks(7389), new DateTime(2022, 12, 12, 10, 52, 7, 914, DateTimeKind.Local).AddTicks(7390) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 12, 10, 52, 7, 914, DateTimeKind.Local).AddTicks(7392), new DateTime(2022, 12, 12, 10, 52, 7, 914, DateTimeKind.Local).AddTicks(7393) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 12, 10, 52, 7, 914, DateTimeKind.Local).AddTicks(7394), new DateTime(2022, 12, 12, 10, 52, 7, 914, DateTimeKind.Local).AddTicks(7395) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 12, 10, 52, 7, 914, DateTimeKind.Local).AddTicks(7396), new DateTime(2022, 12, 12, 10, 52, 7, 914, DateTimeKind.Local).AddTicks(7397) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyTenantId",
                table: "Shar_Branches_Temp");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "Shar_Branches_Temp");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "Shar_Branches_Temp");

            migrationBuilder.DropColumn(
                name: "InsertBy",
                table: "Shar_Branches_Temp");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                table: "Shar_Branches_Temp");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Shar_Branches_Temp");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "Shar_Branches_Temp");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Shar_Branches_Temp");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 12, 9, 59, 20, 236, DateTimeKind.Local).AddTicks(6702), new DateTime(2022, 12, 12, 9, 59, 20, 236, DateTimeKind.Local).AddTicks(6703) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 12, 9, 59, 20, 236, DateTimeKind.Local).AddTicks(6705), new DateTime(2022, 12, 12, 9, 59, 20, 236, DateTimeKind.Local).AddTicks(6705) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 12, 9, 59, 20, 236, DateTimeKind.Local).AddTicks(6706), new DateTime(2022, 12, 12, 9, 59, 20, 236, DateTimeKind.Local).AddTicks(6707) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 12, 9, 59, 20, 236, DateTimeKind.Local).AddTicks(6708), new DateTime(2022, 12, 12, 9, 59, 20, 236, DateTimeKind.Local).AddTicks(6708) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 12, 9, 59, 20, 236, DateTimeKind.Local).AddTicks(6710), new DateTime(2022, 12, 12, 9, 59, 20, 236, DateTimeKind.Local).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 12, 9, 59, 20, 236, DateTimeKind.Local).AddTicks(6528), new DateTime(2022, 12, 12, 9, 59, 20, 236, DateTimeKind.Local).AddTicks(6537) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 12, 9, 59, 20, 236, DateTimeKind.Local).AddTicks(6543), new DateTime(2022, 12, 12, 9, 59, 20, 236, DateTimeKind.Local).AddTicks(6543) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 12, 9, 59, 20, 236, DateTimeKind.Local).AddTicks(6544), new DateTime(2022, 12, 12, 9, 59, 20, 236, DateTimeKind.Local).AddTicks(6545) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 12, 9, 59, 20, 236, DateTimeKind.Local).AddTicks(6546), new DateTime(2022, 12, 12, 9, 59, 20, 236, DateTimeKind.Local).AddTicks(6546) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 12, 9, 59, 20, 236, DateTimeKind.Local).AddTicks(6547), new DateTime(2022, 12, 12, 9, 59, 20, 236, DateTimeKind.Local).AddTicks(6548) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 12, 9, 59, 20, 236, DateTimeKind.Local).AddTicks(6653), new DateTime(2022, 12, 12, 9, 59, 20, 236, DateTimeKind.Local).AddTicks(6653) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 12, 9, 59, 20, 236, DateTimeKind.Local).AddTicks(6678), new DateTime(2022, 12, 12, 9, 59, 20, 236, DateTimeKind.Local).AddTicks(6679) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 12, 9, 59, 20, 236, DateTimeKind.Local).AddTicks(6680), new DateTime(2022, 12, 12, 9, 59, 20, 236, DateTimeKind.Local).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 12, 9, 59, 20, 236, DateTimeKind.Local).AddTicks(6682), new DateTime(2022, 12, 12, 9, 59, 20, 236, DateTimeKind.Local).AddTicks(6682) });
        }
    }
}
