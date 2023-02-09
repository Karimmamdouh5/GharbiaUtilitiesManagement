using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class SharedTempBillTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shar_Bills_Temp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BRANCH_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BRANCH_Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City_Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AREA_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AREA_Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Block_Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ADDRESS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ACTIVITY_TYPE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CUSTOMER_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BILL_KEY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BILL_PRINTED_DATE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LAST_READING = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CURRENT_READING = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ASSIGNED_TO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NUMBER_OF_UNITS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BILL_AMOUNT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CUST_KEY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CUST_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bill_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Shar_Bills_Temp", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Cust_CustomerStatus",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(4205), new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(4428), new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(4428) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(4433), new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(4433) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(4438), new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(4438) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(4442), new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(4442) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(4447), new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(4447) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(3823), new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(3846) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(3846), new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(3851) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(3851), new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(3851) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(3856), new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(3856) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(4265), new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(4265) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(4340), new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(4344) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(4344), new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(4349) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(4349), new DateTime(2023, 1, 29, 11, 39, 34, 922, DateTimeKind.Local).AddTicks(4349) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shar_Bills_Temp");

            migrationBuilder.UpdateData(
                table: "Cust_CustomerStatus",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 28, 23, 57, 10, 615, DateTimeKind.Local).AddTicks(8943), new DateTime(2023, 1, 28, 23, 57, 10, 615, DateTimeKind.Local).AddTicks(8947) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 28, 23, 57, 10, 615, DateTimeKind.Local).AddTicks(9147), new DateTime(2023, 1, 28, 23, 57, 10, 615, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 28, 23, 57, 10, 615, DateTimeKind.Local).AddTicks(9157), new DateTime(2023, 1, 28, 23, 57, 10, 615, DateTimeKind.Local).AddTicks(9161) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 28, 23, 57, 10, 615, DateTimeKind.Local).AddTicks(9166), new DateTime(2023, 1, 28, 23, 57, 10, 615, DateTimeKind.Local).AddTicks(9166) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 28, 23, 57, 10, 615, DateTimeKind.Local).AddTicks(9171), new DateTime(2023, 1, 28, 23, 57, 10, 615, DateTimeKind.Local).AddTicks(9175) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 28, 23, 57, 10, 615, DateTimeKind.Local).AddTicks(9180), new DateTime(2023, 1, 28, 23, 57, 10, 615, DateTimeKind.Local).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 28, 23, 57, 10, 615, DateTimeKind.Local).AddTicks(8328), new DateTime(2023, 1, 28, 23, 57, 10, 615, DateTimeKind.Local).AddTicks(8375) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 28, 23, 57, 10, 615, DateTimeKind.Local).AddTicks(8379), new DateTime(2023, 1, 28, 23, 57, 10, 615, DateTimeKind.Local).AddTicks(8384) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 28, 23, 57, 10, 615, DateTimeKind.Local).AddTicks(8389), new DateTime(2023, 1, 28, 23, 57, 10, 615, DateTimeKind.Local).AddTicks(8389) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 28, 23, 57, 10, 615, DateTimeKind.Local).AddTicks(8393), new DateTime(2023, 1, 28, 23, 57, 10, 615, DateTimeKind.Local).AddTicks(8393) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 28, 23, 57, 10, 615, DateTimeKind.Local).AddTicks(9026), new DateTime(2023, 1, 28, 23, 57, 10, 615, DateTimeKind.Local).AddTicks(9031) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 28, 23, 57, 10, 615, DateTimeKind.Local).AddTicks(9036), new DateTime(2023, 1, 28, 23, 57, 10, 615, DateTimeKind.Local).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 28, 23, 57, 10, 615, DateTimeKind.Local).AddTicks(9040), new DateTime(2023, 1, 28, 23, 57, 10, 615, DateTimeKind.Local).AddTicks(9045) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 28, 23, 57, 10, 615, DateTimeKind.Local).AddTicks(9050), new DateTime(2023, 1, 28, 23, 57, 10, 615, DateTimeKind.Local).AddTicks(9050) });
        }
    }
}
