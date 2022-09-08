using System;
using System.Text;

namespace Entidades
{
    public class Cuenta
    {
        private string titular;
        private float cantidad;

        public Cuenta( string t, float f)
        {
            this.cantidad = f;
            this.titular = t;
        }

        public float Cantidad { get { return this.cantidad; } }
        public string Titular { get { return this.titular; } }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Titular: {this.Titular}");
            sb.AppendLine($"Monto: {this.Cantidad}");
            return sb.ToString();
        }

        public void Ingresar(float value)
        {
            if(value != null && value >= 0)
            {
                this.cantidad = this.cantidad + value;
            }
        }

        public void Retirar(float value)
        {
            if (value != null && value >= 0)
            {
                this.cantidad = this.cantidad - value;
            }
        }
    }
}
