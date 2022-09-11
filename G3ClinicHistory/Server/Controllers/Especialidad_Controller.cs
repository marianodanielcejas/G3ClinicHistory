using ClinicHistory.BD.Data;
using ClinicHistory.BD.Data.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace G3ClinicHistory.Server.Controllers
{

    //Cande
    //Api Especialidad
    [ApiController]


    //Ruta del controller
    [Route("{ Controller Especialidad }")]


    public class Especialidad_Controller: ControllerBase
    {

        private readonly dbContext context;


        public Especialidad_Controller(dbContext context)
        { 

            this.context = context;

        }


        //Etiqueta GET
        //Metodo GET (Sirve para pedir datos al servidor)
        [HttpGet]



        //Metodo asincronico
        //ActionResult( Devuelve la respuesta, la lista de Especialidad)
        public async Task<ActionResult<List<Especialidad>>> Get()
        {

            //Tabla Especialidades
            return await context.Especialidades.ToListAsync();

        }


        //Traer Especialidad segun ID
        [HttpGet("{id: int }")]


        public async Task<ActionResult<Especialidad>> Get(int id)
        {

            //Tabla Especialidades
            var especialidad = await context.Especialidades.Where(e => e.Id == id).FirstOrDefaultAsync();


            if (especialidad == null)
            {

                return NotFound($" No existe la especialidad de Id = {id}");

            }

            return especialidad;

        }
    }

}
