using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public static class Calculadora
    {
        public static double Calcular(double numeroA, double numeroB, string operacion)
        {
            double resultado = 0;
            if (operacion == "+")
            {
                resultado = numeroA + numeroB;
            }
            if (operacion == "-")
            {
                resultado = numeroA - numeroB;
            }
            if (operacion == "/")
            {
                if (Validar(numeroB))
                {
                    resultado = numeroA / numeroB;
                }
                else
                {
                    Console.WriteLine("No se puede dividir por 0");
                }
            }
            if (operacion == "*")
            {
                resultado = numeroA * numeroB;
            }

            return resultado;
        }

        private static bool Validar(double numeroB)
        {
            if (numeroB != 0)
            {
                return true;
            }
            return false;

        }
    }
}
