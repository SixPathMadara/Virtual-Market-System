using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using VIS_API.Model;
using VIS_API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

//Register all Service interfaces
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IMarketService, MarketService>();
builder.Services.AddScoped<IIndicatorService, IndicatorService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MarketContext>(opt => {
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
