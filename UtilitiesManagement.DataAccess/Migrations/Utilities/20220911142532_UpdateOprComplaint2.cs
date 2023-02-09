using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class UpdateOprComplaint2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Customer_Id",
                table: "Opr_Complaints",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<bool>(
                name: "IsPublic",
                table: "Opr_Complaints",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PublicAddress",
                table: "Opr_Complaints",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PublicBlock_Id",
                table: "Opr_Complaints",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 25, 32, 130, DateTimeKind.Local).AddTicks(4446), new DateTime(2022, 9, 11, 16, 25, 32, 130, DateTimeKind.Local).AddTicks(4446) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 25, 32, 130, DateTimeKind.Local).AddTicks(4448), new DateTime(2022, 9, 11, 16, 25, 32, 130, DateTimeKind.Local).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 25, 32, 130, DateTimeKind.Local).AddTicks(4449), new DateTime(2022, 9, 11, 16, 25, 32, 130, DateTimeKind.Local).AddTicks(4450) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 25, 32, 130, DateTimeKind.Local).AddTicks(4451), new DateTime(2022, 9, 11, 16, 25, 32, 130, DateTimeKind.Local).AddTicks(4451) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 25, 32, 130, DateTimeKind.Local).AddTicks(4452), new DateTime(2022, 9, 11, 16, 25, 32, 130, DateTimeKind.Local).AddTicks(4453) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 25, 32, 130, DateTimeKind.Local).AddTicks(4294), new DateTime(2022, 9, 11, 16, 25, 32, 130, DateTimeKind.Local).AddTicks(4302) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 25, 32, 130, DateTimeKind.Local).AddTicks(4304), new DateTime(2022, 9, 11, 16, 25, 32, 130, DateTimeKind.Local).AddTicks(4304) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 25, 32, 130, DateTimeKind.Local).AddTicks(4306), new DateTime(2022, 9, 11, 16, 25, 32, 130, DateTimeKind.Local).AddTicks(4306) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 25, 32, 130, DateTimeKind.Local).AddTicks(4307), new DateTime(2022, 9, 11, 16, 25, 32, 130, DateTimeKind.Local).AddTicks(4308) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 25, 32, 130, DateTimeKind.Local).AddTicks(4309), new DateTime(2022, 9, 11, 16, 25, 32, 130, DateTimeKind.Local).AddTicks(4309) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 25, 32, 130, DateTimeKind.Local).AddTicks(4423), new DateTime(2022, 9, 11, 16, 25, 32, 130, DateTimeKind.Local).AddTicks(4424) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 25, 32, 130, DateTimeKind.Local).AddTicks(4426), new DateTime(2022, 9, 11, 16, 25, 32, 130, DateTimeKind.Local).AddTicks(4426) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 25, 32, 130, DateTimeKind.Local).AddTicks(4427), new DateTime(2022, 9, 11, 16, 25, 32, 130, DateTimeKind.Local).AddTicks(4428) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 25, 32, 130, DateTimeKind.Local).AddTicks(4429), new DateTime(2022, 9, 11, 16, 25, 32, 130, DateTimeKind.Local).AddTicks(4429) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPublic",
                table: "Opr_Complaints");

            migrationBuilder.DropColumn(
                name: "PublicAddress",
                table: "Opr_Complaints");

            migrationBuilder.DropColumn(
                name: "PublicBlock_Id",
                table: "Opr_Complaints");

            migrationBuilder.AlterColumn<long>(
                name: "Customer_Id",
                table: "Opr_Complaints",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8474), new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8475) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8477), new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8478) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8479), new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8480) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8482), new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8482) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8484), new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8485) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8279), new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8293) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8296), new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8297) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8298), new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8299) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8301), new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8301) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8303), new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8303) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8444), new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8445) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8447), new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8450), new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8450) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8452), new DateTime(2022, 9, 7, 14, 35, 50, 621, DateTimeKind.Local).AddTicks(8453) });
        }
    }
}
