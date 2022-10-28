using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(short c, string n)
        {
            this.nombre = n; this.cantidadDeJugadores = c;
        }

        public static bool operator + (Equipo e, Jugador j)
        {
            bool x = true ;
            foreach (var item in e.jugadores)
            {
                if (item == j) { x = true; }
                x = false;
            }
            if (x==false) { e.jugadores.Add(j); }
            return x;
        }
    }
}
