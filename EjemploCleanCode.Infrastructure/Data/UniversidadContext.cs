using EjemploCleanCode.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCleanCode.Infrastructure.Data
{
    public class UniversidadContext : DbContext
    {
        public UniversidadContext(DbContextOptions<UniversidadContext> options) : base(options) 
        { 
        
        }

        public DbSet<Facultad> facultad { get; set; }
        public DbSet<Docente> docente { get; set; }
    }
}
