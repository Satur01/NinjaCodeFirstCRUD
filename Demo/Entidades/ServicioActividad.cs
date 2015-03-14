using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entidades
{
    public class ServicioActividad
    {
        [Key]
        public int Id { get; set; }
        [Key]
        public int IdServicio { get; set; }
        [Key]
        public int IdActividad { get; set; }

        public virtual Servicio SERVICIO { get; set; }
        public virtual Actividad ACTIVIDAD { get; set; }
    }
}
