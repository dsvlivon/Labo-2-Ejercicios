using System;using Entidades;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante e1 = new Estudiante("jon", "doe","l001");
            Estudiante e2 = new Estudiante("jim", "doe","l002");
            Estudiante e3 = new Estudiante("jay", "doe","l003");

            e1.SetNotaPrimerParcial(6);
            e1.SetNotaSegundoParcial(9);
            e2.SetNotaPrimerParcial(7);
            e2.SetNotaSegundoParcial(7);
            e3.SetNotaPrimerParcial(2);
            e3.SetNotaSegundoParcial(2);

            Console.WriteLine(e1.Mostrar());
            Console.WriteLine(e2.Mostrar());
            Console.WriteLine(e3.Mostrar());

            Console.ReadLine();
        }
    }
}
