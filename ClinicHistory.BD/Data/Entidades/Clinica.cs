using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicHistory.BD.Data.Entidades
{
    public class Clinica:EntityBase
    {
          
        //parte echa por Felix Espinoza. no estoy seguro de como enfocar esto pues mi enfoque es para atender a un paciente. pero se ira modificando.
        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(50, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string NombreClinica { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(50, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string DirecClinica { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(20, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string NumTelClinica { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(10, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string CodigoEmergencia { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(50, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string ObraSocialAsociada { get; set; }
    }
}
