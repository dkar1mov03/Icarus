
using Serilog;
using Icarus.Api.Models;
using Icarus.Api.Extensions;
using Icarus.Data.DbContexts;
using Icarus.Api.Middlewares;
using Icarus.Service.Mappers;
using Icarus.Service.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddDbContext<IcarusDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddControllers();
builder.Services.AddCustomService();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Serilog
var logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .Enrich.FromLogContext()
    .CreateLogger();
builder.Logging.ClearProviders();
builder.Logging.AddSerilog(logger);

builder.Services.AddAutoMapper(typeof(MappingProfile));

// Configure api url name
builder.Services.AddControllers(options =>
{
    options.Conventions.Add(new RouteTokenTransformerConvention(
                                        new ConfigurationApiUrlName()));
});

var app = builder.Build();
WebHostEnvironmentHelper.WebRootPath = Path.GetFullPath("wwwroot");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseMiddleware<ExceptionHandlerMiddleWare>();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthorization();


app.MapControllers();

app.Run();

