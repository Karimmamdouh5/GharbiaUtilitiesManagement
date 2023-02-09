using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class MessegingDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Noti_Message",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserSender_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReadOnly = table.Column<bool>(type: "bit", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Noti_Message", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Noti_Message_Perm_Users_UserSender_Id",
                        column: x => x.UserSender_Id,
                        principalTable: "Perm_Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Noti_MessageUser",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Message_Id = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Noti_MessageUser", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Noti_MessageUser_Noti_Message_Message_Id",
                        column: x => x.Message_Id,
                        principalTable: "Noti_Message",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Noti_MessageUser_Perm_Users_User_Id",
                        column: x => x.User_Id,
                        principalTable: "Perm_Users",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7637), new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7637) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7639), new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7639) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7641), new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7641) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7642), new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7643) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7644), new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7644) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7477), new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7488) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7490), new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7491) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7492), new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7493) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7495), new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7495) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7496), new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7497) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7610), new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7611) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7613), new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7613) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7615), new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7615) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7616), new DateTime(2022, 10, 2, 14, 34, 42, 592, DateTimeKind.Local).AddTicks(7617) });

            migrationBuilder.CreateIndex(
                name: "IX_Noti_Message_UserSender_Id",
                table: "Noti_Message",
                column: "UserSender_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Noti_MessageUser_Message_Id",
                table: "Noti_MessageUser",
                column: "Message_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Noti_MessageUser_User_Id",
                table: "Noti_MessageUser",
                column: "User_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Noti_MessageUser");

            migrationBuilder.DropTable(
                name: "Noti_Message");

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(4007), new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(4008) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(4009), new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(4009) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(4011), new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(4011) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(4012), new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(4012) });

            migrationBuilder.UpdateData(
                table: "Hr_Status",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(4013), new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(4014) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(3851), new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(3861) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(3863), new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(3863) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(3864), new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(3865) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 10040,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(3866), new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(3866) });

            migrationBuilder.UpdateData(
                table: "Opr_MeterStatus",
                keyColumn: "ID",
                keyValue: 20131,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(3867), new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(3868) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(3978), new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(3979) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(3980), new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(3981) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(3984), new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(3984) });

            migrationBuilder.UpdateData(
                table: "Opr_UpdatedCustomerTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(3985), new DateTime(2022, 10, 2, 14, 22, 45, 823, DateTimeKind.Local).AddTicks(3986) });
        }
    }
}
