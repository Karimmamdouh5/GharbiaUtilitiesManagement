using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class AddingState_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shar_States",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    StateCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    StateName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
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
                    table.PrimaryKey("PK_Shar_States", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Shar_States_Shar_Areas_Area_Id",
                        column: x => x.Area_Id,
                        principalTable: "Shar_Areas",
                        principalColumn: "ID");
                });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(3052), new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(3052) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(3054), new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(3054) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(3055), new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(3056) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(3057), new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(3057) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(3058), new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(3059) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(2906), new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(2914) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(2916), new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(2916) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(2917), new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(2918) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(2919), new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(2920), new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(2921) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(3026), new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(3027) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(3029), new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(3029) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(3030), new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(3031) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(3032), new DateTime(2022, 12, 11, 0, 15, 51, 992, DateTimeKind.Local).AddTicks(3032) });

            migrationBuilder.CreateIndex(
                name: "IX_Shar_States_Area_Id",
                table: "Shar_States",
                column: "Area_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shar_States");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7475), new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7475) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7477), new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7477) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7478), new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7479) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7480), new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7481), new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7482) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7307), new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7315) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7340), new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7342), new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7342) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7343), new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7344) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7345), new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7345) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7450), new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7451) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7452), new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7453) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7454), new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7454) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7456), new DateTime(2022, 12, 11, 0, 11, 58, 830, DateTimeKind.Local).AddTicks(7456) });
        }
    }
}
