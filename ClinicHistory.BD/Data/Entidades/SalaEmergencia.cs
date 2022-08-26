using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicHistory.BD.Data.Entidades
{
    public class SalaEmergencia:EntityBase
    {

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(20, ErrorMessage = "Este dato no puede superar los {1} caracteres")]
        public string NombreClinica { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(30, ErrorMessage = "Este dato no puede superar los {1} caracteres")]
        public string DireccClinica { get; set; }
        public int NumTelClinica { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(4, ErrorMessage = "Este dato no puede superar los {1} caracteres")]
        public string CodigoEmergencia { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(20, ErrorMessage = "Este dato no puede superar los {1} caracteres")]
        public string ObraSocialAsociada { get; set; }

        [Required(ErrorMessage = "La ambulancia es obligatoria")]
        public int AmbulanciaId { get; set; }

        public Ambulancia Ambulancia { get; set; }

    }
}
