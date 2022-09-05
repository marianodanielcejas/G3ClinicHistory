﻿using System;
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
        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(20, ErrorMessage = "Este dato no puede superar los {1} caracteres")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(20, ErrorMessage = "Este dato no puede superar los {1} caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(8, ErrorMessage = "Este dato no puede superar los {1} caracteres")]
        public string DNI { get; set; }


        public List <Medico> medicos { get; set; }  
        


    }
}
