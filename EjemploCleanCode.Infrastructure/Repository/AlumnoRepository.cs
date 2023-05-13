using EjemploCleanCode.Application.Repository;
using EjemploCleanCode.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCleanCode.Infrastructure.Repository
{
    public class AlumnoRepository : IAlumnoRepository
    {

        public static List<Alumno> alumnos = new List<Alumno>()
        {
           new Alumno { Id = 1, Nombre = "Marcos", Apellidos = "Orozco", Direccion = "Escuintla"},
            new Alumno { Id = 1, Nombre = "Marcos", Apellidos = "Orozco", Direccion = "Escuintla"},
             new Alumno { Id = 1, Nombre = "Marcos", Apellidos = "Orozco", Direccion = "Escuintla"},
              new Alumno { Id = 1, Nombre = "Marcos", Apellidos = "Orozco", Direccion = "Escuintla"},
               new Alumno { Id = 1, Nombre = "Marcos", Apellidos = "Orozco", Direccion = "Escuintla"},
        };

        public List<Alumno> GetAllAlumnos()
        {
            return alumnos;
        }
    }
}
