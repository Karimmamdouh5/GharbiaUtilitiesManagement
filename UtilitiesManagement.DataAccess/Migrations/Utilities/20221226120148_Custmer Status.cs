using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class CustmerStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cust_CustomerStatus",
                columns: new[] { "ID", "CompanyTenantId", "DeleteBy", "DeleteDate", "InsertBy", "InsertDate", "IsDeleted", "Name", "UpdateBy", "UpdateDate" },
                values: new object[] { 1, null, null, null, null, new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9215), false, "سارى", null, new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9215) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9262), new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9262) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9264), new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9264) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9267), new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9267) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9270), new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9270) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9279), new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9282) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9080), new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9091) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9097), new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9099), new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9100), new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9101) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9102), new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9102) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9232), new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9232) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9235), new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9236) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9237), new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9237) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9239), new DateTime(2022, 12, 26, 14, 1, 46, 958, DateTimeKind.Local).AddTicks(9240) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cust_CustomerStatus",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2941), new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2942) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2943), new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2943) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2945), new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2945) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2946), new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2947) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2948), new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2948) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2797), new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2806) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2807), new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2808) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2809), new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2811), new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2811) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2812), new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2813) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2918), new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2921), new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2921) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2922), new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2923) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2924), new DateTime(2022, 12, 26, 12, 25, 20, 816, DateTimeKind.Local).AddTicks(2924) });
        }
    }
}
