using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GharbiaUtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class changescustomersandreaders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ImageRequired",
                table: "Opr_UpdatedCustomerTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "NationalId",
                table: "Opr_UpdatedCustomers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "PreviousReading",
                table: "Opr_MeterReadings",
                type: "float",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCustomerComplaint",
                table: "Opr_Complaints",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "InstKey",
                table: "Cust_CustomerData",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NationalId",
                table: "Cust_CustomerData",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ReadingAvg",
                table: "Cust_CustomerActivities",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyTenantId",
                table: "Bill_PaymentTransactions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeleteBy",
                table: "Bill_PaymentTransactions",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "Bill_PaymentTransactions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsertBy",
                table: "Bill_PaymentTransactions",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                table: "Bill_PaymentTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Bill_PaymentTransactions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "Bill_PaymentTransactions",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Bill_PaymentTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CompanyTenantId",
                table: "Bill_PaymentSafes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeleteBy",
                table: "Bill_PaymentSafes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "Bill_PaymentSafes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsertBy",
                table: "Bill_PaymentSafes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                table: "Bill_PaymentSafes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Bill_PaymentSafes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "Bill_PaymentSafes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Bill_PaymentSafes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CompanyTenantId",
                table: "Bill_Payment",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeleteBy",
                table: "Bill_Payment",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "Bill_Payment",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsertBy",
                table: "Bill_Payment",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                table: "Bill_Payment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Bill_Payment",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "PaymentType_Id",
                table: "Bill_Payment",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "Bill_Payment",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Bill_Payment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CompanyTenantId",
                table: "Bill_PayDataLogDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeleteBy",
                table: "Bill_PayDataLogDetails",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "Bill_PayDataLogDetails",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsertBy",
                table: "Bill_PayDataLogDetails",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                table: "Bill_PayDataLogDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Bill_PayDataLogDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "Bill_PayDataLogDetails",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Bill_PayDataLogDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Bill_PaymentType",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SysName = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Bill_PaymentType", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Bill_PaymentType",
                columns: new[] { "ID", "CompanyTenantId", "DeleteBy", "DeleteDate", "InsertBy", "InsertDate", "IsDeleted", "Name", "SysName", "UpdateBy", "UpdateDate" },
                values: new object[,]
                {
                    { 1, null, null, null, null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "كاش", "cash", null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, null, null, null, null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "شيك", "cheque", null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, null, null, null, null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "فيزا", "visa", null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "Cust_CustomerStatus",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "ImageRequired", "InsertDate", "UpdateDate" },
                values: new object[] { true, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Opr_UpdatedCustomerTypes",
                columns: new[] { "ID", "CompanyTenantId", "DeleteBy", "DeleteDate", "ImageRequired", "InsertBy", "InsertDate", "IsDeleted", "Name", "SysName", "UpdateBy", "UpdateDate" },
                values: new object[] { 5, null, null, null, true, null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "الرقم القومى", "nationalid", null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_Bill_Payment_PaymentType_Id",
                table: "Bill_Payment",
                column: "PaymentType_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_Payment_Bill_PaymentType_PaymentType_Id",
                table: "Bill_Payment",
                column: "PaymentType_Id",
                principalTable: "Bill_PaymentType",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_Payment_Bill_PaymentType_PaymentType_Id",
                table: "Bill_Payment");

            migrationBuilder.DropTable(
                name: "Bill_PaymentType");

            migrationBuilder.DropIndex(
                name: "IX_Bill_Payment_PaymentType_Id",
                table: "Bill_Payment");

            migrationBuilder.DeleteData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "ImageRequired",
                table: "Opr_UpdatedCustomerTypes");

            migrationBuilder.DropColumn(
                name: "NationalId",
                table: "Opr_UpdatedCustomers");

            migrationBuilder.DropColumn(
                name: "IsCustomerComplaint",
                table: "Opr_Complaints");

            migrationBuilder.DropColumn(
                name: "InstKey",
                table: "Cust_CustomerData");

            migrationBuilder.DropColumn(
                name: "NationalId",
                table: "Cust_CustomerData");

            migrationBuilder.DropColumn(
                name: "ReadingAvg",
                table: "Cust_CustomerActivities");

            migrationBuilder.DropColumn(
                name: "CompanyTenantId",
                table: "Bill_PaymentTransactions");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "Bill_PaymentTransactions");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "Bill_PaymentTransactions");

            migrationBuilder.DropColumn(
                name: "InsertBy",
                table: "Bill_PaymentTransactions");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                table: "Bill_PaymentTransactions");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Bill_PaymentTransactions");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "Bill_PaymentTransactions");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Bill_PaymentTransactions");

            migrationBuilder.DropColumn(
                name: "CompanyTenantId",
                table: "Bill_PaymentSafes");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "Bill_PaymentSafes");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "Bill_PaymentSafes");

            migrationBuilder.DropColumn(
                name: "InsertBy",
                table: "Bill_PaymentSafes");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                table: "Bill_PaymentSafes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Bill_PaymentSafes");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "Bill_PaymentSafes");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Bill_PaymentSafes");

            migrationBuilder.DropColumn(
                name: "CompanyTenantId",
                table: "Bill_Payment");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "Bill_Payment");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "Bill_Payment");

            migrationBuilder.DropColumn(
                name: "InsertBy",
                table: "Bill_Payment");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                table: "Bill_Payment");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Bill_Payment");

            migrationBuilder.DropColumn(
                name: "PaymentType_Id",
                table: "Bill_Payment");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "Bill_Payment");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Bill_Payment");

            migrationBuilder.DropColumn(
                name: "CompanyTenantId",
                table: "Bill_PayDataLogDetails");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "Bill_PayDataLogDetails");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "Bill_PayDataLogDetails");

            migrationBuilder.DropColumn(
                name: "InsertBy",
                table: "Bill_PayDataLogDetails");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                table: "Bill_PayDataLogDetails");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Bill_PayDataLogDetails");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "Bill_PayDataLogDetails");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Bill_PayDataLogDetails");

            migrationBuilder.AlterColumn<string>(
                name: "PreviousReading",
                table: "Opr_MeterReadings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

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
        }
    }
}
