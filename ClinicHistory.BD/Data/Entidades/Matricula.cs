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

        [Required(ErrorMessage = "El Médico es obligatorio")]
        public int MedicoId { get; set; }

        public Medico Medico { get; set; }

        [Required(ErrorMessage = "La Especialidad es obligatoria")]

        public int EspecialidadId { get; set; }

        public Especialidad Especialidad { get; set; }
    }
}
