using System;
using System.Text;

namespace Entidades
{
    public enum eTipoCliente { PoliticoCorrupto, EmpesarioCorrupto, JugadorDeFutbol, Financista, SinTipo};
    public enum eParaisosFiscales{ Anguila, Belice, Delaware, Gibraltar, Hong_Kong, Mauricio, Panama, Seychelles, Singapur, Suiza};
    public class Cliente
    {
        private string _aliasParaIncognito;
        private string _nombre;
        private eTipoCliente _tipoDeCliente;

        private Cliente()
        {
            this._nombre = "NN";
            this._aliasParaIncognito = "Sin Alias";
            this._tipoDeCliente= eTipoCliente.SinTipo;
        }

        public Cliente(eTipoCliente e)
        {
            this._tipoDeCliente = e;
        }
        public Cliente(eTipoCliente e, string n):this(e)
        {
            this._nombre = n;
        }

        private void CrearAlias()
        {
            Random n = new Random();
            this._aliasParaIncognito = (n.Next(1000, 9999)).ToString() + this._tipoDeCliente.ToString();
        }

        public string GetAlias()
        {
            if(this._aliasParaIncognito =="Sin Aliass")
            {
                this.CrearAlias();
            }
            return this._aliasParaIncognito;
        }

        private string RetornarDatos()
        {
            StringBuilder s = new StringBuilder();
            s.AppendLine($"nombre: {this._nombre}");
            s.AppendLine($"alias: {this._aliasParaIncognito}");
            s.AppendLine($"tipo: {this._tipoDeCliente.ToString()}");
            return s.ToString();
        }

        private string RetornarDatos(Cliente c)
        {
            return "";
        }

    }
}
