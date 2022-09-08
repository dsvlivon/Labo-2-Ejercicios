using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public static class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;
        
        public static string Imprimir()
        {
            return Sello.ArmarFormatoMensaje();
        }

        public static void Borrar()
        {
            Sello.mensaje = "";
        }

        public static void ImprimirEnColor()
        {
            Console.WriteLine(Sello.Imprimir());
        }
        //parte 3
        private static string ArmarFormatoMensaje()
        {
            //StringBuilder sb = new StringBuilder();
            if(Sello.mensaje == "" || Sello.mensaje == null)
            {
                return Sello.mensaje;
            } else {
                string asteriscos = null;
                for (int i = 0; i < Sello.mensaje.Length+2; i++)
                {
                    asteriscos = asteriscos + "*";
                }
                return asteriscos + "\n" + "*" + Sello.mensaje + "*\n" + asteriscos;
            }
        }
    }
}

