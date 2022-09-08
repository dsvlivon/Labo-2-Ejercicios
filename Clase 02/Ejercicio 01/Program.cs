using System;
using Entidades;

namespace clase02_I01
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int valor;
            int acumulador = 0;
            int contador = 0;
            int max = int.MinValue;
            int min = int.MaxValue;
            string input;
            float promedio;

            for (int i = 0; i < 3; i++)
            {
                Console.Write("ingrese un numero: ", i);
                input = Console.ReadLine();

                while (!int.TryParse(input, out valor))
                {
                    Console.Write("ingrese un numero: ", i);
                    input = Console.ReadLine();
                }
                if(Validador.ValidarValorEntreRangos(valor, -100, 100))
                {
                    if ((valor > max) || i == 0)
                    {
                        max = valor;
                    }
                    if ((valor < min || i == 0))
                    {
                        min = valor;
                    }
                    contador++;
                    acumulador += valor;
                } else { 
                    Console.WriteLine("Numero fuera de rango!");
                    i--;
                }
            }
            Console.Clear();
            Console.WriteLine("El numero maximo es: {0} ", max);
            Console.WriteLine("El numero minimo es: {0} ", min);
            promedio = acumulador / contador;
            Console.WriteLine("El numero promedio es: {0:#.##}", promedio);
            Console.ReadKey();
        }
    }
}
