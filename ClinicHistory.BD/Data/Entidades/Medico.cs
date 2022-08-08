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
        [MaxLength(150, ErrorMessage = "El nombre no puede superar los {1} caracteres")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(8, ErrorMessage = "El DNI no puede superar los {1} caracteres")]
        public string DNI { get; set; }

        public List <HistoriaClinicaPaciente> HistoriasClinicas { get; set; }

        public List<Matricula> Matriculas { get; set; }
    }
}
