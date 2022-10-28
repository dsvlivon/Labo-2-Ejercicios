using System;

namespace Entidades
{
    public class Persona
    {
        private long dni;
        private string nombre;

        public long Dni { get; set; }
        public string Nombre { get; set; }

        public virtual string MostrarDatos()
        {
            return $"nombre: {this.Nombre}\ndni: {this.Dni}";
        }

        public Persona(long d, string n): this(n)
        {
            this.Dni = d;
        }
        public Persona(string n)
        {
            this.Nombre = n;
        }
    }
}
