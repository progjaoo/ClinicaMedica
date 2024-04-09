using ClinicaMedica.Application.Commands.Pacientes.CreatePacienteCommand;
using ClinicaMedica.Application.Queries.Pacientes.GetAll;
using ClinicaMedica.Core.Entidades;
using ClinicaMedica.Core.Repositorios;
using ClinicaMedica.Infrastructure.Authentication;
using ClinicaMedica.Infrastructure.Persistence.Repositorios;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region CONEXOEX/D.I
//CONEXAO-BD
var connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ClinicaMedicaContext>(options =>
    options.UseSqlServer(connection));


//inje��es de dependencia
builder.Services.AddScoped<IAuthService, AuthenticationService>();
builder.Services.AddScoped<IPacienteRepository, PacienteRepository>();
builder.Services.AddScoped<IMedicoRepository, MedicoRepository>();
builder.Services.AddScoped<IAtendimentoRepository, AtendimentoRepository>();

//mediator
builder.Services.AddMediatR(typeof(GetAllPacientesQuery));
builder.Services.AddMediatR(typeof(CreatePacienteCommand));


#endregion

builder.Services.AddHttpClient();


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
