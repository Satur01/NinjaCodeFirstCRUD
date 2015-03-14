using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entidades
{
    public class CitaServicio
    {
        [Key]
        public int Id { get; set; }
        [Key]
        public Guid IdCita { get; set; }
        [Key]
        public int IdServicio { get; set; }

        public virtual Cita CITA { get; set; }
        public virtual Servicio SERVICIO { get; set; }
    }
}
