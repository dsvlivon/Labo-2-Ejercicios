using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Peso
    {
        double cantidad;
        static double cotizRespectoDolar;
        static Peso()
        {
            cotizRespectoDolar = 0.25;
        }
        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Peso(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }
        public static double getCotizacion()
        {
            return cotizRespectoDolar;
        }
        public double getCantidad()
        {
            return this.cantidad;
        }

        public static explicit operator Dolar (Peso p)//ok
        {
            var x = p.cantidad;
            var y = Peso.getCotizacion();
            var res = x * y;
            Dolar dolar = new Dolar(Convert.ToDouble(res));

            return dolar;
        }

        public static explicit operator Euro(Peso p)//ok
        {
            Euro euro = new Euro(Convert.ToDouble(p.cantidad * Euro.getCotizacion()));
            return euro;
        }

        public static implicit operator Peso(double p)
        {
            Peso peso = new Peso(p);
            return peso;
        }

        public static bool operator ==(Peso d, Dolar e)
        {
            return d.cantidad == e.getCantidad();
        }
        public static bool operator !=(Peso d, Dolar e)
        {
            return !(d == e);
        }
        public static bool operator ==(Peso d, Euro e)
        {
            return d.cantidad == e.getCantidad();
        }
        public static bool operator !=(Peso d, Euro e)
        {
            return !(d == e);
        }
        public static bool operator ==(Peso p1, Peso p2)
        {
            return p1.cantidad == p2.cantidad;
        }
        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p2 == p1);
        }
        public static Peso operator -(Peso p, Dolar e)
        {
            Peso aux = new Peso(p.cantidad - e.getCantidad());
            return aux;
        }
        public static Peso operator +(Peso p, Dolar e)
        {
            Peso aux = new Peso(p.cantidad + e.getCantidad());
            return aux;
        }
        public static Peso operator -(Peso p, Euro e)
        {
            Peso aux = new Peso(p.cantidad - e.getCantidad());
            return aux;
        }
        public static Peso operator +(Peso p, Euro e)
        {
            Peso aux = new Peso(p.cantidad + e.getCantidad());
            return aux;
        }
        public static void SetCotizacion(double value)
        {
            cotizRespectoDolar = value;
        }
    }
}
