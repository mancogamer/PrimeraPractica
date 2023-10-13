using Microsoft.AspNetCore.Mvc;
using WebAplication.Context;
using WebAplication.Models;

namespace WebAplication.Controllers
{
    [ApiController]

    [Route("[controller]")]
    public class Teachers_Controller : ControllerBase
    {

        private readonly ILogger<Teachers_Controller> _logger;

        private readonly Aplication_Context _aplication_context;
        public Teachers_Controller(
            ILogger<Teachers_Controller> logger,


            Aplication_Context aplication_context)
        {
            _logger = logger;


            _aplication_context = aplication_context;

        }
        /*Crear*/
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Teacher teacher)
        {
            _aplication_context.teachers.Add(teacher);

            _aplication_context.SaveChanges();
            return Ok(teacher);

        }
        /*Obtener lista*/
        [Route("")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_aplication_context.teachers.ToList());

        }
        /*Modificar*/
        [Route("{id}")]

        [HttpPut]
        public IActionResult Put(
            [FromBody] Teacher teacher)
        {
            _aplication_context.teachers.Update(teacher);
            _aplication_context.SaveChanges();

            return Ok(teacher);
        }
        /*Eliminar*/
        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int Teacher_ID)
        {
            _aplication_context.teachers.Remove(
                _aplication_context.teachers.ToList()
                .Where(x => x.id_Teacher == Teacher_ID)

                .FirstOrDefault());
            _aplication_context.SaveChanges();

            return Ok(Teacher_ID);
        }
    }
}
