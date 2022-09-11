using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicHistory.BD.Data.Entidades
{
    public class HistoriaClinicaPaciente:EntityBase
    {
        [Required(ErrorMessage ="Este campo es obligatorio")]
        [MaxLength(10, ErrorMessage = "Este dato no puede superar los {1} caracteres")]
        public string EstadoCivil { get; set; }
        public int TelFijo { get; set; }
        public int TelCelular { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage = "Este dato no puede superar los {1} caracteres")]
        public string Localidad { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage = "Este dato no puede superar los {1} caracteres")]
        public string Provincia { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(20, ErrorMessage = "Este dato no puede superar los {1} caracteres")]
        public string Pais { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage = "Este dato no puede superar los {1} caracteres")]
        public string Barrio { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage = "Este dato no puede superar los {1} caracteres")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(6, ErrorMessage = "Este dato no puede superar los {1} caracteres")]
        public string Peso { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(8, ErrorMessage = "Este dato no puede superar los {1} caracteres")]
        public string Talla { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage = "Este dato no puede superar los {1} caracteres")]
        public string HabitosAlimenticios { get; set; }
        public int IMC { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage = "Este dato no puede superar los {1} caracteres")]
        public string NivelEducativo { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength]
        public string AntecedentesPersonales { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength]
        public string AntecedentesFamiliares { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength]
        public int NumeroHabitacionesDomicilio { get; set; }
        public int NumeroPersonasDomicilio { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength]
        public string EstudiosMedicosRealizados { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength]
        public string DiagnosticoMedico { get; set; }

        [Required(ErrorMessage = "El Médico es obligatorio")]
        public int MedicoId { get; set; }

        public Medico Medico { get; set; }

        [Required(ErrorMessage = "El Paciente es obligatorio")]
        public int PacienteId { get; set; }

        public Paciente Paciente { get; set; }

    }
}
