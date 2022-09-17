using System;
using System.Collections.Generic;
using Entidades;

namespace ejercicio_C01
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador j1 = new Jugador(112223333, "nico", 12, 24);
            Jugador j2 = new Jugador(112223334, "mati", 1, 10);
            Jugador j3 = new Jugador(112223335, "dani", 4, 4);
            Jugador j4 = new Jugador(112223336, "coco");
            Jugador j5 = new Jugador(112223337, "marco");

            Equipo equipo = new Equipo(4, "Operations");
           
            string msg;
            msg = equipo + j1 ? $"Se agregó a {j1.Nombre}" : "Error! no se puede agregar jugador";
            Console.WriteLine(msg);
            msg = equipo + j2 ? $"Se agregó a {j2.Nombre}" : "Error! no se puede agregar jugador";
            Console.WriteLine(msg);
            msg = equipo + j3 ? $"Se agregó a {j3.Nombre}" : "Error! no se puede agregar jugador";
            Console.WriteLine(msg);
            msg = equipo + j4 ? $"Se agregó a {j4.Nombre}" : "Error! no se puede agregar jugador";
            Console.WriteLine(msg);
            msg = equipo + j5 ? $"Se agregó a {j5.Nombre}" : "Error! no se puede agregar jugador";
            Console.WriteLine(msg);

            foreach (var item in equipo.Jugadores)
            {
                Console.WriteLine(item.MostrarDatos());
            }
            Console.ReadLine();
        }
    }
}
