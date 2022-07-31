using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicHistory.BD.Data
{
    //Esta clase nos permite tomarla como base para no repetir campos en las demas clases, teniendo esta clase yo pongo una sola vez la propiedad
    //y cuando las demas clases me lo soliciten simplemente agregamos  dos puntos y colocamos Entity Base y automaticamente heredamos esa propiedad.
    public class EntityBase
    {
        public int Id { get; set; }
        //Lo mismo que lo anterior solo  que este al tener signo de pregunta quiere decir que puede tomar valores nulos.
        public DateTime? FechaCreacion { get; set; }
    }
}
