using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class AddCollectionFlagToBillPaymentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CollectionDate",
                table: "Bill_Payment",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCollected",
                table: "Bill_Payment",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1318), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1318) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1320), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1320) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1321), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1322) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1323), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1324), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1325) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1131), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1139) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1140), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1141) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1142), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1142) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1144), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1144) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1145), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1145) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1276), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1277) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1278), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1279) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1302), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1302) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1303), new DateTime(2022, 8, 16, 10, 15, 3, 427, DateTimeKind.Local).AddTicks(1304) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CollectionDate",
                table: "Bill_Payment");

            migrationBuilder.DropColumn(
                name: "IsCollected",
                table: "Bill_Payment");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(1057), new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(1058) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(1059), new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(1060) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(1062), new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(1062) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(1064), new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(1065) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(1066), new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(1067) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(882), new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(894), new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(894) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(896), new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(896) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(898), new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(899) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(900), new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(901) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(1031), new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(1032) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(1034), new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(1034) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(1036), new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(1036) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(1038), new DateTime(2022, 8, 15, 13, 46, 48, 396, DateTimeKind.Local).AddTicks(1039) });
        }
    }
}
