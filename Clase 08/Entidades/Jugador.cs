using System;

namespace Entidades
{
    public class Jugador: Persona
    {
        private int partidosJugados;
        private int totalGoles;

        public int Partidos{ get; set; }
        public int Goles{ get; set; }
        public float PromedioGoles { get {
                return this.Goles / this.Partidos;
            } 
        }
        public Jugador(int d, string n):base(d, n)
        {

        }

        public Jugador(int d, string n, int g, int p):this(d,n)
        {
            this.Goles = g; this.Partidos = p;
        }

        public override string MostrarDatos()
        {
            return base.MostrarDatos() + $"T.partidos: {this.Partidos}\nT.goles: {this.Goles}\npromedio: {this.PromedioGoles}";
        }

        public static bool operator ==(Jugador a, Jugador b)
        {
            if(a.Nombre==b.Nombre & a.Dni == b.Dni) { return true; }
            return false;
        }

        public static bool operator !=(Jugador a, Jugador b) { return !(a == b); }
    }
}
