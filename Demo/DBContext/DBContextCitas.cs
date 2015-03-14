using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Demo.Entidades;

namespace Demo.DBContext
{
    public class DBContextCitas : DbContext
    {

        //"Server=.\SQLExpress;Initial Catalog=[NamesPace].[ContextClass];Integrated Security=true"
        public DBContextCitas():base("")
        {
            
        }

        public virtual DbSet<Cita> Citas { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<Servicio> Servicios { get; set; }
        public virtual DbSet<Actividad> Actividads { get; set; }
        public virtual DbSet<ServicioActividad> ServicioActividads { get; set; }
        public virtual DbSet<CitaServicio> CitaServicios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
