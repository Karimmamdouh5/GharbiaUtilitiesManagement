
using UtilitiesManagement.DataAccess.DataContext;
using UtilitiesManagement.DataAccess.Repositories;
using UtilitiesManagement.DataAccess.Repositories.Align;
using UtilitiesManagement.DataAccess.Repositories.Shared;
using UtilitiesManagement.DataAccess.Repositories.StaticDataRepository;
using UtilitiesManagement.Domain;
using UtilitiesManagement.Domain.Interfaces;
using UtilitiesManagement.Domain.Interfaces.Align;
using UtilitiesManagement.Domain.Interfaces.Shared;
using UtilitiesManagement.Domain.Interfaces.StaticDataRepository;
using UtilitiesManagement.Domain.Models;
using UtilitiesManagement.Domain.Models.Permission;
using UtilitiesManagement.Domain.Options;
using UtilitiesManagement.Domain.SwaggerFilter;
using UtilitiesManagement.Services.IServices;

using UtilitiesManagement.Services.IServices.IAppConfig;
using UtilitiesManagement.Services.IServices.Seeds;
using UtilitiesManagement.Services.IServices.Shared;
using UtilitiesManagement.Services.IServices.StaticData;
using UtilitiesManagement.Services.Services;
using UtilitiesManagement.Services.Services.AppConfig;

using UtilitiesManagement.Services.Services.Permission;
using UtilitiesManagement.Services.Services.Seeds;
using UtilitiesManagement.Services.Services.Shared;
using UtilitiesManagement.Services.Services.StaticData;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Serilog;
using System.Globalization;
using System.Text;
using System.Text.Json.Serialization;
using UtilitiesManagement.Domain.Untility;
using UtilitiesManagement.Api.Filters;
using UtilitiesManagement.Services.Services.Operation;
using UtilitiesManagement.Services.IServices.HR;
using UtilitiesManagement.Services.Services.HR;
using UtilitiesManagement.Services.IServices.Technician;
using UtilitiesManagement.Services.Services.Technician;
using UtilitiesManagement.Services.Services.Customer;
using UtilitiesManagement.Services.Services.Bill;
using UtilitiesManagement.Domain.Interfaces.Operation;
using UtilitiesManagement.DataAccess.Repositories.Operation;
using UtilitiesManagement.Services.Services.Report;
using Microsoft.Extensions.DependencyInjection.Extensions;
using UtilitiesManagement.Api.SignalRConfig;
using System.Drawing;
using UtilitiesManagement.Services.Hubs.DashBoard;
using UtilitiesManagement.Services.Services.Notification;
using UtilitiesManagement.Services.IServices.Notifications;
using UtilitiesManagement.Api.Profiles;
using FacilityManagement.Api.Profiles;

var builder = WebApplication.CreateBuilder(args);

var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

//var logger = new LoggerConfiguration()
//  .ReadFrom.Configuration(config)
//  .Enrich.FromLogContext()
//  .CreateLogger();
//builder.Logging.ClearProviders();
//builder.Logging.AddSerilog(logger);

Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(config)
    .CreateLogger();
builder.Host.UseSerilog();


//builder.Services.AddSingleton(Log.Logger);
builder.Services.AddScoped<IDbInitSeedsService, DBInitSeedsService>(); //can be placed among other "AddScoped" - above: var app = builder.Build();   
//builder.Services.AddCors(
//    options => {
//        options.AddPolicy("CORSPolicy", builder => builder.AllowAnyMethod().AllowAnyHeader().AllowCredentials().SetIsOriginAllowed((hosts) => true));
//    });
// Add services to the container.

#region Dependency Injection

//to add any services like send Emails in to  AuthService
builder.Services.AddAutoMapper(typeof(Program).Assembly);

builder.Services.AddSingleton(provider => new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new BillsProfile(provider.CreateScope().ServiceProvider.GetService<IHttpContextAccessor>()));
    cfg.AddProfile(new CustomerProfile());
    cfg.AddProfile(new AuthProfile());
    cfg.AddProfile(new HrEmployeeProfile());
    cfg.AddProfile(new NotificationProfiler());
    cfg.AddProfile(new OperationProfile());
    cfg.AddProfile(new SharProfile());
    cfg.AddProfile(new TechProfile());
}).CreateMapper());

