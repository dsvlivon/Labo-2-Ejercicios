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
        private static Random random;
        //Tendrá un constructor estático que inicializará el atributo estático random.
        static Estudiante()
        {
            Estudiante.random = new Random();
        }
        //Tendrá un constructor de instancia que inicializará los atributos nombre, apellido y legajo.
        public Estudiante(string a, string l, string n)
        {
            this.apellido = a;
            this.legajo = l;
            this.nombre =n;
        }
        public int NotaPrimerParcial { get; set; }
        public int NotaSegundoParcial { get; set; }
        //El método CalcularNotaFinal deberá retornar la nota del final con un numero aleatorio entre 6 y 10 incluidos siempre y cuando las notas del primer y segundo parcial sean mayores o iguales a 4, caso contrario la inicializará con el valor -1.
        public double CalcularNotaFinal()
        {
            if (this.NotaPrimerParcial >= 4 && this.NotaSegundoParcial >= 4)
            {
                return (random.Next(6, 10));
            }
            return -1;
        }

        //El método setter SetNotaPrimerParcial permitirá cambiar el valor del atributo notaPrimerParcial.
        public void SetNotaPrimerParcial(int value) { this.NotaPrimerParcial = value; }

        //El método setter SetNotaSegundoParcial permitirá cambiar el valor del atributo notaSegundoParcial.
        public void SetNotaSegundoParcial(int value) { this.NotaSegundoParcial = value; }

        //El método privado CalcularPromedio retornará el promedio de las dos notas.
        public float CalcularPromedio() { return (this.NotaPrimerParcial + this.NotaSegundoParcial) / 2; }

        //El método Mostrar utilizará StringBuilder para armar una cadena de texto con todos los datos de los alumnos:
        //Nombre, apellido y legajo.
        //Nota del primer y segundo parcial.
        //Promedio.
        //Nota final. Se mostrará sólo si el valor es distinto de -1, caso contrario se mostrará la leyenda "Alumno desaprobado".
        public string Mostar()
        {
            int nota = (int)this.CalcularNotaFinal();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("datos de los alumnos: ");
            sb.AppendLine($"nombre: {this.nombre}");
            sb.AppendLine($"apellido: {this.apellido}");
            sb.AppendLine($"nota 1er parcial: {this.NotaPrimerParcial}");
            sb.AppendLine($"nota 2do parcial: {this.NotaSegundoParcial}");
            sb.AppendLine($"promedio: {this.CalcularPromedio()}");
            if (nota != -1)
            {
                sb.AppendLine($"nota final: {nota}");
            } else { sb.AppendLine("Alumno desaprobado"); }

            return sb.ToString();
        }        
    }
}
