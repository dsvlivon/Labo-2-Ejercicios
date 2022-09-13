using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Ejercicio_C01
{
    public partial class FormPrincipal : Form
    {
        Dolar unDolar = new Dolar(1);
        Euro unEuro = new Euro(1);
        Peso unPeso = new Peso(1);
        public FormPrincipal()
        {
            InitializeComponent();
            tbxCotizacionEuro.Text = Euro.getCotizacion().ToString();
            tbxCotizacionDolar.Text = Dolar.getCotizacion().ToString();
            tbxCotizacionPeso.Text = Peso.getCotizacion().ToString();
        }
    }
}
