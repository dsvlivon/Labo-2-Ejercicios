using System;
using System.Collections.Generic;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Consola de pruebas de EjercicioI01 - Mi primer CRUD");

            Persona p = new Persona("jon", "doe", 3);
            Persona p2 = new Persona("jack", "doe", 1);

            //if (PersonaDAO.Guardar(p)) { Console.WriteLine($"Se guardo: { p.Nombre} { p.Apellido} "); }//Guardar OK
            //if (PersonaDAO.Guardar(p2)) { Console.WriteLine($"Se modifico: {p2.Nombre} {p2.Apellido}"); }//Guardar OK
            
            List<Persona> l = new List<Persona>();
            l = PersonaDAO.Leer();//Leer OK

            foreach (var item in l)
            {
                Console.WriteLine($"Nombre:{item.Nombre} Apellido: {item.Apellido}");
            }

            PersonaDAO.Borrar(14);//Borrar OK

            
            Persona x = PersonaDAO.LeerPorID(3);
            Console.WriteLine($"Leyendo a .... \nNombre:{x.Nombre} Apellido: {x.Apellido}");//LeerPorId OK

            x.Nombre = "jhon";
            if (PersonaDAO.Modifcar(x)) { Console.WriteLine($"Se modifico: {x.Nombre} {x.Apellido}"); } //Modificar OK
        }
    }
}
