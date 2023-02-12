using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bill_Issues",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    IssueName = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
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
                    table.PrimaryKey("PK_Bill_Issues", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Cust_CustomerActivities",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
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
                    table.PrimaryKey("PK_Cust_CustomerActivities", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Cust_CustomerStatus",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
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
                    table.PrimaryKey("PK_Cust_CustomerStatus", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Hr_EmployeeBlocks",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    CollectorID = table.Column<long>(type: "bigint", nullable: false),
                    CollectorName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    BlockID = table.Column<long>(type: "bigint", nullable: false),
                    BlockCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    BlockName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hr_EmployeeBlocks", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Hr_Status",
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
                    table.PrimaryKey("PK_Hr_Status", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Opr_ComplaintTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsAttachedImage = table.Column<bool>(type: "bit", nullable: false),
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
                    table.PrimaryKey("PK_Opr_ComplaintTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Opr_MeterStatus",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Opr_MeterStatus", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Opr_UpdatedCustomerTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
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
                    table.PrimaryKey("PK_Opr_UpdatedCustomerTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Shar_Company",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Activity = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LogoPrint = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoWeb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", maxLength: 50, nullable: false),
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
                    table.PrimaryKey("PK_Shar_Company", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Perm_Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InsertBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Company_Id = table.Column<long>(type: "bigint", nullable: false),
                    CompanyTenantId = table.Column<int>(type: "int", nullable: true),
                    Is_Admin = table.Column<bool>(type: "bit", nullable: false),
                    Is_SuperAdmin = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perm_Roles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Perm_Roles_Shar_Company_Company_Id",
                        column: x => x.Company_Id,
                        principalTable: "Shar_Company",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Perm_UserTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    TimeOfToken = table.Column<TimeSpan>(type: "time", nullable: false),
                    SysName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perm_UserTypes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Perm_UserTypes_Shar_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Shar_Company",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Shar_Branches",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    BranchCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    BranchName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    Company_Id = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_Shar_Branches", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Shar_Branches_Shar_Company_Company_Id",
                        column: x => x.Company_Id,
                        principalTable: "Shar_Company",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Perm_RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InsertBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyTenantId = table.Column<int>(type: "int", nullable: true),
                    HistoryDisc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perm_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Perm_RoleClaims_Perm_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Perm_Roles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Bill_IssueDetail",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    BillStartNum = table.Column<int>(type: "int", nullable: false),
                    BillEndNum = table.Column<int>(type: "int", nullable: false),
                    BranchIssueStatus = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CanPostReading = table.Column<bool>(type: "bit", nullable: false),
                    Issue_Id = table.Column<long>(type: "bigint", nullable: false),
                    Branch_Id = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_Bill_IssueDetail", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Bill_IssueDetail_Bill_Issues_Issue_Id",
                        column: x => x.Issue_Id,
                        principalTable: "Bill_Issues",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Bill_IssueDetail_Shar_Branches_Branch_Id",
                        column: x => x.Branch_Id,
                        principalTable: "Shar_Branches",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Hr_Employees",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Job = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status_Id = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Branch_Id = table.Column<long>(type: "bigint", nullable: false),
                    IsTechnician = table.Column<bool>(type: "bit", nullable: false),
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
                    table.PrimaryKey("PK_Hr_Employees", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Hr_Employees_Hr_Status_Status_Id",
                        column: x => x.Status_Id,
                        principalTable: "Hr_Status",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Hr_Employees_Shar_Branches_Branch_Id",
                        column: x => x.Branch_Id,
                        principalTable: "Shar_Branches",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Shar_Areas",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    AreaCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    AreaName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    Branch_Id = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_Shar_Areas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Shar_Areas_Shar_Branches_Branch_Id",
                        column: x => x.Branch_Id,
                        principalTable: "Shar_Branches",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Perm_Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Employee_Id = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InsertBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyTenantId = table.Column<int>(type: "int", nullable: true),
                    UserType_Id = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perm_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Perm_Users_Hr_Employees_Employee_Id",
                        column: x => x.Employee_Id,
                        principalTable: "Hr_Employees",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Perm_Users_Perm_UserTypes_UserType_Id",
                        column: x => x.UserType_Id,
                        principalTable: "Perm_UserTypes",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Tech_Technicians",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Employee_Id = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CanCollect = table.Column<bool>(type: "bit", nullable: false),
                    CanRead = table.Column<bool>(type: "bit", nullable: false),
                    CanComplain = table.Column<bool>(type: "bit", nullable: false),
                    CanEditCustomer = table.Column<bool>(type: "bit", nullable: false),
                    AttachImageRead = table.Column<bool>(type: "bit", nullable: false),
                    AttachImageEditCustomer = table.Column<bool>(type: "bit", nullable: false),
                    MaxOfflineWorkingHours = table.Column<int>(type: "int", nullable: false),
                    MaxOfflineWorkingBills = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Tech_Technicians", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Tech_Technicians_Hr_Employees_Employee_Id",
                        column: x => x.Employee_Id,
                        principalTable: "Hr_Employees",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Shar_Blocks",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    BlockCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    BlockName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    Area_Id = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_Shar_Blocks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Shar_Blocks_Shar_Areas_Area_Id",
                        column: x => x.Area_Id,
                        principalTable: "Shar_Areas",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Perm_OnlineUsers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AndroidId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchId = table.Column<long>(type: "bigint", nullable: true),
                    ExpireOn = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    table.PrimaryKey("PK_Perm_OnlineUsers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Perm_OnlineUsers_Perm_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Perm_Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Perm_UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InsertBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyTenantId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perm_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Perm_UserClaims_Perm_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Perm_Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Perm_UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InsertBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyTenantId = table.Column<int>(type: "int", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perm_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_Perm_UserLogins_Perm_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Perm_Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Perm_UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InsertBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyTenantId = table.Column<int>(type: "int", nullable: true),
                    HistoryDisc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perm_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_Perm_UserRoles_Perm_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Perm_Roles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Perm_UserRoles_Perm_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Perm_Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Perm_UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InsertBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyTenantId = table.Column<int>(type: "int", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perm_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_Perm_UserTokens_Perm_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Perm_Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tech_Technician_WalkingLines",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Technician_Id = table.Column<long>(type: "bigint", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    DeActiveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeActiveBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
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
                    table.PrimaryKey("PK_Tech_Technician_WalkingLines", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Tech_Technician_WalkingLines_Tech_Technicians_Technician_Id",
                        column: x => x.Technician_Id,
                        principalTable: "Tech_Technicians",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Tech_TechnicianLocations",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Technician_Id = table.Column<long>(type: "bigint", nullable: false),
                    X = table.Column<double>(type: "float", nullable: true),
                    Y = table.Column<double>(type: "float", nullable: true),
                    MobileDate = table.Column<DateTime>(type: "datetime", nullable: true),
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
                    table.PrimaryKey("PK_Tech_TechnicianLocations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Tech_TechnicianLocations_Tech_Technicians_Technician_Id",
                        column: x => x.Technician_Id,
                        principalTable: "Tech_Technicians",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Cust_CustomerData",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    SubscriptionStartDate = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ActualName = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ActualActivity = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    StartIssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumOfUnits = table.Column<int>(type: "int", nullable: false),
                    ActivityStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerHasSewage = table.Column<bool>(type: "bit", nullable: false),
                    MeterChassisNum = table.Column<int>(type: "int", nullable: false),
                    MeterDiameter = table.Column<int>(type: "int", nullable: false),
                    MeterStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MeterStartReading = table.Column<int>(type: "int", nullable: false),
                    MeterStartIssue = table.Column<DateTime>(type: "datetime2", nullable: false),
                    X = table.Column<double>(type: "float", nullable: true),
                    Y = table.Column<double>(type: "float", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDataComplete = table.Column<bool>(type: "bit", nullable: false),
                    Block_Id = table.Column<long>(type: "bigint", nullable: false),
                    CustomerStatus_Id = table.Column<int>(type: "int", nullable: false),
                    CustomerActivity_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cust_CustomerData", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Cust_CustomerData_Cust_CustomerActivities_CustomerActivity_Id",
                        column: x => x.CustomerActivity_Id,
                        principalTable: "Cust_CustomerActivities",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Cust_CustomerData_Cust_CustomerStatus_CustomerStatus_Id",
                        column: x => x.CustomerStatus_Id,
                        principalTable: "Cust_CustomerStatus",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Cust_CustomerData_Shar_Blocks_Block_Id",
                        column: x => x.Block_Id,
                        principalTable: "Shar_Blocks",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Bill_BillPayment",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    Cutomer_Id = table.Column<long>(type: "bigint", nullable: false),
                    BillNum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PayDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BillValue = table.Column<double>(type: "float", nullable: false),
                    WaterValue = table.Column<double>(type: "float", nullable: false),
                    Installment = table.Column<double>(type: "float", nullable: false),
                    Others = table.Column<double>(type: "float", nullable: false),
                    Maintenance = table.Column<double>(type: "float", nullable: false),
                    ContenutityService = table.Column<double>(type: "float", nullable: false),
                    RegularityService = table.Column<double>(type: "float", nullable: false),
                    WaterInstallment = table.Column<double>(type: "float", nullable: false),
                    WastWaterInstallment = table.Column<double>(type: "float", nullable: false),
                    Tax14Percent = table.Column<double>(type: "float", nullable: false),
                    CustomerPayingDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bill_BillPayment", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Bill_BillPayment_Cust_CustomerData_Cutomer_Id",
                        column: x => x.Cutomer_Id,
                        principalTable: "Cust_CustomerData",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Bill_Payment",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerData_Id = table.Column<long>(type: "bigint", nullable: false),
                    Employee_Id = table.Column<long>(type: "bigint", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    PayDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bill_Payment", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Bill_Payment_Cust_CustomerData_CustomerData_Id",
                        column: x => x.CustomerData_Id,
                        principalTable: "Cust_CustomerData",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Bill_Payment_Hr_Employees_Employee_Id",
                        column: x => x.Employee_Id,
                        principalTable: "Hr_Employees",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Opr_Complaints",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComplaintDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    X = table.Column<double>(type: "float", nullable: false),
                    Y = table.Column<double>(type: "float", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRevised = table.Column<bool>(type: "bit", nullable: false),
                    Employee_Id = table.Column<long>(type: "bigint", nullable: false),
                    Customer_Id = table.Column<long>(type: "bigint", nullable: false),
                    Issue_Id = table.Column<long>(type: "bigint", nullable: false),
                    ComplaintType_Id = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Opr_Complaints", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Opr_Complaints_Bill_Issues_Issue_Id",
                        column: x => x.Issue_Id,
                        principalTable: "Bill_Issues",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Opr_Complaints_Cust_CustomerData_Customer_Id",
                        column: x => x.Customer_Id,
                        principalTable: "Cust_CustomerData",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Opr_Complaints_Hr_Employees_Employee_Id",
                        column: x => x.Employee_Id,
                        principalTable: "Hr_Employees",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Opr_Complaints_Opr_ComplaintTypes_ComplaintType_Id",
                        column: x => x.ComplaintType_Id,
                        principalTable: "Opr_ComplaintTypes",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Opr_MeterReadings",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(type: "float", nullable: false),
                    X = table.Column<double>(type: "float", nullable: false),
                    Y = table.Column<double>(type: "float", nullable: false),
                    IsRevised = table.Column<bool>(type: "bit", nullable: false),
                    IsPotsed = table.Column<bool>(type: "bit", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OperationUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MeterStatus_Id = table.Column<int>(type: "int", nullable: false),
                    Employee_Id = table.Column<long>(type: "bigint", nullable: false),
                    Customer_Id = table.Column<long>(type: "bigint", nullable: false),
                    Issue_Id = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_Opr_MeterReadings", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Opr_MeterReadings_Bill_Issues_Issue_Id",
                        column: x => x.Issue_Id,
                        principalTable: "Bill_Issues",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Opr_MeterReadings_Cust_CustomerData_Customer_Id",
                        column: x => x.Customer_Id,
                        principalTable: "Cust_CustomerData",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Opr_MeterReadings_Hr_Employees_Employee_Id",
                        column: x => x.Employee_Id,
                        principalTable: "Hr_Employees",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Opr_MeterReadings_Opr_MeterStatus_MeterStatus_Id",
                        column: x => x.MeterStatus_Id,
                        principalTable: "Opr_MeterStatus",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Opr_UpdetedCustomers",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    X = table.Column<double>(type: "float", nullable: true),
                    Y = table.Column<double>(type: "float", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumOfUnits = table.Column<int>(type: "int", nullable: true),
                    IsRevised = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedCustomerType_Id = table.Column<int>(type: "int", nullable: false),
                    CustomerData_Id = table.Column<long>(type: "bigint", nullable: false),
                    Employee_Id = table.Column<long>(type: "bigint", nullable: false),
                    CustomerActivity_Id = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_Opr_UpdetedCustomers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Opr_UpdetedCustomers_Cust_CustomerActivities_CustomerActivity_Id",
                        column: x => x.CustomerActivity_Id,
                        principalTable: "Cust_CustomerActivities",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Opr_UpdetedCustomers_Cust_CustomerData_CustomerData_Id",
                        column: x => x.CustomerData_Id,
                        principalTable: "Cust_CustomerData",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Opr_UpdetedCustomers_Hr_Employees_Employee_Id",
                        column: x => x.Employee_Id,
                        principalTable: "Hr_Employees",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Opr_UpdetedCustomers_Opr_UpdatedCustomerTypes_UpdatedCustomerType_Id",
                        column: x => x.UpdatedCustomerType_Id,
                        principalTable: "Opr_UpdatedCustomerTypes",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Bill_PaymentTransactions",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Bill_Id = table.Column<long>(type: "bigint", nullable: false),
                    BillPayment_Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bill_PaymentTransactions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Bill_PaymentTransactions_Bill_BillPayment_Bill_Id",
                        column: x => x.Bill_Id,
                        principalTable: "Bill_BillPayment",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Bill_PaymentTransactions_Bill_Payment_BillPayment_Id",
                        column: x => x.BillPayment_Id,
                        principalTable: "Bill_Payment",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Opr_ComplaintImages",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Complaint_Id = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_Opr_ComplaintImages", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Opr_ComplaintImages_Opr_Complaints_Complaint_Id",
                        column: x => x.Complaint_Id,
                        principalTable: "Opr_Complaints",
                        principalColumn: "ID");
                });

            migrationBuilder.InsertData(
                table: "Hr_Status",
                columns: new[] { "ID", "CompanyTenantId", "DeleteBy", "DeleteDate", "InsertBy", "InsertDate", "IsDeleted", "Name", "UpdateBy", "UpdateDate" },
                values: new object[,]
                {
                    { 1, null, null, null, null, new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2635), false, "يعمل", null, new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2636) },
                    { 2, null, null, null, null, new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2638), false, "تمت اقالتة", null, new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2638) },
                    { 3, null, null, null, null, new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2640), false, "أجازة", null, new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2640) },
                    { 4, null, null, null, null, new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2642), false, "معاش", null, new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2642) },
                    { 5, null, null, null, null, new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2644), false, "متوفى", null, new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2644) }
                });

            migrationBuilder.InsertData(
                table: "Opr_MeterStatus",
                columns: new[] { "ID", "CompanyTenantId", "DeleteBy", "DeleteDate", "InsertBy", "InsertDate", "IsDeleted", "Name", "UpdateBy", "UpdateDate" },
                values: new object[,]
                {
                    { 12, null, null, null, null, new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2469), false, "متعذر", null, new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2476) },
                    { 13, null, null, null, null, new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2478), false, "معطل", null, new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2479) },
                    { 14, null, null, null, null, new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2480), false, "صالح", null, new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2481) },
                    { 10040, null, null, null, null, new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2482), false, "مغشى", null, new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2483) },
                    { 20131, null, null, null, null, new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2484), false, "انتظار", null, new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2485) }
                });

            migrationBuilder.InsertData(
                table: "Opr_UpdatedCustomerTypes",
                columns: new[] { "ID", "CompanyTenantId", "DeleteBy", "DeleteDate", "InsertBy", "InsertDate", "IsDeleted", "Name", "SysName", "UpdateBy", "UpdateDate" },
                values: new object[,]
                {
                    { 1, null, null, null, null, new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2611), false, "الموقع", "location", null, new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2611) },
                    { 2, null, null, null, null, new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2614), false, "النشاط", "activity", null, new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2614) },
                    { 3, null, null, null, null, new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2616), false, "عدد الوحدات", "unitsnumber", null, new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2616) },
                    { 4, null, null, null, null, new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2618), false, "صورة العميل", "customerimage", null, new DateTime(2022, 7, 22, 17, 1, 35, 483, DateTimeKind.Local).AddTicks(2618) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bill_BillPayment_Cutomer_Id",
                table: "Bill_BillPayment",
                column: "Cutomer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_IssueDetail_Branch_Id",
                table: "Bill_IssueDetail",
                column: "Branch_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_IssueDetail_Issue_Id",
                table: "Bill_IssueDetail",
                column: "Issue_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_Payment_CustomerData_Id",
                table: "Bill_Payment",
                column: "CustomerData_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_Payment_Employee_Id",
                table: "Bill_Payment",
                column: "Employee_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_PaymentTransactions_Bill_Id",
                table: "Bill_PaymentTransactions",
                column: "Bill_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_PaymentTransactions_BillPayment_Id",
                table: "Bill_PaymentTransactions",
                column: "BillPayment_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Cust_CustomerData_Block_Id",
                table: "Cust_CustomerData",
                column: "Block_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Cust_CustomerData_CustomerActivity_Id",
                table: "Cust_CustomerData",
                column: "CustomerActivity_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Cust_CustomerData_CustomerStatus_Id",
                table: "Cust_CustomerData",
                column: "CustomerStatus_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Hr_Employees_Branch_Id",
                table: "Hr_Employees",
                column: "Branch_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Hr_Employees_Status_Id",
                table: "Hr_Employees",
                column: "Status_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Opr_ComplaintImages_Complaint_Id",
                table: "Opr_ComplaintImages",
                column: "Complaint_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Opr_Complaints_ComplaintType_Id",
                table: "Opr_Complaints",
                column: "ComplaintType_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Opr_Complaints_Customer_Id",
                table: "Opr_Complaints",
                column: "Customer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Opr_Complaints_Employee_Id",
                table: "Opr_Complaints",
                column: "Employee_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Opr_Complaints_Issue_Id",
                table: "Opr_Complaints",
                column: "Issue_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Opr_MeterReadings_Customer_Id",
                table: "Opr_MeterReadings",
                column: "Customer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Opr_MeterReadings_Employee_Id",
                table: "Opr_MeterReadings",
                column: "Employee_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Opr_MeterReadings_Issue_Id",
                table: "Opr_MeterReadings",
                column: "Issue_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Opr_MeterReadings_MeterStatus_Id",
                table: "Opr_MeterReadings",
                column: "MeterStatus_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Opr_UpdetedCustomers_CustomerActivity_Id",
                table: "Opr_UpdetedCustomers",
                column: "CustomerActivity_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Opr_UpdetedCustomers_CustomerData_Id",
                table: "Opr_UpdetedCustomers",
                column: "CustomerData_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Opr_UpdetedCustomers_Employee_Id",
                table: "Opr_UpdetedCustomers",
                column: "Employee_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Opr_UpdetedCustomers_UpdatedCustomerType_Id",
                table: "Opr_UpdetedCustomers",
                column: "UpdatedCustomerType_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Perm_OnlineUsers_UserId",
                table: "Perm_OnlineUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Perm_RoleClaims_RoleId",
                table: "Perm_RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Perm_Roles_Company_Id",
                table: "Perm_Roles",
                column: "Company_Id");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Perm_Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Perm_UserClaims_UserId",
                table: "Perm_UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Perm_UserLogins_UserId",
                table: "Perm_UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Perm_UserRoles_RoleId",
                table: "Perm_UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Perm_Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Perm_Users_Employee_Id",
                table: "Perm_Users",
                column: "Employee_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Perm_Users_UserType_Id",
                table: "Perm_Users",
                column: "UserType_Id");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Perm_Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Perm_UserTypes_CompanyId",
                table: "Perm_UserTypes",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Shar_Areas_Branch_Id",
                table: "Shar_Areas",
                column: "Branch_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Shar_Blocks_Area_Id",
                table: "Shar_Blocks",
                column: "Area_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Shar_Branches_Company_Id",
                table: "Shar_Branches",
                column: "Company_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tech_Technician_WalkingLines_Technician_Id",
                table: "Tech_Technician_WalkingLines",
                column: "Technician_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tech_TechnicianLocations_Technician_Id",
                table: "Tech_TechnicianLocations",
                column: "Technician_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tech_Technicians_Employee_Id",
                table: "Tech_Technicians",
                column: "Employee_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bill_IssueDetail");

            migrationBuilder.DropTable(
                name: "Bill_PaymentTransactions");

            migrationBuilder.DropTable(
                name: "Hr_EmployeeBlocks");

            migrationBuilder.DropTable(
                name: "Opr_ComplaintImages");

            migrationBuilder.DropTable(
                name: "Opr_MeterReadings");

            migrationBuilder.DropTable(
                name: "Opr_UpdetedCustomers");

            migrationBuilder.DropTable(
                name: "Perm_OnlineUsers");

            migrationBuilder.DropTable(
                name: "Perm_RoleClaims");

            migrationBuilder.DropTable(
                name: "Perm_UserClaims");

            migrationBuilder.DropTable(
                name: "Perm_UserLogins");

            migrationBuilder.DropTable(
                name: "Perm_UserRoles");

            migrationBuilder.DropTable(
                name: "Perm_UserTokens");

            migrationBuilder.DropTable(
                name: "Tech_Technician_WalkingLines");

            migrationBuilder.DropTable(
                name: "Tech_TechnicianLocations");

            migrationBuilder.DropTable(
                name: "Bill_BillPayment");

            migrationBuilder.DropTable(
                name: "Bill_Payment");

            migrationBuilder.DropTable(
                name: "Opr_Complaints");

            migrationBuilder.DropTable(
                name: "Opr_MeterStatus");

            migrationBuilder.DropTable(
                name: "Opr_UpdatedCustomerTypes");

            migrationBuilder.DropTable(
                name: "Perm_Roles");

            migrationBuilder.DropTable(
                name: "Perm_Users");

            migrationBuilder.DropTable(
                name: "Tech_Technicians");

            migrationBuilder.DropTable(
                name: "Bill_Issues");

            migrationBuilder.DropTable(
                name: "Cust_CustomerData");

            migrationBuilder.DropTable(
                name: "Opr_ComplaintTypes");

            migrationBuilder.DropTable(
                name: "Perm_UserTypes");

            migrationBuilder.DropTable(
                name: "Hr_Employees");

            migrationBuilder.DropTable(
                name: "Cust_CustomerActivities");

            migrationBuilder.DropTable(
                name: "Cust_CustomerStatus");

            migrationBuilder.DropTable(
                name: "Shar_Blocks");

            migrationBuilder.DropTable(
                name: "Hr_Status");

            migrationBuilder.DropTable(
                name: "Shar_Areas");

            migrationBuilder.DropTable(
                name: "Shar_Branches");

            migrationBuilder.DropTable(
                name: "Shar_Company");
        }
    }
}
