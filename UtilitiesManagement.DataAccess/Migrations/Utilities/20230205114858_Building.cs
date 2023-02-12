using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class Building : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "BillPaymentSafe_Id",
                table: "Bill_Payment",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Bill_Safes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
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
                    table.PrimaryKey("PK_Bill_Safes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Bill_PaymentSafes",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillSafe_Id = table.Column<int>(type: "int", nullable: false),
                    HrEmployee_Id = table.Column<long>(type: "bigint", nullable: false),
                    TotalAmount = table.Column<double>(type: "float", nullable: false),
                    IsPosted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bill_PaymentSafes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Bill_PaymentSafes_Bill_Safes_BillSafe_Id",
                        column: x => x.BillSafe_Id,
                        principalTable: "Bill_Safes",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Bill_PaymentSafes_Hr_Employees_HrEmployee_Id",
                        column: x => x.HrEmployee_Id,
                        principalTable: "Hr_Employees",
                        principalColumn: "ID");
                });

            migrationBuilder.UpdateData(
                table: "Cust_CustomerStatus",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(4332), new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(4453), new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(4453) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(4457), new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(4462) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(4462), new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(4467) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(4467), new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(4471), new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(3787), new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(3829) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(3838), new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(3838) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(3843), new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(3843) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(3922), new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(3927) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(4397), new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(4397) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(4401), new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(4401) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(4406), new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(4406) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(4411), new DateTime(2023, 2, 5, 13, 48, 56, 951, DateTimeKind.Local).AddTicks(4411) });

            migrationBuilder.CreateIndex(
                name: "IX_Bill_Payment_BillPaymentSafe_Id",
                table: "Bill_Payment",
                column: "BillPaymentSafe_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_PaymentSafes_BillSafe_Id",
                table: "Bill_PaymentSafes",
                column: "BillSafe_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_PaymentSafes_HrEmployee_Id",
                table: "Bill_PaymentSafes",
                column: "HrEmployee_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_Payment_Bill_PaymentSafes_BillPaymentSafe_Id",
                table: "Bill_Payment",
                column: "BillPaymentSafe_Id",
                principalTable: "Bill_PaymentSafes",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_Payment_Bill_PaymentSafes_BillPaymentSafe_Id",
                table: "Bill_Payment");

            migrationBuilder.DropTable(
                name: "Bill_PaymentSafes");

            migrationBuilder.DropTable(
                name: "Bill_Safes");

            migrationBuilder.DropIndex(
                name: "IX_Bill_Payment_BillPaymentSafe_Id",
                table: "Bill_Payment");

            migrationBuilder.DropColumn(
                name: "BillPaymentSafe_Id",
                table: "Bill_Payment");

            migrationBuilder.UpdateData(
                table: "Cust_CustomerStatus",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(7180), new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(7185) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(7348), new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(7348) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(7353), new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(7357) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(7357), new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(7362) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(7362), new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(7362) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(7366), new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(7371) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(6729), new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(6766) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(6771), new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(6771) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(6775), new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(6780), new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(6780) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(7250), new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(7255) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(7259), new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(7259) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(7264), new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(7264) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(7269), new DateTime(2023, 1, 29, 22, 59, 5, 271, DateTimeKind.Local).AddTicks(7269) });
        }
    }
}
