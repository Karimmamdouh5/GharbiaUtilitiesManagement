using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class AddBaseEntityTOApplicationUserBranches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyTenantId",
                table: "ApplicationUserBranches",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeleteBy",
                table: "ApplicationUserBranches",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "ApplicationUserBranches",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsertBy",
                table: "ApplicationUserBranches",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                table: "ApplicationUserBranches",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ApplicationUserBranches",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "ApplicationUserBranches",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "ApplicationUserBranches",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(488), new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(489) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(490), new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(491) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(492), new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(492) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(494), new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(494) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(495), new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(496) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(337), new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(346) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(348), new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(348) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(350), new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(350) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(351), new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(352) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(353), new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(354) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(460), new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(460) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(463), new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(463) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(464), new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(468), new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(468) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyTenantId",
                table: "ApplicationUserBranches");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "ApplicationUserBranches");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "ApplicationUserBranches");

            migrationBuilder.DropColumn(
                name: "InsertBy",
                table: "ApplicationUserBranches");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                table: "ApplicationUserBranches");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ApplicationUserBranches");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "ApplicationUserBranches");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "ApplicationUserBranches");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(2074), new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(2075) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(2076), new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(2076) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(2078), new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(2078) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(2079), new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(2079) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(2081), new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(2081) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(1923), new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(1934), new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(1935) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(1936), new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(1936) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(1938), new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(1938) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(1939), new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(1940) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(2048), new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(2049) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(2050), new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(2051) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(2052), new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(2052) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(2053), new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(2054) });
        }
    }
}
