using EjemploCleanCode.Application.Repository;
using EjemploCleanCode.Domain.Entities;
using EjemploCleanCode.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCleanCode.Infrastructure.Repository
{
    public class DocenteRepository : IDocenteRepository
    {
        private readonly UniversidadContext _context;

        public DocenteRepository(UniversidadContext context)
        {
            _context = context;
        }

        public static List<Docente> docentes = new List<Docente>()
        {
            new Docente { Id = 1, Nombre = "Marcos", Activo = true },
            new Docente { Id = 2, Nombre = "Enio", Activo = false }
        };

        public List<Docente> GetAllDocentes()
        {
            //return docentes;
            return _context.docente.ToList();
        }

       
    }
}
