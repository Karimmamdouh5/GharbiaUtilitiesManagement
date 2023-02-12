using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class BuildingGeoSystem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shar_Areas_Shar_Branches_Branch_Id",
                table: "Shar_Areas");

            migrationBuilder.DropForeignKey(
                name: "FK_Shar_Blocks_Shar_Areas_SharAreaId",
                table: "Shar_Blocks");

            migrationBuilder.DropForeignKey(
                name: "FK_Shar_Blocks_Shar_States_StateId",
                table: "Shar_Blocks");

            migrationBuilder.DropForeignKey(
                name: "FK_Shar_States_Shar_Areas_Area_Id",
                table: "Shar_States");

            migrationBuilder.DropIndex(
                name: "IX_Shar_Blocks_SharAreaId",
                table: "Shar_Blocks");

            migrationBuilder.DropColumn(
                name: "SharAreaId",
                table: "Shar_Blocks");

            migrationBuilder.RenameColumn(
                name: "Area_Id",
                table: "Shar_States",
                newName: "Branch_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Shar_States_Area_Id",
                table: "Shar_States",
                newName: "IX_Shar_States_Branch_Id");

            migrationBuilder.RenameColumn(
                name: "StateId",
                table: "Shar_Blocks",
                newName: "Area_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Shar_Blocks_StateId",
                table: "Shar_Blocks",
                newName: "IX_Shar_Blocks_Area_Id");

            migrationBuilder.RenameColumn(
                name: "Branch_Id",
                table: "Shar_Areas",
                newName: "City_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Shar_Areas_Branch_Id",
                table: "Shar_Areas",
                newName: "IX_Shar_Areas_City_Id");

            migrationBuilder.CreateTable(
                name: "SharCity",
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
                    table.PrimaryKey("PK_SharCity", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SharCity_Shar_States_State_Id",
                        column: x => x.State_Id,
                        principalTable: "Shar_States",
                        principalColumn: "ID");
                });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 13, 31, 4, 833, DateTimeKind.Local).AddTicks(3646), new DateTime(2022, 12, 11, 13, 31, 4, 833, DateTimeKind.Local).AddTicks(3646) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 13, 31, 4, 833, DateTimeKind.Local).AddTicks(3648), new DateTime(2022, 12, 11, 13, 31, 4, 833, DateTimeKind.Local).AddTicks(3649) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 13, 31, 4, 833, DateTimeKind.Local).AddTicks(3650), new DateTime(2022, 12, 11, 13, 31, 4, 833, DateTimeKind.Local).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 13, 31, 4, 833, DateTimeKind.Local).AddTicks(3651), new DateTime(2022, 12, 11, 13, 31, 4, 833, DateTimeKind.Local).AddTicks(3652) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 13, 31, 4, 833, DateTimeKind.Local).AddTicks(3653), new DateTime(2022, 12, 11, 13, 31, 4, 833, DateTimeKind.Local).AddTicks(3653) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 13, 31, 4, 833, DateTimeKind.Local).AddTicks(3501), new DateTime(2022, 12, 11, 13, 31, 4, 833, DateTimeKind.Local).AddTicks(3508) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 13, 31, 4, 833, DateTimeKind.Local).AddTicks(3510), new DateTime(2022, 12, 11, 13, 31, 4, 833, DateTimeKind.Local).AddTicks(3510) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 13, 31, 4, 833, DateTimeKind.Local).AddTicks(3511), new DateTime(2022, 12, 11, 13, 31, 4, 833, DateTimeKind.Local).AddTicks(3512) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 13, 31, 4, 833, DateTimeKind.Local).AddTicks(3513), new DateTime(2022, 12, 11, 13, 31, 4, 833, DateTimeKind.Local).AddTicks(3513) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 13, 31, 4, 833, DateTimeKind.Local).AddTicks(3514), new DateTime(2022, 12, 11, 13, 31, 4, 833, DateTimeKind.Local).AddTicks(3515) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 13, 31, 4, 833, DateTimeKind.Local).AddTicks(3623), new DateTime(2022, 12, 11, 13, 31, 4, 833, DateTimeKind.Local).AddTicks(3624) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 13, 31, 4, 833, DateTimeKind.Local).AddTicks(3625), new DateTime(2022, 12, 11, 13, 31, 4, 833, DateTimeKind.Local).AddTicks(3625) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 13, 31, 4, 833, DateTimeKind.Local).AddTicks(3627), new DateTime(2022, 12, 11, 13, 31, 4, 833, DateTimeKind.Local).AddTicks(3627) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 13, 31, 4, 833, DateTimeKind.Local).AddTicks(3628), new DateTime(2022, 12, 11, 13, 31, 4, 833, DateTimeKind.Local).AddTicks(3629) });

            migrationBuilder.CreateIndex(
                name: "IX_SharCity_State_Id",
                table: "SharCity",
                column: "State_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Shar_Areas_SharCity_City_Id",
                table: "Shar_Areas",
                column: "City_Id",
                principalTable: "SharCity",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Shar_Blocks_Shar_Areas_Area_Id",
                table: "Shar_Blocks",
                column: "Area_Id",
                principalTable: "Shar_Areas",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Shar_States_Shar_Branches_Branch_Id",
                table: "Shar_States",
                column: "Branch_Id",
                principalTable: "Shar_Branches",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shar_Areas_SharCity_City_Id",
                table: "Shar_Areas");

            migrationBuilder.DropForeignKey(
                name: "FK_Shar_Blocks_Shar_Areas_Area_Id",
                table: "Shar_Blocks");

            migrationBuilder.DropForeignKey(
                name: "FK_Shar_States_Shar_Branches_Branch_Id",
                table: "Shar_States");

            migrationBuilder.DropTable(
                name: "SharCity");

            migrationBuilder.RenameColumn(
                name: "Branch_Id",
                table: "Shar_States",
                newName: "Area_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Shar_States_Branch_Id",
                table: "Shar_States",
                newName: "IX_Shar_States_Area_Id");

            migrationBuilder.RenameColumn(
                name: "Area_Id",
                table: "Shar_Blocks",
                newName: "StateId");

            migrationBuilder.RenameIndex(
                name: "IX_Shar_Blocks_Area_Id",
                table: "Shar_Blocks",
                newName: "IX_Shar_Blocks_StateId");

            migrationBuilder.RenameColumn(
                name: "City_Id",
                table: "Shar_Areas",
                newName: "Branch_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Shar_Areas_City_Id",
                table: "Shar_Areas",
                newName: "IX_Shar_Areas_Branch_Id");

            migrationBuilder.AddColumn<long>(
                name: "SharAreaId",
                table: "Shar_Blocks",
                type: "bigint",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7977), new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7978) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7979), new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7980) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(8011), new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(8013), new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(8013) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(8014), new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(8015) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7834), new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7842) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7843), new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7844) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7845), new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7845) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7847), new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7847) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7848), new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7849) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7955), new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7956) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7958), new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7958) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7960), new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7960) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7961), new DateTime(2022, 12, 11, 1, 1, 17, 343, DateTimeKind.Local).AddTicks(7962) });

            migrationBuilder.CreateIndex(
                name: "IX_Shar_Blocks_SharAreaId",
                table: "Shar_Blocks",
                column: "SharAreaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shar_Areas_Shar_Branches_Branch_Id",
                table: "Shar_Areas",
                column: "Branch_Id",
                principalTable: "Shar_Branches",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Shar_Blocks_Shar_Areas_SharAreaId",
                table: "Shar_Blocks",
                column: "SharAreaId",
                principalTable: "Shar_Areas",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Shar_Blocks_Shar_States_StateId",
                table: "Shar_Blocks",
                column: "StateId",
                principalTable: "Shar_States",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Shar_States_Shar_Areas_Area_Id",
                table: "Shar_States",
                column: "Area_Id",
                principalTable: "Shar_Areas",
                principalColumn: "ID");
        }
    }
}
