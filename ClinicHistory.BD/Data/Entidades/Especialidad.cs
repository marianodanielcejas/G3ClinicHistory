using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicHistory.BD.Data.Entidades
{
    [Index(nameof(CodEsp), Name = "CodigoEspecialidad_UQ", IsUnique = true)]
    //Parte Candelaria
    public class Especialidad:EntityBase
    {
        public string CodEsp { get; set; }

        public string NomEsp { get; set; }

        public List<Matricula> Matriculas { get; set; }
        public List<Paramedico> paramedicos { get; set; }   

        
    }
}
