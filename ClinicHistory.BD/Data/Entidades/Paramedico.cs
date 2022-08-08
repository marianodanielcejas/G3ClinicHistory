using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicHistory.BD.Data.Entidades
{

    //esta linea no se que tan util sera de momento pues. sabemos que trabajaremos con una historia clinica
    //pero no como identificarla o que tan util sera en este hambito
    public class Paramedico:EntityBase
    {
        //Parte hecha por Felix Espinoza.
        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(50, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(20, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(10, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string DNI { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(50, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string NumAmbu { get; set; }

        //Esta linea no se que tan util sera de momento pues. sabemos que trabajaremos con una Historia clinica.
        //Pero no como identificarla o que tan util sera en este ambito.
        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(00, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string HistoriaMed { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(500, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string EstadoPaciente { get; set; }

    }
}
