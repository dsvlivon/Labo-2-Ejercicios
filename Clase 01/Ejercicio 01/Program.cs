using System;

namespace Ejercicio_I01
{
    /*Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.*/
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            int acumulator = 0;
            int counter = 0;
            int max = int.MinValue;
            int min = int.MaxValue;
            string input;
            float average;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("ingrese un numero: ", i);
                input = Console.ReadLine();

                while (!int.TryParse(input, out value))
                {
                    Console.Write("ingrese un numero: ", i);
                    input = Console.ReadLine();
                }
                if ((value > max) || i == 0)
                {
                    max = value;
                }
                if ((value < min || i == 0))
                {
                    min = value;
                }
                counter++;
                acumulator += value;
            }
            Console.Clear();
            Console.WriteLine("El numero maximo es: {0} ", max);
            Console.WriteLine("El numero minimo es: {0} ", min);
            average = acumulator / counter;
            Console.WriteLine("El numero promedio es: {0:#.##}", average);
            Console.ReadKey();

        }
    }
}
