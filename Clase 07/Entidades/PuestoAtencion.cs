using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Entidades
{
    
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        static int NumeroActual
        {
            get { 
                return PuestoAtencion.numeroActual ++;
            }
        }

        public bool Atender(Cliente c)
        {
            Thread.Sleep(20);
            return true; 
        }

        static PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto p)
        {
            this.puesto = p;
        }
    }
}