builder.Services.AddSingleton<IAuthorizationPolicyProvider, PermissionPolicyProvider>();
builder.Services.AddScoped<IAuthorizationHandler, PermissionAuthorizationHandler>();
builder.Services.AddScoped<IStaticDataRepository, StaticDataRepository>();
builder.Services.AddScoped<IStaticDataServices, StaticDataServices>();
builder.Services.AddScoped<ISharedServices, SharedServices>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddScoped<IOnlineUsersService, OnlineUsersService>();
builder.Services.AddScoped<IPermissionsService, PermissionsService>();
builder.Services.AddScoped<IFileUploader, FileUploader>();
builder.Services.AddScoped<IBranchService, BranchService>();
builder.Services.AddScoped<IAreaService, AreaService>();
builder.Services.AddScoped<IBlockService, BlockService>();
builder.Services.AddScoped<IGeneralService, GeneralService>();
builder.Services.AddScoped<ITechnicianLocationsService, TechnicianLocationService>();
builder.Services.AddScoped<IMeterReadingsService, MeterReadingsService>();
builder.Services.AddScoped<IComplaintsService, ComplaintsService>();
builder.Services.AddScoped<IUpdatedCustomersService, UpdatedCustomersService>();
builder.Services.AddScoped<IComplaintTypesService, ComplaintTypesService>();
builder.Services.AddScoped<ICustomerDataService, CustomerDataService>();
builder.Services.AddScoped<IBillService, BillService>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IComplaintTypesService, ComplaintTypesService>();  builder.Services.AddScoped<ICustomerDataService, CustomerDataService>();
builder.Services.AddScoped<IIssueService, IssueService>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();//
builder.Services.AddScoped<IIssuesReportService, IssuesReportService>();
builder.Services.AddScoped<ISharedReportService, SharedReportService>();
builder.Services.AddScoped<IPermMenuService, PermMenuService>();
builder.Services.AddScoped<IDashBoardServices, DashBoardServices>();
builder.Services.AddScoped<IFcmConfigService, FcmConfigService>();
builder.Services.AddScoped<INotiModulesServices, FcmModulesServices>();
builder.Services.AddScoped<IStateService, StateService>();
builder.Services.AddScoped<ICityService, CityService>();
builder.Services.AddScoped<INotiMessagesService, FcmMessagesService>();
builder.Services.AddScoped<IBillSafeService, BillSafeService>();

#endregion

//jwt configration
builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection("JwtSettings"));
#region Localization configuration
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");


var supportedCultures = new[] {"ar-EG", "en-US"};
var localizationOptions =
    new RequestLocalizationOptions().SetDefaultCulture(supportedCultures[0])
    .AddSupportedCultures(supportedCultures)
    .AddSupportedUICultures(supportedCultures);


#endregion


// configre to use identity in my project
builder.Services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
{
    options.SignIn.RequireConfirmedAccount = true;
    ////
    options.User.RequireUniqueEmail = false;
    //options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 6;
}
  ).AddEntityFrameworkStores<UtilitiesDbContext>();
builder.Services.AddControllersWithViews().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

//.AddJsonOptions(options =>
//      options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);
var jwtSettings = new JwtSettings();
builder.Configuration.Bind(nameof(jwtSettings), jwtSettings);
builder.Services.AddSingleton(jwtSettings);

#region SignalR
builder.Services.AddSignalR();
#endregion
builder.Services.AddControllers();

//to use jwt with authentication
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer
    (o =>
    {
        o.RequireHttpsMetadata = false;
        o.SaveToken = false;
        o.TokenValidationParameters = new TokenValidationParameters
        {

            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtSettings.SecretKey)),
            ValidateIssuer = true,
            ValidateAudience = false,
            ValidateLifetime = true,
            //RequireExpirationTime = false, // Todo update
            ValidIssuer = jwtSettings.Issuer,
            ClockSkew = TimeSpan.Zero,

        };
        o.Events = new JwtBearerEvents
        {
            OnMessageReceived = context =>
            {
                var accessToken = context.Request.Query["access_token"];

                // If the request is for our hub...
                var path = context.HttpContext.Request.Path;
                if (!string.IsNullOrEmpty(accessToken) && (path.StartsWithSegments("/OperationsHub")))
                {
                    // Read the token out of the query string
                    context.Request.Headers.Authorization = accessToken;
                    context.Token = accessToken;
                }
                return Task.CompletedTask;
            }
        };
    });
#region signalR
builder.Services.TryAddEnumerable(
    ServiceDescriptor.Singleton<IPostConfigureOptions<JwtBearerOptions>,
        ConfigureJwtBearerOptions>());
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("DomainRestricted", policy =>
    {
        policy.Requirements.Add(new DomainRestrictedRequirement());
    });
});
#endregion






//builder.Services.AddTransient(typeof(IAuthService), typeof(AuthService));

//builder.Services.AddScoped<IAuthService, AuthService>().AddScoped(serviceProvider => new Lazy<IAuthService>(() => serviceProvider.GetRequiredService<IAuthService>())); ;
builder.Services.AddScoped<IAlignCompanyRepository, AlignCompanyRepository>();
builder.Services.AddScoped<ILoggingRepository, LoggingRepository>();

//builder.Services.AddScoped<IBooksService, BooksService>();

var AlignConnectionString = builder.Configuration.GetConnectionString("AlignConnection");
builder.Services.AddDbContext<AlignDbContext>(options =>
    options.UseSqlServer(AlignConnectionString));

var FacilityConnectionString = builder.Configuration.GetConnectionString("UtilitiesConnection");
builder.Services.AddDbContext<UtilitiesDbContext>(options =>
    options.UseSqlServer(FacilityConnectionString));

// when not uset unitofwork
//builder.Services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();


