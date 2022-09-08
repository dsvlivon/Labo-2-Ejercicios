using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public static class Validador
    {
        public static bool ValidarEntero(string valor)
        {
            int valorSalida;
            if (int.TryParse(valor, out valorSalida))
            {
                return true;
            }
            return false;
        }
        public static bool ValidarRespuesta(string respuesta)
        {
            if (respuesta == "Y" || respuesta == "y")
            {
                return true;
            }
            return false;
        }

        public static bool ValidarValorEntreRangos(int valor, int min, int max)
        {
            if (valor >= min && valor <= max) { return true; }
            return false;
        }
    }
}
