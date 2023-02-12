namespace AlignSales.DataAccess.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static DateTime StaticDate = new DateTime(2023, 1, 1);
        public static void Seed(this ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<OprMeterStatus>()
               .HasData(
                   new OprMeterStatus() { Id = 15, Name = "متعذر", InsertDate = StaticDate, UpdateDate = StaticDate },
                   new OprMeterStatus() { Id = 16, Name = "غير مقروء", InsertDate = StaticDate, UpdateDate = StaticDate },
                   new OprMeterStatus() { Id = 17, Name = "تقديرية", InsertDate = StaticDate, UpdateDate = StaticDate },
                   new OprMeterStatus() { Id = 18, Name = "صحيحة", InsertDate = StaticDate, UpdateDate = StaticDate }
               );
            
            modelBuilder.Entity<BillPaymentType>()
               .HasData(
                   new BillPaymentType() { Id = 1,SysName="cash", Name = "كاش", InsertDate = StaticDate, UpdateDate = StaticDate },
                   new BillPaymentType() { Id = 2,SysName = "cheque", Name = "شيك", InsertDate = StaticDate, UpdateDate = StaticDate },
                   new BillPaymentType() { Id = 3,SysName = "visa", Name = "فيزا", InsertDate = StaticDate, UpdateDate = StaticDate }
                  
               );

            modelBuilder.Entity<CustCustomerStatus>()
                .HasData(
                    new CustCustomerStatus() { InsertDate = StaticDate, UpdateDate = StaticDate , Id = 1 , Name = "سارى" }
                );

            modelBuilder.Entity<OprUpdatedCustomerType>()
               .HasData(
                   new OprUpdatedCustomerType() { Id = 1, Name = "الموقع", SysName = "location" ,InsertDate = StaticDate, UpdateDate = StaticDate },
                   new OprUpdatedCustomerType() { Id = 2, Name = "النشاط", SysName = "activity", InsertDate = StaticDate, UpdateDate = StaticDate },
                   new OprUpdatedCustomerType() { Id = 3, Name = "عدد الوحدات", SysName = "unitsnumber", InsertDate = StaticDate, UpdateDate = StaticDate },
                   new OprUpdatedCustomerType() { Id = 4, Name = "صورة العميل", SysName = "customerimage", InsertDate = StaticDate, UpdateDate = StaticDate }
               );

            modelBuilder.Entity<HrStatus>()
               .HasData(
                   new HrStatus() { Id = 1, Name = "يعمل", InsertDate = StaticDate, UpdateDate = StaticDate },
                   new HrStatus() { Id = 2, Name = "تمت اقالتة", InsertDate = StaticDate, UpdateDate = StaticDate },
                    new HrStatus() { Id = 3, Name = "أجازة", InsertDate = StaticDate, UpdateDate = StaticDate },
                     new HrStatus() { Id = 4, Name = "معاش", InsertDate = StaticDate, UpdateDate = StaticDate },
                     new HrStatus() { Id = 5, Name = "متوفى", InsertDate = StaticDate, UpdateDate = StaticDate }
               );

            //modelBuilder.Entity<PermMenu>()
            //    .HasData(
            //        new PermMenu() { Name = "Screen", IsLast = false, Route = "", Permission = "", Icon = "" },
            //        new PermMenu() { Name = "Report", IsLast = false, Route = "", Permission = "", Icon = "" }
            //        );

        }

        public static void AddQueryFilterToAllEntitiesAssignableFrom<T>(this ModelBuilder modelBuilder,
         Expression<Func<T, bool>> expression)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                if (!typeof(T).IsAssignableFrom(entityType.ClrType))
                    continue;

                var parameterType = Expression.Parameter(entityType.ClrType);
                var expressionFilter = ReplacingExpressionVisitor.Replace(
                    expression.Parameters.Single(), parameterType, expression.Body);

                var currentQueryFilter = entityType.GetQueryFilter();
                if (currentQueryFilter != null)
                {
                    var currentExpressionFilter = ReplacingExpressionVisitor.Replace(
                        currentQueryFilter.Parameters.Single(), parameterType, currentQueryFilter.Body);
                    expressionFilter = Expression.AndAlso(currentExpressionFilter, expressionFilter);
                }

                var lambdaExpression = Expression.Lambda(expressionFilter, parameterType);
                entityType.SetQueryFilter(lambdaExpression);
            }
        }
    }

    public static class EntityTypeBuilderExtensions
    {
        public static void AddQueryFilter<T>(this EntityTypeBuilder entityTypeBuilder, Expression<Func<T, bool>> expression)
        {
            var parameterType = Expression.Parameter(entityTypeBuilder.Metadata.ClrType);
            var expressionFilter = ReplacingExpressionVisitor.Replace(
                expression.Parameters.Single(), parameterType, expression.Body);

            var currentQueryFilter = entityTypeBuilder.Metadata.GetQueryFilter();
            if (currentQueryFilter != null)
            {
                var currentExpressionFilter = ReplacingExpressionVisitor.Replace(
                    currentQueryFilter.Parameters.Single(), parameterType, currentQueryFilter.Body);
                expressionFilter = Expression.AndAlso(currentExpressionFilter, expressionFilter);
            }

            var lambdaExpression = Expression.Lambda(expressionFilter, parameterType);
            entityTypeBuilder.HasQueryFilter(lambdaExpression);
        }
    }
}

