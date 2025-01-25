using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using NpgsqlTypes;
using RealEstateWebApi.Application;
using RealEstateWebApi.Application.DTOs.TokenOperation;
using RealEstateWebApi.Infrastructure;
using RealEstateWebApi.Infrastructure.Services.Storage.Aws;
using RealEstateWebApi.Infrastructure.Services.Storage.Local;
using RealEstateWebApi.Persistence;
using RealEstateWebApi.Persistence.Contexts;
using RealEstateWebApi.WebApi.Configurations.ColumWriters;
using RealEstateWebApi.WebApi.Extensions;
using Serilog;
using Serilog.Context;
using Serilog.Core;
using Serilog.Sinks.PostgreSQL;
using System.Net;
using System.Security.Claims;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpContextAccessor();

// Add services to the container.
builder.Services.AddPersistenceServices(builder.Configuration);
builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices();
builder.Services.AddStorage<LocalStorage>();

var tokenOptions = builder.Configuration.GetSection("TokenOptions").Get<TokenOptions>();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
{
    opt.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateAudience = true,
        ValidateIssuer = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = tokenOptions.Issuer,
        ValidAudience = tokenOptions.Audience,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenOptions.SecurityKey)),
        ClockSkew = TimeSpan.Zero
    };
});

builder.Services.AddCors(options => options.AddDefaultPolicy(policy =>
    policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()
));


Logger log = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File("logs/log.txt")
    .WriteTo.PostgreSQL(builder.Configuration.GetConnectionString("PostgreSQL"), "api_logs",
        needAutoCreateTable: true,
        columnOptions: new Dictionary<string, ColumnWriterBase>
        {
            {"message", new RenderedMessageColumnWriter(NpgsqlDbType.Text)},
            {"message_template", new MessageTemplateColumnWriter(NpgsqlDbType.Text)},
            {"level", new LevelColumnWriter(true , NpgsqlDbType.Varchar)},
            {"time_stamp", new TimestampColumnWriter(NpgsqlDbType.Timestamp)},
            {"exception", new ExceptionColumnWriter(NpgsqlDbType.Text)},
            {"log_event", new LogEventSerializedColumnWriter(NpgsqlDbType.Json)},
            {"user_id", new UserIdColumnWriter()},
            {"remote_ip",new RemoteIpColumnWriter()},
        })
    .Enrich.FromLogContext()
    .MinimumLevel.Information()
    .CreateLogger();

builder.Host.UseSerilog(log);

builder.Services.AddHttpLogging(logging =>
{
    logging.LoggingFields = HttpLoggingFields.All;
    logging.RequestHeaders.Add("sec-ch-ua");
    logging.MediaTypeOptions.AddText("application/javascript");
    logging.RequestBodyLogLimit = 4096;
    logging.ResponseBodyLogLimit = 4096;
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "RealEstateWebApi", Version = "v1" });
    var jwtSecurityScheme = new OpenApiSecurityScheme
    {
        Scheme = "bearer",
        BearerFormat = "JWT",
        Name = "JWT Authentication",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Description = "Put **_ONLY_** your JWT Bearer token on textbox below!",

        Reference = new OpenApiReference
        {
            Id = JwtBearerDefaults.AuthenticationScheme,
            Type = ReferenceType.SecurityScheme
        }
    };

    c.AddSecurityDefinition(jwtSecurityScheme.Reference.Id, jwtSecurityScheme);

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    { jwtSecurityScheme, Array.Empty<string>() }
                });
});

//npsql timestamp and timezone bug fix 
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
//npsql dateonly value -infinity bug fix 
AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSerilogRequestLogging();

app.UseHttpLogging();

app.UseCustomExceptionMiddleware();


using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<RealEstateWebApiDbContext>();
    db.Database.Migrate();

}


app.UseStaticFiles();
app.UseCors();

app.UseHttpsRedirection();

app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
});

app.UseAuthentication();
app.UseAuthorization();

app.Use(async (context, next) =>
{
    var userid = context.User?.Identity?.IsAuthenticated == true ? context.User.Claims.First(x => x.Type == ClaimTypes.NameIdentifier)?.Value : null;
    LogContext.PushProperty("user_id", userid);
    //var remoteIp = context.Connection.RemoteIpAddress?.MapToIPv4().ToString();
    IPAddress ip;
    var headers = context.Request.Headers.ToList();
    if (headers.Exists((kvp) => kvp.Key == "X-Forwarded-For"))
    {
        try
        {
            // when running behind a load balancer you can expect this header
            var header = headers.First((kvp) => kvp.Key == "X-Forwarded-For").Value.ToString();
            // in case the IP contains a port, remove ':' and everything after
            ip = IPAddress.Parse(header.Remove(header.IndexOf(':')));
        }
        catch (Exception ex)
        {
            ip = context.Request.HttpContext.Connection.LocalIpAddress;
        }

    }
    else
    {
        // this will always have a value (running locally in development won't have the header)
        ip = context.Request.HttpContext.Connection.RemoteIpAddress;
    }
    LogContext.PushProperty("remote_ip", ip.ToString());
    await next();
});

app.MapControllers();

app.Run();
