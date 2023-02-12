using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class ADDINGBLOCKTEMP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shar_Blocks_Temp",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    BlockCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlockName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    Area_Id = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InsertBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DeleteBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CompanyTenantId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shar_Blocks_Temp", x => x.ID);
                });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5405), new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5406) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5407), new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5407) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5408), new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5409) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5410), new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5411) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5412), new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5412) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5248), new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5256) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5258), new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5259) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5260), new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5261) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5262), new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5264), new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5264) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5380), new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5380) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5382), new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5382) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5384), new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5384) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5386), new DateTime(2022, 12, 17, 16, 52, 29, 985, DateTimeKind.Local).AddTicks(5386) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shar_Blocks_Temp");

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
    }
}
