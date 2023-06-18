
using Application.Interfaces;
using Application.Interfaces.ICiudad;
using Application.Interfaces.IPais;
using Application.Interfaces.IProvincia;
using Application.Interfaces.IViajeCiudad;
using Application.UseCase;
using Infrastructure.Client;
using Infrastructure.Command;
using Infrastructure.Persistence;
using Infrastructure.Query;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Custom
var connectionString = builder.Configuration["ConnectionString"];
builder.Services.AddDbContext<DestinosContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddScoped<IPaisService, PaisService>();
builder.Services.AddScoped<IPaisCommand, PaisCommand>();
builder.Services.AddTransient<IPaisQuery, PaisQuery>();

builder.Services.AddScoped<IProvinciaService, ProvinciaService>();
builder.Services.AddScoped<IProvinciaCommand, ProvinciaCommand>();
builder.Services.AddTransient<IProvinciaQuery, ProvinciaQuery>();

builder.Services.AddScoped<ICiudadService, CiudadService>();
builder.Services.AddScoped<ICiudadCommand, CiudadCommand>();
builder.Services.AddTransient<ICiudadQuery, CiudadQuery>();

builder.Services.AddScoped<IViajeCiudadService, ViajeCiudadService>();
builder.Services.AddScoped<IViajeCiudadCommand, ViajeCiudadCommand>();
builder.Services.AddTransient<IViajeCiudadQuery, ViajeCiudadQuery>();

builder.Services.AddScoped<IClientViaje, ClientViaje>();

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

