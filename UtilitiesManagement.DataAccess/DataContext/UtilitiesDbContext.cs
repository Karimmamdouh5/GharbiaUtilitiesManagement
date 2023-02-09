using AlignSales.DataAccess.Extensions;
using UtilitiesManagement.Domain.Extensions.Auth;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;
using System.Reflection;
using UtilitiesManagement.Domain.Models.Notification;
using GharbiaUtilitiesManagement.Domain.Models.Shared;

namespace UtilitiesManagement.DataAccess.DataContext
{
    public partial class UtilitiesDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string,
         ApplicationUserClaim, ApplicationUserRole, ApplicationUserLogin,
         ApplicationRoleClaim, ApplicationUserToken>
    {

        public IHttpContextAccessor _accessor { get; set; }
     
        public UtilitiesDbContext(DbContextOptions<UtilitiesDbContext> options, IHttpContextAccessor accessor) : base(options)
        {
            _accessor = accessor;
        }

        //public void SetGlobalQuery<T>(ModelBuilder builder) where T : BaseEntity
        //{
        //    builder.Entity<T>().HasQueryFilter(e => !e.IsDeleted && e.CompanyTenantId == null);
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            modelBuilder.AddQueryFilterToAllEntitiesAssignableFrom<BaseEntity>(x => x.IsDeleted == false /*&& x.CompanyTenantId == _accessor!.HttpContext!.User.GetCompanyId()*/);
            //modelBuilder.AddQueryFilterToAllEntitiesAssignableFrom<BaseEntity>(x => );

            modelBuilder.Seed();

            //  modelBuilder.Entity<HrEmployee>()
            // .HasOne(x => x.Branch)
            //.WithMany(x => x.Employees)
            //.HasForeignKey(x => x.Branch_Id);

            //modelBuilder.Entity<SharBranch>().HasOne<HrEmployee>(x => x.BranchManager)
            //.WithMany(x => x.Branch)
            //.HasForeignKey(x => x.BranchManagerId)
            //.OnDelete(deleteBehavior: DeleteBehavior.NoAction)
            //.IsRequired(false);

            #region Fluent API

            modelBuilder.Entity<ApplicationUser>(user =>
            {
              
                user.HasMany(x => x.UserRoles)
                .WithOne(e=>e.User)
                .HasForeignKey(x => x.UserId).IsRequired();

                user.HasMany(x => x.UserLogs)
                .WithOne(e=>e.User)
                .HasForeignKey(x => x.UserId).IsRequired();
                //user.HasMany(x => x.UserClaims).WithOne().HasForeignKey(x => x.UserId);
                //user.HasMany(x => x.UserTokens).WithOne().HasForeignKey(x => x.UserId);
            });
            modelBuilder.Entity<ApplicationRole>(role=>
            {

                role.HasMany(x => x.UserRoles)
                .WithOne(e => e.Role)
                .HasForeignKey(x => x.RoleId).IsRequired();

                role.HasMany(x => x.RoleClaims)
                .WithOne(e => e.Role)
                .HasForeignKey(x => x.RoleId).IsRequired();


                //user.HasMany(x => x.UserClaims).WithOne().HasForeignKey(x => x.UserId);
                //user.HasMany(x => x.UserTokens).WithOne().HasForeignKey(x => x.UserId);
            });
            modelBuilder.Entity<SharBlock>(block=>
            {

                //block.HasMany(x => x.EmployeeBlocks)
                //.WithOne(e => e.Block)
                //.HasForeignKey(x => x.Block_Id).IsRequired();

             
            });

            //modelBuilder.Entity<UserClaim>(userClaim =>
            //{
            //    userClaim.HasKey(r => r.Id);
            //    userClaim.HasOne(r => r.User).WithOne().HasForeignKey<UserClaim>(x => x.UserId);
            //});



            //modelBuilder.Entity<HrEmployee>(e =>
            //{
            //    e.HasOne(d => d.Branch)
            //        .WithMany(p => p.Employees)
            //        .HasForeignKey(d => d.Branch_Id);
            //});

            //modelBuilder.Entity<CustClientDataBranch>(e =>
            // {
            //     e.HasOne(d => d.Technician)
            //         .WithMany(p => p.ClientDataBranches)
            //         .HasForeignKey(d => d.Technician_Id);
            // }); 

            //modelBuilder.Entity<TechTechnician>(e =>
            //{
            //    e.HasOne(d => d.Employee)
            //        .WithMany(p => p.Technicians)
            //        .HasForeignKey(d => d.Employee_Id);
            //});
            modelBuilder.Entity<PermOnlineUser>(e =>
            {
                e.HasOne(d => d.User)
                    .WithMany(p => p.UserLogs)
                    .HasForeignKey(d => d.UserId);
            });
            //modelBuilder.Entity<TechTechnicianLocation>(e =>
            //{
            //    e.HasOne(d => d.Technician)
            //        .WithMany(p => p.TechnicianLocations)
            //        .HasForeignKey(d => d.Technician_Id);
            //});

            //modelBuilder.Entity<CustClientBranchDay>(e =>
            //{
            //    e.HasOne(d => d.ClientDataBranch)
            //        .WithMany(p => p.ClientDays)
            //        .HasForeignKey(d => d.ClientDataBranch_Id);
            //});

            //modelBuilder.Entity<TechTechnicianWalkingLine>(e =>
            //{
            //    e.HasOne(d => d.Technician)
            //        .WithMany(p => p.TechnicianWalkingLines)
            //        .HasForeignKey(d => d.Technician_Id);

            //    e.HasOne(d => d.WalkingLine)
            //        .WithMany(p => p.TechnicianWalkingLines)
            //        .HasForeignKey(d => d.WalkingLine_Id);
            //});

            //modelBuilder.Entity<CustClientBranchWalkingLine>(e =>
            //{
            //    e.HasOne(d => d.ClientDataBranch)
            //        .WithMany(p => p.ClientBranchWalkingLines)
            //        .HasForeignKey(d => d.ClientDataBranch_Id);

            //    e.HasOne(d => d.WalkingLine)
            //        .WithMany(p => p.ClientBranchWalkingLines)
            //        .HasForeignKey(d => d.WalkingLine_Id);
            //});
            #endregion

            //foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            //{
            //    modelBuilder.Entity(entityType.Name).Property<DateTime>("InsertDate");
            //    modelBuilder.Entity(entityType.Name).Property<DateTime>("UpdateDate");
            //}

            /// global filter other method important
            //foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            //{
            //    if (typeof(BaseEntity).IsAssignableFrom(entityType.ClrType))
            //        modelBuilder.Entity(entityType.ClrType).AddQueryFilter<BaseEntity>(e =>  e.IsDeleted == false);
            //    if (typeof(BaseEntity).IsAssignableFrom(entityType.ClrType))
            //        modelBuilder.Entity(entityType.ClrType).AddQueryFilter<BaseEntity>(e => e.CompanyTenantId == _accessor.HttpContext.User.GetCompanyId());
                
            //}
            modelBuilder.Entity<ApplicationUser>().ToTable("Perm_Users");
            modelBuilder.Entity<ApplicationRole>().ToTable("Perm_Roles");
            modelBuilder.Entity<ApplicationUserRole>().ToTable("Perm_UserRoles");
            modelBuilder.Entity<ApplicationUserClaim>().ToTable("Perm_UserClaims");
            modelBuilder.Entity<ApplicationUserLogin>().ToTable("Perm_UserLogins");
            modelBuilder.Entity<ApplicationRoleClaim>().ToTable("Perm_RoleClaims");
            modelBuilder.Entity<ApplicationUserToken>().ToTable("Perm_UserTokens");

            //modelBuilder.Entity<Book>().Property(b => b.Rating).HasDefaultValue(1);
            //modelBuilder.Entity<Author>().Property(b => b.DisplayName).HasComputedColumnSql("[FirstName]+', ' +[LastName]");

            //modelBuilder.Entity<SharState>().HasQueryFilter(p => !p.IsDeleted);


            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.NoAction;
            }


