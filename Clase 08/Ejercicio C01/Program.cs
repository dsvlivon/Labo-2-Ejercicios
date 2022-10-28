using System;using Entidades;

namespace Ejercicio_C01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Equipo p = new Equipo(3, "AFA");

            Jugador j1 = new Jugador(12123123 ,"a1");
            Jugador j2 = new Jugador(12123124, "a2");
            Jugador j3 = new Jugador(12123122, "a3");

            p + j1;
            p + j2;
            p + j3;
        }
    }//fecha de entrega y defensa 6 de octubre
}
