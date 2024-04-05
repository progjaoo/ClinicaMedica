using ClinicaMedica.Core.Entidades;
using ClinicaMedica.Core.Repositorios;
using ClinicaMedica.Infrastructure.Persistence.Repositorios;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();


#region
//CONEXAO-BD
var connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ClinicaMedicaContext>(options =>
    options.UseSqlServer(connection));



//injeções de dependencia
builder.Services.AddScoped<IPacienteRepository, PacienteRepository>();


#endregion

var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
