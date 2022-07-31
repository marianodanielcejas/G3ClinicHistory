using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicHistory.BD.Data.Entidades
{
    public class Medico:EntityBase
    {
        [MaxLength(150, ErrorMessage = "El nombre no puede superar los {1} caracteres")]
        public string nombre { get; set; }
        [MaxLength(8, ErrorMessage = "El DNI no puede superar los {1} caracteres")]
        //[Index(nameof(DNI),Name ="NombreMedico-uq",IsUnique =true)]
        public string DNI { get; set; }
    }
}
