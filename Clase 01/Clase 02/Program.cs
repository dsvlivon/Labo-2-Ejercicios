using System;

namespace Ejercicio_I02
{
    class Program
    {
        /*Ingresar un número y mostrar el cuadrado y el cubo del mismo. 
         * Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".*/
        static void Main(string[] args)
        {
            int value;
            string input;
            double doubleValue;

            Console.Write("Ingrese un numero mayor a cero: ");
            input = Console.ReadLine();
            int.TryParse(input, out value);

            while (value <= 0)
            {
                Console.Write("Error! El numero ingresado debe ser mayor a cero: ");
                input = Console.ReadLine();
                Int32.TryParse(input, out value);
            }
            doubleValue = value;
            Console.WriteLine("El cuadrado del numero ingresado es : {0}", Math.Pow(doubleValue, 2));
            Console.WriteLine("El cuadrado del numero ingresado es : {0}", Math.Pow(doubleValue, 3));
            Console.ReadKey();
        }
    }
}
