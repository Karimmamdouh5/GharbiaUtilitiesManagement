using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class BuildingGeoSystem2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shar_Areas_SharCity_City_Id",
                table: "Shar_Areas");

            migrationBuilder.DropForeignKey(
                name: "FK_SharCity_Shar_States_State_Id",
                table: "SharCity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SharCity",
                table: "SharCity");

            migrationBuilder.RenameTable(
                name: "SharCity",
                newName: "SharCities");

            migrationBuilder.RenameIndex(
                name: "IX_SharCity_State_Id",
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
                values: new object[] { new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(5998), new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(5998) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(6000), new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(6000) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(6001), new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(6002) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(6003), new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(6003) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(6049), new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(6049) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(5835), new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(5845) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(5847), new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(5848) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(5849), new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(5849) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(5851), new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(5851) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(5852), new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(5853) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(5971), new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(5972) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(5973), new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(5974) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(5975), new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(5975) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(5977), new DateTime(2022, 12, 11, 14, 18, 31, 760, DateTimeKind.Local).AddTicks(5977) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                newName: "SharCity");

            migrationBuilder.RenameIndex(
                name: "IX_SharCities_State_Id",
                table: "SharCity",
                newName: "IX_SharCity_State_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SharCity",
                table: "SharCity",
                column: "ID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Shar_Areas_SharCity_City_Id",
                table: "Shar_Areas",
                column: "City_Id",
                principalTable: "SharCity",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SharCity_Shar_States_State_Id",
                table: "SharCity",
                column: "State_Id",
                principalTable: "Shar_States",
                principalColumn: "ID");
        }
    }
}
