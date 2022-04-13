using Microsoft.EntityFrameworkCore;
using TMSAPI.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

string ConStr = builder.Configuration.GetConnectionString("MyConStr");
builder.Services.AddDbContext<AppDBContext>(dbConOptions => dbConOptions.UseSqlServer(ConStr));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
