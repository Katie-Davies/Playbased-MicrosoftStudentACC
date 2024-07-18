using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
  c.SwaggerDoc("v1", new OpenApiInfo { Title = "Playbased API", Description = "Activities your little ones will love!", Version = "v1" });
});
builder.Services.AddHttpsRedirection(options =>
{
  options.HttpsPort = 7219; // Your HTTPS port as per launchSettings.json
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI(c =>
   {
     c.SwaggerEndpoint("/swagger/v1/swagger.json", "PlaybasedActivities API V1");
   }); ;
}


app.UseHttpsRedirection();


app.MapGet("/", () => "Hello World!");

app.Run();


