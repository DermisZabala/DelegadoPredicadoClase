using System;
using System.Collections.Generic;

namespace DelegadoPredicadoClase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Personas> AlmacenPersonas = new List<Personas> ();

            Personas p1 = new Personas ();
            Personas p2 = new Personas ();
            Personas p3 = new Personas ();
            Personas p4 = new Personas ();
            Personas p5 = new Personas ();
            Personas p6 = new Personas ();
            Personas p7 = new Personas ();

            AlmacenPersonas.AddRange(new Personas[] { p1, p2, p3, p4, p5, p6, p7});

            p1.Nombre = "Hamel";
            p1.Edad = 18;
            p2.Nombre = "Alex";
            p2.Edad = 25;
            p3.Nombre = "Harley";
            p3.Edad = 20;
            p4.Nombre = "Miguel";
            p4.Edad = 18;
            p5.Nombre = "Ana";
            p5.Edad = 26;
            p6.Nombre = "Manuel";
            p6.Edad = 29;
            p7.Nombre = "Hidalgo";
            p7.Edad = 18;


            Predicate<Personas> ElPredicado = new Predicate<Personas>(ExistePersona);

            bool PersonasDis = AlmacenPersonas.Exists(ElPredicado);

            if(PersonasDis)
                Console.WriteLine("Si existen personas con esa edad");
            else
                Console.WriteLine("No existen personas con esa edad");

            List<Personas> PersonasExistentes = AlmacenPersonas.FindAll(ElPredicado);

            Console.WriteLine();
            Console.WriteLine("Personas encontradas:");
            foreach (Personas elementos in PersonasExistentes)
            {
                Console.WriteLine(elementos.Nombre + " " + elementos.Edad);
            }
        }

        static bool ExistePersona(Personas persona)
        {
            if(persona.Edad == 18)
                return true;
            else
                return false;
        }
    }

    class Personas
    {
        private int edad;
        private string nombre;

        public int Edad { get => edad; set => edad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
