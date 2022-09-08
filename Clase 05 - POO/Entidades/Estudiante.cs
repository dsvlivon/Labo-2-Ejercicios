using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random rand;

        static Estudiante()
        {
            rand = new Random();
        }

        public double CalcularNotaFinal()
        {
            if(this.notaPrimerParcial >= 4 & this.notaSegundoParcial >= 4)
            {
                return rand.Next(6, 10);
            } return -1;
        }
        private double CalcularPromedio()
        { 
            return (this.notaPrimerParcial + this.notaSegundoParcial) / 2;
        }
        public Estudiante(string n, string a, string l)
        {
            this.nombre = n; this.nombre = a;this.legajo = l;
        }

        public string Nombre{ get { return this.nombre;} }
        public string Apellido { get { return this.apellido; } }
        public string Legajo { get { return this.legajo; } }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"nombre: {this.Nombre}");
            sb.AppendLine($"Apellido: {this.Apellido}");
            sb.AppendLine($"Legajo: {this.Legajo}");
            sb.AppendLine($"nota 1: {this.notaPrimerParcial}");
            sb.AppendLine($"nota 2: {this.notaSegundoParcial}");
            sb.AppendLine($"promedio: {this.CalcularPromedio()}");
            sb.AppendLine($"nota final: {this.CalcularNotaFinal()}");

            return sb.ToString();
        }
        public void SetNotaPrimerParcial(int nota)
        {
            if (nota != null && nota >= 0) {
                this.notaPrimerParcial = nota;
            }
        }
        public void SetNotaSegundoParcial(int nota)
        {
            if (nota != null && nota >= 0)
            {
                this.notaSegundoParcial = nota;
            }
        }
    }
}
