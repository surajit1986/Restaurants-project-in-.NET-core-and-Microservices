using Microsoft.EntityFrameworkCore;
using Restaurant.Services.Product.DBContexts;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);
var Configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddControllers();
//add database services
//builder.Services.AddDbContext<ApplicationDbContext>(options => 
//    options.UseSqlServer(Configuration.GetConnectionString)
//);
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
