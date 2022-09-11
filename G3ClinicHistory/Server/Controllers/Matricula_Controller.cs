using ClinicHistory.BD.Data;
using ClinicHistory.BD.Data.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace G3ClinicHistory.Server.Controllers
{

    //Cande
    //Api Matricula
    [ApiController]


    //Ruta del controller
    [Route("{ Controller Matricula}")]


    public class Matricula_Controller: ControllerBase
    {

        private readonly dbContext context;


        public Matricula_Controller(dbContext context)
        {

            this.context = context;

        }


        //Etiqueta GET
        //Metodo GET (Sirve para pedir datos al servidor)
        [HttpGet]



        //Metodo asincronico
        //ActionResult( Devuelve la respuesta, la lista de Matricula)
        public async Task<ActionResult<List<Matricula>>> Get()
        {

            //Tabla Matriculas
            return await context.Matriculas.ToListAsync();

        }


        //Traer Matricula segun ID
        [HttpGet("{id: int }")]


        public async Task<ActionResult<Matricula>> Get(int id)
        {

            //Tabla Matriculas
            var matricula = await context.Matriculas.Where(e => e.Id == id).FirstOrDefaultAsync();


            if (matricula == null)
            {

                return NotFound($" No existe la matricula de Id = {id}");

            }

            return matricula;

        }

    }

}



