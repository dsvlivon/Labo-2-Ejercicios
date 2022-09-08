using System;
using Entidades;

namespace Clase02_I04
{
    class Program
    {
        static void Main(string[] args)
        {
            string continuar = "SI";
            double numeroA;
            double numeroB;
            string operacion = "";
            string input;
            int forrometro = 0;

            string msg1 = "Ingrese el primer numero: ";
            string error = "Error!!! ";
            string msg2 = "Ingrese el segundo numero: ";
            do
            {
                Console.Clear();
                do
                {
                    if (forrometro == 0) { Console.Write(msg1); }
                    else if(forrometro > 5){ Console.Write("Al final Thanos tenia razon..."); return; }
                    else { Console.Write(error + msg1); }
                    input = Console.ReadLine(); 
                    forrometro++;
                } while (!Validador.ValidarEntero(input));
                
                numeroA = Convert.ToDouble(input);
                forrometro = 0;
                do
                {
                    if (forrometro == 0) { Console.Write(msg2); }
                    else if (forrometro > 10) { Console.Write("Al final Thanos tenia razon..."); return; }
                    else { Console.Write(error + msg2); }
                    input = Console.ReadLine(); 
                    forrometro++;
                } while (!Validador.ValidarEntero(input));
                                
                numeroB = Convert.ToDouble(input);
                forrometro = 0;
                Console.Write("Elija que operacion desea realiza(+ , - , / , * ): ");
                operacion = Console.ReadLine();

                switch (operacion)
                {
                    case "+":
                        Console.WriteLine("El resultado de la suma es {0}: ", Calculadora.Calcular(numeroA, numeroB, "+"));
                        break;
                    case "-":
                        Console.WriteLine("El resultado de la resta es {0}: ", Calculadora.Calcular(numeroA, numeroB, "-"));
                        break;
                    case "/":
                        Console.WriteLine("El resultado de la division es {0}: ", Calculadora.Calcular(numeroA, numeroB, "/"));
                        break;
                    case "*":
                        Console.WriteLine("El resultado de la multiplicacion es {0}: ", Calculadora.Calcular(numeroA, numeroB, "*"));
                        break;
                    default:
                        Console.WriteLine("La opcion ingresada es incorrecta");
                        break;
                }
                Console.WriteLine("Desea Continuar Y/N: ");
                continuar = Console.ReadLine();
            } while (continuar == "Y" || continuar == "y");
        }
    }
}
