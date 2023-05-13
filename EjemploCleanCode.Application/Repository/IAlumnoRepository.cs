using EjemploCleanCode.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCleanCode.Application.Repository
{
    public interface IAlumnoRepository
    {
        List<Alumno> GetAllAlumnos();
    }
}
