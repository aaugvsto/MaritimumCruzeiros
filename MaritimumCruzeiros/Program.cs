using CruzeirosEmporio.Services;
using MaritimumCruzeiros.Data;
using MaritimumCruzeiros.Services;
using MaritimumCruzeiros.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using MaritimumCruzeiros.Helpers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DBContext>(options =>
                    options.UseMySql(ConnectionHelper.GetConnectionString(builder.Configuration),
                    ServerVersion.Parse("10.4.22-MariaDB")));

builder.Services.AddScoped<ICabineService, CabineService>();
builder.Services.AddScoped<ICabineTripulanteService, CabineTripulanteService>();
builder.Services.AddScoped<ICruzeiroService, CruzeiroService>();
builder.Services.AddScoped<INavioService, NavioService>();
builder.Services.AddScoped<IPessoaService, PessoaService>();
builder.Services.AddScoped<ISexoPessoaService, SexoPessoaService>();
builder.Services.AddScoped<ITipoCabineService, TipoCabineService>();
builder.Services.AddScoped<ITipoTripulanteService, TipoTripulanteService>();
builder.Services.AddScoped<ITripulanteService, TripulanteService>();

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
