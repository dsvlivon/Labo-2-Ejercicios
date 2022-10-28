using System;

namespace Entidades
{
    public class DirectorTecnico: Persona
    {
        private DateTime fechaNacimiento;

        public DirectorTecnico(string n):base(n)
        {

        }
        public DirectorTecnico(string n, DateTime f):this(n)
        {
            f = DateTime.Now;
        }

        public override string MostrarDatos()
        {
            return base.MostrarDatos() + $"fecha nac.: {this.fechaNacimiento.ToString()}";
        }
        public static bool operator ==(DirectorTecnico a, DirectorTecnico b)
        {
            if (a.Nombre == b.Nombre & a.fechaNacimiento == b.fechaNacimiento) { return true; }
            return false;
        }

        public static bool operator !=(DirectorTecnico a, DirectorTecnico b) { return !(a == b); }
    }
}
