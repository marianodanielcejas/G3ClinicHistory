using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicHistory.BD.Data.Entidades
{
    public class InformeMedico:EntityBase
    {
        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength]
        public string InformePara { get; set; }

        [Required(ErrorMessage = "El Paciente es obligatorio")]
        public int PacienteId { get; set; }

        public Paciente Paciente { get; set; }
    }
}