builder.Services.AddControllers().AddDataAnnotationsLocalization(options =>
{
    options.DataAnnotationLocalizerProvider = (type, factory) =>
        factory.Create(typeof(DataAnnotationValidation));
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

#region SignalR
builder.Services.AddSignalR();
//builder.Services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
#endregion

builder.Services.AddSwaggerGen(c =>
{
   
    c.SwaggerDoc(SD.Modules.Auth, new OpenApiInfo
    {
        Title = "Auth",
        Version = "v1"
    });
    c.SwaggerDoc(SD.Modules.HR, new OpenApiInfo
    {
        Title = "Hr",
        Version = "v1"
    });
    c.SwaggerDoc(SD.Modules.Shared, new OpenApiInfo
    {
        Title = "Shared",
        Version = "v1"
    });
    c.SwaggerDoc(SD.Modules.Technician, new OpenApiInfo
    {
        Title = "Technician",
        Version = "v1"
    });
    c.SwaggerDoc(SD.Modules.Customer, new OpenApiInfo
    {
        Title = "Customers",
        Version = "v1"
    });
    c.SwaggerDoc(SD.Modules.Bill, new OpenApiInfo
    {
        Title = "Bills",
        Version = "v1"
    });

    c.SwaggerDoc(SD.Modules.Operation, new OpenApiInfo
    {
        Title = "Operation",
        Version = "v1"
    });

    c.SwaggerDoc(SD.Modules.Report, new OpenApiInfo
    {
        Title = "Report",
        Version = "v1"
    });
    c.SwaggerDoc(SD.Modules.DashBoard, new OpenApiInfo
    {
        Title = "DashBoard",
        Version = "v1"
    });
    c.SwaggerDoc(SD.Modules.Notification, new OpenApiInfo
    {
        Title = "Notification",
        Version = "v1"
    });
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please insert JWT with Bearer into field",
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement {
   {
     new OpenApiSecurityScheme
     {
       Reference = new OpenApiReference
       {
         Type = ReferenceType.SecurityScheme,
         Id = "Bearer",

       },
        In = ParameterLocation.Header,
        Name= "Bearer",
      },
      new string[] { }
    }
  });
    c.SchemaFilter<swaggertest>();
});
try
{
    var app = builder.Build();
Log.Information("Application starting.");
#region SeedData
if (args.Length == 1 && args[0].ToLower() == "seeddata")
{
    Log.Information("Data seeding.");
    try
    {
        SeedData(app);
    }
    catch (Exception ex)
    {
        Log.Error(ex, "Error When Seedding Data");
       
    }
    //can be placed above app.UseStaticFiles();
    Log.Information("Data seeded.");
}

async void SeedData(IHost app) //can be placed at the very bottom under app.Run()
{
    var scopedFactory = app.Services.GetService<IServiceScopeFactory>();
   
    using (var scope = scopedFactory.CreateScope())
    {
        var dbInitializer = scope.ServiceProvider.GetService<IDbInitSeedsService>();
        await dbInitializer.Initialize();
        //await dbInitializer.SeedBasicUserAsync();
        //await dbInitializer.SeedSuperAdminUserAsync();
    }
}
#endregion
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.IsProduction() || app.Environment.IsEnvironment("Local"))
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint($"/swagger/{SD.Modules.Auth}/swagger.json", "Auth v1");
        c.SwaggerEndpoint($"/swagger/{SD.Modules.HR}/swagger.json", "Hr v1"); 
        c.SwaggerEndpoint($"/swagger/{SD.Modules.Shared}/swagger.json", "Shared v1");
        c.SwaggerEndpoint($"/swagger/{SD.Modules.Technician}/swagger.json", "Technician v1");
        c.SwaggerEndpoint($"/swagger/{SD.Modules.Customer}/swagger.json", "Customers v1");
        c.SwaggerEndpoint($"/swagger/{SD.Modules.Bill}/swagger.json", "Bills v1");
        c.SwaggerEndpoint($"/swagger/{SD.Modules.Operation}/swagger.json", "Operation v1");
        c.SwaggerEndpoint($"/swagger/{SD.Modules.Report}/swagger.json", "Report v1");
        c.SwaggerEndpoint($"/swagger/{SD.Modules.DashBoard}/swagger.json", "DashBoard v1");
        c.SwaggerEndpoint($"/swagger/{SD.Modules.Notification}/swagger.json", "Notification v1");
    });
}
//Log.Information("step1");
app.UseHttpsRedirection();
//app.UseStaticFiles();

app.UseStaticFiles(new StaticFileOptions()
{
    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "FilesServer/images")),
    RequestPath = new PathString("/FilesServer/images")
});
app.UseCors(c => c.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin().AllowAnyOrigin());

    app.UseRequestLocalization(localizationOptions);

app.UseAuthentication();
app.UseAuthorization();


app.UseSerilogRequestLogging();
app.MapHub<OperationsHub>("/OperationsHub");
    //Log.Information("step2");
    app.MapControllers();
    app.Run();
    Log.Information("Application Started");
}
catch (Exception ex)
{
    Log.Fatal(ex,"Application Error When Building");
}

