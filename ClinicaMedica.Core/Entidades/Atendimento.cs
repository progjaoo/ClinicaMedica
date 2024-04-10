﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using ClinicaMedica.Core.Enums;

namespace ClinicaMedica.Core.Entidades;

public partial class Atendimento
{
    public Atendimento(int idServico, int idMedico, int idPaciente, TipoAtendimento tipoAtendimento, DateTime? dataInicio, DateTime? dataFim)
    {
        IdServico = idServico;
        IdMedico = idMedico;
        IdPaciente = idPaciente;
        TipoAtendimento = tipoAtendimento;
        DataInicio = dataInicio;
        DataFim = dataFim;
    }

    public int IdAtendimento { get; private set; }
    public int IdServico { get; private set; }
    public int IdMedico { get; private set; }
    public int IdPaciente { get; private set; }
    public TipoAtendimento TipoAtendimento { get; private set; }
    public DateTime? DataInicio { get; private set; }
    public DateTime? DataFim { get; private set; }

    public void Update(int idServico, int idMedico, int idPaciente, TipoAtendimento tipoAtendimento, DateTime? dataInicio, DateTime? dataFim)
    {
        IdServico = idServico;
        IdMedico = idMedico;
        IdPaciente = idPaciente;
        TipoAtendimento = tipoAtendimento;
        DataInicio = dataInicio;
        DataFim = dataFim;
    }
}