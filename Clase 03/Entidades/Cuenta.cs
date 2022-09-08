using System;

namespace Entidades
{
    public class Cuenta
    {
        private string titular;
        private float cantidad;

        public Cuenta(string t, float c)
        {
            this.titular = t;   this.cantidad = c;
        }

        public float Cantidad{ get { return this.cantidad; } }
        public string Titular{ get { return this.titular; } }

        public string Mostrar()
        {
            return "Titutlar: " + this.Titular + "\nCantidad: " + this.Cantidad.ToString();
        }

        public void Ingresar(float monto)
        {
            if(monto >= 0) { this.cantidad = this.cantidad + monto; }
        }

        public void Retirar(float monto)
        {
            this.cantidad = this.cantidad - monto;
        }
    }
}
