using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class BuildingTempTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shar_Areas_SharCities_City_Id",
                table: "Shar_Areas");

            migrationBuilder.DropForeignKey(
                name: "FK_SharCities_Shar_States_State_Id",
                table: "SharCities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SharCities",
                table: "SharCities");

            migrationBuilder.RenameTable(
                name: "SharCities",
                newName: "Shar_Cities");

            migrationBuilder.RenameIndex(
                name: "IX_SharCities_State_Id",
                table: "Shar_Cities",
                newName: "IX_Shar_Cities_State_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shar_Cities",
                table: "Shar_Cities",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "Shar_Areas_Temp",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    AreaCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AreaName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    City_Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shar_Areas_Temp", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Shar_Cities_Temp",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    CityCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    State_Id = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_Shar_Cities_Temp", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Shar_States_Temp",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    StateCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    Branch_Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shar_States_Temp", x => x.ID);
                });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Shar_Areas_Shar_Cities_City_Id",
                table: "Shar_Areas",
                column: "City_Id",
                principalTable: "Shar_Cities",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Shar_Cities_Shar_States_State_Id",
                table: "Shar_Cities",
                column: "State_Id",
                principalTable: "Shar_States",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shar_Areas_Shar_Cities_City_Id",
                table: "Shar_Areas");

            migrationBuilder.DropForeignKey(
                name: "FK_Shar_Cities_Shar_States_State_Id",
                table: "Shar_Cities");

            migrationBuilder.DropTable(
                name: "Shar_Areas_Temp");

            migrationBuilder.DropTable(
                name: "Shar_Cities_Temp");

            migrationBuilder.DropTable(
                name: "Shar_States_Temp");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shar_Cities",
                table: "Shar_Cities");

            migrationBuilder.RenameTable(
                name: "Shar_Cities",
                newName: "SharCities");

            migrationBuilder.RenameIndex(
                name: "IX_Shar_Cities_State_Id",
                table: "SharCities",
                newName: "IX_SharCities_State_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SharCities",
                table: "SharCities",
                column: "ID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Shar_Areas_SharCities_City_Id",
                table: "Shar_Areas",
                column: "City_Id",
                principalTable: "SharCities",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SharCities_Shar_States_State_Id",
                table: "SharCities",
                column: "State_Id",
                principalTable: "Shar_States",
                principalColumn: "ID");
        }
    }
}
