using System;
using System.Data.Entity;
using System.Linq;
using Demo.DBContext;
using Demo.Entidades;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create
            Persona persona = new Persona()
            {
                ApMaterno = "Juárez",
                ApPaterno = "Pimentel",
                Nombre = "José Saturnino",
                Sexo = "H"
            };


            //Register

            using (var contexto = new DBContextCitas())
            {
                contexto.Personas.Add(persona);
                contexto.SaveChanges();

                Console.WriteLine("Se ha registrado con éxito.");
                Console.ReadLine();

            }

            //Update
            using (var contexto = new DBContextCitas())
            {

                //Búsqueda
                var personaResultado =
                    contexto.Personas.FirstOrDefault(
                        pre => pre.ApPaterno.Equals("Pimentel") && pre.Nombre.Equals("José Saturnino"));

                if (personaResultado != null)
                {
                    Persona personaEditada = new Persona()
                    {
                        ApMaterno = "Juárez",
                        ApPaterno = "Martínez",
                        Nombre = "José Saturnino",
                        Sexo = "H"
                    };

                    personaResultado.ApMaterno = personaEditada.ApMaterno;
                    personaResultado.ApPaterno = personaEditada.ApPaterno;
                    personaResultado.Nombre = personaEditada.Nombre;
                    personaResultado.Sexo = personaEditada.Sexo;

                    contexto.SaveChanges();
                    Console.WriteLine("Se ha actualizado con éxito.");
                    Console.ReadLine();

                }

            }

            //Delete
            using (var contexto = new DBContextCitas())
            {

                //Búsqueda
                var personaResultado =
                    contexto.Personas.FirstOrDefault(
                        pre => pre.ApPaterno.Equals("Pimentel") && pre.Nombre.Equals("José Saturnino"));

                if (personaResultado != null)
                {
                    contexto.Personas.Remove(personaResultado);
                    contexto.SaveChanges();
                    Console.WriteLine("Se ha eliminado con éxito.");
                    Console.ReadLine();
                }
            }


        }
    }
}