using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class BuildingDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationUserBranches",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Branch_Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserBranches", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ApplicationUserBranches_Perm_Users_User_Id",
                        column: x => x.User_Id,
                        principalTable: "Perm_Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ApplicationUserBranches_Shar_Branches_Branch_Id",
                        column: x => x.Branch_Id,
                        principalTable: "Shar_Branches",
                        principalColumn: "ID");
                });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(2074), new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(2075) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(2076), new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(2076) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(2078), new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(2078) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(2079), new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(2079) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(2081), new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(2081) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(1923), new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(1934), new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(1935) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(1936), new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(1936) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(1938), new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(1938) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(1939), new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(1940) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(2048), new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(2049) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(2050), new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(2051) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(2052), new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(2052) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(2053), new DateTime(2022, 10, 12, 21, 14, 31, 484, DateTimeKind.Local).AddTicks(2054) });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserBranches_Branch_Id",
                table: "ApplicationUserBranches",
                column: "Branch_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserBranches_User_Id",
                table: "ApplicationUserBranches",
                column: "User_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserBranches");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7637), new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7637) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7639), new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7639) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7641), new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7641) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7642), new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7643) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7644), new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7644) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7477), new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7488) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7490), new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7491) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7492), new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7493) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7495), new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7495) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7496), new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7497) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7610), new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7611) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7613), new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7613) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7615), new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7615) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7616), new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7617) });
        }
    }
}
