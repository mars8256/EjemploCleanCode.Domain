using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCleanCode.Domain.Entities
{
    public class Docente
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public bool Activo { get; set; }
    }
}
