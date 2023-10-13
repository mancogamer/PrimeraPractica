using Microsoft.AspNetCore.Mvc;
using WebApplication2.Context;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstudianteController : ControllerBase
    {

        private readonly ILogger<EstudianteController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public EstudianteController(
            ILogger<EstudianteController> logger, 
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear estudiantes
        [HttpPost(Name = "GetEstudiante")]
        public IActionResult Post(
            [FromBody] Estudiante estudiante)
        {
            _aplicacionContexto.Estudiante.Add(estudiante);
            _aplicacionContexto.SaveChanges();
            return Ok(estudiante);
        }
        //READ: Obtener lista de estudiantes
        [HttpGet(Name = "GetEstudiante")]
        public IActionResult Get()
        {
            return Ok(_aplicacionContexto.Estudiante.ToList());

        }
        //Update: Modificar estudiantes
        [HttpPut(Name = "GetEstudiante")]
        public IActionResult Put(
            [FromBody] Estudiante estudiante)
        {
            _aplicacionContexto.Estudiante.Update(estudiante);
            _aplicacionContexto.SaveChanges();
            return Ok(estudiante);
        }
        //Delete: Eliminar estudiantes
        [HttpDelete(Name = "GetEstudiante")]
        public IActionResult Delete(int estudianteId)
        {
            _aplicacionContexto.Estudiante.Remove(
                _aplicacionContexto.Estudiante.ToList()
                .Where(x => x.idEstudiante == estudianteId)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(estudianteId);
        }
    }
}