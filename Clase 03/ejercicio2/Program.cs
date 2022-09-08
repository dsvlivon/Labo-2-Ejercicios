using System;
using Entidades;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(1988, 3, 10);
            Console.WriteLine("Hello World!");
            Persona p = new Entidades.Persona();
            p.Dni = 12243242;
            p.Nombre = "daniel";
            p.Fecha = date;

            Console.WriteLine(p.Mostrar());

        }
    }
}