            //foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            //{
            //    //other automated configurations left out
            //    if (typeof(BaseEntity).IsAssignableFrom(entityType.ClrType))
            //    {
            //        entityType.AddSoftDeleteQueryFilter(companyId ?? 0);

            //    }
            //}

          


            //Expression<Func<BaseEntity, bool>> filterExpr = bm => !bm.IsDeleted && (bm.CompanyTenantId == companyId || companyId==null);
            //foreach (var mutableEntityType in modelBuilder.Model.GetEntityTypes())
            //{

            //    // check if current entity type is child of BaseModel
            //    if (mutableEntityType.ClrType.IsAssignableTo(typeof(BaseEntity)))
            //    {
            //        // modify expression to handle correct child type
            //        var parameter = Expression.Parameter(mutableEntityType.ClrType);
            //        var body = ReplacingExpressionVisitor.Replace(filterExpr.Parameters.First(), parameter, filterExpr.Body);
            //        var lambdaExpression = Expression.Lambda(body, parameter);

            //        // set filter
            //        mutableEntityType.SetQueryFilter(lambdaExpression);
            //    }
            //}
        }

        #region DataSets

        public DbSet<ApplicationUserBranches> UserBranches { get; set; }
        public DbSet<SharCompany> SharCompanies { get; set; }
        public DbSet<SharBranch> SharBranches { get; set; }
        public DbSet<SharArea> SharAreas { get; set; }
        public DbSet<SharBlock> SharBlocks { get; set; }
        public DbSet<SharMainTable_Bills> MainTableBills { get; set; }
        public DbSet<SharState> SharStates { get; set; }
        public DbSet<SharCity> SharCities { get; set; }
        public DbSet<SharBranch_Temp> SharBlocks_Temp { get; set; }
        public DbSet<SharArea_Temp> SharAreas_Temp { get; set; }
        public DbSet<SharBranch_Temp> SharBranchs_Temp { get; set; }
        public DbSet<SharCity_Temp> SharCities_Temp { get; set; }
        public DbSet<SharState_Temp> SharStates_Temp { get; set; }
        public DbSet<SharBlock_Temp> SharBlock_Temp { get; set; }


     
        public DbSet<BillBillsData> BillBillsData { get; set; }
        public DbSet<BillPayment> BillPayment { get; set; }
        public DbSet<BillPaymentTransaction> BillPaymentTransactions { get; set; }
        public DbSet<BillIssue> BillIssue { get; set; }
        public DbSet<BillIssueDetail> BillIssueDetail { get; set; }


        public DbSet<CustCustomerData> CustCustomerData { get; set; }
        public DbSet<CustCustomerStatus> CustCustomerStatus { get; set; }
        public DbSet<CustCustomerActivity> CustCustomerActivity { get; set; }

        public DbSet<OprComplaint> OprComplaint { get; set; }
        public DbSet<OprComplaintImage> OprComplaintImage { get; set; }
        public DbSet<OprComplaintType> OprComplaintType { get; set; }
        public DbSet<OprMeterReading> OprMeterReading { get; set; }
        public DbSet<OprMeterStatus> OprMeterStatus { get; set; }
        public DbSet<OprUpdatedCustomer> OprUpdetedCustomer { get; set; }
        public DbSet<OprUpdatedCustomerType> OprUpdatedCustomerType { get; set; }



        public DbSet<TechTechnician> TechTechnicians { get; set; }
        public DbSet<TechTechnicianWalkingLine> TechTechnicianWalkingLines { get; set; }
        public DbSet<TechTechnicianLocation> TechTechnicianLocations { get; set; }


        public DbSet<HrEmployee> HrEmployees { get; set; }
        public DbSet<HrEmployee_Temp> Employee_Temp { get; set; }
        public DbSet<HrEmployeeBlocks> HREmployeeBlocks { get; set; }
        public DbSet<HrStatus> HrStatus { get; set; }

        public DbSet<UserTypes> UserTypes { get; set; }
        

        public DbSet<PermOnlineUser> PermOnlineUsers { get; set; }
        public DbSet<PermMenu> PermMenus { get; set; }

        public DbSet<OprMeterReadingLog> MeterReadingLogs { get; set; }
        public DbSet<BillPrintLog> PrintLogs { get; set; }

        //Notifications
        public DbSet<NotiFcmConfig> NotiFcmConfig { get; set; }
        public DbSet<NotiMessageUser> NotiMessageUsers { get; set; }
        public DbSet<NotiMessage> NotiMessages { get; set; }
        public DbSet<PayDataLog> PayDataLogs { get; set; }

        public DbSet<CustCustomerDataTemp> CustomerDataTemp { get; set; }

       

        #endregion


        #region Tracker Changes
        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken())
        {


            DateTime dateNow = new DateTime().NowEg();
            string userId= _accessor!.HttpContext==null ? "":_accessor!.HttpContext!.User.GetUserId();
            int? companyId=_accessor!.HttpContext==null ? null:_accessor!.HttpContext!.User.GetCompanyId();

            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is BaseEntity && (
                        e.State == EntityState.Added
                        || e.State == EntityState.Modified
                        || e.State == EntityState.Deleted)
                        );

            foreach (var entityEntry in entries)
            {

               
                
                ((BaseEntity)entityEntry.Entity).CompanyTenantId = companyId;

                if (entityEntry.State == EntityState.Added)
                {
                    ((BaseEntity)entityEntry.Entity).InsertDate = dateNow;
                    ((BaseEntity)entityEntry.Entity).InsertBy = userId;
                    ((BaseEntity)entityEntry.Entity).CompanyTenantId = companyId;
                }
                //if (entityEntry.State == EntityState.Deleted)
                //{
                //    entityEntry.State = EntityState.Modified;
                //    ((BaseEntity)entityEntry.Entity).DeleteDate = dateNow;
                //    ((BaseEntity)entityEntry.Entity).DeleteBy = userId;
                //    ((BaseEntity)entityEntry.Entity).CompanyTenantId = companyId;
                //    ((BaseEntity)entityEntry.Entity).IsDeleted = true;
                //    ((BaseEntity)entityEntry.Entity).UpdateDate = dateNow;
                //    ((BaseEntity)entityEntry.Entity).UpdateBy = userId;
                //}
            }

            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
        #endregion

    
   
    }
   
  
}
