using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GharbiaUtilitiesManagement.DataAccess.Migrations.Utilities
{
    public partial class firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Cust_CustomerActivities",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ReadingAvg = table.Column<double>(type: "float", nullable: false),
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
                name: "Cust_CustomerDataTemp",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    SubscriptionStartDate = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ActualName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ActualActivity = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CustomerStartIssue = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NumOfUnits = table.Column<int>(type: "int", nullable: false),
                    ActivityStarIssue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CustomerHasSewage = table.Column<bool>(type: "bit", nullable: false),
                    MeterChassisNum = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MeterDiameter = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MeterStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MeterStartReading = table.Column<int>(type: "int", nullable: false),
                    MeterStartIssue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    X = table.Column<double>(type: "float", nullable: true),
                    Y = table.Column<double>(type: "float", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDataComplete = table.Column<bool>(type: "bit", nullable: false),
                    Block_Id = table.Column<long>(type: "bigint", nullable: false),
                    CustomerStatus_Id = table.Column<int>(type: "int", nullable: false),
                    CustomerActivity_Id = table.Column<int>(type: "int", nullable: false),
                    PreviousReading = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PreviousReadingIssueNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_Cust_CustomerDataTemp", x => x.ID);
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
                name: "Hr_Employees_Temp",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchID = table.Column<long>(type: "bigint", nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
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
                    table.PrimaryKey("PK_Hr_Employees_Temp", x => x.ID);
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
                name: "Noti_FcmConfig",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsAndroid = table.Column<bool>(type: "bit", nullable: false),
                    apiKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    authDomain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    projectId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    storageBucket = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    messagingSenderId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    appId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    measurementId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServerKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SenderId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublicKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Noti_FcmConfig", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Noti_FcmModules",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    table.PrimaryKey("PK_Noti_FcmModules", x => x.ID);
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
                name: "Perm_Menu",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentId = table.Column<long>(type: "bigint", nullable: true),
                    IsLast = table.Column<bool>(type: "bit", nullable: true),
                    Route = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Permission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderBy = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Perm_Menu", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Shar_Areas_Temp",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    AreaCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AreaName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    City_Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shar_Areas_Temp", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Shar_Bills_Temp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BRANCH_NAME = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    BRANCH_Id = table.Column<long>(type: "bigint", nullable: true),
                    Block_Id = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ADDRESS = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ACTIVITY_TYPE = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ACTIVITY_TYPE_Id = table.Column<long>(type: "bigint", nullable: true),
                    CUSTOMER_NAME = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    BILL_KEY = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    BILL_PRINTED_DATE = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LAST_READING = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CURRENT_READING = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ASSIGNED_TO = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NUMBER_OF_UNITS = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    BILL_AMOUNT = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CUST_KEY = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CUST_ID = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Bill_ID = table.Column<long>(type: "bigint", nullable: true),
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

            migrationBuilder.CreateTable(
                name: "Shar_Blocks_Temp",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    BlockCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Shar_Blocks_Temp", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Shar_Branches_Temp",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    BranchCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Shar_Branches_Temp", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Shar_Cities_Temp",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    CityCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    State_Id = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_Shar_Cities_Temp", x => x.ID);
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
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    LogoPrint = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoWeb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", maxLength: 50, nullable: false),
                    MobileUsersCount = table.Column<int>(type: "int", nullable: false),
                    CompanyServiceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "Shar_States_Temp",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    StateCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    Branch_Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shar_States_Temp", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Bill_Issues",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Company_Id = table.Column<long>(type: "bigint", nullable: false),
                    IssueName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_Bill_Issues_Shar_Company_Company_Id",
                        column: x => x.Company_Id,
                        principalTable: "Shar_Company",
                        principalColumn: "ID");
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
                    BranchCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillStartNum = table.Column<int>(type: "int", nullable: false),
                    BillEndNum = table.Column<int>(type: "int", nullable: false),
                    BranchIssueStatus = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CanPostReading = table.Column<bool>(type: "bit", nullable: false),
                    Issue_Id = table.Column<long>(type: "bigint", nullable: false),
                    Branch_Id = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
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
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Job = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status_Id = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsReader = table.Column<bool>(type: "bit", nullable: true),
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
                name: "Shar_States",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    StateCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
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
                    table.PrimaryKey("PK_Shar_States", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Shar_States_Shar_Branches_Branch_Id",
                        column: x => x.Branch_Id,
                        principalTable: "Shar_Branches",
                        principalColumn: "ID");
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    IsAndroid = table.Column<bool>(type: "bit", nullable: false),
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
                name: "Shar_Cities",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    CityCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    State_Id = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_Shar_Cities", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Shar_Cities_Shar_States_State_Id",
                        column: x => x.State_Id,
                        principalTable: "Shar_States",
                        principalColumn: "ID");
                });

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
                name: "Noti_UserModule",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Module_Id = table.Column<int>(type: "int", nullable: true),
                    User_Id = table.Column<string>(type: "nvarchar(450)", nullable: true),
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
                    table.PrimaryKey("PK_Noti_UserModule", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Noti_UserModule_Noti_FcmModules_Module_Id",
                        column: x => x.Module_Id,
                        principalTable: "Noti_FcmModules",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Noti_UserModule_Perm_Users_User_Id",
                        column: x => x.User_Id,
                        principalTable: "Perm_Users",
                        principalColumn: "Id");
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
                name: "Perm_UserBranches",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    table.PrimaryKey("PK_Perm_UserBranches", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Perm_UserBranches_Perm_Users_User_Id",
                        column: x => x.User_Id,
                        principalTable: "Perm_Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Perm_UserBranches_Shar_Branches_Branch_Id",
                        column: x => x.Branch_Id,
                        principalTable: "Shar_Branches",
                        principalColumn: "ID");
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
                name: "Shar_Areas",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    AreaCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AreaName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    City_Id = table.Column<long>(type: "bigint", nullable: false),
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
                        name: "FK_Shar_Areas_Shar_Cities_City_Id",
                        column: x => x.City_Id,
                        principalTable: "Shar_Cities",
                        principalColumn: "ID");
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

            migrationBuilder.CreateTable(
                name: "Shar_Blocks",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    BlockCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "Cust_CustomerData",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    SubscriptionStartDate = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ActualName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ActualActivity = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CustomerStartIssue = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NumOfUnits = table.Column<int>(type: "int", nullable: false),
                    ActivityStarIssue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CustomerHasSewage = table.Column<bool>(type: "bit", nullable: false),
                    MeterChassisNum = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MeterDiameter = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MeterStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MeterStartReading = table.Column<int>(type: "int", nullable: false),
                    MeterStartIssue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    X = table.Column<double>(type: "float", nullable: true),
                    Y = table.Column<double>(type: "float", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDataComplete = table.Column<bool>(type: "bit", nullable: false),
                    Block_Id = table.Column<long>(type: "bigint", nullable: false),
                    CustomerStatus_Id = table.Column<int>(type: "int", nullable: false),
                    CustomerActivity_Id = table.Column<int>(type: "int", nullable: false),
                    PreviousReading = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PreviousReadingIssueNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstKey = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsPosted = table.Column<bool>(type: "bit", nullable: false),
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
                name: "Hr_EmployeeBlocks",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Collector_Id = table.Column<long>(type: "bigint", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Block_Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hr_EmployeeBlocks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Hr_EmployeeBlocks_Hr_Employees_Collector_Id",
                        column: x => x.Collector_Id,
                        principalTable: "Hr_Employees",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Hr_EmployeeBlocks_Shar_Blocks_Block_Id",
                        column: x => x.Block_Id,
                        principalTable: "Shar_Blocks",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Bill_BillData",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    BillIssue_Id = table.Column<long>(type: "bigint", nullable: true),
                    Customer_Id = table.Column<long>(type: "bigint", nullable: false),
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
                    CustomerPayingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PrevReading = table.Column<double>(type: "float", nullable: false),
                    CurrentReading = table.Column<double>(type: "float", nullable: false),
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
                    table.PrimaryKey("PK_Bill_BillData", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Bill_BillData_Bill_Issues_BillIssue_Id",
                        column: x => x.BillIssue_Id,
                        principalTable: "Bill_Issues",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Bill_BillData_Cust_CustomerData_Customer_Id",
                        column: x => x.Customer_Id,
                        principalTable: "Cust_CustomerData",
                        principalColumn: "ID");
                });

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
                name: "Bill_Payment",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerData_Id = table.Column<long>(type: "bigint", nullable: false),
                    Employee_Id = table.Column<long>(type: "bigint", nullable: false),
                    BillPaymentSafe_Id = table.Column<long>(type: "bigint", nullable: true),
                    PaymentType_Id = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    PayDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    X = table.Column<double>(type: "float", nullable: false),
                    Y = table.Column<double>(type: "float", nullable: false),
                    IsCollected = table.Column<bool>(type: "bit", nullable: true),
                    CollectionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsRePrint = table.Column<bool>(type: "bit", nullable: false),
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
                    table.PrimaryKey("PK_Bill_Payment", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Bill_Payment_Bill_PaymentSafes_BillPaymentSafe_Id",
                        column: x => x.BillPaymentSafe_Id,
                        principalTable: "Bill_PaymentSafes",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Bill_Payment_Bill_PaymentType_PaymentType_Id",
                        column: x => x.PaymentType_Id,
                        principalTable: "Bill_PaymentType",
                        principalColumn: "ID");
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
                    Customer_Id = table.Column<long>(type: "bigint", nullable: true),
                    Issue_Id = table.Column<long>(type: "bigint", nullable: false),
                    ComplaintType_Id = table.Column<int>(type: "int", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    IsCustomerComplaint = table.Column<bool>(type: "bit", nullable: false),
                    PublicAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlockId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_Opr_Complaints_Shar_Blocks_BlockId",
                        column: x => x.BlockId,
                        principalTable: "Shar_Blocks",
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
                    IsPosted = table.Column<bool>(type: "bit", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReadingImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeterStatus_Id = table.Column<int>(type: "int", nullable: false),
                    Employee_Id = table.Column<long>(type: "bigint", nullable: false),
                    Customer_Id = table.Column<long>(type: "bigint", nullable: false),
                    Issue_Details_Id = table.Column<long>(type: "bigint", nullable: false),
                    InternetSpeed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeterReadingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PreviousReading = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreviousReadingIssueNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                        name: "FK_Opr_MeterReadings_Bill_IssueDetail_Issue_Details_Id",
                        column: x => x.Issue_Details_Id,
                        principalTable: "Bill_IssueDetail",
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
                name: "Opr_UpdatedCustomers",
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
                    Issue_Id = table.Column<long>(type: "bigint", nullable: false),
                    CustomerActivity_Id = table.Column<int>(type: "int", nullable: true),
                    InternetSpeed = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_Opr_UpdatedCustomers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Opr_UpdatedCustomers_Bill_Issues_Issue_Id",
                        column: x => x.Issue_Id,
                        principalTable: "Bill_Issues",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Opr_UpdatedCustomers_Cust_CustomerActivities_CustomerActivity_Id",
                        column: x => x.CustomerActivity_Id,
                        principalTable: "Cust_CustomerActivities",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Opr_UpdatedCustomers_Cust_CustomerData_CustomerData_Id",
                        column: x => x.CustomerData_Id,
                        principalTable: "Cust_CustomerData",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Opr_UpdatedCustomers_Hr_Employees_Employee_Id",
                        column: x => x.Employee_Id,
                        principalTable: "Hr_Employees",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Opr_UpdatedCustomers_Opr_UpdatedCustomerTypes_UpdatedCustomerType_Id",
                        column: x => x.UpdatedCustomerType_Id,
                        principalTable: "Opr_UpdatedCustomerTypes",
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
                    PayDataLogId = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_Bill_PayDataLogDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Bill_PayDataLogDetails_Bill_BillData_Bill_Id",
                        column: x => x.Bill_Id,
                        principalTable: "Bill_BillData",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Bill_PayDataLogDetails_Bill_PayDataLog_PayDataLogId",
                        column: x => x.PayDataLogId,
                        principalTable: "Bill_PayDataLog",
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
                    BillPayment_Id = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_Bill_PaymentTransactions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Bill_PaymentTransactions_Bill_BillData_Bill_Id",
                        column: x => x.Bill_Id,
                        principalTable: "Bill_BillData",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Bill_PaymentTransactions_Bill_Payment_BillPayment_Id",
                        column: x => x.BillPayment_Id,
                        principalTable: "Bill_Payment",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Bill_PrintLog",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillPayment_Id = table.Column<long>(type: "bigint", nullable: false),
                    Disc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    table.PrimaryKey("PK_Bill_PrintLog", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Bill_PrintLog_Bill_Payment_BillPayment_Id",
                        column: x => x.BillPayment_Id,
                        principalTable: "Bill_Payment",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Bill_PrintLog_Perm_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Perm_Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Opr_ComplaintImages",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Complaint_Id = table.Column<long>(type: "bigint", nullable: false),
                    InternetSpeed = table.Column<string>(type: "nvarchar(max)", nullable: true),
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

            migrationBuilder.CreateTable(
                name: "Opr_MeterReadings_Logs",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OldValue = table.Column<double>(type: "float", nullable: false),
                    NewValue = table.Column<double>(type: "float", nullable: false),
                    MeterReadings_Id = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_Opr_MeterReadings_Logs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Opr_MeterReadings_Logs_Opr_MeterReadings_MeterReadings_Id",
                        column: x => x.MeterReadings_Id,
                        principalTable: "Opr_MeterReadings",
                        principalColumn: "ID");
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

            migrationBuilder.InsertData(
                table: "Cust_CustomerStatus",
                columns: new[] { "ID", "CompanyTenantId", "DeleteBy", "DeleteDate", "InsertBy", "InsertDate", "IsDeleted", "Name", "UpdateBy", "UpdateDate" },
                values: new object[] { 1, null, null, null, null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "سارى", null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Hr_Status",
                columns: new[] { "ID", "CompanyTenantId", "DeleteBy", "DeleteDate", "InsertBy", "InsertDate", "IsDeleted", "Name", "UpdateBy", "UpdateDate" },
                values: new object[,]
                {
                    { 1, null, null, null, null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "يعمل", null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, null, null, null, null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "تمت اقالتة", null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, null, null, null, null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "أجازة", null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, null, null, null, null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "معاش", null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, null, null, null, null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "متوفى", null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Opr_MeterStatus",
                columns: new[] { "ID", "CompanyTenantId", "DeleteBy", "DeleteDate", "InsertBy", "InsertDate", "IsDeleted", "Name", "UpdateBy", "UpdateDate" },
                values: new object[,]
                {
                    { 15, null, null, null, null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "متعذر", null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, null, null, null, null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "غير مقروء", null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, null, null, null, null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "تقديرية", null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, null, null, null, null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "صحيحة", null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Opr_UpdatedCustomerTypes",
                columns: new[] { "ID", "CompanyTenantId", "DeleteBy", "DeleteDate", "InsertBy", "InsertDate", "IsDeleted", "Name", "SysName", "UpdateBy", "UpdateDate" },
                values: new object[,]
                {
                    { 1, null, null, null, null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "الموقع", "location", null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, null, null, null, null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "النشاط", "activity", null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, null, null, null, null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "عدد الوحدات", "unitsnumber", null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, null, null, null, null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "صورة العميل", "customerimage", null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bill_BillData_BillIssue_Id",
                table: "Bill_BillData",
                column: "BillIssue_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_BillData_Customer_Id",
                table: "Bill_BillData",
                column: "Customer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_IssueDetail_Branch_Id",
                table: "Bill_IssueDetail",
                column: "Branch_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_IssueDetail_Issue_Id",
                table: "Bill_IssueDetail",
                column: "Issue_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_Issues_Company_Id",
                table: "Bill_Issues",
                column: "Company_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_PayDataLog_Customer_Id",
                table: "Bill_PayDataLog",
                column: "Customer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_PayDataLog_Employee_Id",
                table: "Bill_PayDataLog",
                column: "Employee_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_PayDataLogDetails_Bill_Id",
                table: "Bill_PayDataLogDetails",
                column: "Bill_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_PayDataLogDetails_PayDataLogId",
                table: "Bill_PayDataLogDetails",
                column: "PayDataLogId");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_Payment_BillPaymentSafe_Id",
                table: "Bill_Payment",
                column: "BillPaymentSafe_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_Payment_CustomerData_Id",
                table: "Bill_Payment",
                column: "CustomerData_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_Payment_Employee_Id",
                table: "Bill_Payment",
                column: "Employee_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_Payment_PaymentType_Id",
                table: "Bill_Payment",
                column: "PaymentType_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_PaymentSafes_BillSafe_Id",
                table: "Bill_PaymentSafes",
                column: "BillSafe_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_PaymentSafes_HrEmployee_Id",
                table: "Bill_PaymentSafes",
                column: "HrEmployee_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_PaymentTransactions_Bill_Id",
                table: "Bill_PaymentTransactions",
                column: "Bill_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_PaymentTransactions_BillPayment_Id",
                table: "Bill_PaymentTransactions",
                column: "BillPayment_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_PrintLog_BillPayment_Id",
                table: "Bill_PrintLog",
                column: "BillPayment_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_PrintLog_UserId",
                table: "Bill_PrintLog",
                column: "UserId");

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
                name: "IX_Hr_EmployeeBlocks_Block_Id",
                table: "Hr_EmployeeBlocks",
                column: "Block_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Hr_EmployeeBlocks_Collector_Id",
                table: "Hr_EmployeeBlocks",
                column: "Collector_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Hr_Employees_Branch_Id",
                table: "Hr_Employees",
                column: "Branch_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Hr_Employees_Status_Id",
                table: "Hr_Employees",
                column: "Status_Id");

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

            migrationBuilder.CreateIndex(
                name: "IX_Noti_UserModule_Module_Id",
                table: "Noti_UserModule",
                column: "Module_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Noti_UserModule_User_Id",
                table: "Noti_UserModule",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Opr_ComplaintImages_Complaint_Id",
                table: "Opr_ComplaintImages",
                column: "Complaint_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Opr_Complaints_BlockId",
                table: "Opr_Complaints",
                column: "BlockId");

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
                name: "IX_Opr_MeterReadings_Issue_Details_Id",
                table: "Opr_MeterReadings",
                column: "Issue_Details_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Opr_MeterReadings_MeterStatus_Id",
                table: "Opr_MeterReadings",
                column: "MeterStatus_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Opr_MeterReadings_Logs_MeterReadings_Id",
                table: "Opr_MeterReadings_Logs",
                column: "MeterReadings_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Opr_UpdatedCustomers_CustomerActivity_Id",
                table: "Opr_UpdatedCustomers",
                column: "CustomerActivity_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Opr_UpdatedCustomers_CustomerData_Id",
                table: "Opr_UpdatedCustomers",
                column: "CustomerData_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Opr_UpdatedCustomers_Employee_Id",
                table: "Opr_UpdatedCustomers",
                column: "Employee_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Opr_UpdatedCustomers_Issue_Id",
                table: "Opr_UpdatedCustomers",
                column: "Issue_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Opr_UpdatedCustomers_UpdatedCustomerType_Id",
                table: "Opr_UpdatedCustomers",
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
                name: "IX_Perm_UserBranches_Branch_Id",
                table: "Perm_UserBranches",
                column: "Branch_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Perm_UserBranches_User_Id",
                table: "Perm_UserBranches",
                column: "User_Id");

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
                name: "IX_Shar_Areas_City_Id",
                table: "Shar_Areas",
                column: "City_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Shar_Blocks_Area_Id",
                table: "Shar_Blocks",
                column: "Area_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Shar_Branches_Company_Id",
                table: "Shar_Branches",
                column: "Company_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Shar_Cities_State_Id",
                table: "Shar_Cities",
                column: "State_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Shar_States_Branch_Id",
                table: "Shar_States",
                column: "Branch_Id");

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
                name: "Bill_PayDataLogDetails");

            migrationBuilder.DropTable(
                name: "Bill_PaymentTransactions");

            migrationBuilder.DropTable(
                name: "Bill_PrintLog");

            migrationBuilder.DropTable(
                name: "Cust_CustomerDataTemp");

            migrationBuilder.DropTable(
                name: "Hr_EmployeeBlocks");

            migrationBuilder.DropTable(
                name: "Hr_Employees_Temp");

            migrationBuilder.DropTable(
                name: "Noti_FcmConfig");

            migrationBuilder.DropTable(
                name: "Noti_MessageUser");

            migrationBuilder.DropTable(
                name: "Noti_UserModule");

            migrationBuilder.DropTable(
                name: "Opr_ComplaintImages");

            migrationBuilder.DropTable(
                name: "Opr_MeterReadings_Logs");

            migrationBuilder.DropTable(
                name: "Opr_UpdatedCustomers");

            migrationBuilder.DropTable(
                name: "Perm_Menu");

            migrationBuilder.DropTable(
                name: "Perm_OnlineUsers");

            migrationBuilder.DropTable(
                name: "Perm_RoleClaims");

            migrationBuilder.DropTable(
                name: "Perm_UserBranches");

            migrationBuilder.DropTable(
                name: "Perm_UserClaims");

            migrationBuilder.DropTable(
                name: "Perm_UserLogins");

            migrationBuilder.DropTable(
                name: "Perm_UserRoles");

            migrationBuilder.DropTable(
                name: "Perm_UserTokens");

            migrationBuilder.DropTable(
                name: "Shar_Areas_Temp");

            migrationBuilder.DropTable(
                name: "Shar_Bills_Temp");

            migrationBuilder.DropTable(
                name: "Shar_Blocks_Temp");

            migrationBuilder.DropTable(
                name: "Shar_Branches_Temp");

            migrationBuilder.DropTable(
                name: "Shar_Cities_Temp");

            migrationBuilder.DropTable(
                name: "Shar_States_Temp");

            migrationBuilder.DropTable(
                name: "Tech_Technician_WalkingLines");

            migrationBuilder.DropTable(
                name: "Tech_TechnicianLocations");

            migrationBuilder.DropTable(
                name: "Bill_PayDataLog");

            migrationBuilder.DropTable(
                name: "Bill_BillData");

            migrationBuilder.DropTable(
                name: "Bill_Payment");

            migrationBuilder.DropTable(
                name: "Noti_Message");

            migrationBuilder.DropTable(
                name: "Noti_FcmModules");

            migrationBuilder.DropTable(
                name: "Opr_Complaints");

            migrationBuilder.DropTable(
                name: "Opr_MeterReadings");

            migrationBuilder.DropTable(
                name: "Opr_UpdatedCustomerTypes");

            migrationBuilder.DropTable(
                name: "Perm_Roles");

            migrationBuilder.DropTable(
                name: "Tech_Technicians");

            migrationBuilder.DropTable(
                name: "Bill_PaymentSafes");

            migrationBuilder.DropTable(
                name: "Bill_PaymentType");

            migrationBuilder.DropTable(
                name: "Perm_Users");

            migrationBuilder.DropTable(
                name: "Opr_ComplaintTypes");

            migrationBuilder.DropTable(
                name: "Bill_IssueDetail");

            migrationBuilder.DropTable(
                name: "Cust_CustomerData");

            migrationBuilder.DropTable(
                name: "Opr_MeterStatus");

            migrationBuilder.DropTable(
                name: "Bill_Safes");

            migrationBuilder.DropTable(
                name: "Hr_Employees");

            migrationBuilder.DropTable(
                name: "Perm_UserTypes");

            migrationBuilder.DropTable(
                name: "Bill_Issues");

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
                name: "Shar_Cities");

            migrationBuilder.DropTable(
                name: "Shar_States");

            migrationBuilder.DropTable(
                name: "Shar_Branches");

            migrationBuilder.DropTable(
                name: "Shar_Company");
        }
    }
}
