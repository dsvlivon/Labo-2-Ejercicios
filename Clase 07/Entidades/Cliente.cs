using System;

namespace Entidades
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public Cliente() { }
        public Cliente(int n, string b)
        {
            this.numero = n; this.nombre = b;
        }

        public int Numero { get; }
        public string Nombre { get; set; }

        public static bool operator ==(Cliente a, Cliente b)
        {
            if (a.numero == b.numero)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Cliente a, Cliente b)
        {
            return !(a == b);
        }
    }
}
