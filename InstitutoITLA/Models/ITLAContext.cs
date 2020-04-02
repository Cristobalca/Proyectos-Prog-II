using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstitutoITLA.Models
{
    public class ITLAContext  : DbContext
    {
        public ITLAContext(DbContextOptions<ITLAContext> options) : base(options) { }

        public DbSet<Estudiantes> Estudiantes { get; set; }
        public DbSet<Profesores> Profesores { get; set; }
        public DbSet<Asignaturas> Asignaturas { get; set; }
        public DbSet<AsignaturasMaestros> AsignaturasMaestros { get; set; }
        public DbSet<AsignaturasEstudiantes> AsignaturasEstudiantes { get; set; }
    }
}
