using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using DotNetEnv;
using MyBackend.Data;
using MyBackend.Models;

var builder = WebApplication.CreateBuilder(args);

// Load environment variables from .env file
DotNetEnv.Env.Load();

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
  c.SwaggerDoc("v1", new OpenApiInfo
  {
    Title = "Playbased API",
    Description = "Activities your little ones will love!",
    Version = "v1"
  });
});

// builder.Services.AddHttpsRedirection(options =>
// {
//   options.HttpsPort = 7219; // Your HTTPS port as per launchSettings.json
// });

// Configure Entity Framework and SQL Server
var sqlServer = Environment.GetEnvironmentVariable("SQLSERVER");
var database = Environment.GetEnvironmentVariable("DATABASE");
var userId = Environment.GetEnvironmentVariable("USER_ID");
var password = Environment.GetEnvironmentVariable("PASSWORD");

var connectionString = $"Server=tcp:{sqlServer};Initial Catalog={database};Persist Security Info=False;User ID={userId};Password={password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI(c =>
  {
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "PlaybasedActivities API V1");
  });
}

// app.UseHttpsRedirection();

app.MapGet("/", () => "Hello World!");

app.Run();
