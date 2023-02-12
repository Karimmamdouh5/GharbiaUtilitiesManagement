using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class AddingCustomerTemp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cust_CustomerDataTemp",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    SubscriptionStartDate = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ActualName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ActualActivity = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CustomerStartIssue = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NumOfUnits = table.Column<int>(type: "int", nullable: false),
                    ActivityStarIssue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CustomerHasSewage = table.Column<bool>(type: "bit", nullable: false),
                    MeterChassisNum = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MeterDiameter = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MeterStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MeterStartReading = table.Column<int>(type: "int", nullable: false),
                    MeterStartIssue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    X = table.Column<double>(type: "float", nullable: true),
                    Y = table.Column<double>(type: "float", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDataComplete = table.Column<bool>(type: "bit", nullable: false),
                    Block_Id = table.Column<long>(type: "bigint", nullable: false),
                    CustomerStatus_Id = table.Column<int>(type: "int", nullable: false),
                    CustomerActivity_Id = table.Column<int>(type: "int", nullable: false),
                    PreviousReading = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PreviousReadingIssueNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_Cust_CustomerDataTemp", x => x.ID);
                });

            migrationBuilder.UpdateData(
                table: "Cust_CustomerStatus",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6369), new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6448), new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6449) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6450), new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6451) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6452), new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6452) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6453), new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6453) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6465), new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6468) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6255), new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6264) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6265), new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6266) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6267), new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6267) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6269), new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6269) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6270), new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6271) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6385), new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6385) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6387), new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6387) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6424), new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6425) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6426), new DateTime(2022, 12, 27, 16, 0, 22, 813, DateTimeKind.Local).AddTicks(6426) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cust_CustomerDataTemp");

            migrationBuilder.UpdateData(
                table: "Cust_CustomerStatus",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7765), new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7768) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7873), new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7875) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7880), new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7881) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7885), new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7890), new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7891) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7922), new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7929) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7402), new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7423) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7430), new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7431) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7435), new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7437) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7440), new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7442) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7446), new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7447) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7807), new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7809) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7814), new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7815) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7820), new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7821) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7825), new DateTime(2022, 12, 27, 14, 5, 36, 230, DateTimeKind.Local).AddTicks(7827) });
        }
    }
}
