using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Dolar()
        {
            cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad=cantidad;
        }

        public Dolar(double cantidad, double cotizacion):this(cantidad)
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

        public static explicit operator Euro(Dolar d)
        {
            Euro euro = new Euro(d.cantidad*Euro.getCotizacion());//busca el constructor q recibe cant y tipo de parametros q estoy pasando
            //como d.cantidad y euro.getCotizacion son doubles, sigue double.
            return euro;
        }

        public static explicit operator Peso(Dolar d)
        {
            Peso peso = new Peso(d.cantidad * Peso.getCotizacion());
            return peso;
        }

        public static implicit operator Dolar(double d)
        {
            Dolar dolar = new Dolar(d);
            return dolar;
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            if(d.cantidad == e.getCantidad())
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            if (d.cantidad != e.getCantidad())
            {
                return true;
            }
            return false;
        }

        public static bool operator ==(Dolar d, Peso e)
        {
            return d.cantidad == e.getCantidad();
        }

        public static bool operator !=(Dolar d, Peso e)
        {
            return !(d == e);
        }
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            if (d1.cantidad == d2.cantidad)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            if (d1.cantidad != d2.cantidad)
            {
                return true;
            }
            return false;
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar aux = new Dolar(d.cantidad - e.getCantidad());
            return aux;
        }
        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar aux = new Dolar(d.cantidad + e.getCantidad());
            return aux;
        }
        public static Dolar operator -(Dolar d, Peso p)
        {
            Dolar aux = new Dolar(d.cantidad - p.getCantidad());
            return aux;
        }
        public static Dolar operator +(Dolar d, Peso p)
        {
            Dolar aux = new Dolar(d.cantidad + p.getCantidad());
            return aux;
        }

    }
}
