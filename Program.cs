using API_CONCESSIONARIA.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();



// Registers PizzariaContext using the "Pizzaria" connection string
builder.Services.AddDbContext<ConcessionariaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Concessionaria")));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
