using ECommerceAPI.API.Configurations.ColumnWriters;
using ECommerceAPI.API.Extensions;
using ECommerceAPI.API.Filters;
using ECommerceAPI.Application;
using ECommerceAPI.Application.Validators.Products;
using ECommerceAPI.Infrastructure;
using ECommerceAPI.Infrastructure.Filters;
using ECommerceAPI.Infrastructure.Services.Storage.Azure;
using ECommerceAPI.Infrastructure.Services.Storage.Local;
using ECommerceAPI.Persistence;
using ECommerceAPI.SignalR;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.IdentityModel.Tokens;
using NpgsqlTypes;
using Serilog;
using Serilog.Context;
using Serilog.Core;
using Serilog.Sinks.PostgreSQL;
using System.Security.Claims;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpContextAccessor();
builder.Services.AddPersistenceServices();
builder.Services.AddInfrastructureServices();
builder.Services.AddApplicationServcies();
builder.Services.AddSignalRServices();

var storageConnectionString = builder.Configuration["Storage:Azure"];
if (!string.IsNullOrWhiteSpace(storageConnectionString))
{
    builder.Services.AddStorage<AzureStorage>();
}
else
{
    builder.Services.AddStorage<LocalStorage>();
}

builder.Services.AddCors(options => options.AddDefaultPolicy(policy =>
    policy.WithOrigins("https://localhost:4200", "http://localhost:4200").AllowAnyHeader().AllowAnyMethod().AllowCredentials()
));

var loggerConfiguration = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.Async(a => a.File("logs/log.txt"))
    .Enrich.FromLogContext()
    .MinimumLevel.Information();

var postgresConnectionString = builder.Configuration.GetConnectionString("PostgreSQL");
if (!string.IsNullOrWhiteSpace(postgresConnectionString))
{
    var columnOptions = new Dictionary<string, ColumnWriterBase>
    {
        {"message", new RenderedMessageColumnWriter(NpgsqlDbType.Text)},
        {"message_template", new MessageTemplateColumnWriter(NpgsqlDbType.Text)},
        {"level", new LevelColumnWriter(true , NpgsqlDbType.Varchar)},
        {"time_stamp", new TimestampColumnWriter(NpgsqlDbType.Timestamp)},
        {"exception", new ExceptionColumnWriter(NpgsqlDbType.Text)},
        {"log_event", new LogEventSerializedColumnWriter(NpgsqlDbType.Json)},
        {"user_name", new UsernameColumnWriter()}
    };

    loggerConfiguration = loggerConfiguration.WriteTo.Async(a => a.PostgreSQL(postgresConnectionString, "logs",
        needAutoCreateTable: true,
        columnOptions: columnOptions));
}

var seqServerUrl = builder.Configuration["Seq:ServerURL"];
if (!string.IsNullOrWhiteSpace(seqServerUrl))
{
    loggerConfiguration = loggerConfiguration.WriteTo.Async(a => a.Seq(seqServerUrl));
}

Logger log = loggerConfiguration.CreateLogger();

builder.Host.UseSerilog(log);

builder.Services.AddHttpLogging(logging =>
{
    logging.LoggingFields = HttpLoggingFields.All;
    logging.RequestHeaders.Add("sec-ch-ua");
    logging.MediaTypeOptions.AddText("application/javascript");
    logging.RequestBodyLogLimit = 4096;
    logging.ResponseBodyLogLimit = 4096;
});

builder.Services.AddControllers(options =>
{
    options.Filters.Add<ValidationFilter>();
    options.Filters.Add<RolePermissionFilter>();
}).ConfigureApiBehaviorOptions(options => options.SuppressModelStateInvalidFilter = true);

builder.Services.AddFluentValidationAutoValidation().AddValidatorsFromAssemblyContaining<CreateProductValidator>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var tokenAudience = builder.Configuration["Token:Audience"] ?? "test-audience";
var tokenIssuer = builder.Configuration["Token:Issuer"] ?? "test-issuer";
var tokenSecurityKey = builder.Configuration["Token:SecurityKey"] ?? "TestSecurityKey1234567890TestSecurityKey1234567890";

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer("Admin", options =>
    {
        options.TokenValidationParameters = new()
        {
            ValidateAudience = true, // Origin Check
            ValidateIssuer = true, // Who Delivers The Token
            ValidateLifetime = true, // Time Check
            ValidateIssuerSigningKey = true, // Secret Key Check

            ValidAudience = tokenAudience,
            ValidIssuer = tokenIssuer,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenSecurityKey)),
            LifetimeValidator = (notBefore, expires, securityToken, validationParameters) => expires != null ? expires > DateTime.UtcNow : false,

            NameClaimType = ClaimTypes.Name
        };
    });

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.ConfigureExceptionHandler<Program>(app.Services.GetRequiredService<ILogger<Program>>());
app.UseStaticFiles();

app.UseSerilogRequestLogging();

app.UseHttpLogging();

app.UseCors();
app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.Use(async (context, next) =>
{
    var username = context.User?.Identity?.IsAuthenticated != null || true ? context.User.Identity.Name : null;
    LogContext.PushProperty("user_name", username);
    await next();
});

app.MapControllers();
app.MapHubs();

app.Run();

public partial class Program
{
}
