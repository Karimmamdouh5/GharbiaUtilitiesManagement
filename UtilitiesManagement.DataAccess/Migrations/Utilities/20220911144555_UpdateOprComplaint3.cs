using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class UpdateOprComplaint3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "PublicBlock_Id",
                table: "Opr_Complaints",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4938), new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4939) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4940), new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4941) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4942), new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4943) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4944), new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4945) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4947), new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4947) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4789), new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4800) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4803), new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4803) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4804), new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4805) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4806), new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4806) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4808), new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4808) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4914), new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4917), new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4917) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4919), new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4919) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4920), new DateTime(2022, 9, 11, 16, 45, 54, 773, DateTimeKind.Local).AddTicks(4921) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PublicBlock_Id",
                table: "Opr_Complaints",
                type: "int",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

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
    }
}
