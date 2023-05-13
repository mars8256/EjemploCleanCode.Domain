using EjemploCleanCode.Application.Service;
using EjemploCleanCode.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EjemploCleanCode.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnosController : ControllerBase
    {
        private readonly IAlumnoService _alumnoService;

        public AlumnosController(IAlumnoService alumnoService)
        {
            _alumnoService = alumnoService;
        }

        [HttpGet]
        public ActionResult<IList<Alumno>> Get() 
        {
            return Ok(_alumnoService.GetAllAlumnos());
        }
    }
}
