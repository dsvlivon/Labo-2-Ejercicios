using System;
using Entidades;

namespace Clase02_EjercicioDeClase
{
    class Program
    {
        static void Main(string[] args)
        {
            //parte 1
            Sello.mensaje = "hola mundo";

            Console.WriteLine(Sello.Imprimir());
            Sello.Borrar();
            Console.WriteLine(Sello.Imprimir());

            //parte 2
            Sello.mensaje = "hola mundo C#";
            
            Sello.color = ConsoleColor.Red;

            Console.ForegroundColor = Sello.color;
            Sello.ImprimirEnColor();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(Sello.Imprimir());



        }
    }
}
