﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ClinicaMedica.Core.Entidades;

public partial class Atendimento
{
    public int IdAtendimento { get; private set; }
    public int IdServico { get; private set; }
    public int IdMedico { get; private set; }
    public int IdPaciente { get; private set; }
    public int? TipoAtendimento { get; private set; }
    public DateTime? DataInicio { get; private set; }
    public DateTime? DataFim { get; private set; }
}