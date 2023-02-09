using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class SharBranch_Temp2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shar_Branches_Temp",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    BranchCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    Company_Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shar_Branches_Temp", x => x.ID);
                });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 51, 18, 789, DateTimeKind.Local).AddTicks(7403), new DateTime(2022, 12, 11, 16, 51, 18, 789, DateTimeKind.Local).AddTicks(7404) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 51, 18, 789, DateTimeKind.Local).AddTicks(7405), new DateTime(2022, 12, 11, 16, 51, 18, 789, DateTimeKind.Local).AddTicks(7405) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 51, 18, 789, DateTimeKind.Local).AddTicks(7407), new DateTime(2022, 12, 11, 16, 51, 18, 789, DateTimeKind.Local).AddTicks(7407) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 51, 18, 789, DateTimeKind.Local).AddTicks(7408), new DateTime(2022, 12, 11, 16, 51, 18, 789, DateTimeKind.Local).AddTicks(7409) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 51, 18, 789, DateTimeKind.Local).AddTicks(7410), new DateTime(2022, 12, 11, 16, 51, 18, 789, DateTimeKind.Local).AddTicks(7410) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 51, 18, 789, DateTimeKind.Local).AddTicks(7251), new DateTime(2022, 12, 11, 16, 51, 18, 789, DateTimeKind.Local).AddTicks(7261) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 51, 18, 789, DateTimeKind.Local).AddTicks(7263), new DateTime(2022, 12, 11, 16, 51, 18, 789, DateTimeKind.Local).AddTicks(7264) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 51, 18, 789, DateTimeKind.Local).AddTicks(7265), new DateTime(2022, 12, 11, 16, 51, 18, 789, DateTimeKind.Local).AddTicks(7265) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 51, 18, 789, DateTimeKind.Local).AddTicks(7266), new DateTime(2022, 12, 11, 16, 51, 18, 789, DateTimeKind.Local).AddTicks(7267) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 51, 18, 789, DateTimeKind.Local).AddTicks(7268), new DateTime(2022, 12, 11, 16, 51, 18, 789, DateTimeKind.Local).AddTicks(7268) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 51, 18, 789, DateTimeKind.Local).AddTicks(7378), new DateTime(2022, 12, 11, 16, 51, 18, 789, DateTimeKind.Local).AddTicks(7378) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 51, 18, 789, DateTimeKind.Local).AddTicks(7380), new DateTime(2022, 12, 11, 16, 51, 18, 789, DateTimeKind.Local).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 51, 18, 789, DateTimeKind.Local).AddTicks(7381), new DateTime(2022, 12, 11, 16, 51, 18, 789, DateTimeKind.Local).AddTicks(7382) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 51, 18, 789, DateTimeKind.Local).AddTicks(7384), new DateTime(2022, 12, 11, 16, 51, 18, 789, DateTimeKind.Local).AddTicks(7384) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shar_Branches_Temp");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(5090), new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(5091) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(5092), new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(5092) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(5093), new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(5094) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(5095), new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(5095) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(5096), new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(5097) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(4944), new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(4955) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(4957), new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(4958) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(4959), new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(4959) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(4960), new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(4961) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(4962), new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(4962) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(5069), new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(5070) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(5072), new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(5072) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(5073), new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(5074) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(5075), new DateTime(2022, 12, 11, 16, 48, 49, 89, DateTimeKind.Local).AddTicks(5075) });
        }
    }
}
