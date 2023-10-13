using Microsoft.AspNetCore.Mvc;
using WebAplication.Context;
using WebAplication.Models;

namespace WebAplication.Controllers
{
    [ApiController]

    [Route("[controller]")]
    public class Students_Controller : ControllerBase
    {

        private readonly ILogger<Students_Controller> _logger;

        private readonly Aplication_Context _aplication_context;
        public Students_Controller(
            ILogger<Students_Controller> logger,


            Aplication_Context aplication_context)
        {
            _logger = logger;


            _aplication_context = aplication_context;

        }
        /*Crear*/
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Student student)
        {
            _aplication_context.students.Add(student);

            _aplication_context.SaveChanges();
            return Ok(student);

        }
        /*Obtener lista*/
        [Route("")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_aplication_context.students.ToList());

        }
        /*Modificar*/
        [Route("/id")]

        [HttpPut]
        public IActionResult Put(
            [FromBody] Student student)
        {
            _aplication_context.students.Update(student);
            _aplication_context.SaveChanges();

            return Ok(student);
        }
        /*Eliminar*/
        [Route("/id")]
        [HttpDelete]
        public IActionResult Delete(int Student_ID)
        {
            _aplication_context.students.Remove(
                _aplication_context.students.ToList()
                .Where(x => x.id_Student == Student_ID)

                .FirstOrDefault());
            _aplication_context.SaveChanges();

            return Ok(Student_ID);
        }
    }
}
