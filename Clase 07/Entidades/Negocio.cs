using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public enum Puesto { Caja1, Caja2 }
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public Cliente Cliente { 
            get { 
                return this.clientes.Peek(); 
            } 
            //set; 
        }

        private Negocio(){
            clientes = new Queue<Cliente>();
            caja = new PuestoAtencion(Puesto.Caja1);
        }

        public int ClientesPendientes { get {
                return this.clientes.Count;
            } }

        public Negocio(string n):this()
        {
            this.nombre = n;
        }

        public static bool operator ==(Negocio n, Cliente b)
        {
            foreach (var i in n.clientes)
            {
                if (i.Numero == b.Numero)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Negocio n, Cliente b)
        {
            return !(n==b);
        }

        public static bool operator +(Negocio n, Cliente b)
        {
            if(n!= b){
                n.clientes.Enqueue(b);
                return true;
            } return false;
        }

        public static bool operator ~(Negocio n)
        {
            Cliente x = n.Cliente;
            if (n != n.Cliente)
            {
                if (n.caja.Atender(n.Cliente))
                {
                    return true;
                }
            } return false;
        }
    }
}
