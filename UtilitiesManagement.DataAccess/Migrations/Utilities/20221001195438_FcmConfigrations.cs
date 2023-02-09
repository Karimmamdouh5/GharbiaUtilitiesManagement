using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class FcmConfigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Noti_FcmConfig",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsAndroid = table.Column<bool>(type: "bit", nullable: false),
                    apiKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    authDomain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    projectId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    storageBucket = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    messagingSenderId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    appId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    measurementId = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Noti_FcmConfig", x => x.ID);
                });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7637), new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7638) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7639), new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7641), new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7642) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7643), new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7643) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7644), new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7645) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7462), new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7472), new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7473) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7474), new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7474) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7476), new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7476) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7477), new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7478) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7613), new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7614) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7616), new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7616) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7617), new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7618) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7619), new DateTime(2022, 10, 1, 21, 54, 38, 144, DateTimeKind.Local).AddTicks(7620) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Noti_FcmConfig");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8177), new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8177) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8179), new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8179) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8181), new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8181) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8182), new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8183) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8184), new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8185) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8024), new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8031) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8033), new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8034) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8035), new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8036) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8037), new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8037) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8039), new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8039) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8152), new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8153) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8154), new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8155) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8156), new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8157) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8158), new DateTime(2022, 9, 21, 14, 2, 26, 748, DateTimeKind.Local).AddTicks(8158) });
        }
    }
}
