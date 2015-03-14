using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entidades
{
    public class Actividad
    {
        [Key]
        public int Id { get; set; }
        [Required,MaxLength(120)]
        public string Nombre { get; set; }

        public virtual ICollection<ServicioActividad> ServicioActividads { get; set; }
    }
}
