﻿using ClinicHistory.BD.Data.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicHistory.BD.Data
{
    // La clase dbContext es generada por nosotros, esta a su vez hereda de la clase DbContext que pertenece a Entity Framework.
    public class dbContext : DbContext
    {
        //Creacion de la tabla Historias Clinicas que se rige bajo el modelo PacienteHistoriaClinica. 
        DbSet<HistoriaClinicaPaciente> HistoriaClinica { get; set ;}

        DbSet<Medico> Medicos { get; set; }

        DbSet<Matricula> Matriculas { get; set; }

        //Constructor de la clase dbContext que recibe una variable options y se lo debe pasar a la clase base que es DbContext.
        //Aca se tablas con el dbset
        public dbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
