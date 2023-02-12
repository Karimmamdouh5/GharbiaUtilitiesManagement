using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class customerdatabaseentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Opr_UpdetedCustomers_Cust_CustomerActivities_CustomerActivity_Id",
                table: "Opr_UpdetedCustomers");

            migrationBuilder.DropForeignKey(
                name: "FK_Opr_UpdetedCustomers_Cust_CustomerData_CustomerData_Id",
                table: "Opr_UpdetedCustomers");

            migrationBuilder.DropForeignKey(
                name: "FK_Opr_UpdetedCustomers_Hr_Employees_Employee_Id",
                table: "Opr_UpdetedCustomers");

            migrationBuilder.DropForeignKey(
                name: "FK_Opr_UpdetedCustomers_Opr_UpdatedCustomerTypes_UpdatedCustomerType_Id",
                table: "Opr_UpdetedCustomers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Opr_UpdetedCustomers",
                table: "Opr_UpdetedCustomers");

            migrationBuilder.RenameTable(
                name: "Opr_UpdetedCustomers",
                newName: "Opr_UpdatedCustomers");

            migrationBuilder.RenameIndex(
                name: "IX_Opr_UpdetedCustomers_UpdatedCustomerType_Id",
                table: "Opr_UpdatedCustomers",
                newName: "IX_Opr_UpdatedCustomers_UpdatedCustomerType_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Opr_UpdetedCustomers_Employee_Id",
                table: "Opr_UpdatedCustomers",
                newName: "IX_Opr_UpdatedCustomers_Employee_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Opr_UpdetedCustomers_CustomerData_Id",
                table: "Opr_UpdatedCustomers",
                newName: "IX_Opr_UpdatedCustomers_CustomerData_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Opr_UpdetedCustomers_CustomerActivity_Id",
                table: "Opr_UpdatedCustomers",
                newName: "IX_Opr_UpdatedCustomers_CustomerActivity_Id");

            migrationBuilder.AddColumn<int>(
                name: "CompanyTenantId",
                table: "Cust_CustomerData",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeleteBy",
                table: "Cust_CustomerData",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "Cust_CustomerData",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsertBy",
                table: "Cust_CustomerData",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                table: "Cust_CustomerData",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Cust_CustomerData",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "Cust_CustomerData",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Cust_CustomerData",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Opr_UpdatedCustomers",
                table: "Opr_UpdatedCustomers",
                column: "ID");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(281), new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(282) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(285), new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(285) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(288), new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(288) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(290), new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(291) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(293), new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(294) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(47), new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(57) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(60), new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(61) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(63), new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(64) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(67), new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(68) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(70), new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(70) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(233), new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(234) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(237), new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(237) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(245), new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(246) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(248), new DateTime(2022, 7, 24, 22, 28, 43, 545, DateTimeKind.Local).AddTicks(249) });

            migrationBuilder.AddForeignKey(
                name: "FK_Opr_UpdatedCustomers_Cust_CustomerActivities_CustomerActivity_Id",
                table: "Opr_UpdatedCustomers",
                column: "CustomerActivity_Id",
                principalTable: "Cust_CustomerActivities",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Opr_UpdatedCustomers_Cust_CustomerData_CustomerData_Id",
                table: "Opr_UpdatedCustomers",
                column: "CustomerData_Id",
                principalTable: "Cust_CustomerData",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Opr_UpdatedCustomers_Hr_Employees_Employee_Id",
                table: "Opr_UpdatedCustomers",
                column: "Employee_Id",
                principalTable: "Hr_Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Opr_UpdatedCustomers_Opr_UpdatedCustomerTypes_UpdatedCustomerType_Id",
                table: "Opr_UpdatedCustomers",
                column: "UpdatedCustomerType_Id",
                principalTable: "Opr_UpdatedCustomerTypes",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Opr_UpdatedCustomers_Cust_CustomerActivities_CustomerActivity_Id",
                table: "Opr_UpdatedCustomers");

            migrationBuilder.DropForeignKey(
                name: "FK_Opr_UpdatedCustomers_Cust_CustomerData_CustomerData_Id",
                table: "Opr_UpdatedCustomers");

            migrationBuilder.DropForeignKey(
                name: "FK_Opr_UpdatedCustomers_Hr_Employees_Employee_Id",
                table: "Opr_UpdatedCustomers");

            migrationBuilder.DropForeignKey(
                name: "FK_Opr_UpdatedCustomers_Opr_UpdatedCustomerTypes_UpdatedCustomerType_Id",
                table: "Opr_UpdatedCustomers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Opr_UpdatedCustomers",
                table: "Opr_UpdatedCustomers");

            migrationBuilder.DropColumn(
                name: "CompanyTenantId",
                table: "Cust_CustomerData");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "Cust_CustomerData");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "Cust_CustomerData");

            migrationBuilder.DropColumn(
                name: "InsertBy",
                table: "Cust_CustomerData");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                table: "Cust_CustomerData");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Cust_CustomerData");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "Cust_CustomerData");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Cust_CustomerData");

            migrationBuilder.RenameTable(
                name: "Opr_UpdatedCustomers",
                newName: "Opr_UpdetedCustomers");

            migrationBuilder.RenameIndex(
                name: "IX_Opr_UpdatedCustomers_UpdatedCustomerType_Id",
                table: "Opr_UpdetedCustomers",
                newName: "IX_Opr_UpdetedCustomers_UpdatedCustomerType_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Opr_UpdatedCustomers_Employee_Id",
                table: "Opr_UpdetedCustomers",
                newName: "IX_Opr_UpdetedCustomers_Employee_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Opr_UpdatedCustomers_CustomerData_Id",
                table: "Opr_UpdetedCustomers",
                newName: "IX_Opr_UpdetedCustomers_CustomerData_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Opr_UpdatedCustomers_CustomerActivity_Id",
                table: "Opr_UpdetedCustomers",
                newName: "IX_Opr_UpdetedCustomers_CustomerActivity_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Opr_UpdetedCustomers",
                table: "Opr_UpdetedCustomers",
                column: "ID");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6960), new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6961) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6964), new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6964) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6967), new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6968) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6970), new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6970) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6973), new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6716), new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6723) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6735), new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6736) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6739), new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6742), new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6743) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6746), new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6746) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6918), new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6923), new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6924) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6926), new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6927) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6929), new DateTime(2022, 7, 24, 20, 31, 51, 514, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.AddForeignKey(
                name: "FK_Opr_UpdetedCustomers_Cust_CustomerActivities_CustomerActivity_Id",
                table: "Opr_UpdetedCustomers",
                column: "CustomerActivity_Id",
                principalTable: "Cust_CustomerActivities",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Opr_UpdetedCustomers_Cust_CustomerData_CustomerData_Id",
                table: "Opr_UpdetedCustomers",
                column: "CustomerData_Id",
                principalTable: "Cust_CustomerData",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Opr_UpdetedCustomers_Hr_Employees_Employee_Id",
                table: "Opr_UpdetedCustomers",
                column: "Employee_Id",
                principalTable: "Hr_Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Opr_UpdetedCustomers_Opr_UpdatedCustomerTypes_UpdatedCustomerType_Id",
                table: "Opr_UpdetedCustomers",
                column: "UpdatedCustomerType_Id",
                principalTable: "Opr_UpdatedCustomerTypes",
                principalColumn: "ID");
        }
    }
}
