using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class AddPermMenuTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Perm_Menu",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentId = table.Column<long>(type: "bigint", nullable: false),
                    IsLast = table.Column<bool>(type: "bit", nullable: false),
                    Route = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Permission = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Perm_Menu", x => x.ID);
                });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5591), new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5592) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5593), new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5593) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5595), new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5595) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5596), new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5596) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5598), new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5598) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5443), new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5452) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5453), new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5454) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5455), new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5455) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5456), new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5457) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5458), new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5458) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5568), new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5569) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5570), new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5571), new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5572) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5573), new DateTime(2022, 8, 9, 13, 15, 5, 54, DateTimeKind.Local).AddTicks(5573) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Perm_Menu");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 11, 4, 523, DateTimeKind.Local).AddTicks(3535), new DateTime(2022, 8, 9, 13, 11, 4, 523, DateTimeKind.Local).AddTicks(3535) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 11, 4, 523, DateTimeKind.Local).AddTicks(3536), new DateTime(2022, 8, 9, 13, 11, 4, 523, DateTimeKind.Local).AddTicks(3537) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 11, 4, 523, DateTimeKind.Local).AddTicks(3538), new DateTime(2022, 8, 9, 13, 11, 4, 523, DateTimeKind.Local).AddTicks(3538) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 11, 4, 523, DateTimeKind.Local).AddTicks(3544), new DateTime(2022, 8, 9, 13, 11, 4, 523, DateTimeKind.Local).AddTicks(3545) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 11, 4, 523, DateTimeKind.Local).AddTicks(3546), new DateTime(2022, 8, 9, 13, 11, 4, 523, DateTimeKind.Local).AddTicks(3546) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 11, 4, 523, DateTimeKind.Local).AddTicks(3402), new DateTime(2022, 8, 9, 13, 11, 4, 523, DateTimeKind.Local).AddTicks(3411) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 11, 4, 523, DateTimeKind.Local).AddTicks(3412), new DateTime(2022, 8, 9, 13, 11, 4, 523, DateTimeKind.Local).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 11, 4, 523, DateTimeKind.Local).AddTicks(3414), new DateTime(2022, 8, 9, 13, 11, 4, 523, DateTimeKind.Local).AddTicks(3414) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 11, 4, 523, DateTimeKind.Local).AddTicks(3415), new DateTime(2022, 8, 9, 13, 11, 4, 523, DateTimeKind.Local).AddTicks(3416) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 11, 4, 523, DateTimeKind.Local).AddTicks(3417), new DateTime(2022, 8, 9, 13, 11, 4, 523, DateTimeKind.Local).AddTicks(3417) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 11, 4, 523, DateTimeKind.Local).AddTicks(3514), new DateTime(2022, 8, 9, 13, 11, 4, 523, DateTimeKind.Local).AddTicks(3514) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 11, 4, 523, DateTimeKind.Local).AddTicks(3516), new DateTime(2022, 8, 9, 13, 11, 4, 523, DateTimeKind.Local).AddTicks(3516) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 11, 4, 523, DateTimeKind.Local).AddTicks(3517), new DateTime(2022, 8, 9, 13, 11, 4, 523, DateTimeKind.Local).AddTicks(3518) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 11, 4, 523, DateTimeKind.Local).AddTicks(3519), new DateTime(2022, 8, 9, 13, 11, 4, 523, DateTimeKind.Local).AddTicks(3519) });
        }
    }
}
