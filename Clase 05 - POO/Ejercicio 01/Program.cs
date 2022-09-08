using System;using Entidades;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta c = new Cuenta("Daniel", 10000);
            Console.WriteLine(c.Mostrar());
            c.Ingresar(2000);
            Console.WriteLine(c.Mostrar());
            c.Retirar(500);
            Console.WriteLine(c.Mostrar());

            Console.ReadLine();
        }
    }
}
