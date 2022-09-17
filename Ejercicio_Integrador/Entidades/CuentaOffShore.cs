using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class CuentaOffShore
    {
        private Cliente _dueño;
        private int _numeroCuenta;
        private double _saldo;

        public Cliente Dueño { get { return this._dueño; } }
        public double Saldo { get { return this._saldo; } set { this._saldo = value; } }

        public CuentaOffShore(Cliente c, int n, double s)
        {
            this._dueño = c; this._numeroCuenta = n; this._saldo = s;
        }

        public CuentaOffShore(string x, int n, double s, eTipoCliente t):this(new Cliente(t,x), n, s)
        {
        }

        public static explicit operator int(CuentaOffShore c2){
            return c2._numeroCuenta;
        }

        public static bool operator == (CuentaOffShore c1, CuentaOffShore c2)
        {
            if(c1._numeroCuenta == c2._numeroCuenta && c1.Dueño == c2.Dueño)
            {
                return true;
            }  return false;
        }
        public static bool operator !=(CuentaOffShore c1, CuentaOffShore c2)
        {
            return !(c1 == c2);
        }
    }
}
