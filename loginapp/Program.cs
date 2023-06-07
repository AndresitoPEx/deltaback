using loginapp.Db.Contexts;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(
    options => options.AddDefaultPolicy(
        policy => policy
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    //.AllowAnyOrigin()
                    .WithOrigins("*")
    )
);

builder.Services.AddDbContext<MiBDContext>(Context => Context.UseNpgsql(builder. Configuration.GetConnectionString("StoreConnection")));
//"User ID = postgres; Password = metalkokex; Host = localhost; Port = 5432; Database = delta"
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
