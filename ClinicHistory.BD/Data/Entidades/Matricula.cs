using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicHistory.BD.Data.Entidades
{
    public class Matricula:EntityBase
    {
        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(50, ErrorMessage = "El numero de matricula no puede superar los {1} caracteres")]
        public int numeroMatric { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(150, ErrorMessage = "El nombre del medico no puede superar los {1} caracteres")]
        public string nombreMedico { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(8, ErrorMessage = "El DNI no puede superar los {1} caracteres")]
        
        public string DNI { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(50, ErrorMessage = "La especialidad no puede superar los {1} caracteres")]
        public string Especialidad { get; set; }
        
    }
}
