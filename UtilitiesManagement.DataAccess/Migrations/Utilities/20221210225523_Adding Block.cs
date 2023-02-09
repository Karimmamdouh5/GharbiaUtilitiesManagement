using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class AddingBlock : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shar_Blocks_Shar_Areas_Area_Id",
                table: "Shar_Blocks");

            migrationBuilder.RenameColumn(
                name: "Area_Id",
                table: "Shar_Blocks",
                newName: "StateId");

            migrationBuilder.RenameIndex(
                name: "IX_Shar_Blocks_Area_Id",
                table: "Shar_Blocks",
                newName: "IX_Shar_Blocks_StateId");

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
                values: new object[] { new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(3074), new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(3075) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(3076), new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(3077) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(3078), new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(3078) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(3080), new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(3081), new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(3082) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(2907), new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(2917) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(2918), new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(2920), new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(2922), new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(2922) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(2923), new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(3048), new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(3049) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(3051), new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(3051) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(3053), new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(3053) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(3054), new DateTime(2022, 12, 11, 0, 55, 22, 644, DateTimeKind.Local).AddTicks(3055) });

            migrationBuilder.CreateIndex(
                name: "IX_Shar_Blocks_SharAreaId",
                table: "Shar_Blocks",
                column: "SharAreaId");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shar_Blocks_Shar_Areas_SharAreaId",
                table: "Shar_Blocks");

            migrationBuilder.DropForeignKey(
                name: "FK_Shar_Blocks_Shar_States_StateId",
                table: "Shar_Blocks");

            migrationBuilder.DropIndex(
                name: "IX_Shar_Blocks_SharAreaId",
                table: "Shar_Blocks");

            migrationBuilder.DropColumn(
                name: "SharAreaId",
                table: "Shar_Blocks");

            migrationBuilder.RenameColumn(
                name: "StateId",
                table: "Shar_Blocks",
                newName: "Area_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Shar_Blocks_StateId",
                table: "Shar_Blocks",
                newName: "IX_Shar_Blocks_Area_Id");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4574), new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4575) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4577), new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4577) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4579), new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4579) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4580), new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4581) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4582), new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4582) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4418), new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4427) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4429), new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4429) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4431), new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4431) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4433), new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4433) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4434), new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4435) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4547), new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4548) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4550), new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4550) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4552), new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4552) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4553), new DateTime(2022, 12, 11, 0, 25, 32, 255, DateTimeKind.Local).AddTicks(4554) });

            migrationBuilder.AddForeignKey(
                name: "FK_Shar_Blocks_Shar_Areas_Area_Id",
                table: "Shar_Blocks",
                column: "Area_Id",
                principalTable: "Shar_Areas",
                principalColumn: "ID");
        }
    }
}
