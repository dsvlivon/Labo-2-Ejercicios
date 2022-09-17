using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class ParaisoFiscal
    {
        private List<CuentaOffShore> _listadoCuentas;
        private eParaisosFiscales _lugar;
        public static int cantidadDeCuentas;
        public static DateTime fechaInicioActividades;

        public static implicit operator ParaisoFiscal(eParaisosFiscales e)
        {
            ParaisoFiscal p = new ParaisoFiscal(e); return p;
        }

        public void MostrarParaiso() {
            StringBuilder s = new StringBuilder();
            s.AppendLine($"Fecha: {ParaisoFiscal.fechaInicioActividades}");
            s.AppendLine($"lugar: {this._lugar}");
            s.AppendLine($"cant. cuuentas: {ParaisoFiscal.cantidadDeCuentas}");
            foreach (var item in this._listadoCuentas)
            {
                s.AppendLine($"N° cuenta: {(int)item}");
                s.AppendLine($"saldo: {item.Saldo}");
                s.AppendLine($"--------------------");
                s.AppendLine($"     nombre: {Cliente.RetornarDatos(item.Dueño)}");
            }

            Console.WriteLine(s.ToString());
        }

        static ParaisoFiscal()
        {
            ParaisoFiscal.cantidadDeCuentas = 0;
            ParaisoFiscal.fechaInicioActividades = DateTime.Now;
        }
        private ParaisoFiscal()
        {
            this._listadoCuentas = new List<CuentaOffShore>();
        }

        public ParaisoFiscal(eParaisosFiscales l) : this()
        {
            this._lugar = l;
        }

        public static bool operator ==(ParaisoFiscal p, CuentaOffShore c)
        {
            foreach (var item in p._listadoCuentas)
            {
                if (item == c) { return true; } 
            } return false;
        }

        public static bool operator !=(ParaisoFiscal p, CuentaOffShore c)
        {
            return !(p == c);
        }

        public static ParaisoFiscal operator +(ParaisoFiscal p, CuentaOffShore c)
        {
            foreach (var item in p._listadoCuentas)
            {
                if (item == c) { 
                    item.Saldo=item.Saldo+c.Saldo; 
                    Console.WriteLine($"El cliente existe\nEl nuevo saldo es : {item.Saldo}");
                    return p;
                }
            } 
            p._listadoCuentas.Add(c);
            Console.WriteLine($"Se agrega la cuenta {(int)c}.");
            ParaisoFiscal.cantidadDeCuentas++;
            return p;
        }

        public static ParaisoFiscal operator -(ParaisoFiscal p, CuentaOffShore c)
        {
            if (p == c)
            {
                if(ParaisoFiscal.cantidadDeCuentas > 0)
                {
                    Console.WriteLine($"Se elimino cuenta: {(int)c}");
                    p._listadoCuentas.Remove(c);
                    ParaisoFiscal.cantidadDeCuentas--;
                }
                else { ParaisoFiscal.cantidadDeCuentas = 0; }
            } Console.WriteLine($"La cuenta {(int)c} no existe.");
            return p;
        }
    }
}
