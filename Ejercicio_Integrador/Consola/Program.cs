using System; using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Vizgarra y Daniel";//Cambiar por SU apellido y SU nombre
            Cliente mauri = new Cliente(eTipoCliente.PoliticoCorrupto,"Mauri");
            Cliente fariña = new Cliente(eTipoCliente.Financista, "Fariña");
            Cliente mesias = new Cliente(eTipoCliente.JugadorDeFutbol,"Lio");
            
            CuentaOffShore messiOff = new CuentaOffShore(mesias, 123, 15000);
            CuentaOffShore mauriOff = new CuentaOffShore(mauri, 678, 25000);
            CuentaOffShore lazaroOff = new CuentaOffShore("lazaro", 456, 56000, eTipoCliente.EmpresarioCorrupto);
            CuentaOffShore otraDeMauri = new CuentaOffShore(mauri, 678,50000);
            CuentaOffShore fariOff = new CuentaOffShore(fariña, 666, 3500);

            ParaisoFiscal panamaPappers = eParaisosFiscales.Panama;
            
            panamaPappers += messiOff;
            panamaPappers += mauriOff;
            panamaPappers += lazaroOff;
            panamaPappers.MostrarParaiso();
            panamaPappers += otraDeMauri;
            panamaPappers -= messiOff;
            panamaPappers -= fariOff;
            panamaPappers.MostrarParaiso();
            Console.ReadLine();
        }
    }
}
