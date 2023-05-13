using EjemploCleanCode.Application.Repository;
using EjemploCleanCode.Application.Service;
using EjemploCleanCode.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCleanCode.Application.ServiceImpl
{
    public class AlumnoServiceImpl : IAlumnoService
    {
        private readonly IAlumnoRepository _alumnoRepository;

        public AlumnoServiceImpl(IAlumnoRepository alumnoRepository)
        {
            _alumnoRepository = alumnoRepository;
        }

        public List<Alumno> GetAllAlumnos()
        {
            return _alumnoRepository.GetAllAlumnos();
        }
    }
}
