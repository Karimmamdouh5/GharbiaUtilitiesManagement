using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class PymentLogs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bill_PayDataLog",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_Id = table.Column<long>(type: "bigint", nullable: false),
                    PayDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Employee_Id = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_Bill_PayDataLog", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Bill_PayDataLog_Cust_CustomerData_Customer_Id",
                        column: x => x.Customer_Id,
                        principalTable: "Cust_CustomerData",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Bill_PayDataLog_Hr_Employees_Employee_Id",
                        column: x => x.Employee_Id,
                        principalTable: "Hr_Employees",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Bill_PayDataLogDetails",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bill_Id = table.Column<long>(type: "bigint", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    BillDataId = table.Column<long>(type: "bigint", nullable: false),
                    PayDataLogId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bill_PayDataLogDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Bill_PayDataLogDetails_Bill_BillData_BillDataId",
                        column: x => x.BillDataId,
                        principalTable: "Bill_BillData",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Bill_PayDataLogDetails_Bill_PayDataLog_PayDataLogId",
                        column: x => x.PayDataLogId,
                        principalTable: "Bill_PayDataLog",
                        principalColumn: "ID");
                });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3937), new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3938) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3939), new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3940) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3941), new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3941) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3943), new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3943) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3944), new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3945) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3791), new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3804) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3805), new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3806) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3807), new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3808) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3809), new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3809) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3810), new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3811) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3913), new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3914) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3915), new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3916) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3917), new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3917) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3919), new DateTime(2022, 10, 12, 23, 38, 35, 790, DateTimeKind.Local).AddTicks(3919) });

            migrationBuilder.CreateIndex(
                name: "IX_Bill_PayDataLog_Customer_Id",
                table: "Bill_PayDataLog",
                column: "Customer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_PayDataLog_Employee_Id",
                table: "Bill_PayDataLog",
                column: "Employee_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_PayDataLogDetails_BillDataId",
                table: "Bill_PayDataLogDetails",
                column: "BillDataId");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_PayDataLogDetails_PayDataLogId",
                table: "Bill_PayDataLogDetails",
                column: "PayDataLogId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bill_PayDataLogDetails");

            migrationBuilder.DropTable(
                name: "Bill_PayDataLog");

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
        }
    }
}
