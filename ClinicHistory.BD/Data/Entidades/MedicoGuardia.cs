using System;

public class MedicoGuardia
{
	public MedicoGuardia()
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

    }
}
