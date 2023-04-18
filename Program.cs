// 1. Using to work EntityFramework
using Microsoft.EntityFrameworkCore;
using UniversityBackend.DataAccess;

var builder = WebApplication.CreateBuilder(args);

// 2. Connection with SQL Server Express
const string CONNECTIONNAME = "UniversityDB";
var connectiongString = builder.Configuration.GetConnectionString(CONNECTIONNAME);

// 3. Add context
builder.Services.AddDbContext<UniversityDBContext>(options => options.UseSqlServer(connectiongString));


// Add services to the container.

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
