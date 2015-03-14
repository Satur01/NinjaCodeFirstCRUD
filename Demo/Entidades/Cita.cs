using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entidades
{
    public class Cita
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        public TimeSpan HoraInicio { get; set; }
        [Required]
        public TimeSpan HoraFin { get; set; }
        [Required]
        public Guid IdPersona { get; set; }        
        public virtual Persona PERSONA { get; set; }

        public virtual ICollection<CitaServicio> CitaServicios { get; set; }
    }
}
