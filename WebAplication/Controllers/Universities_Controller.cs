using Microsoft.AspNetCore.Mvc;
using WebAplication.Context;
using WebAplication.Models;

namespace WebAplication.Controllers
{
    [ApiController]

    [Route("[controller]")]
    public class Universities_Controller : ControllerBase
    {

        private readonly ILogger<Universities_Controller> _logger;

        private readonly Aplication_Context _aplication_context;
        public Universities_Controller(
            ILogger<Universities_Controller> logger,


            Aplication_Context aplication_context)
        {
            _logger = logger;


            _aplication_context = aplication_context;

        }
        /*Crear*/
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] University university)
        {
            _aplication_context.universities.Add(university);

            _aplication_context.SaveChanges();
            return Ok(university);

        }
        /*Obtener lista*/
        [Route("")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_aplication_context.universities.ToList());

        }
        /*Modificar*/
        [Route("{id}")]

        [HttpPut]
        public IActionResult Put(
            [FromBody] University university)
        {
            _aplication_context.universities.Update(university);
            _aplication_context.SaveChanges();

            return Ok(university);
        }
        /*Eliminar*/
        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int University_ID)
        {
            _aplication_context.universities.Remove(
                _aplication_context.universities.ToList()
                .Where(x => x.id_University == University_ID)

                .FirstOrDefault());
            _aplication_context.SaveChanges();

            return Ok(University_ID);
        }
    }
}
