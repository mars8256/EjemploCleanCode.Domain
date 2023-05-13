using EjemploCleanCode.Application.Service;
using EjemploCleanCode.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EjemploCleanCode.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocentesController : ControllerBase
    {
        private readonly IDocenteService _docenteService;

        public DocentesController(IDocenteService docenteService)
        {
            _docenteService = docenteService;
        }

        [HttpGet]
        public ActionResult<IList<Docente>> Get()
        {
            return Ok(_docenteService.GetAllDocentes());
        }
    }
}
