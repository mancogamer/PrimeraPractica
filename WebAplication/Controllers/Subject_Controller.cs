using Microsoft.AspNetCore.Mvc;
using WebAplication.Context;
using WebAplication.Models;

namespace WebAplication.Controllers
{
    [ApiController]

    [Route("[controller]")]
    public class Subject_Controller : ControllerBase
    {

        private readonly ILogger<Subject_Controller> _logger;

        private readonly Aplication_Context _aplication_context;
        public Subject_Controller(
            ILogger<Subject_Controller> logger,


            Aplication_Context aplication_context)
        {
            _logger = logger;


            _aplication_context = aplication_context;

        }
        /*Crear*/
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Subject subject)
        {
            _aplication_context.subjects.Add(subject);

            _aplication_context.SaveChanges();
            return Ok(subject);

        }
        /*Obtener lista*/
        [Route("")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_aplication_context.subjects.ToList());

        }
        /*Modificar*/
        [Route("{id}")]

        [HttpPut]
        public IActionResult Put(
            [FromBody] Subject subject)
        {
            _aplication_context.subjects.Update(subject);
            _aplication_context.SaveChanges();

            return Ok(subject);
        }
        /*Eliminar*/
        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int Subject_ID)
        {
            _aplication_context.subjects.Remove(
                _aplication_context.subjects.ToList()
                .Where(x => x.id_Subject == Subject_ID)

                .FirstOrDefault());
            _aplication_context.SaveChanges();

            return Ok(Subject_ID);
        }
    }
}
