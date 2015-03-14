using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Demo.Entidades
{
    public class Persona
    {
        [Key]
        public Guid Id { get; set; }
        [Required, MaxLength(45)]
        public string Nombre { get; set; }
        [Required,MaxLength(45)]
        public string ApPaterno { get; set; }
        [Required, MaxLength(45)]
        public string ApMaterno { get; set; }
        [MaxLength(1)]
        public string Sexo { get; set; }
        public virtual ICollection<Cita> Citas { get; set; }
    }
}
