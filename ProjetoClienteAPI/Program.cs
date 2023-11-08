using Microsoft.EntityFrameworkCore;
using ProjetoClienteAPI.Data.Contexto;
using ProjetoClienteAPI.Data.Repositorio;
using ProjetoClienteAPI.Data.Repositorio.Interface;
using ProjetoClienteAPI.Servico.Servico;
using ProjetoClienteAPI.Servico.Servico.Interface;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<BancoContexto>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Database")));

builder.Services.AddScoped<IClienteRepositporio, ClienteRepositorio>();
builder.Services.AddScoped<IClienteServico, ClienteServico>();

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
