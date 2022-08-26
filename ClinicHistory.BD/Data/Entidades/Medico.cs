using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicHistory.BD.Data.Entidades
{
    [Index(nameof(DNI), Name = "DniMedico-uq", IsUnique = true)]
    public class Medico:EntityBase
    {
        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(30, ErrorMessage = "Este dato no puede superar los {1} caracteres")]
        public string NombreCompleto { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(8, ErrorMessage = "Este dato no puede superar los {1} caracteres")]
        public string DNI { get; set; }

        public List<HistoriaClinica> HistoriasClinicas { get; set; }
        public List<Paciente> Pacientes { get; set; }
        public List<Matricula> Matriculas { get; set; }
    }
}
