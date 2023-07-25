using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Npgsql;
using PFM.Database;
using PFM.Database.Repositories;
using PFM.Services;
using System.Reflection;
using System.Text.Json.Serialization;

var myLocalHostPolicy = "MyCORSPolicy";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: myLocalHostPolicy, policy =>
    {
        policy.WithOrigins("http://localhost:4200").AllowAnyHeader();
    });
});

// Add services to the container.
builder.Services.AddScoped<ITransactionService, TransactionService>();
builder.Services.AddScoped<ITransactionRepository, TransactionRepository>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IAnalyticsService, AnalyticsService>();

// AutoMapper definition
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.Converters.Add(
        new JsonStringEnumConverter(System.Text.Json.JsonNamingPolicy.CamelCase)
        );
    options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Personal Finance Management API",
        Version = "v1",
        Description = "Personal Finance Management API allows analyze of a client's spending patterns against pre-defined budgets over time"
    });
});


builder.Services.AddDbContext<PfmDbContext>(opt =>
{
    opt.UseNpgsql(CreateConnectionString(builder.Configuration));
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    // pokretanje migracije
    using var scope = app.Services.GetService<IServiceScopeFactory>().CreateScope();
    scope.ServiceProvider.GetRequiredService<PfmDbContext>().Database.Migrate();

}

app.UseAuthorization();

app.MapControllers();
app.UseCors(myLocalHostPolicy);
app.Run();

string CreateConnectionString(IConfiguration configuration)
{
    var username = Environment.GetEnvironmentVariable("DATABASE_USERNAME") ?? "sa";
    var pass = Environment.GetEnvironmentVariable("DATABASE_PASSWORD") ?? "Password123#";
    var databaseName = Environment.GetEnvironmentVariable("DATABASE_NAME") ?? "pfm";
    var host = Environment.GetEnvironmentVariable("DATABASE_HOST") ?? "localhost";
    var port = Environment.GetEnvironmentVariable("DATABASE_PORT") ?? "5432";

    var connBuilder = new NpgsqlConnectionStringBuilder
    {
        Host = host,
        Port = int.Parse(port),
        Username = username,
        Database = databaseName,
        Password = pass,
        Pooling = true
    };

    return connBuilder.ConnectionString;
}