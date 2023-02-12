using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class Modules : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Noti_FcmModules",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Noti_FcmModules", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserNoti_Modules",
                columns: table => new
                {
                    FcmModulesId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserNoti_Modules", x => new { x.FcmModulesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserNoti_Modules_Noti_FcmModules_FcmModulesId",
                        column: x => x.FcmModulesId,
                        principalTable: "Noti_FcmModules",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ApplicationUserNoti_Modules_Perm_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Perm_Users",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 23, 2, 12, 267, DateTimeKind.Local).AddTicks(6465), new DateTime(2022, 10, 1, 23, 2, 12, 267, DateTimeKind.Local).AddTicks(6466) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 23, 2, 12, 267, DateTimeKind.Local).AddTicks(6467), new DateTime(2022, 10, 1, 23, 2, 12, 267, DateTimeKind.Local).AddTicks(6467) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 23, 2, 12, 267, DateTimeKind.Local).AddTicks(6468), new DateTime(2022, 10, 1, 23, 2, 12, 267, DateTimeKind.Local).AddTicks(6469) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 23, 2, 12, 267, DateTimeKind.Local).AddTicks(6470), new DateTime(2022, 10, 1, 23, 2, 12, 267, DateTimeKind.Local).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 23, 2, 12, 267, DateTimeKind.Local).AddTicks(6471), new DateTime(2022, 10, 1, 23, 2, 12, 267, DateTimeKind.Local).AddTicks(6472) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 23, 2, 12, 267, DateTimeKind.Local).AddTicks(6295), new DateTime(2022, 10, 1, 23, 2, 12, 267, DateTimeKind.Local).AddTicks(6307) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 23, 2, 12, 267, DateTimeKind.Local).AddTicks(6308), new DateTime(2022, 10, 1, 23, 2, 12, 267, DateTimeKind.Local).AddTicks(6309) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 23, 2, 12, 267, DateTimeKind.Local).AddTicks(6310), new DateTime(2022, 10, 1, 23, 2, 12, 267, DateTimeKind.Local).AddTicks(6310) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 23, 2, 12, 267, DateTimeKind.Local).AddTicks(6311), new DateTime(2022, 10, 1, 23, 2, 12, 267, DateTimeKind.Local).AddTicks(6312) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 23, 2, 12, 267, DateTimeKind.Local).AddTicks(6313), new DateTime(2022, 10, 1, 23, 2, 12, 267, DateTimeKind.Local).AddTicks(6313) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 23, 2, 12, 267, DateTimeKind.Local).AddTicks(6444), new DateTime(2022, 10, 1, 23, 2, 12, 267, DateTimeKind.Local).AddTicks(6445) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 23, 2, 12, 267, DateTimeKind.Local).AddTicks(6446), new DateTime(2022, 10, 1, 23, 2, 12, 267, DateTimeKind.Local).AddTicks(6447) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 23, 2, 12, 267, DateTimeKind.Local).AddTicks(6448), new DateTime(2022, 10, 1, 23, 2, 12, 267, DateTimeKind.Local).AddTicks(6448) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 23, 2, 12, 267, DateTimeKind.Local).AddTicks(6450), new DateTime(2022, 10, 1, 23, 2, 12, 267, DateTimeKind.Local).AddTicks(6450) });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserNoti_Modules_UsersId",
                table: "ApplicationUserNoti_Modules",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserNoti_Modules");

            migrationBuilder.DropTable(
                name: "Noti_FcmModules");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7378), new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7379) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7380), new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7383), new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7383) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7385), new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7385) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7387), new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7387) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7214), new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7229) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7230), new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7231) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7232), new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7232) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7234), new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7234) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7235), new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7236) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7349), new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7350) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7351), new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7353), new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7354) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7355), new DateTime(2022, 10, 1, 22, 56, 6, 432, DateTimeKind.Local).AddTicks(7355) });
        }
    }
}
