using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class Noti_UserModule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserNoti_Modules");

            migrationBuilder.CreateTable(
                name: "Noti_UserModule",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Module_Id = table.Column<int>(type: "int", nullable: false),
                    User_Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Noti_UserModule", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Noti_UserModule_Noti_FcmModules_Module_Id",
                        column: x => x.Module_Id,
                        principalTable: "Noti_FcmModules",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Noti_UserModule_Perm_Users_User_Id",
                        column: x => x.User_Id,
                        principalTable: "Perm_Users",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3324), new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3328), new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3328) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3330), new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3331) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3332), new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3333) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3335), new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3335) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3127), new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3138) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3141), new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3142) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3144), new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3146), new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3147) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3149), new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3149) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3293), new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3294) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3296), new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3297) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3299), new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3299) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3301), new DateTime(2022, 10, 2, 9, 30, 49, 705, DateTimeKind.Local).AddTicks(3302) });

            migrationBuilder.CreateIndex(
                name: "IX_Noti_UserModule_Module_Id",
                table: "Noti_UserModule",
                column: "Module_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Noti_UserModule_User_Id",
                table: "Noti_UserModule",
                column: "User_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Noti_UserModule");

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
    }
}
