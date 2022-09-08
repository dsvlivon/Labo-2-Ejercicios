using System;
using Entidades;

namespace Clase_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Cuenta c = new Cuenta("daniel", 10);
            c.Ingresar(50);
            Console.WriteLine(c.Mostrar());
            c.Retirar(45);
            Console.WriteLine(c.Mostrar());
            Console.ReadLine();
        }
    }
}
