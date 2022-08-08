using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicHistory.BD.Data.Entidades
{


    //Clase realizada por MARIANO CEJAS.
    //La clave unica en este caso es el DNI de nuestro paciente, bajo ningun punto de vista puede repetirse, ademas la seccion urgencias
    //necesitara este campo para poder leer la hc del paciente accidentado.
    [Index(nameof(DNI), Name = "DniPaciente_UQ", IsUnique = true)]
    

    //Creacion de la clase HistoriaClinicaPaciente
    //La Clase PacienteHistoriaClinica hereda el id de la clase EntityBase
    public class HistoriaClinicaPaciente : EntityBase
    {
   
        //Exigo que el campo sea compleatdo en el caso que se pase por alto se muestra un mensaje solicitando el dato.
        [Required(ErrorMessage = "Campo obligatorio")]
        //Exijo que tenga una determinada longitud en el caso que se exceda del limite caracteres.
        [MaxLength(50, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        //Declaracion de las propiedades de esta clase.
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(50, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string Apellido { get; set; }


        [Required(ErrorMessage = "Campo obligatorio")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(10, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string DNI { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(10, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string EstadoCivil { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(15, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string TelFijo { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(15, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string TelCelular { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(10, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string Localidad { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(20, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string Provincia { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(20, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string Pais { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(20, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string Barrio { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(20, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(20, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string Peso { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(10, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string Talla { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(10, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string HabitosAlimenticios { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public int IMC { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(30, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string NivelEducativo { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(300, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string AntecedentesPersonales { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(300, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string AntecedentesFamiliares { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public int NumeroHabitacionesDomicilio { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public int NumeroPersonasDomicilio { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        
        public string EstudiosMedicosRealizados { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        
        public string DiagnosticoMedico { get; set; }

        public List<Medico> Medicos { get; set; }


        //Detalles Nesesarios
        //CLASE MEDICO: Lo necesito por que este paciente va a ser atendido por muchos medicos(URIEL)
        //CLASE ESPECIALIDAD: Lo necesito por que mas quiero saber cual es la especialidad de esos medicos
        //que atienden a nuestro paciente(CANDE)
        //CLASE MATRICULA: Ademas de la especialidad necesito saber también la matricula de ese medico(URIEL).
        //TODOS ESTOS DATOS SON NECESARIOS PARA PODER MANTENER UNA HISTORIA CLINICA INTEGRA Y COMPLETA.


    }
}   
