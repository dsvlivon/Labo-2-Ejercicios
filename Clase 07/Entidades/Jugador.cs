using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        public string Nombre  { get; }//lo Agregue p mostrar el msg
        private Jugador()
        {
            this.promedioGoles = 0;
            //???cual mas
        }

        public Jugador(int d, string n, int goles, int partidos):this()
        {
            this.dni = d; this.nombre = n; this.totalGoles = goles; this.partidosJugados = partidos;
        }
        public Jugador(int d, string n) : this()
        {
            this.dni = d; this.nombre = n;
        }

        public string MostrarDatos()
        {
            StringBuilder s = new StringBuilder();
            this.promedioGoles= this.GetPromedioGoles();
            s.AppendLine($"nombre: {this.nombre}");
            s.AppendLine($"dni: {this.dni}");
            s.AppendLine($"p.jugados: {this.partidosJugados}");
            s.AppendLine($"t.goles: {this.totalGoles}");
            s.AppendLine($"promedio: {this.promedioGoles}");

            return s.ToString();
        }

        public static bool operator ==(Jugador a, Jugador b)
        {
            if (a.dni == b.dni) { return true; }
            return false;
        }

        public static bool operator !=(Jugador a, Jugador b)
        {
            return !(a == b);
        }

        public float GetPromedioGoles()
        {
            if (this.partidosJugados > 0)
            {
                int a = this.totalGoles;
                int b = this.partidosJugados;
                int v = a / b;
                float x = v;
                return x;
            } else { return 0; }
        }
    }
}
