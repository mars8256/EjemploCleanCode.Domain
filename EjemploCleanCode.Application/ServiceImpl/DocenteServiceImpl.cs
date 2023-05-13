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
    public class DocenteServiceImpl : IDocenteService
    {
        private readonly IDocenteRepository _docenteRepository;

        public DocenteServiceImpl(IDocenteRepository docenteRepository)
        {
            _docenteRepository = docenteRepository;
        }

        public List<Docente> GetAllDocentes()
        {
            return _docenteRepository.GetAllDocentes();
        }

        public bool isActivo(int id)
        {
            var docente = _docenteRepository.GetAllDocentes()
                .Where(d => d.Id == id)
                .FirstOrDefault();

            if (docente == null)
                throw new Exception("Recurso no encontrado");

            return docente.Activo;
        }
    }
}
