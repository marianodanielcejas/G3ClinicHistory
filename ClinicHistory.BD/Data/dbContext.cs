using ClinicHistory.BD.Data.Entidades;
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
        //Creacion de la tabla Historias Clinicas que se rige bajo el modelo HistoriaClinicaPaciente. 
        public DbSet<HistoriaClinicaPaciente> HistoriasClinicas { get; set ;}

        public DbSet<Paciente> Pacientes { get; set; }

        public DbSet<Medico> Medicos { get; set; }

        public DbSet<Matricula> Matriculas { get; set; }

        public DbSet<Paramedico> Paramedicos { get; set; }

        public DbSet<SalaEmergencia> SalasDeEmergencias { get; set; }

        public DbSet<Especialidad> Especialidades { get; set; }

        public DbSet<InformeMedico> InformesMedicos { get; set; }

        public DbSet<Ambulancia> Ambulancias { get; set; }




        //Constructor de la clase dbContext que recibe una variable options y se lo debe pasar a la clase base que es DbContext.
        //Aca se tablas con el dbset
        public dbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
