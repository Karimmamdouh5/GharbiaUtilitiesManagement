using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class RemoveTableId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PermMenus");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PermMenus",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsLast = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentId = table.Column<long>(type: "bigint", nullable: false),
                    Permission = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Route = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermMenus", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8306), new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8307) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8308), new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8308) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8309), new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8311), new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8311) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8312), new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8312) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8175), new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8183) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8185), new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8185) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8187), new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8187) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8188), new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8188) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8189), new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8190) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8283), new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8283) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8285), new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8285) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8287), new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8287) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8288), new DateTime(2022, 8, 9, 11, 23, 2, 997, DateTimeKind.Local).AddTicks(8289) });
        }
    }
}
