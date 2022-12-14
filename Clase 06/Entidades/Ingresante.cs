using System;
using System.Text;

namespace Entidades
{
    public class Ingresante
    {
        private string[] cursos;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;

        public Ingresante(string n, string d, string g, string p, string[] c, int e)
        {
            this.nombre = n; this.direccion = d; this.genero = g;this.pais = p; this.cursos = c; this.edad = e;
        }

        public string Mostrar()
        {
            StringBuilder s = new StringBuilder();
            s.AppendLine($"nombre: {this.nombre}");
            s.AppendLine($"edad: {this.edad}");
            s.AppendLine($"direccion: {this.direccion}");
            s.AppendLine($"genero: {this.genero}");
            s.AppendLine($"pais: {this.pais}");
            s.AppendLine("curso/s: ");
            for (int i = 0; i < 2; i++)
            {
                s.Append(this.cursos[i]+" ");
            }
            return s.ToString();
        }
    }
}
