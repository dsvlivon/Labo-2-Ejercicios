using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Equipo
    {
        private short cantidadDEJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        public Equipo(short c, string n):this()
        {
            this.cantidadDEJugadores = c; this.nombre = n;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            if(e.jugadores.Count < e.cantidadDEJugadores)
            {
                if(e!=j)
                {
                    e.jugadores.Add(j); return true;
                }
            }
            return false;
        }

        public static bool operator ==(Equipo e, Jugador j)
        {
            foreach (var i in e.jugadores)
            {
                if (i == j)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }

        public List<Jugador> Jugadores
        {
            get { return this.jugadores; }
        } // lo agregue p mostar datos
    }
}
