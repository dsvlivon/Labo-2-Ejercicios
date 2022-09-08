using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public static class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero) {
            string resto = "";

            while ((numeroEntero >= 2))
            {
                resto = numeroEntero % 2 + resto;
                numeroEntero /= 2;
            }
            return resto;
        }

        static public int BinarioDecimal(string inputBinario)
        {
            char[] array = inputBinario.ToCharArray();
           
            Array.Reverse(array);//invierte los valores van incrementadose de derecha a izquierda
            int suma = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {
                    //Usamos la potencia de 2, segun la posicion
                    suma += (int)Math.Pow(2, i);
                }
            }
            return suma;
        }
    }
}
