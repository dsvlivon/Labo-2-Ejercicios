using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;
        static Euro()
        {
            cotizRespectoDolar = 0.89;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
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

        public static explicit operator Dolar(Euro d)
        {
            Dolar dolar = new Dolar(d.cantidad * Dolar.getCotizacion());
            return dolar;
        }

        public static explicit operator Peso(Euro d)
        {
            Peso peso = new Peso(d.cantidad * Peso.getCotizacion());
            return peso;
        }

        public static implicit operator Euro (double d)
        {
            Euro euro = new Euro(d);
            return euro;
        }

        public static bool operator ==(Euro d, Dolar e)
        {
            return d.cantidad == e.getCantidad();
        }

        public static bool operator !=(Euro d, Dolar e)
        {
            return !(d == e);
        }

        public static bool operator ==(Euro d, Peso e)
        {
            return d.cantidad == e.getCantidad();
        }

        public static bool operator !=(Euro d, Peso e)
        {
            return !(d == e);
        }
        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.cantidad == e2.cantidad;
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e2 == e1);
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            Euro aux = new Euro(e.cantidad - d.getCantidad());
            return aux;
        }
        public static Euro operator +(Euro e, Dolar d)
        {
            Euro aux = new Euro(e.cantidad + d.getCantidad());
            return aux;
        }
        public static Euro operator -(Euro e, Peso p)
        {
            Euro aux = new Euro(e.cantidad - p.getCantidad());
            return aux;
        }
        public static Euro operator +(Euro e, Peso p)
        {
            Euro aux = new Euro(e.cantidad + p.getCantidad());
            return aux;
        }

        public static void SetCotizacion() { }
    }
}
