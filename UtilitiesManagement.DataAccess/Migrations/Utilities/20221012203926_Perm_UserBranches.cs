using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class Perm_UserBranches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserBranches_Perm_Users_User_Id",
                table: "ApplicationUserBranches");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserBranches_Shar_Branches_Branch_Id",
                table: "ApplicationUserBranches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationUserBranches",
                table: "ApplicationUserBranches");

            migrationBuilder.RenameTable(
                name: "ApplicationUserBranches",
                newName: "Perm_UserBranches");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationUserBranches_User_Id",
                table: "Perm_UserBranches",
                newName: "IX_Perm_UserBranches_User_Id");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationUserBranches_Branch_Id",
                table: "Perm_UserBranches",
                newName: "IX_Perm_UserBranches_Branch_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Perm_UserBranches",
                table: "Perm_UserBranches",
                column: "ID");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 39, 25, 951, DateTimeKind.Local).AddTicks(6975), new DateTime(2022, 10, 12, 22, 39, 25, 951, DateTimeKind.Local).AddTicks(6975) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 39, 25, 951, DateTimeKind.Local).AddTicks(6977), new DateTime(2022, 10, 12, 22, 39, 25, 951, DateTimeKind.Local).AddTicks(6977) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 39, 25, 951, DateTimeKind.Local).AddTicks(6979), new DateTime(2022, 10, 12, 22, 39, 25, 951, DateTimeKind.Local).AddTicks(6979) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 39, 25, 951, DateTimeKind.Local).AddTicks(6980), new DateTime(2022, 10, 12, 22, 39, 25, 951, DateTimeKind.Local).AddTicks(6981) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 39, 25, 951, DateTimeKind.Local).AddTicks(6982), new DateTime(2022, 10, 12, 22, 39, 25, 951, DateTimeKind.Local).AddTicks(6983) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 39, 25, 951, DateTimeKind.Local).AddTicks(6773), new DateTime(2022, 10, 12, 22, 39, 25, 951, DateTimeKind.Local).AddTicks(6785) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 39, 25, 951, DateTimeKind.Local).AddTicks(6787), new DateTime(2022, 10, 12, 22, 39, 25, 951, DateTimeKind.Local).AddTicks(6787) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 39, 25, 951, DateTimeKind.Local).AddTicks(6789), new DateTime(2022, 10, 12, 22, 39, 25, 951, DateTimeKind.Local).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 39, 25, 951, DateTimeKind.Local).AddTicks(6790), new DateTime(2022, 10, 12, 22, 39, 25, 951, DateTimeKind.Local).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 39, 25, 951, DateTimeKind.Local).AddTicks(6792), new DateTime(2022, 10, 12, 22, 39, 25, 951, DateTimeKind.Local).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 39, 25, 951, DateTimeKind.Local).AddTicks(6920), new DateTime(2022, 10, 12, 22, 39, 25, 951, DateTimeKind.Local).AddTicks(6921) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 39, 25, 951, DateTimeKind.Local).AddTicks(6922), new DateTime(2022, 10, 12, 22, 39, 25, 951, DateTimeKind.Local).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 39, 25, 951, DateTimeKind.Local).AddTicks(6924), new DateTime(2022, 10, 12, 22, 39, 25, 951, DateTimeKind.Local).AddTicks(6924) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 39, 25, 951, DateTimeKind.Local).AddTicks(6926), new DateTime(2022, 10, 12, 22, 39, 25, 951, DateTimeKind.Local).AddTicks(6926) });

            migrationBuilder.AddForeignKey(
                name: "FK_Perm_UserBranches_Perm_Users_User_Id",
                table: "Perm_UserBranches",
                column: "User_Id",
                principalTable: "Perm_Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Perm_UserBranches_Shar_Branches_Branch_Id",
                table: "Perm_UserBranches",
                column: "Branch_Id",
                principalTable: "Shar_Branches",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Perm_UserBranches_Perm_Users_User_Id",
                table: "Perm_UserBranches");

            migrationBuilder.DropForeignKey(
                name: "FK_Perm_UserBranches_Shar_Branches_Branch_Id",
                table: "Perm_UserBranches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Perm_UserBranches",
                table: "Perm_UserBranches");

            migrationBuilder.RenameTable(
                name: "Perm_UserBranches",
                newName: "ApplicationUserBranches");

            migrationBuilder.RenameIndex(
                name: "IX_Perm_UserBranches_User_Id",
                table: "ApplicationUserBranches",
                newName: "IX_ApplicationUserBranches_User_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Perm_UserBranches_Branch_Id",
                table: "ApplicationUserBranches",
                newName: "IX_ApplicationUserBranches_Branch_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUserBranches",
                table: "ApplicationUserBranches",
                column: "ID");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(488), new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(489) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(490), new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(491) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(492), new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(492) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(494), new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(494) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(495), new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(496) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(337), new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(346) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(348), new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(348) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(350), new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(350) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(351), new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(352) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(353), new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(354) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(460), new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(460) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(463), new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(463) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(464), new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(468), new DateTime(2022, 10, 12, 22, 24, 57, 555, DateTimeKind.Local).AddTicks(468) });

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserBranches_Perm_Users_User_Id",
                table: "ApplicationUserBranches",
                column: "User_Id",
                principalTable: "Perm_Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserBranches_Shar_Branches_Branch_Id",
                table: "ApplicationUserBranches",
                column: "Branch_Id",
                principalTable: "Shar_Branches",
                principalColumn: "ID");
        }
    }
}
