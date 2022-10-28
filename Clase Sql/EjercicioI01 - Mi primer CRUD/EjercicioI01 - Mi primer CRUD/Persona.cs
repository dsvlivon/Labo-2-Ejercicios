using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int id;
        private Random r;

        public Persona(string nombre, string apellido, int id):this(nombre, apellido)
        {
            ID = id;
        }
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            r = new Random();
            this.ID = r.Next(10000, 99999);
        }

        public int ID { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public static bool operator == (Persona p1, Persona p2)
        {
            if(p2.Apellido == p2.Apellido) 
            { return true; } return false;
        }
        public static bool operator !=(Persona p1, Persona p2) { return !(p1 == p2); }
        public static bool operator ==(List<Persona> l, Persona p2)
        {
            foreach (var item in l)
            {
                if (p2 == item)
                { return true; }
            }
            return false;
        }
        public static bool operator !=(List<Persona> l, Persona p2)
        {
            return !(l ==p2);
        }
    }
}
