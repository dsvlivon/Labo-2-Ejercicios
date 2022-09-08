using System;

namespace Ejercicio_I04
{
    class Program
    {
        /*Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos (excluido el mismo) que son divisores del número.
        El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
        Escribir una aplicación que encuentre los 4 primeros números perfectos.*/
        static void Main(string[] args)
        {
            int buffer = 0;
            int cont = 0;
            int value = 1;

            do
            {
                for (int i = 0; i < value; i++)
                {
                    for (int j = value - 1; j > 0; j--)
                    {
                        if ((value % j) == 0)
                        {
                            buffer += j;
                            //cont++;
                        }
                        else
                            Console.WriteLine("no... ");
                    }
                    if (buffer == value)
                    {
                        cont++;
                        Console.WriteLine("Los primeros cuatro numeros perfectos son: {0}", i);
                    }
                }
                value++;
            } while (cont == 3);
            Console.ReadLine();
        }
    }
}
