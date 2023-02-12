using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class removeRelationEmployeeBlocks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Shar_Company",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<int>(
                name: "MobileUsersCount",
                table: "Shar_Company",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 41, 56, 954, DateTimeKind.Local).AddTicks(104), new DateTime(2022, 7, 24, 16, 41, 56, 954, DateTimeKind.Local).AddTicks(105) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 41, 56, 954, DateTimeKind.Local).AddTicks(107), new DateTime(2022, 7, 24, 16, 41, 56, 954, DateTimeKind.Local).AddTicks(107) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 41, 56, 954, DateTimeKind.Local).AddTicks(109), new DateTime(2022, 7, 24, 16, 41, 56, 954, DateTimeKind.Local).AddTicks(109) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 41, 56, 954, DateTimeKind.Local).AddTicks(111), new DateTime(2022, 7, 24, 16, 41, 56, 954, DateTimeKind.Local).AddTicks(111) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 41, 56, 954, DateTimeKind.Local).AddTicks(112), new DateTime(2022, 7, 24, 16, 41, 56, 954, DateTimeKind.Local).AddTicks(113) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 41, 56, 953, DateTimeKind.Local).AddTicks(9917), new DateTime(2022, 7, 24, 16, 41, 56, 953, DateTimeKind.Local).AddTicks(9924) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 41, 56, 953, DateTimeKind.Local).AddTicks(9926), new DateTime(2022, 7, 24, 16, 41, 56, 953, DateTimeKind.Local).AddTicks(9927) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 41, 56, 953, DateTimeKind.Local).AddTicks(9929), new DateTime(2022, 7, 24, 16, 41, 56, 953, DateTimeKind.Local).AddTicks(9929) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 41, 56, 953, DateTimeKind.Local).AddTicks(9931), new DateTime(2022, 7, 24, 16, 41, 56, 953, DateTimeKind.Local).AddTicks(9931) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 41, 56, 953, DateTimeKind.Local).AddTicks(9932), new DateTime(2022, 7, 24, 16, 41, 56, 953, DateTimeKind.Local).AddTicks(9933) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 41, 56, 954, DateTimeKind.Local).AddTicks(69), new DateTime(2022, 7, 24, 16, 41, 56, 954, DateTimeKind.Local).AddTicks(70) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 41, 56, 954, DateTimeKind.Local).AddTicks(72), new DateTime(2022, 7, 24, 16, 41, 56, 954, DateTimeKind.Local).AddTicks(72) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 41, 56, 954, DateTimeKind.Local).AddTicks(80), new DateTime(2022, 7, 24, 16, 41, 56, 954, DateTimeKind.Local).AddTicks(81) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 16, 41, 56, 954, DateTimeKind.Local).AddTicks(83), new DateTime(2022, 7, 24, 16, 41, 56, 954, DateTimeKind.Local).AddTicks(83) });

            migrationBuilder.CreateIndex(
                name: "IX_Hr_EmployeeBlocks_BlockID",
                table: "Hr_EmployeeBlocks",
                column: "BlockID");

            migrationBuilder.AddForeignKey(
                name: "FK_Hr_EmployeeBlocks_Shar_Blocks_BlockID",
                table: "Hr_EmployeeBlocks",
                column: "BlockID",
                principalTable: "Shar_Blocks",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hr_EmployeeBlocks_Shar_Blocks_BlockID",
                table: "Hr_EmployeeBlocks");

            migrationBuilder.DropIndex(
                name: "IX_Hr_EmployeeBlocks_BlockID",
                table: "Hr_EmployeeBlocks");

            migrationBuilder.DropColumn(
                name: "MobileUsersCount",
                table: "Shar_Company");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Shar_Company",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2974), new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2975) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2977), new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2977) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2979), new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2979) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2981), new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2981) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2983), new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2798), new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2806) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2809), new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2809) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2811), new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2811) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2813), new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2814) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2815), new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2816) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2948), new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2949) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2951), new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2952) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2953), new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2954) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2956), new DateTime(2022, 7, 22, 17, 4, 36, 962, DateTimeKind.Local).AddTicks(2956) });
        }
    }
}
