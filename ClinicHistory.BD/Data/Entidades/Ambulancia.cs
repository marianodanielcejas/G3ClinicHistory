using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicHistory.BD.Data.Entidades
{
    public class Ambulancia:EntityBase
    {
        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(4, ErrorMessage = "Este dato no puede superar los {1} caracteres")]
        public string CodigoEmergencia { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(7, ErrorMessage = "Este dato no puede superar los {1} caracteres")]
        public string Patente { get; set; }

        [Required(ErrorMessage = "La sala de emergencia es obligatoria")]
        public int SalaEmergenciaId { get; set; }

        public SalaEmergencia SalaEmergencia { get; set; }

    }
}
