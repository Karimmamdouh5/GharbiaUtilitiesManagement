using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class CustomerUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MeterStartIssue",
                table: "Cust_CustomerData",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "MeterDiameter",
                table: "Cust_CustomerData",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "Cust_CustomerData",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerStartIssue",
                table: "Cust_CustomerData",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "ActivityStarIssue",
                table: "Cust_CustomerData",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MeterStartIssue",
                table: "Cust_CustomerData",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MeterDiameter",
                table: "Cust_CustomerData",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "Cust_CustomerData",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerStartIssue",
                table: "Cust_CustomerData",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ActivityStarIssue",
                table: "Cust_CustomerData",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Cust_CustomerStatus",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2582), new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2583) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2621), new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2622) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2623), new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2623) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2625), new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2625) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2627), new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2627) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2628), new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2629) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2438), new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2447) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2449), new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2451), new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2452) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2453), new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2453) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2599), new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2599) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2603), new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2604) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2605), new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2606) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2607), new DateTime(2023, 1, 10, 13, 32, 57, 618, DateTimeKind.Local).AddTicks(2607) });
        }
    }
}
