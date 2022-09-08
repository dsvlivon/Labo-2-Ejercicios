using System;
using Entidades;

namespace clase02_I02
{
    class Program
    {
        /*Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje "¿Desea continuar? (S/N)".
        Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.
        El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.*/
        static void Main(string[] args)
        {
            string input;
            char answer;
            string inputChar;            

            do
            {
                do
                {
                    Console.Write("ingrese un numero: ");
                    input = Console.ReadLine();
                } while (!Validador.ValidarEntero(input));
                Console.Write("Desea ingresar otro numero(S/N): ");
                inputChar = Console.ReadLine();
                char.TryParse(inputChar, out answer);
            } while (Validador.ValidarRespuesta(answer.ToString()));
            Console.Write("Gracias...");
        }
    }
}
